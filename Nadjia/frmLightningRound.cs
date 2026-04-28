using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;

namespace Nadjia
{
    public partial class frmLightningRound : Form
    {
        public frmLightningRound()
        {
            InitializeComponent();
        }

        private void frmLightningRound_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(18, 14, 28);
//           this.ClientSize = new System.Drawing.Size(620, 330);
//           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            StyleButton(btnClose);
            
            SoundPlayer sndLightning = new SoundPlayer(nadjiaConfig.soundboardLibraryFolder + "\\LightningRound.wav");
            sndLightning.Play();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            // DirectoryInfo d = New;
            // Int32 intFiles = 0;
            Int32 a = 0;
            Int32 intMynum = 0;
            string strImagePath = "";


            //Add Effect here
            SoundPlayer sndLightning = new SoundPlayer(nadjiaConfig.soundboardLibraryFolder + "\\spin.wav");
            sndLightning.Play();

            //Pull LR Directory
            string[] fileEntries = Directory.GetFiles(nadjiaConfig.LRQuestionsFolder, "*.png");

            //Display Error if No Files Found
            if (fileEntries.Count() == 0) { MessageBox.Show("No Lightning Round Questions Found"); btnSpin.Enabled = false; }

            //Pick Random number
            var rand = new Random();

            for (a = 1; a < 7; a++)
            {
                intMynum = rand.Next(0, fileEntries.Count() - 1);
                strImagePath = fileEntries[intMynum];
                this.BackgroundImage = System.Drawing.Image.FromFile(strImagePath);
                this.Refresh();
                Thread.Sleep(500);
            }
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            // DirectoryInfo d = New;
            // Int32 intFiles = 0;
            // Int32 a = 0;
            Int32 intMynum = 0;
            string strImagePath = "";


            //Pull LR Directory
            string[] fileEntries = Directory.GetFiles(nadjiaConfig.LRQuestionsFolder, "*.png");

            //Display Error if No Files Found
            if (fileEntries.Count() == 0) { MessageBox.Show("No Lightning Round Questions Found"); btnSpin.Enabled = false; }

            //Pick Random number
            var rand = new Random();

            intMynum = rand.Next(0, fileEntries.Count() - 1);
            strImagePath = fileEntries[intMynum];
            this.BackgroundImage = System.Drawing.Image.FromFile(strImagePath);
            this.Refresh();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
