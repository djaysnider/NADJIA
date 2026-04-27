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
            this.ClientSize = new System.Drawing.Size(620, 330);
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
    }
}
