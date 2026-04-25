using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using TagLib;

namespace Nadjia
{
    public partial class frmBuildLibrary : Form
    {
        public frmBuildLibrary()
        {
            InitializeComponent();
        }

        private void frmBuildLibrary_Load(object sender, EventArgs e)
        {
            var trackCount = AppState.MusicLibrary.Count;
            lblTracksLoaded.Text = trackCount + " tracks loaded from music library.";
            lblLibraryPath.Text = "Current Library Path:" + nadiaConfig.trackLibraryFolder;
        }

        private void btnBuildLibrary_Click(object sender, EventArgs e)
        {
            string rootDirectory = @"D:\Music\Indianapolis";
            string outputXmlPath = @"C:\Users\djays\Documents\EMMA\library.xml";

            btnRebuild.Enabled = false;
            progressBuildLibrary.Value = 0;
            lblBuildStatus.Text = "Scanning MP3 files...";

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;

            worker.DoWork += (s, args) =>
            {
                Mp3LibraryXmlBuilder.BuildXml(
                    rootDirectory,
                    outputXmlPath,
                    (current, total, filePath) =>
                    {
                        int percent = total == 0 ? 100 : (int)((current / (double)total) * 100);

                        worker.ReportProgress(percent, new ProgressInfo
                        {
                            Current = current,
                            Total = total,
                            FilePath = filePath
                        });
                    });
            };

            worker.ProgressChanged += (s, args) =>
            {
                progressBuildLibrary.Value = args.ProgressPercentage;

                ProgressInfo info = args.UserState as ProgressInfo;

                if (info != null)
                {
                    lblBuildStatus.Text =
                        "Processing " + info.Current + " of " + info.Total +
                        " - " + Path.GetFileName(info.FilePath);
                }
            };

            worker.RunWorkerCompleted += (s, args) =>
            {
                btnRebuild.Enabled = true;

                if (args.Error != null)
                {
                    lblBuildStatus.Text = "Error building library.";
                    MessageBox.Show(args.Error.Message, "Error");
                }
                else
                {
                    progressBuildLibrary.Value = 100;
                    lblBuildStatus.Text = "Library build complete.";
                    MessageBox.Show("Library XML created successfully.");
                }
            };

            worker.RunWorkerAsync();
        }

        private class ProgressInfo
        {
            public int Current { get; set; }
            public int Total { get; set; }
            public string FilePath { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public static class Mp3LibraryXmlBuilder
    {
        public static void BuildXml(
            string rootDirectory,
            string outputXmlPath,
            Action<int, int, string> reportProgress)
        {
            if (!Directory.Exists(rootDirectory))
                throw new DirectoryNotFoundException(rootDirectory);

            var mp3Files = Directory
                .EnumerateFiles(rootDirectory, "*.mp3", SearchOption.AllDirectories)
                .OrderBy(f => f)
                .ToList();

            int total = mp3Files.Count;
            int index = 1;

            var tracks = new List<XElement>();

            foreach (var filePath in mp3Files)
            {
                try
                {
                    using (var tagFile = TagLib.File.Create(filePath))
                    {
                        var tag = tagFile.Tag;

                        tracks.Add(new XElement("Track",
                            new XElement("Index", index),
                            new XElement("Artist", CleanXmlText(tag.FirstPerformer)),
                            new XElement("Title", CleanXmlText(tag.Title)),
                            new XElement("Album", CleanXmlText(tag.Album)),
                            new XElement("Year", tag.Year > 0 ? tag.Year.ToString() : ""),
                            new XElement("Genre", CleanXmlText(tag.FirstGenre)),
                            new XElement("FilePath", CleanXmlText(filePath))
                        ));
                    }
                }
                catch
                {
                    tracks.Add(new XElement("Track",
                        new XElement("Index", index),
                        new XElement("Artist", ""),
                        new XElement("Title", ""),
                        new XElement("Album", ""),
                        new XElement("Year", ""),
                        new XElement("Genre", ""),
                        new XElement("FilePath", CleanXmlText(filePath)),
                        new XElement("Error", "Could not read ID3 tags")
                    ));
                }

                reportProgress?.Invoke(index, total, filePath);
                index++;
            }

            var document = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Tracks", tracks)
            );

            document.Save(outputXmlPath);
        }

        private static string CleanXmlText(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            return new string(value
                .Where(ch =>
                    ch == 0x9 ||
                    ch == 0xA ||
                    ch == 0xD ||
                    (ch >= 0x20 && ch <= 0xD7FF) ||
                    (ch >= 0xE000 && ch <= 0xFFFD))
                .ToArray());
        }
    }
}