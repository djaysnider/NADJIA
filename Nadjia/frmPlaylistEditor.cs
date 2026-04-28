using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Nadjia
{
    public partial class frmPlaylistEditor : Form
    {
        private List<TrackInfo> _tracks;
        public frmPlaylistEditor(List<TrackInfo> tracks)
        {
            InitializeComponent();
            _tracks = tracks ?? new List<TrackInfo>();
        }

        private void frmPlaylistEditor_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(18, 14, 28);
            //            this.ClientSize = new System.Drawing.Size(620, 330);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            StyleButton(btnSave);
            StyleButton(btnCancel);
            
            txtPlaylistName.Text = "Playlist-" + DateTime.Now.ToString("yyyy-MM-dd");

            SetupPlaylistGrid();

            dgvPlaylistTracks.DataSource = null;
            dgvPlaylistTracks.DataSource = _tracks;

            lblTrackCount.Text = _tracks.Count.ToString("N0") + " tracks";
        }

        private void SetupPlaylistGrid()
        {
            dgvPlaylistTracks.AutoGenerateColumns = false;
            dgvPlaylistTracks.Columns.Clear();

            dgvPlaylistTracks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlaylistTracks.MultiSelect = false;
            dgvPlaylistTracks.ReadOnly = true;
            dgvPlaylistTracks.AllowUserToAddRows = false;
            dgvPlaylistTracks.AllowUserToDeleteRows = false;
            dgvPlaylistTracks.RowHeadersVisible = false;

            dgvPlaylistTracks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Artist",
                HeaderText = "Artist",
                DataPropertyName = "Artist",
                Width = 160
            });

            dgvPlaylistTracks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Title",
                DataPropertyName = "Title",
                Width = 220
            });

            dgvPlaylistTracks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Album",
                HeaderText = "Album",
                DataPropertyName = "Album",
                Width = 180
            });

            dgvPlaylistTracks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Year",
                HeaderText = "Year",
                DataPropertyName = "Year",
                Width = 60
            });

            dgvPlaylistTracks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Genre",
                HeaderText = "Genre",
                DataPropertyName = "Genre",
                Width = 120
            });

            dgvPlaylistTracks.BackgroundColor = Color.FromArgb(20, 18, 30);

            dgvPlaylistTracks.DefaultCellStyle.BackColor = Color.FromArgb(25, 22, 40);
            dgvPlaylistTracks.DefaultCellStyle.ForeColor = Color.White;
            dgvPlaylistTracks.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            dgvPlaylistTracks.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvPlaylistTracks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 30, 60);
            dgvPlaylistTracks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvPlaylistTracks.EnableHeadersVisualStyles = false;
            dgvPlaylistTracks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvPlaylistTracks.Columns["Artist"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPlaylistTracks.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPlaylistTracks.Columns["Album"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPlaylistTracks.Columns["Year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPlaylistTracks.Columns["Genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPlaylistTracks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvPlaylistTracks.RowHeadersVisible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string playlistName = txtPlaylistName.Text.Trim();

            if (string.IsNullOrWhiteSpace(playlistName))
            {
                MessageBox.Show("Enter a playlist name.");
                return;
            }

            string safeName = MakeSafeFileName(playlistName);
            string outputPath = Path.Combine(
                nadjiaConfig.trackLibraryFolder,
                safeName + ".xml");

            PlaylistXmlService.SavePlaylist(outputPath, playlistName, _tracks);

            MessageBox.Show("Playlist saved:\r\n" + outputPath);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private string MakeSafeFileName(string fileName)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c, '_');
            }

            return fileName;
        }
    }
}
