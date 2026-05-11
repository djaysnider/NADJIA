using System;
using System.Drawing;
using System.Windows.Forms;
namespace Nadjia
{
    partial class frmConsoleDesk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.FromArgb(120, 90, 160);
            button.BackColor = Color.FromArgb(42, 32, 58);
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsoleDesk));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblNextShowStart = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblShowName = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblSysTime = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.lblShowTimeLeft = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.lblTrackTimeLeft = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadLibrary = new System.Windows.Forms.Button();
            this.btnDedupe = new System.Windows.Forms.Button();
            this.btnLoadQueue = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnLoadPlaylist = new System.Windows.Forms.Button();
            this.btnSaveQueue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnUpdateServer = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCustomBuild = new System.Windows.Forms.Button();
            this.numDropOffset = new System.Windows.Forms.NumericUpDown();
            this.numSweepFreq = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.chkAutosend = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numWiticismOffset = new System.Windows.Forms.NumericUpDown();
            this.numWeatherOffset = new System.Windows.Forms.NumericUpDown();
            this.numTimeCheckOffset = new System.Windows.Forms.NumericUpDown();
            this.numCommercialOffset = new System.Windows.Forms.NumericUpDown();
            this.numWiticisimFreq = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numDayOverride = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.chkTimeOverride = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numHourOverride = new System.Windows.Forms.NumericUpDown();
            this.numMinuteOverride = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numTrackCount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numSetCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numCrossfade = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numWeatherBreaks = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numTimeCheck = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numAdBreaks = new System.Windows.Forms.NumericUpDown();
            this.txtNowPlaying = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSetLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLibrary = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnWiticism = new System.Windows.Forms.Button();
            this.btnNewSet = new System.Windows.Forms.Button();
            this.btnWeather = new System.Windows.Forms.Button();
            this.btnTimeBreak = new System.Windows.Forms.Button();
            this.btnRecap = new System.Windows.Forms.Button();
            this.btnRefreshTime = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBroadcastQueue = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.trkProgress = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnForward10 = new System.Windows.Forms.Button();
            this.btnNextTrack = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPrevTrack = new System.Windows.Forms.Button();
            this.btnBack10 = new System.Windows.Forms.Button();
            this.picAlbumArt = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblConnections = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDropOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSweepFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWiticismOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeatherOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeCheckOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommercialOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWiticisimFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDayOverride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHourOverride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuteOverride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossfade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeatherBreaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdBreaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetLength)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.lblNextShowStart);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.lblShowName);
            this.groupBox6.Controls.Add(this.lblPlaylist);
            this.groupBox6.Controls.Add(this.lblShowTimeLeft);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Gray;
            this.groupBox6.Location = new System.Drawing.Point(547, 437);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(416, 138);
            this.groupBox6.TabIndex = 79;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Current Status";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Gold;
            this.label26.Location = new System.Drawing.Point(7, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 13);
            this.label26.TabIndex = 66;
            this.label26.Text = "Starts In:";
            // 
            // lblNextShowStart
            // 
            this.lblNextShowStart.AutoSize = true;
            this.lblNextShowStart.ForeColor = System.Drawing.Color.White;
            this.lblNextShowStart.Location = new System.Drawing.Point(116, 60);
            this.lblNextShowStart.Name = "lblNextShowStart";
            this.lblNextShowStart.Size = new System.Drawing.Size(84, 13);
            this.lblNextShowStart.TabIndex = 65;
            this.lblNextShowStart.Text = "Show Time Left";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Gold;
            this.label24.Location = new System.Drawing.Point(7, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 13);
            this.label24.TabIndex = 64;
            this.label24.Text = "Current Show:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Gold;
            this.label25.Location = new System.Drawing.Point(7, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 13);
            this.label25.TabIndex = 63;
            this.label25.Text = "Using Playlist:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Gold;
            this.label22.Location = new System.Drawing.Point(7, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 62;
            this.label22.Text = "Next Show:";
            // 
            // label23
            // 
            this.label23.ForeColor = System.Drawing.Color.Gold;
            this.label23.Location = new System.Drawing.Point(323, 276);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 13);
            this.label23.TabIndex = 61;
            this.label23.Text = "Track Time Left:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.ForeColor = System.Drawing.Color.White;
            this.lblShowName.Location = new System.Drawing.Point(116, 17);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(68, 13);
            this.lblShowName.TabIndex = 60;
            this.lblShowName.Text = "Show Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gold;
            this.label19.Location = new System.Drawing.Point(523, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 20);
            this.label19.TabIndex = 59;
            this.label19.Text = "Weather:";
            // 
            // lblSysTime
            // 
            this.lblSysTime.AutoSize = true;
            this.lblSysTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysTime.ForeColor = System.Drawing.Color.White;
            this.lblSysTime.Location = new System.Drawing.Point(289, 34);
            this.lblSysTime.Name = "lblSysTime";
            this.lblSysTime.Size = new System.Drawing.Size(73, 29);
            this.lblSysTime.TabIndex = 1;
            this.lblSysTime.Text = "Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gold;
            this.label14.Location = new System.Drawing.Point(289, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 20);
            this.label14.TabIndex = 58;
            this.label14.Text = "Current Air Time:";
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.ForeColor = System.Drawing.Color.White;
            this.lblPlaylist.Location = new System.Drawing.Point(116, 32);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(42, 13);
            this.lblPlaylist.TabIndex = 45;
            this.lblPlaylist.Text = "Playlist";
            // 
            // lblShowTimeLeft
            // 
            this.lblShowTimeLeft.AutoSize = true;
            this.lblShowTimeLeft.ForeColor = System.Drawing.Color.White;
            this.lblShowTimeLeft.Location = new System.Drawing.Point(117, 75);
            this.lblShowTimeLeft.Name = "lblShowTimeLeft";
            this.lblShowTimeLeft.Size = new System.Drawing.Size(84, 13);
            this.lblShowTimeLeft.TabIndex = 57;
            this.lblShowTimeLeft.Text = "Show Time Left";
            // 
            // lblWeather
            // 
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.ForeColor = System.Drawing.Color.White;
            this.lblWeather.Location = new System.Drawing.Point(603, 11);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(279, 61);
            this.lblWeather.TabIndex = 53;
            this.lblWeather.Text = "Weather";
            // 
            // lblTrackTimeLeft
            // 
            this.lblTrackTimeLeft.ForeColor = System.Drawing.Color.White;
            this.lblTrackTimeLeft.Location = new System.Drawing.Point(323, 294);
            this.lblTrackTimeLeft.Name = "lblTrackTimeLeft";
            this.lblTrackTimeLeft.Size = new System.Drawing.Size(85, 13);
            this.lblTrackTimeLeft.TabIndex = 56;
            this.lblTrackTimeLeft.Text = "Track Time Left:";
            this.lblTrackTimeLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(378, 247);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(28, 13);
            this.lblDuration.TabIndex = 68;
            this.lblDuration.Text = "0:00";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Location = new System.Drawing.Point(6, 247);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(28, 13);
            this.lblElapsed.TabIndex = 67;
            this.lblElapsed.Text = "0:00";
            // 
            // lblArtist
            // 
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.Gold;
            this.lblArtist.Location = new System.Drawing.Point(216, 85);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(194, 55);
            this.lblArtist.TabIndex = 54;
            this.lblArtist.Text = "Artist";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTrack
            // 
            this.lblTrack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrack.ForeColor = System.Drawing.Color.White;
            this.lblTrack.Location = new System.Drawing.Point(216, 18);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(194, 82);
            this.lblTrack.TabIndex = 55;
            this.lblTrack.Text = "Track";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnLoadLibrary);
            this.groupBox2.Controls.Add(this.btnDedupe);
            this.groupBox2.Controls.Add(this.btnLoadQueue);
            this.groupBox2.Controls.Add(this.btnShuffle);
            this.groupBox2.Controls.Add(this.btnLoadPlaylist);
            this.groupBox2.Controls.Add(this.btnSaveQueue);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnAddFile);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(410, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 251);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Queue Controls";
            // 
            // btnLoadLibrary
            // 
            this.btnLoadLibrary.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnLoadLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnLoadLibrary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoadLibrary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnLoadLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnLoadLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadLibrary.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadLibrary.ForeColor = System.Drawing.Color.White;
            this.btnLoadLibrary.Location = new System.Drawing.Point(7, 74);
            this.btnLoadLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadLibrary.Name = "btnLoadLibrary";
            this.btnLoadLibrary.Size = new System.Drawing.Size(114, 25);
            this.btnLoadLibrary.TabIndex = 8;
            this.btnLoadLibrary.Text = "Load from Library";
            this.btnLoadLibrary.UseVisualStyleBackColor = false;
            this.btnLoadLibrary.Click += new System.EventHandler(this.btnLoadLibrary_Click);
            // 
            // btnDedupe
            // 
            this.btnDedupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnDedupe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDedupe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnDedupe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDedupe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnDedupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDedupe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDedupe.ForeColor = System.Drawing.Color.White;
            this.btnDedupe.Location = new System.Drawing.Point(7, 158);
            this.btnDedupe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDedupe.Name = "btnDedupe";
            this.btnDedupe.Size = new System.Drawing.Size(114, 25);
            this.btnDedupe.TabIndex = 11;
            this.btnDedupe.Text = "De-Dupe Queue";
            this.btnDedupe.UseVisualStyleBackColor = false;
            this.btnDedupe.Click += new System.EventHandler(this.btnDedupe_Click);
            // 
            // btnLoadQueue
            // 
            this.btnLoadQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnLoadQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoadQueue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnLoadQueue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnLoadQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadQueue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadQueue.ForeColor = System.Drawing.Color.White;
            this.btnLoadQueue.Location = new System.Drawing.Point(7, 18);
            this.btnLoadQueue.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadQueue.Name = "btnLoadQueue";
            this.btnLoadQueue.Size = new System.Drawing.Size(114, 25);
            this.btnLoadQueue.TabIndex = 6;
            this.btnLoadQueue.Text = "Load Queue";
            this.btnLoadQueue.UseVisualStyleBackColor = false;
            this.btnLoadQueue.Click += new System.EventHandler(this.btnLoadQueue_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShuffle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnShuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.White;
            this.btnShuffle.Location = new System.Drawing.Point(7, 186);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(114, 25);
            this.btnShuffle.TabIndex = 12;
            this.btnShuffle.Text = "Shuffle Queue";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnLoadPlaylist
            // 
            this.btnLoadPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnLoadPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadPlaylist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnLoadPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnLoadPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPlaylist.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnLoadPlaylist.Location = new System.Drawing.Point(7, 102);
            this.btnLoadPlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPlaylist.Name = "btnLoadPlaylist";
            this.btnLoadPlaylist.Size = new System.Drawing.Size(114, 25);
            this.btnLoadPlaylist.TabIndex = 9;
            this.btnLoadPlaylist.Text = "Load from Playlist";
            this.btnLoadPlaylist.UseVisualStyleBackColor = false;
            this.btnLoadPlaylist.Click += new System.EventHandler(this.btnLoadPlaylist_Click);
            // 
            // btnSaveQueue
            // 
            this.btnSaveQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnSaveQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveQueue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnSaveQueue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnSaveQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQueue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQueue.ForeColor = System.Drawing.Color.White;
            this.btnSaveQueue.Location = new System.Drawing.Point(7, 46);
            this.btnSaveQueue.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveQueue.Name = "btnSaveQueue";
            this.btnSaveQueue.Size = new System.Drawing.Size(114, 25);
            this.btnSaveQueue.TabIndex = 7;
            this.btnSaveQueue.Text = "Save Queue";
            this.btnSaveQueue.UseVisualStyleBackColor = false;
            this.btnSaveQueue.Click += new System.EventHandler(this.btnSaveQueue_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(7, 214);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 25);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Queue";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnAddFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFile.ForeColor = System.Drawing.Color.White;
            this.btnAddFile.Location = new System.Drawing.Point(7, 130);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(114, 25);
            this.btnAddFile.TabIndex = 10;
            this.btnAddFile.Text = "Load from File";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.btnUpdateServer);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.btnCustomBuild);
            this.groupBox1.Controls.Add(this.numDropOffset);
            this.groupBox1.Controls.Add(this.numSweepFreq);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.chkAutosend);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.numWiticismOffset);
            this.groupBox1.Controls.Add(this.numWeatherOffset);
            this.groupBox1.Controls.Add(this.numTimeCheckOffset);
            this.groupBox1.Controls.Add(this.numCommercialOffset);
            this.groupBox1.Controls.Add(this.numWiticisimFreq);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numDayOverride);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.chkTimeOverride);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numHourOverride);
            this.groupBox1.Controls.Add(this.numMinuteOverride);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numTrackCount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numSetCount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numCrossfade);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numWeatherBreaks);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numTimeCheck);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numAdBreaks);
            this.groupBox1.Controls.Add(this.txtNowPlaying);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numSetLength);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbLibrary);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(969, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 499);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto DJ Configuration";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.DimGray;
            this.button9.Location = new System.Drawing.Point(7, 439);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 56);
            this.button9.TabIndex = 82;
            this.button9.Text = "Darrin Proof";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.DimGray;
            this.button8.Location = new System.Drawing.Point(68, 439);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 56);
            this.button8.TabIndex = 83;
            this.button8.Text = "AutoDJ Mode";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnUpdateServer
            // 
            this.btnUpdateServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnUpdateServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnUpdateServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnUpdateServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateServer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateServer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateServer.Location = new System.Drawing.Point(108, 81);
            this.btnUpdateServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateServer.Name = "btnUpdateServer";
            this.btnUpdateServer.Size = new System.Drawing.Size(171, 25);
            this.btnUpdateServer.TabIndex = 96;
            this.btnUpdateServer.Text = "Send to Server";
            this.btnUpdateServer.UseVisualStyleBackColor = false;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(144, 259);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 112;
            this.label20.Text = "Offset:";
            // 
            // btnCustomBuild
            // 
            this.btnCustomBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnCustomBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomBuild.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnCustomBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCustomBuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnCustomBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomBuild.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomBuild.ForeColor = System.Drawing.Color.White;
            this.btnCustomBuild.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomBuild.Location = new System.Drawing.Point(229, 22);
            this.btnCustomBuild.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomBuild.Name = "btnCustomBuild";
            this.btnCustomBuild.Size = new System.Drawing.Size(48, 25);
            this.btnCustomBuild.TabIndex = 95;
            this.btnCustomBuild.Text = "Build";
            this.btnCustomBuild.UseVisualStyleBackColor = false;
            // 
            // numDropOffset
            // 
            this.numDropOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numDropOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numDropOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDropOffset.ForeColor = System.Drawing.Color.Silver;
            this.numDropOffset.Location = new System.Drawing.Point(192, 257);
            this.numDropOffset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numDropOffset.Name = "numDropOffset";
            this.numDropOffset.Size = new System.Drawing.Size(36, 22);
            this.numDropOffset.TabIndex = 111;
            this.numDropOffset.UseWaitCursor = true;
            this.numDropOffset.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numSweepFreq
            // 
            this.numSweepFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSweepFreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numSweepFreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSweepFreq.ForeColor = System.Drawing.Color.Silver;
            this.numSweepFreq.Location = new System.Drawing.Point(97, 256);
            this.numSweepFreq.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSweepFreq.Name = "numSweepFreq";
            this.numSweepFreq.Size = new System.Drawing.Size(36, 22);
            this.numSweepFreq.TabIndex = 110;
            this.numSweepFreq.UseWaitCursor = true;
            this.numSweepFreq.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(7, 258);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 13);
            this.label21.TabIndex = 109;
            this.label21.Text = "Sweep Freq:";
            // 
            // chkAutosend
            // 
            this.chkAutosend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutosend.AutoSize = true;
            this.chkAutosend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.chkAutosend.ForeColor = System.Drawing.Color.White;
            this.chkAutosend.Location = new System.Drawing.Point(7, 85);
            this.chkAutosend.Name = "chkAutosend";
            this.chkAutosend.Size = new System.Drawing.Size(80, 17);
            this.chkAutosend.TabIndex = 108;
            this.chkAutosend.Text = "Auto Send";
            this.chkAutosend.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(144, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 107;
            this.label18.Text = "Offset:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(144, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 106;
            this.label17.Text = "Offset:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(144, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 105;
            this.label16.Text = "Offset:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(144, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 104;
            this.label15.Text = "Offset:";
            // 
            // numWiticismOffset
            // 
            this.numWiticismOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numWiticismOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numWiticismOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numWiticismOffset.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numWiticismOffset.ForeColor = System.Drawing.Color.Silver;
            this.numWiticismOffset.Location = new System.Drawing.Point(192, 231);
            this.numWiticismOffset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWiticismOffset.Name = "numWiticismOffset";
            this.numWiticismOffset.Size = new System.Drawing.Size(36, 22);
            this.numWiticismOffset.TabIndex = 103;
            this.numWiticismOffset.UseWaitCursor = true;
            this.numWiticismOffset.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numWeatherOffset
            // 
            this.numWeatherOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numWeatherOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numWeatherOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numWeatherOffset.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numWeatherOffset.ForeColor = System.Drawing.Color.Silver;
            this.numWeatherOffset.Location = new System.Drawing.Point(192, 203);
            this.numWeatherOffset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWeatherOffset.Name = "numWeatherOffset";
            this.numWeatherOffset.Size = new System.Drawing.Size(36, 22);
            this.numWeatherOffset.TabIndex = 102;
            this.numWeatherOffset.UseWaitCursor = true;
            // 
            // numTimeCheckOffset
            // 
            this.numTimeCheckOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTimeCheckOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numTimeCheckOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTimeCheckOffset.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numTimeCheckOffset.ForeColor = System.Drawing.Color.Silver;
            this.numTimeCheckOffset.Location = new System.Drawing.Point(192, 175);
            this.numTimeCheckOffset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTimeCheckOffset.Name = "numTimeCheckOffset";
            this.numTimeCheckOffset.Size = new System.Drawing.Size(36, 22);
            this.numTimeCheckOffset.TabIndex = 101;
            this.numTimeCheckOffset.UseWaitCursor = true;
            // 
            // numCommercialOffset
            // 
            this.numCommercialOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCommercialOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numCommercialOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCommercialOffset.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numCommercialOffset.ForeColor = System.Drawing.Color.Silver;
            this.numCommercialOffset.Location = new System.Drawing.Point(192, 147);
            this.numCommercialOffset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCommercialOffset.Name = "numCommercialOffset";
            this.numCommercialOffset.Size = new System.Drawing.Size(36, 22);
            this.numCommercialOffset.TabIndex = 100;
            this.numCommercialOffset.UseWaitCursor = true;
            this.numCommercialOffset.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numWiticisimFreq
            // 
            this.numWiticisimFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numWiticisimFreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numWiticisimFreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numWiticisimFreq.ForeColor = System.Drawing.Color.Silver;
            this.numWiticisimFreq.Location = new System.Drawing.Point(97, 230);
            this.numWiticisimFreq.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWiticisimFreq.Name = "numWiticisimFreq";
            this.numWiticisimFreq.Size = new System.Drawing.Size(36, 22);
            this.numWiticisimFreq.TabIndex = 96;
            this.numWiticisimFreq.UseWaitCursor = true;
            this.numWiticisimFreq.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Witicism Freq:";
            // 
            // numDayOverride
            // 
            this.numDayOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numDayOverride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numDayOverride.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDayOverride.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numDayOverride.ForeColor = System.Drawing.Color.Silver;
            this.numDayOverride.Location = new System.Drawing.Point(44, 359);
            this.numDayOverride.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numDayOverride.Name = "numDayOverride";
            this.numDayOverride.Size = new System.Drawing.Size(36, 22);
            this.numDayOverride.TabIndex = 91;
            this.numDayOverride.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "Day:";
            // 
            // chkTimeOverride
            // 
            this.chkTimeOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTimeOverride.AutoSize = true;
            this.chkTimeOverride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.chkTimeOverride.ForeColor = System.Drawing.Color.White;
            this.chkTimeOverride.Location = new System.Drawing.Point(221, 362);
            this.chkTimeOverride.Name = "chkTimeOverride";
            this.chkTimeOverride.Size = new System.Drawing.Size(70, 17);
            this.chkTimeOverride.TabIndex = 89;
            this.chkTimeOverride.Text = "Override";
            this.chkTimeOverride.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = ":";
            // 
            // numHourOverride
            // 
            this.numHourOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numHourOverride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numHourOverride.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numHourOverride.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numHourOverride.ForeColor = System.Drawing.Color.Silver;
            this.numHourOverride.Location = new System.Drawing.Point(115, 359);
            this.numHourOverride.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHourOverride.Name = "numHourOverride";
            this.numHourOverride.Size = new System.Drawing.Size(41, 22);
            this.numHourOverride.TabIndex = 87;
            this.numHourOverride.UseWaitCursor = true;
            // 
            // numMinuteOverride
            // 
            this.numMinuteOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numMinuteOverride.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numMinuteOverride.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMinuteOverride.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numMinuteOverride.ForeColor = System.Drawing.Color.Silver;
            this.numMinuteOverride.Location = new System.Drawing.Point(167, 359);
            this.numMinuteOverride.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinuteOverride.Name = "numMinuteOverride";
            this.numMinuteOverride.Size = new System.Drawing.Size(44, 22);
            this.numMinuteOverride.TabIndex = 86;
            this.numMinuteOverride.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(81, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Time:";
            // 
            // numTrackCount
            // 
            this.numTrackCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTrackCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numTrackCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTrackCount.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numTrackCount.ForeColor = System.Drawing.Color.Silver;
            this.numTrackCount.Location = new System.Drawing.Point(103, 327);
            this.numTrackCount.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numTrackCount.Name = "numTrackCount";
            this.numTrackCount.Size = new System.Drawing.Size(36, 22);
            this.numTrackCount.TabIndex = 84;
            this.numTrackCount.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 83;
            this.label10.Text = "Track Count:";
            // 
            // numSetCount
            // 
            this.numSetCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSetCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numSetCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSetCount.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numSetCount.ForeColor = System.Drawing.Color.Silver;
            this.numSetCount.Location = new System.Drawing.Point(228, 327);
            this.numSetCount.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numSetCount.Name = "numSetCount";
            this.numSetCount.Size = new System.Drawing.Size(36, 22);
            this.numSetCount.TabIndex = 82;
            this.numSetCount.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(165, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Set Count:";
            // 
            // numCrossfade
            // 
            this.numCrossfade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCrossfade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numCrossfade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCrossfade.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numCrossfade.ForeColor = System.Drawing.Color.Silver;
            this.numCrossfade.Location = new System.Drawing.Point(103, 299);
            this.numCrossfade.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numCrossfade.Name = "numCrossfade";
            this.numCrossfade.Size = new System.Drawing.Size(36, 22);
            this.numCrossfade.TabIndex = 80;
            this.numCrossfade.UseWaitCursor = true;
            this.numCrossfade.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Crossfade:";
            // 
            // numWeatherBreaks
            // 
            this.numWeatherBreaks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numWeatherBreaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numWeatherBreaks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numWeatherBreaks.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numWeatherBreaks.ForeColor = System.Drawing.Color.Silver;
            this.numWeatherBreaks.Location = new System.Drawing.Point(97, 202);
            this.numWeatherBreaks.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWeatherBreaks.Name = "numWeatherBreaks";
            this.numWeatherBreaks.Size = new System.Drawing.Size(36, 22);
            this.numWeatherBreaks.TabIndex = 78;
            this.numWeatherBreaks.UseWaitCursor = true;
            this.numWeatherBreaks.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Weather Freq:";
            // 
            // numTimeCheck
            // 
            this.numTimeCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTimeCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numTimeCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTimeCheck.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numTimeCheck.ForeColor = System.Drawing.Color.Silver;
            this.numTimeCheck.Location = new System.Drawing.Point(97, 174);
            this.numTimeCheck.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTimeCheck.Name = "numTimeCheck";
            this.numTimeCheck.Size = new System.Drawing.Size(36, 22);
            this.numTimeCheck.TabIndex = 76;
            this.numTimeCheck.UseWaitCursor = true;
            this.numTimeCheck.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Timecheck Freq:";
            // 
            // numAdBreaks
            // 
            this.numAdBreaks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numAdBreaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numAdBreaks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAdBreaks.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numAdBreaks.ForeColor = System.Drawing.Color.Silver;
            this.numAdBreaks.Location = new System.Drawing.Point(97, 146);
            this.numAdBreaks.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numAdBreaks.Name = "numAdBreaks";
            this.numAdBreaks.Size = new System.Drawing.Size(36, 22);
            this.numAdBreaks.TabIndex = 74;
            this.numAdBreaks.UseWaitCursor = true;
            this.numAdBreaks.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // txtNowPlaying
            // 
            this.txtNowPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNowPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.txtNowPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNowPlaying.ForeColor = System.Drawing.Color.Silver;
            this.txtNowPlaying.Location = new System.Drawing.Point(109, 54);
            this.txtNowPlaying.Margin = new System.Windows.Forms.Padding(4);
            this.txtNowPlaying.Name = "txtNowPlaying";
            this.txtNowPlaying.Size = new System.Drawing.Size(170, 20);
            this.txtNowPlaying.TabIndex = 67;
            this.txtNowPlaying.Text = "Live from Studio B";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Ad Freq:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Now Playing:";
            // 
            // numSetLength
            // 
            this.numSetLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSetLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.numSetLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSetLength.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numSetLength.ForeColor = System.Drawing.Color.Silver;
            this.numSetLength.Location = new System.Drawing.Point(97, 118);
            this.numSetLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSetLength.Name = "numSetLength";
            this.numSetLength.Size = new System.Drawing.Size(36, 22);
            this.numSetLength.TabIndex = 72;
            this.numSetLength.UseWaitCursor = true;
            this.numSetLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Set Length:";
            // 
            // cmbLibrary
            // 
            this.cmbLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.cmbLibrary.ForeColor = System.Drawing.Color.Silver;
            this.cmbLibrary.FormattingEnabled = true;
            this.cmbLibrary.Items.AddRange(new object[] {
            "acoustic",
            "exclusive",
            "extreme",
            "hardrock",
            "mainstream",
            "newtracks"});
            this.cmbLibrary.Location = new System.Drawing.Point(109, 25);
            this.cmbLibrary.Name = "cmbLibrary";
            this.cmbLibrary.Size = new System.Drawing.Size(113, 21);
            this.cmbLibrary.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Genre / Show:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.btnWiticism);
            this.groupBox4.Controls.Add(this.btnNewSet);
            this.groupBox4.Controls.Add(this.btnWeather);
            this.groupBox4.Controls.Add(this.btnTimeBreak);
            this.groupBox4.Controls.Add(this.btnRecap);
            this.groupBox4.Controls.Add(this.btnRefreshTime);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Gray;
            this.groupBox4.Location = new System.Drawing.Point(410, 331);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(130, 246);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AutoDJ Testing";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(7, 214);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 25);
            this.button7.TabIndex = 21;
            this.button7.Text = "Random Track";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnWiticism
            // 
            this.btnWiticism.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnWiticism.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWiticism.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnWiticism.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnWiticism.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnWiticism.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiticism.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWiticism.ForeColor = System.Drawing.Color.White;
            this.btnWiticism.Location = new System.Drawing.Point(7, 158);
            this.btnWiticism.Margin = new System.Windows.Forms.Padding(4);
            this.btnWiticism.Name = "btnWiticism";
            this.btnWiticism.Size = new System.Drawing.Size(114, 25);
            this.btnWiticism.TabIndex = 19;
            this.btnWiticism.Text = "Witicism";
            this.btnWiticism.UseVisualStyleBackColor = false;
            // 
            // btnNewSet
            // 
            this.btnNewSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnNewSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnNewSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnNewSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnNewSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSet.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSet.ForeColor = System.Drawing.Color.White;
            this.btnNewSet.Location = new System.Drawing.Point(7, 186);
            this.btnNewSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewSet.Name = "btnNewSet";
            this.btnNewSet.Size = new System.Drawing.Size(114, 25);
            this.btnNewSet.TabIndex = 20;
            this.btnNewSet.Text = "New Set";
            this.btnNewSet.UseVisualStyleBackColor = false;
            // 
            // btnWeather
            // 
            this.btnWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWeather.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnWeather.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnWeather.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeather.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeather.ForeColor = System.Drawing.Color.White;
            this.btnWeather.Location = new System.Drawing.Point(7, 130);
            this.btnWeather.Margin = new System.Windows.Forms.Padding(4);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(114, 25);
            this.btnWeather.TabIndex = 18;
            this.btnWeather.Text = "Weather";
            this.btnWeather.UseVisualStyleBackColor = false;
            // 
            // btnTimeBreak
            // 
            this.btnTimeBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnTimeBreak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimeBreak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnTimeBreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnTimeBreak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnTimeBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeBreak.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeBreak.ForeColor = System.Drawing.Color.White;
            this.btnTimeBreak.Location = new System.Drawing.Point(7, 102);
            this.btnTimeBreak.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimeBreak.Name = "btnTimeBreak";
            this.btnTimeBreak.Size = new System.Drawing.Size(114, 25);
            this.btnTimeBreak.TabIndex = 17;
            this.btnTimeBreak.Text = "Time";
            this.btnTimeBreak.UseVisualStyleBackColor = false;
            // 
            // btnRecap
            // 
            this.btnRecap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnRecap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnRecap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRecap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnRecap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecap.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecap.ForeColor = System.Drawing.Color.White;
            this.btnRecap.Location = new System.Drawing.Point(7, 74);
            this.btnRecap.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecap.Name = "btnRecap";
            this.btnRecap.Size = new System.Drawing.Size(114, 25);
            this.btnRecap.TabIndex = 16;
            this.btnRecap.Text = "Recap";
            this.btnRecap.UseVisualStyleBackColor = false;
            // 
            // btnRefreshTime
            // 
            this.btnRefreshTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnRefreshTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefreshTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnRefreshTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRefreshTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnRefreshTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshTime.ForeColor = System.Drawing.Color.White;
            this.btnRefreshTime.Location = new System.Drawing.Point(7, 19);
            this.btnRefreshTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshTime.Name = "btnRefreshTime";
            this.btnRefreshTime.Size = new System.Drawing.Size(114, 25);
            this.btnRefreshTime.TabIndex = 14;
            this.btnRefreshTime.Text = "Refresh Time";
            this.btnRefreshTime.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(7, 46);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 25);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start Show";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1457, 830);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 22);
            this.btnExit.TabIndex = 81;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBroadcastQueue
            // 
            this.grpBroadcastQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBroadcastQueue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBroadcastQueue.ForeColor = System.Drawing.Color.Gray;
            this.grpBroadcastQueue.Location = new System.Drawing.Point(12, 76);
            this.grpBroadcastQueue.Name = "grpBroadcastQueue";
            this.grpBroadcastQueue.Size = new System.Drawing.Size(391, 501);
            this.grpBroadcastQueue.TabIndex = 81;
            this.grpBroadcastQueue.TabStop = false;
            this.grpBroadcastQueue.Text = "Station Queue";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblAlbum);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.lblDuration);
            this.groupBox3.Controls.Add(this.btnForward10);
            this.groupBox3.Controls.Add(this.lblElapsed);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.btnNextTrack);
            this.groupBox3.Controls.Add(this.btnPlay);
            this.groupBox3.Controls.Add(this.btnPrevTrack);
            this.groupBox3.Controls.Add(this.btnBack10);
            this.groupBox3.Controls.Add(this.trkProgress);
            this.groupBox3.Controls.Add(this.picAlbumArt);
            this.groupBox3.Controls.Add(this.lblTrackTimeLeft);
            this.groupBox3.Controls.Add(this.lblArtist);
            this.groupBox3.Controls.Add(this.lblTrack);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gray;
            this.groupBox3.Location = new System.Drawing.Point(547, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 358);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player";
            // 
            // lblAlbum
            // 
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.Gold;
            this.lblAlbum.Location = new System.Drawing.Point(216, 144);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(194, 53);
            this.lblAlbum.TabIndex = 71;
            this.lblAlbum.Text = "Album";
            // 
            // trkProgress
            // 
            this.trkProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.trkProgress.Location = new System.Drawing.Point(5, 215);
            this.trkProgress.Maximum = 1000;
            this.trkProgress.Name = "trkProgress";
            this.trkProgress.Size = new System.Drawing.Size(405, 45);
            this.trkProgress.TabIndex = 2;
            this.trkProgress.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkProgress.Scroll += new System.EventHandler(this.trkProgress_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Silver;
            this.groupBox5.Location = new System.Drawing.Point(1274, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(297, 499);
            this.groupBox5.TabIndex = 113;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "System Status";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Nadjia.Properties.Resources.timer_off;
            this.button5.Location = new System.Drawing.Point(1454, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 56);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Nadjia.Properties.Resources.track_player_on;
            this.button4.Location = new System.Drawing.Point(1330, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 56);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Nadjia.Properties.Resources.soundboard_off;
            this.button3.Location = new System.Drawing.Point(1392, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 56);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Nadjia.Properties.Resources.settings_off;
            this.button2.Location = new System.Drawing.Point(1516, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 56);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Nadjia.Properties.Resources.network_off;
            this.button6.Location = new System.Drawing.Point(1268, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 56);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnStop.BackgroundImage = global::Nadjia.Properties.Resources.btnStop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(163, 269);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 45);
            this.btnStop.TabIndex = 70;
            this.btnStop.Text = " ";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnForward10
            // 
            this.btnForward10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnForward10.BackgroundImage = global::Nadjia.Properties.Resources.btnPlusTen;
            this.btnForward10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnForward10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnForward10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnForward10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnForward10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward10.ForeColor = System.Drawing.Color.White;
            this.btnForward10.Location = new System.Drawing.Point(214, 269);
            this.btnForward10.Name = "btnForward10";
            this.btnForward10.Size = new System.Drawing.Size(45, 45);
            this.btnForward10.TabIndex = 7;
            this.btnForward10.Text = " ";
            this.btnForward10.UseVisualStyleBackColor = false;
            this.btnForward10.Click += new System.EventHandler(this.btnForward10_Click);
            // 
            // btnNextTrack
            // 
            this.btnNextTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnNextTrack.BackgroundImage = global::Nadjia.Properties.Resources.btnNext;
            this.btnNextTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNextTrack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnNextTrack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnNextTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnNextTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextTrack.ForeColor = System.Drawing.Color.White;
            this.btnNextTrack.Location = new System.Drawing.Point(265, 269);
            this.btnNextTrack.Name = "btnNextTrack";
            this.btnNextTrack.Size = new System.Drawing.Size(45, 45);
            this.btnNextTrack.TabIndex = 6;
            this.btnNextTrack.Text = " ";
            this.btnNextTrack.UseVisualStyleBackColor = false;
            this.btnNextTrack.Click += new System.EventHandler(this.btnNextTrack_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnPlay.BackgroundImage = global::Nadjia.Properties.Resources.btnPlay;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnPlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(112, 269);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(45, 45);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = " .";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPrevTrack
            // 
            this.btnPrevTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnPrevTrack.BackgroundImage = global::Nadjia.Properties.Resources.btnPrev;
            this.btnPrevTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrevTrack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnPrevTrack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnPrevTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnPrevTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevTrack.ForeColor = System.Drawing.Color.White;
            this.btnPrevTrack.Location = new System.Drawing.Point(10, 269);
            this.btnPrevTrack.Name = "btnPrevTrack";
            this.btnPrevTrack.Size = new System.Drawing.Size(45, 45);
            this.btnPrevTrack.TabIndex = 4;
            this.btnPrevTrack.Text = " ";
            this.btnPrevTrack.UseVisualStyleBackColor = false;
            this.btnPrevTrack.Click += new System.EventHandler(this.btnPrevTrack_Click);
            // 
            // btnBack10
            // 
            this.btnBack10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.btnBack10.BackgroundImage = global::Nadjia.Properties.Resources.btnMinusTen;
            this.btnBack10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnBack10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.btnBack10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnBack10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack10.ForeColor = System.Drawing.Color.White;
            this.btnBack10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack10.Location = new System.Drawing.Point(61, 269);
            this.btnBack10.Name = "btnBack10";
            this.btnBack10.Size = new System.Drawing.Size(45, 45);
            this.btnBack10.TabIndex = 3;
            this.btnBack10.Text = " ";
            this.btnBack10.UseVisualStyleBackColor = false;
            this.btnBack10.Click += new System.EventHandler(this.btnBack10_Click);
            // 
            // picAlbumArt
            // 
            this.picAlbumArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAlbumArt.Image = global::Nadjia.Properties.Resources.IIT_Nadjia2;
            this.picAlbumArt.InitialImage = ((System.Drawing.Image)(resources.GetObject("picAlbumArt.InitialImage")));
            this.picAlbumArt.Location = new System.Drawing.Point(10, 18);
            this.picAlbumArt.Name = "picAlbumArt";
            this.picAlbumArt.Size = new System.Drawing.Size(200, 200);
            this.picAlbumArt.TabIndex = 0;
            this.picAlbumArt.TabStop = false;
            this.picAlbumArt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trkProgress_MouseDown);
            this.picAlbumArt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkProgress_MouseUp);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Nadjia.Properties.Resources.nadjia_logo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 56);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblConnections
            // 
            this.lblConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnections.Location = new System.Drawing.Point(1022, 34);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(211, 23);
            this.lblConnections.TabIndex = 116;
            this.lblConnections.Text = "0 / 0 / 0 ";
            this.lblConnections.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Gold;
            this.label27.Location = new System.Drawing.Point(888, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(345, 20);
            this.label27.TabIndex = 117;
            this.label27.Text = "Connections:     Current / Peak / Duplicate";
            // 
            // frmConsoleDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lblConnections);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblSysTime);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.grpBroadcastQueue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "frmConsoleDesk";
            this.Text = "Master Console";
            this.Load += new System.EventHandler(this.frmConsoleDesk_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDropOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSweepFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWiticismOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeatherOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeCheckOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommercialOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWiticisimFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDayOverride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHourOverride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuteOverride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossfade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeatherBreaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdBreaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetLength)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private GroupBox groupBox6;
        private Label label26;
        private Label lblNextShowStart;
        private Label label24;
        private Label label25;
        private Label label22;
        private Label label23;
        private Label lblShowName;
        private Label label19;
        private Label lblSysTime;
        private Label label14;
        private Label lblPlaylist;
        private Label lblShowTimeLeft;
        private Label lblWeather;
        private Label lblTrackTimeLeft;
        private Label lblArtist;
        private Label lblTrack;
        private GroupBox groupBox2;
        private Button btnShuffle;
        private Button btnLoadPlaylist;
        private Button btnSaveQueue;
        private Button btnClear;
        private Button btnAddFile;
        private GroupBox groupBox1;
        private Label label20;
        private NumericUpDown numDropOffset;
        private NumericUpDown numSweepFreq;
        private Label label21;
        private CheckBox chkAutosend;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private NumericUpDown numWiticismOffset;
        private NumericUpDown numWeatherOffset;
        private NumericUpDown numTimeCheckOffset;
        private NumericUpDown numCommercialOffset;
        private NumericUpDown numWiticisimFreq;
        private Label label7;
        private NumericUpDown numDayOverride;
        private Label label13;
        private CheckBox chkTimeOverride;
        private Label label12;
        private NumericUpDown numHourOverride;
        private NumericUpDown numMinuteOverride;
        private Label label11;
        private NumericUpDown numTrackCount;
        private Label label10;
        private NumericUpDown numSetCount;
        private Label label8;
        private NumericUpDown numCrossfade;
        private Label label9;
        private NumericUpDown numWeatherBreaks;
        private Label label5;
        private NumericUpDown numTimeCheck;
        private Label label6;
        private NumericUpDown numAdBreaks;
        private TextBox txtNowPlaying;
        private Label label4;
        private Label label1;
        private NumericUpDown numSetLength;
        private Label label3;
        private ComboBox cmbLibrary;
        private Label label2;
        private GroupBox groupBox4;
        private Button btnWiticism;
        private Button btnNewSet;
        private Button btnWeather;
        private Button btnTimeBreak;
        private Button btnRecap;
        private Button btnRefreshTime;
        private Button btnStart;
        private Button btnExit;
        private GroupBox grpBroadcastQueue;
        private Timer timer1;
        private OpenFileDialog openFileDialog1;
        private Button button7;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
        private Button btnLoadQueue;
        private Button btnLoadLibrary;
        private Button btnDedupe;
        private Button button9;
        private Button button8;
        private Button btnUpdateServer;
        private Button btnCustomBuild;

        private AudioPlayerService player = new AudioPlayerService();
        private SortableBindingList<PlaylistItem> broadcastQueue = new SortableBindingList<PlaylistItem>();
        private int currentQueueIndex = -1;
        private ListBox lstQueue;
        private Label lblDuration;
        private Label lblElapsed;


        private GroupBox groupBox3;
        private TrackBar trkProgress;
        private PictureBox picAlbumArt;

        private int dragStartIndex = -1;
        private Button btnForward10;
        private Button btnNextTrack;
        private Button btnPlay;
        private Button btnPrevTrack;
        private Button btnBack10;
        private Button btnStop;
        private Label lblAlbum;
        private GroupBox groupBox5;
        private Timer timer2;
        private Label lblConnections;
        private Label label27;
    }
}