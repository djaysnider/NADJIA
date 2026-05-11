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
    public partial class frmTrackSearch : Form
    {
        private List<TrackInfo> _searchResults = new List<TrackInfo>();
        private BindingSource _bindingSource = new BindingSource();



        public frmTrackSearch()
        {
            InitializeComponent();
        }

        private void frmTrackSearch_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(18, 14, 28);
//            this.ClientSize = new System.Drawing.Size(620, 330);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            StyleButton(btnSearch);
            StyleButton(btnClose);

            // Populate dropdown with enum values
            cboSearchField.DataSource = Enum.GetValues(typeof(TrackSearchField));

            // Default to searching everything
            cboSearchField.SelectedItem = TrackSearchField.All;
            cboSearchField.DataSource = Enum.GetValues(typeof(TrackSearchField));
            cboSearchField.SelectedItem = TrackSearchField.All;

            SetupGrid();
            SetupResultsContextMenu();
        }

        private void SetupResultsContextMenu()
        {
            _resultsMenu = new ContextMenuStrip();

            var saveNewPlaylist = new ToolStripMenuItem("Save to new playlist");
            saveNewPlaylist.Click += saveNewPlaylist_Click;

            var saveExistingPlaylist = new ToolStripMenuItem("Save to existing playlist");
            saveExistingPlaylist.Click += saveExistingPlaylist_Click;

            var editId3Tag = new ToolStripMenuItem("Edit ID3 tag");
            editId3Tag.Click += editId3Tag_Click;

            ToolStripMenuItem addToQueueMenuItem = new ToolStripMenuItem("Add to Queue");
            addToQueueMenuItem.Click += addToQueueMenuItem_Click;

            _resultsMenu.Items.Add(saveNewPlaylist);
            _resultsMenu.Items.Add(saveExistingPlaylist);
            _resultsMenu.Items.Add(addToQueueMenuItem);
            _resultsMenu.Items.Add(new ToolStripSeparator());
            _resultsMenu.Items.Add(editId3Tag);

            dgvResults.ContextMenuStrip = _resultsMenu;
        }

        private void editId3Tag_Click(object sender, EventArgs e)
        {
            List<TrackInfo> selectedTracks = GetSelectedTracks();

            if (selectedTracks.Count != 1)
            {
                MessageBox.Show("Select exactly one track to edit its ID3 tag.");
                return;
            }

            frmEditId3Tag editor = new frmEditId3Tag(selectedTracks[0]);

            if (editor.ShowDialog() == DialogResult.OK)
            {
                btnSearch_Click(null, null);
            }
        }

        private List<TrackInfo> GetSelectedTracks()
        {
            var selectedTracks = new List<TrackInfo>();

            foreach (DataGridViewRow row in dgvResults.SelectedRows)
            {
                TrackInfo track = row.DataBoundItem as TrackInfo;

                if (track != null)
                    selectedTracks.Add(track);
            }

            return selectedTracks;
        }

        private void addToQueueMenuItem_Click(object sender, EventArgs e)
        {
            List<TrackInfo> selectedTracks = GetSelectedTracksFromSearchResults();

            if (selectedTracks.Count == 0)
            {
                MessageBox.Show("Select one or more tracks first.");
                return;
            }

            frmConsoleDesk console = Application.OpenForms
                .OfType<frmConsoleDesk>()
                .FirstOrDefault();

            if (console == null)
            {
                console = new frmConsoleDesk();
                console.Show();
            }
            else
            {
                console.BringToFront();
                console.Focus();
            }

            console.AddTracksToQueue(selectedTracks);
        }

        private void saveExistingPlaylist_Click(object sender, EventArgs e)
        {
            List<TrackInfo> selectedTracks = GetSelectedTracksFromSearchResults();

            if (selectedTracks.Count == 0)
            {
                MessageBox.Show("Select one or more tracks first.");
                return;
            }

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Select Existing Playlist";
                dialog.Filter = "Playlist XML Files (*.xml)|*.xml";
                dialog.InitialDirectory = nadjiaConfig.trackLibraryFolder;
                dialog.Multiselect = false;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string playlistPath = dialog.FileName;
                string playlistName = Path.GetFileNameWithoutExtension(playlistPath);

                List<TrackInfo> existingTracks = PlaylistXmlService.LoadPlaylist(playlistPath);
                existingTracks.AddRange(selectedTracks);

                PlaylistXmlService.SavePlaylist(
                    playlistPath,
                    playlistName,
                    existingTracks
                );

                MessageBox.Show("Tracks added to existing playlist.");
            }
        }

        private List<TrackInfo> GetSelectedTracksFromSearchResults()
        {
            List<TrackInfo> tracks = new List<TrackInfo>();

            foreach (DataGridViewRow row in dgvResults.SelectedRows)
            {
                TrackInfo track = row.DataBoundItem as TrackInfo;

                if (track != null)
                    tracks.Add(track);
            }

            return tracks;
        }
        private void saveNewPlaylist_Click(object sender, EventArgs e)
        {
            List<TrackInfo> selectedTracks = GetSelectedTracks();

            if (selectedTracks.Count == 0)
            {
                MessageBox.Show("Select one or more tracks first.");
                return;
            }

            frmPlaylistEditor editor = new frmPlaylistEditor(selectedTracks);
            editor.ShowDialog();
        }

        private void SetupGrid()
        {
            dgvResults.Columns.Clear();

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Artist",
                HeaderText = "Artist",
                DataPropertyName = "Artist",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Title",
                DataPropertyName = "Title",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Album",
                HeaderText = "Album",
                DataPropertyName = "Album",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Year",
                HeaderText = "Year",
                DataPropertyName = "Year",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvResults.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Genre",
                HeaderText = "Genre",
                DataPropertyName = "Genre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            foreach (DataGridViewColumn column in dgvResults.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dgvResults.BackgroundColor = Color.FromArgb(20, 18, 30);

            dgvResults.DefaultCellStyle.BackColor = Color.FromArgb(25, 22, 40);
            dgvResults.DefaultCellStyle.ForeColor = Color.White;
            dgvResults.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            dgvResults.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvResults.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 30, 60);
            dgvResults.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvResults.EnableHeadersVisualStyles = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvResults.Columns["Artist"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResults.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResults.Columns["Album"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResults.Columns["Year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResults.Columns["Genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvResults.RowHeadersVisible = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            TrackSearchField field = (TrackSearchField)cboSearchField.SelectedItem;

            _searchResults = TrackSearchService.Search(
                AppState.MusicLibrary,
                txtSearch.Text,
                field);

            SortableBindingList<TrackInfo> sortableResults =
                new SortableBindingList<TrackInfo>(_searchResults);

            _bindingSource.DataSource = sortableResults;
            dgvResults.DataSource = _bindingSource;

            lblResultCount.Text = _searchResults.Count.ToString("N0") + " results";
            dgvResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        
        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TrackInfo selectedTrack = dgvResults.Rows[e.RowIndex].DataBoundItem as TrackInfo;

            if (selectedTrack == null)
                return;

            MessageBox.Show(
                selectedTrack.Artist + " - " + selectedTrack.Title);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
