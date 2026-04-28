using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nadjia
{
    public partial class frmEditId3Tag : Form
    {
        public frmEditId3Tag()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private TrackInfo _track;

        public frmEditId3Tag(TrackInfo track)
        {
            InitializeComponent();
            _track = track;
        }

        private void frmEditId3Tag_Load(object sender, EventArgs e)
        {
            if (_track == null)
            {
                MessageBox.Show("No track selected.");
                Close();
                return;
            }

            txtArtist.Text = _track.Artist;
            txtTitle.Text = _track.Title;
            txtAlbum.Text = _track.Album;
            txtYear.Text = _track.Year;
            txtGenre.Text = _track.Genre;
            lblFilePath.Text = _track.FilePath;
        }

        private void bthSave_Click(object sender, EventArgs e)
        {
            if (_track == null)
                return;

            try
            {
                using (var tagFile = TagLib.File.Create(_track.FilePath))
                {
                    tagFile.Tag.Performers = new[] { txtArtist.Text.Trim() };
                    tagFile.Tag.Title = txtTitle.Text.Trim();
                    tagFile.Tag.Album = txtAlbum.Text.Trim();

                    uint year;
                    if (uint.TryParse(txtYear.Text.Trim(), out year))
                        tagFile.Tag.Year = year;
                    else
                        tagFile.Tag.Year = 0;

                    tagFile.Tag.Genres = new[] { txtGenre.Text.Trim() };

                    tagFile.Save();
                }

                _track.Artist = txtArtist.Text.Trim();
                _track.Title = txtTitle.Text.Trim();
                _track.Album = txtAlbum.Text.Trim();
                _track.Year = txtYear.Text.Trim();
                _track.Genre = txtGenre.Text.Trim();

                MessageBox.Show("ID3 tag updated.");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update ID3 tag:\r\n" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
