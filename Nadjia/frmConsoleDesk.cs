using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Nadjia
{
    public partial class frmConsoleDesk : Form
    {
        private int manualQueueAnchorIndex = -1;

        private Point dragStartPoint;
        private bool dragInProgress=false;

        private bool userIsDraggingProgress = false;

        public frmConsoleDesk()
        {
            InitializeComponent();
        }

        private void frmConsoleDesk_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(18, 14, 28);
//            this.FormBorderStyle = FormBorderStyle.FixedDialog;
//            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            

            BuildQueueList();
            BuildPlayerVisuals();

            trkProgress.MouseDown -= trkProgress_MouseDown;
            trkProgress.MouseDown += trkProgress_MouseDown;

            trkProgress.MouseUp -= trkProgress_MouseUp;
            trkProgress.MouseUp += trkProgress_MouseUp;

            trkProgress.Scroll -= trkProgress_Scroll;
            trkProgress.Scroll += trkProgress_Scroll;

            timer1.Interval = 500;
            timer1.Tick -= timer1_Tick;
            timer1.Tick += timer1_Tick;

            btnStart.Click -= btnStart_Click;
            btnStart.Click += btnStart_Click;

            player.PlaybackFinished -= player_PlaybackFinished;
            player.PlaybackFinished += player_PlaybackFinished;

            ContextMenuStrip queueMenu = new ContextMenuStrip();

            ToolStripMenuItem playTrackItem = new ToolStripMenuItem("Play Track");
            playTrackItem.Click += queuePlayTrackItem_Click;

            ToolStripMenuItem removeTrackItem = new ToolStripMenuItem("Remove Track");
            removeTrackItem.Click += queueRemoveTrackItem_Click;

            queueMenu.Items.Add(playTrackItem);
            queueMenu.Items.Add(removeTrackItem);

            lstQueue.ContextMenuStrip = queueMenu;
            lstQueue.MouseDown += lstQueue_RightClickSelect;
            lstQueue.HorizontalScrollbar = true;
            lstQueue.MouseDoubleClick += lstQueue_MouseDoubleClick;
            picAlbumArt.SizeMode = PictureBoxSizeMode.Zoom;
            StyleButton(btnStart);
            StyleButton(btnExit);
        }

        private void lstQueue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstQueue.IndexFromPoint(e.Location);

            if (index < 0 || index >= broadcastQueue.Count)
                return;

            manualQueueAnchorIndex = -1;
            PlayQueueItem(index);
        }
        private void lstQueue_RightClickSelect(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            int index = lstQueue.IndexFromPoint(e.Location);

            if (index >= 0 && index < broadcastQueue.Count)
                lstQueue.SelectedIndex = index;
        }

        private void queueRemoveTrackItem_Click(object sender, EventArgs e)
        {
            int index = lstQueue.SelectedIndex;

            if (index < 0 || index >= broadcastQueue.Count)
                return;

            bool removingCurrentTrack = index == currentQueueIndex;

            broadcastQueue.RemoveAt(index);

            if (removingCurrentTrack)
            {
                StopPlayback();
            }
            else if (index < currentQueueIndex)
            {
                currentQueueIndex--;
            }

            manualQueueAnchorIndex = -1;
            UpdateQueueHorizontalScroll();
        }
        private void queuePlayTrackItem_Click(object sender, EventArgs e)
        {
            if (lstQueue.SelectedIndex < 0 || lstQueue.SelectedIndex >= broadcastQueue.Count)
                return;

            manualQueueAnchorIndex = -1;
            PlayQueueItem(lstQueue.SelectedIndex);
            btnPlay.BackgroundImage = Properties.Resources.btnPause;
            btnPlay.Text = "";

        }
        private void UpdateQueueHorizontalScroll()
        {
            if (lstQueue.Items.Count == 0)
            {
                lstQueue.HorizontalExtent = 0;
                return;
            }

            int maxWidth = 0;

            using (Graphics g = lstQueue.CreateGraphics())
            {
                foreach (var item in lstQueue.Items)
                {
                    string text = ((PlaylistItem)item).DisplayText;

                    SizeF size = g.MeasureString(text, lstQueue.Font);

                    if (size.Width > maxWidth)
                        maxWidth = (int)size.Width;
                }
            }

            lstQueue.HorizontalExtent = maxWidth + 20; // padding so it doesn't clip

        }
        private List<TrackInfo> GetTracksFromQueue()
        {
            List<TrackInfo> tracks = new List<TrackInfo>();

            foreach (PlaylistItem item in broadcastQueue)
            {
                if (item.Track != null)
                {
                    tracks.Add(item.Track);
                }
                else
                {
                    tracks.Add(new TrackInfo
                    {
                        Title = item.Title,
                        FilePath = item.FilePath
                    });
                }
            }

            return tracks;
        }



        public void AddTracksToQueue(List<TrackInfo> tracks)
        {
            if (tracks == null || tracks.Count == 0)
                return;

            foreach (TrackInfo track in tracks)
            {
                broadcastQueue.Add(new PlaylistItem
                {
                    ItemType = PlaylistItemType.Track,
                    Title = track.Title,
                    FilePath = track.FilePath,
                    Track = track
                });
                UpdateQueueHorizontalScroll();
            }
        }
        private void BuildQueueList()
        {
            lstQueue = new ListBox();
            lstQueue.Dock = DockStyle.Fill;
            lstQueue.BackColor = Color.FromArgb(28, 22, 38);
            lstQueue.ForeColor = Color.White;
            lstQueue.DisplayMember = "DisplayText";
            lstQueue.DataSource = broadcastQueue;
            lstQueue.AllowDrop = true;

            lstQueue.MouseDown += lstQueue_MouseDown;
            lstQueue.MouseMove += lstQueue_MouseMove;
            lstQueue.MouseUp += lstQueue_MouseUp;
            lstQueue.DragOver += lstQueue_DragOver;
            lstQueue.DragDrop += lstQueue_DragDrop;

            grpBroadcastQueue.Controls.Clear();
            grpBroadcastQueue.Controls.Add(lstQueue);
        }

        private void BuildPlayerVisuals()
        {
            GroupBox grpPlayer = new GroupBox();
            grpPlayer.Text = "Track Player";
            grpPlayer.ForeColor = Color.Gray;
            grpPlayer.Font = new Font("Segoe UI", 8.25F);
            grpPlayer.Location = new Point(475, 75);
            grpPlayer.Size = new Size(300, 300);
            grpPlayer.BackColor = Color.FromArgb(18, 14, 28);

            this.Controls.Add(grpPlayer);
            grpPlayer.SendToBack();

  
            btnBack10.BringToFront();
            btnForward10.BringToFront();
            btnPlay.BringToFront();
            btnNextTrack.BringToFront();
            btnPrevTrack.BringToFront();
            btnStop.BringToFront();

        }


        private void btnPrevTrack_Click(object sender, EventArgs e)
        {
            int previousIndex = currentQueueIndex - 1;

            if (previousIndex >= 0 && previousIndex < broadcastQueue.Count)
            {
                manualQueueAnchorIndex = -1;
                PlayQueueItem(previousIndex);
            }
        }
        private void btnNextTrack_Click(object sender, EventArgs e)
        {
            int nextIndex = currentQueueIndex + 1;

            if (nextIndex >= 0 && nextIndex < broadcastQueue.Count)
            {
                manualQueueAnchorIndex = -1;
                PlayQueueItem(nextIndex);
            }
            else
            {
                StopPlayback();
                btnPlay.BackgroundImage = Properties.Resources.btnPlay;
                btnPlay.Text = ".";

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopPlayback();
            btnPlay.BackgroundImage = Properties.Resources.btnPlay;
            btnPlay.Text = ".";

        }
        private void btnPause_Click()
        {
            
            if (!player.IsLoaded)
                return;

            player.Pause();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text == ".")
            {
                if (player.IsLoaded)
                {
                    player.Play();
                    timer1.Start();
                    btnPlay.BackgroundImage = Properties.Resources.btnPause;
                    btnPlay.Text = "";

                    return;
                }

                int index = lstQueue.SelectedIndex;

                if (index < 0)
                    index = currentQueueIndex;

                if (index < 0 && broadcastQueue.Count > 0)
                    index = 0;

                if (index >= 0 && index < broadcastQueue.Count)
                {
                    manualQueueAnchorIndex = -1;
                    PlayQueueItem(index);
                }

            }
            else { 
                btnPause_Click();
                btnPlay.BackgroundImage = Properties.Resources.btnPlay;
                btnPlay.Text = ".";
            }
        }

        private void PlayQueueItem(int index)
        {
            if (index < 0 || index >= broadcastQueue.Count)
                return;

            PlaylistItem item = broadcastQueue[index];

            if (string.IsNullOrWhiteSpace(item.FilePath) || !System.IO.File.Exists(item.FilePath))
            {
                MessageBox.Show("File not found: " + item.FilePath);
                return;
            }

            currentQueueIndex = index;
            lstQueue.SelectedIndex = index;

            player.Load(item.FilePath);
            player.Play();

            LoadAlbumArt(item.FilePath);

            trkProgress.Value = 0;
            lblElapsed.Text = "00:00";
            lblDuration.Text = player.TotalTime.ToString(@"mm\:ss");

            lblTrack.Text = item.Title;
            lblArtist.Text = item.Track != null ? item.Track.Artist : "";
            lblAlbum.Text = item.Track != null ? item.Track.Album : "";

            timer1.Start();
            btnPlay.BackgroundImage = Properties.Resources.btnPause;
            btnPlay.Text = "";

        }
        private void player_PlaybackFinished(object sender, EventArgs e)
        {
//            MessageBox.Show("PlaybackFinished fired");
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => player_PlaybackFinished(sender, e)));
                return;
            }

            int nextIndex;

            if (manualQueueAnchorIndex >= 0)
            {
                nextIndex = manualQueueAnchorIndex + 1;
                manualQueueAnchorIndex = -1;
            }
            else
            {
                nextIndex = currentQueueIndex + 1;
            }

            if (nextIndex >= 0 && nextIndex < broadcastQueue.Count)
            {
                PlayQueueItem(nextIndex);
                btnPlay.BackgroundImage = Properties.Resources.btnPause;
                btnPlay.Text = "";

            }
            else
            {
                StopPlayback();
                btnPlay.BackgroundImage = Properties.Resources.btnPlay;
                btnPlay.Text = ".";

            }
        }

        private void StopPlayback()
        {
            // Stop timer first so UI doesn't keep updating mid-reset
            timer1.Stop();

            // Stop the player (this should NOT trigger PlaybackFinished if your AudioPlayerService is correct)
            if (player != null)
            {
                player.Stop();
            }

            // Reset playback state
            currentQueueIndex = -1;
            manualQueueAnchorIndex = -1;

            // Reset UI
            lblTrack.Text = "";
            lblArtist.Text = "";
            lblAlbum.Text = "";
            lblElapsed.Text = "00:00";
            lblDuration.Text = "00:00";
            lblTrackTimeLeft.Text = "00:00";

            if (trkProgress != null)
                trkProgress.Value = 0;

            // Clear album art safely
            if (picAlbumArt != null && picAlbumArt.Image != null)
            {
                picAlbumArt.Image.Dispose();
                picAlbumArt.Image = Properties.Resources.IIT_Nadjia2;          }

            // Optional: clear selection so UI reflects stopped state
            if (lstQueue != null)
                lstQueue.ClearSelected();
            btnPlay.BackgroundImage = Properties.Resources.btnPlay;
            btnPlay.Text = ".";

        }
        private void lstQueue_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            dragStartIndex = lstQueue.IndexFromPoint(e.Location);
            dragStartPoint = e.Location;
            dragInProgress = false;
        }

        private void lstQueue_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (dragStartIndex == ListBox.NoMatches)
                return;

            Rectangle dragRectangle = new Rectangle(
                dragStartPoint.X - SystemInformation.DragSize.Width / 2,
                dragStartPoint.Y - SystemInformation.DragSize.Height / 2,
                SystemInformation.DragSize.Width,
                SystemInformation.DragSize.Height
            );

            if (!dragRectangle.Contains(e.Location))
            {
                dragInProgress = true;
                lstQueue.DoDragDrop(dragStartIndex, DragDropEffects.Move);
            }
        }

        private void lstQueue_MouseUp(object sender, MouseEventArgs e)
        {
            int clickedIndex = lstQueue.IndexFromPoint(e.Location);

            if (clickedIndex < 0 || clickedIndex >= broadcastQueue.Count)
                return;

            if (clickedIndex == currentQueueIndex)
                manualQueueAnchorIndex = -1;
            else
                manualQueueAnchorIndex = clickedIndex;
        }

        private void lstQueue_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstQueue_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lstQueue.PointToClient(new Point(e.X, e.Y));
            int dropIndex = lstQueue.IndexFromPoint(point);

            if (dropIndex == ListBox.NoMatches)
                dropIndex = broadcastQueue.Count;

            if (dragStartIndex < 0 || dragStartIndex >= broadcastQueue.Count)
                return;

            if (dropIndex < 0 || dropIndex > broadcastQueue.Count)
                return;

            PlaylistItem draggedItem = broadcastQueue[dragStartIndex];

            broadcastQueue.RemoveAt(dragStartIndex);

            if (dropIndex > dragStartIndex)
                dropIndex--;

            broadcastQueue.Insert(dropIndex, draggedItem);
            lstQueue.SelectedIndex = dropIndex;

            if (dropIndex >= 0 && dropIndex < broadcastQueue.Count)
            {
                if (dropIndex == currentQueueIndex)
                {
                    manualQueueAnchorIndex = -1;
                }
                else
                {
                    manualQueueAnchorIndex = dropIndex;
                }
            }

            if (currentQueueIndex == dragStartIndex)
            {
                currentQueueIndex = dropIndex;
            }
            else if (dragStartIndex < currentQueueIndex && dropIndex >= currentQueueIndex)
            {
                currentQueueIndex--;
            }
            else if (dragStartIndex > currentQueueIndex && dropIndex <= currentQueueIndex)
            {
                currentQueueIndex++;
            }

            manualQueueAnchorIndex = -1;
            dragInProgress = false;
        }

        private void LoadAlbumArt(string filePath)
        {
            if (picAlbumArt.Image != null)
            {
                picAlbumArt.Image.Dispose();
                picAlbumArt.Image = null;
            }

            try
            {
                TagLib.File tagFile = TagLib.File.Create(filePath);

                if (tagFile.Tag.Pictures != null && tagFile.Tag.Pictures.Length > 0)
                {
                    byte[] imageBytes = tagFile.Tag.Pictures[0].Data.Data;

                    using (System.IO.MemoryStream stream = new System.IO.MemoryStream(imageBytes))
                    {
                        picAlbumArt.Image = Image.FromStream(stream);
                    }
                }
            }
            catch
            {
                picAlbumArt.Image = Properties.Resources.IIT_Nadjia2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!player.IsLoaded)
                return;

            TimeSpan current = player.CurrentTime;
            TimeSpan total = player.TotalTime;
            TimeSpan remaining = total - current;

            if (remaining < TimeSpan.Zero)
                remaining = TimeSpan.Zero;

            lblElapsed.Text = current.ToString(@"mm\:ss");
            lblDuration.Text = total.ToString(@"mm\:ss");
            lblTrackTimeLeft.Text = remaining.ToString(@"mm\:ss");

            if (!userIsDraggingProgress && total.TotalSeconds > 0)
            {
                double percent = current.TotalSeconds / total.TotalSeconds;
                int value = (int)(percent * trkProgress.Maximum);

                if (value < trkProgress.Minimum)
                    value = trkProgress.Minimum;

                if (value > trkProgress.Maximum)
                    value = trkProgress.Maximum;

                trkProgress.Value = value;
            }
        }

        private void trkProgress_MouseDown(object sender, MouseEventArgs e)
        {
            userIsDraggingProgress = true;
        }

        private void trkProgress_MouseUp(object sender, MouseEventArgs e)
        {
            SeekToTrackBarPosition();
            userIsDraggingProgress = false;
        }

        private void trkProgress_Scroll(object sender, EventArgs e)
        {
            if (userIsDraggingProgress)
            {
                TimeSpan preview = GetTrackBarTime();
                lblElapsed.Text = preview.ToString(@"mm\:ss");
            }
        }

        private TimeSpan GetTrackBarTime()
        {
            if (!player.IsLoaded || player.TotalTime.TotalSeconds <= 0)
                return TimeSpan.Zero;

            double percent = (double)trkProgress.Value / trkProgress.Maximum;
            return TimeSpan.FromSeconds(player.TotalTime.TotalSeconds * percent);
        }

        private void SeekToTrackBarPosition()
        {
            if (!player.IsLoaded)
                return;

            player.Seek(GetTrackBarTime());
        }

        private void btnBack10_Click(object sender, EventArgs e)
        {
            if (!player.IsLoaded)
                return;

            player.Seek(player.CurrentTime - TimeSpan.FromSeconds(10));
        }

        private void btnForward10_Click(object sender, EventArgs e)
        {
            if (!player.IsLoaded)
                return;

            player.Seek(player.CurrentTime + TimeSpan.FromSeconds(10));
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "MP3 Files (*.mp3)|*.mp3";
                dialog.Multiselect = true;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                foreach (string filePath in dialog.FileNames)
                {
                    broadcastQueue.Add(new PlaylistItem
                    {
                        ItemType = PlaylistItemType.Track,
                        Title = System.IO.Path.GetFileNameWithoutExtension(filePath),
                        FilePath = filePath
                    });
                    UpdateQueueHorizontalScroll();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (broadcastQueue.Count == 0)
                return;

            manualQueueAnchorIndex = -1;
            PlayQueueItem(0);
            btnPlay.BackgroundImage = Properties.Resources.btnPause;
            btnPlay.Text = "";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            player.Dispose();
            Close();
        }

        private void btnLoadPlaylist_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Load Playlist Into Queue";
                dialog.Filter = "Playlist XML Files (*.xml)|*.xml";
                dialog.InitialDirectory = nadjiaConfig.playlistFolder;
                dialog.Multiselect = true;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                int tracksAdded = 0;

                foreach (string playlistPath in dialog.FileNames)
                {
                    List<TrackInfo> tracks = PlaylistXmlService.LoadPlaylist(playlistPath);

                    foreach (TrackInfo track in tracks)
                    {
                        broadcastQueue.Add(new PlaylistItem
                        {
                            ItemType = PlaylistItemType.Track,
                            Title = track.Title,
                            FilePath = track.FilePath,
                            Track = track
                        });
                        UpdateQueueHorizontalScroll();
                        tracksAdded++;
                    }
                }

 //               MessageBox.Show(tracksAdded + " tracks added to the queue.");
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (broadcastQueue.Count <= 1)
                return;

            Random rng = new Random();

            int startIndex = lstQueue.SelectedIndex;

            // Fallbacks
            if (startIndex < 0)
                startIndex = currentQueueIndex;

            if (startIndex < 0)
                startIndex = 0;

            // If we're at the end or nothing to shuffle
            if (startIndex >= broadcastQueue.Count - 1)
                return;

            // Copy items from startIndex to end
            List<PlaylistItem> subset = new List<PlaylistItem>();

            for (int i = startIndex; i < broadcastQueue.Count; i++)
            {
                subset.Add(broadcastQueue[i]);
            }

            // Fisher-Yates shuffle
            for (int i = subset.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                var temp = subset[i];
                subset[i] = subset[j];
                subset[j] = temp;
            }

            // Write shuffled subset back into original queue
            for (int i = 0; i < subset.Count; i++)
            {
                broadcastQueue[startIndex + i] = subset[i];
            }

            // Maintain currentQueueIndex correctly
            if (currentQueueIndex >= startIndex)
            {
                // Find where the currently playing item moved to
                PlaylistItem currentItem = subset.FirstOrDefault(x => x == broadcastQueue[currentQueueIndex]);

                if (currentItem != null)
                {
                    int newIndex = broadcastQueue.IndexOf(currentItem);
                    currentQueueIndex = newIndex;
                }
            }

            UpdateQueueHorizontalScroll();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            broadcastQueue.Clear();
        }

        private void btnLoadQueue_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Load Queue";
                dialog.Filter = "Queue XML Files (*.xml)|*.xml";
                dialog.InitialDirectory = nadjiaConfig.queueFolder;
                dialog.Multiselect = false;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                List<TrackInfo> tracks = PlaylistXmlService.LoadPlaylist(dialog.FileName);
                broadcastQueue.Clear();

                foreach (TrackInfo track in tracks)
                {
                    broadcastQueue.Add(new PlaylistItem
                    {
                        ItemType = PlaylistItemType.Track,
                        Title = track.Title,
                        FilePath = track.FilePath,
                        Track = track
                    });
                    UpdateQueueHorizontalScroll();
                }

//                MessageBox.Show(tracks.Count + " tracks loaded into the queue.");
            }
        }

        private void btnSaveQueue_Click(object sender, EventArgs e)
        {
            if (broadcastQueue.Count == 0)
            {
                MessageBox.Show("The queue is empty.");
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Save Queue";
                dialog.Filter = "Queue XML Files (*.xml)|*.xml";
                dialog.InitialDirectory = nadjiaConfig.queueFolder;
                dialog.FileName = "Queue-" + DateTime.Now.ToString("yyyy-MM-dd-HHmm") + ".xml";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string queueName = System.IO.Path.GetFileNameWithoutExtension(dialog.FileName);
                List<TrackInfo> tracks = GetTracksFromQueue();

                PlaylistXmlService.SavePlaylist(dialog.FileName, queueName, tracks);

                MessageBox.Show("Queue saved.");
            }
        }
        private void btnDedupe_Click(object sender, EventArgs e)
        {
        }

        private void btnLoadLibrary_Click(object sender, EventArgs e)
        {
            var frm = new frmTrackSearch();
            frm.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblWeather.Text = AppState.sysWeather;
            lblSysTime.Text = AppState.sysTime;
            lblConnections.Text = AppState.sysConnections;
        }
    }
}