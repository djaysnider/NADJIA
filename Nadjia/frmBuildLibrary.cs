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
            this.BackColor = System.Drawing.Color.FromArgb(18, 14, 28);
            this.ClientSize = new System.Drawing.Size(620, 330);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            StyleButton(btnRebuild);
            StyleButton(btnChange);
            StyleButton(btnClose);
            lblLibraryPath.Text = nadiaConfig.trackLibraryFolder;

            if (AppState.MusicLibrary != null)
            {
                lblTracksLoaded.Text = AppState.MusicLibrary.Count.ToString("N0") + " tracks currently loaded";
            }
            else
            {
                lblTracksLoaded.Text = "No library loaded";
            }
        }

        /* 
        private void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 90, 160);
            button.BackColor = System.Drawing.Color.FromArgb(42, 32, 58);
            button.ForeColor = System.Drawing.Color.White;
            button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        }
        */
        private void btnBuildLibrary_Click(object sender, EventArgs e)
        {
            string rootDirectory = @"D:\Music\Indianapolis";
            string outputXmlPath = @"C:\Users\djays\Documents\EMMA\library.xml";

            

            btnRebuild.Enabled = false;
            progressBuildLibrary.Value = 0;
            lblProgressPercent.Text = "0%";
            lblBuildStatus.Text = "Scanning MP3 files...";
            lblCurrentFile.Text = "";

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
                lblProgressPercent.Text = args.ProgressPercentage + "%";

                ProgressInfo info = args.UserState as ProgressInfo;

                if (info != null)
                {
                    lblBuildStatus.Text =
                        "Processing " + info.Current + " of " + info.Total;

                    lblCurrentFile.Text =
                        Path.GetFileName(info.FilePath);
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
                    lblProgressPercent.Text = "100%";
                    lblBuildStatus.Text = "Library build complete.";
                    lblCurrentFile.Text = outputXmlPath;

                    AppState.MusicLibrary = LibraryLoader.LoadLibrary(outputXmlPath);
                    lblTracksLoaded.Text = AppState.MusicLibrary.Count.ToString("N0") + " tracks currently loaded";

//                    MessageBox.Show("Library XML created successfully.");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void lblLibraryPath_Click(object sender, EventArgs e)
        {

        }

        private void lblTracksLoaded_Click(object sender, EventArgs e)
        {

        }

        private void lblBuildStatus_Click(object sender, EventArgs e)
        {

        }

        private void progressBuildLibrary_Click(object sender, EventArgs e)
        {

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