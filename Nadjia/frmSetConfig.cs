using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TagLib;

namespace Nadjia
{
    public partial class frmSetConfig : Form
    {
        public frmSetConfig()
        {
            InitializeComponent();
        }



        private void frmSetConfig_Load_1(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(18, 14, 28);
 //           this.ClientSize = new System.Drawing.Size(620, 330);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            StyleButton(btnClose);
            StyleButton(btnSave);

            txtLibraryPath.Text = nadjiaConfig.trackLibraryFolder;
            txtLightningPath.Text = nadjiaConfig.LRQuestionsFolder;
            txtSoundboardPath.Text = nadjiaConfig.soundboardLibraryFolder;
            txtDBPath.Text = nadjiaConfig.masterDatabase;
            txtDropPath.Text = nadjiaConfig.dropFolder;
            txtSweeperPath.Text = nadjiaConfig.sweeperFolder;
            txtBumperPath.Text = nadjiaConfig.bumperFolder;
            txtAdvertPath.Text = nadjiaConfig.advertFolder;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void dbFolderSelector_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDBPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void libraryFolderSelector_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtLibraryPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void sweeperFolderSelector_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSweeperPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void dropsFolderSelector_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDropPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void advertFolderSelector_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtAdvertPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bumperFolderSelector_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBumperPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void lrFolderSelector_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtLightningPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void soundboardFolderSelector_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSoundboardPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Build XML
            XDocument NewDoc = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XElement("settings",
                new XElement("TrackLibrary", txtLibraryPath.Text),
                new XElement("LRQuestions", txtLightningPath.Text),
                new XElement("SoundboardFiles", txtSoundboardPath.Text),
                new XElement("MasterDatabase", txtDBPath.Text),
                new XElement("dropFolder", txtDropPath.Text),
                new XElement("sweeperFolder", txtSweeperPath.Text),
                new XElement("bumperFolder", txtBumperPath.Text),
                new XElement("advertFolder", txtAdvertPath.Text)));

            // Save the document to the hard drive. 
            NewDoc.Save("nadjiaSettings.XML");

            // Display a success message. 
            MessageBox.Show(" File saved!");

            nadjiaConfig.trackLibraryFolder = txtLibraryPath.Text;
            nadjiaConfig.LRQuestionsFolder = txtLightningPath.Text;
            nadjiaConfig.soundboardLibraryFolder = txtSoundboardPath.Text;
            nadjiaConfig.masterDatabase = txtDBPath.Text;
            nadjiaConfig.sweeperFolder = txtSweeperPath.Text;
            nadjiaConfig.dropFolder = txtDropPath.Text;
            nadjiaConfig.bumperFolder = txtBumperPath.Text;
            nadjiaConfig.advertFolder = txtAdvertPath.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
