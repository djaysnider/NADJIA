using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nadjia
{
    partial class frmSetConfig
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetConfig));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtBumperPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdvertPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDropPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSweeperPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDBPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoundboardPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLightningPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLibraryPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.bumperFolderSelector = new System.Windows.Forms.Button();
            this.advertFolderSelector = new System.Windows.Forms.Button();
            this.dropsFolderSelector = new System.Windows.Forms.Button();
            this.sweeperFolderSelector = new System.Windows.Forms.Button();
            this.dbFolderSelector = new System.Windows.Forms.Button();
            this.soundboardFolderSelector = new System.Windows.Forms.Button();
            this.lrFolderSelector = new System.Windows.Forms.Button();
            this.libraryFolderSelector = new System.Windows.Forms.Button();
            this.queueFolderSelector = new System.Windows.Forms.Button();
            this.txtQueuePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPlaylistPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // txtBumperPath
            // 
            this.txtBumperPath.BackColor = System.Drawing.Color.Black;
            this.txtBumperPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBumperPath.ForeColor = System.Drawing.Color.Silver;
            this.txtBumperPath.Location = new System.Drawing.Point(143, 334);
            this.txtBumperPath.Name = "txtBumperPath";
            this.txtBumperPath.Size = new System.Drawing.Size(276, 25);
            this.txtBumperPath.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(14, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = "Bumpers Directory";
            // 
            // txtAdvertPath
            // 
            this.txtAdvertPath.BackColor = System.Drawing.Color.Black;
            this.txtAdvertPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAdvertPath.ForeColor = System.Drawing.Color.Silver;
            this.txtAdvertPath.Location = new System.Drawing.Point(143, 299);
            this.txtAdvertPath.Name = "txtAdvertPath";
            this.txtAdvertPath.Size = new System.Drawing.Size(276, 25);
            this.txtAdvertPath.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label6.Location = new System.Drawing.Point(14, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 63;
            this.label6.Text = "Advert Directory";
            // 
            // txtDropPath
            // 
            this.txtDropPath.BackColor = System.Drawing.Color.Black;
            this.txtDropPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDropPath.ForeColor = System.Drawing.Color.Silver;
            this.txtDropPath.Location = new System.Drawing.Point(143, 264);
            this.txtDropPath.Name = "txtDropPath";
            this.txtDropPath.Size = new System.Drawing.Size(276, 25);
            this.txtDropPath.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(14, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 62;
            this.label7.Text = "Drops Directory";
            // 
            // txtSweeperPath
            // 
            this.txtSweeperPath.BackColor = System.Drawing.Color.Black;
            this.txtSweeperPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSweeperPath.ForeColor = System.Drawing.Color.Silver;
            this.txtSweeperPath.Location = new System.Drawing.Point(143, 229);
            this.txtSweeperPath.Name = "txtSweeperPath";
            this.txtSweeperPath.Size = new System.Drawing.Size(276, 25);
            this.txtSweeperPath.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(14, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 19);
            this.label8.TabIndex = 61;
            this.label8.Text = "Sweeper Directory";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(384, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 449);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtDBPath
            // 
            this.txtDBPath.BackColor = System.Drawing.Color.Black;
            this.txtDBPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDBPath.ForeColor = System.Drawing.Color.Silver;
            this.txtDBPath.Location = new System.Drawing.Point(143, 98);
            this.txtDBPath.Name = "txtDBPath";
            this.txtDBPath.Size = new System.Drawing.Size(276, 25);
            this.txtDBPath.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(14, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "Master Database";
            // 
            // txtSoundboardPath
            // 
            this.txtSoundboardPath.BackColor = System.Drawing.Color.Black;
            this.txtSoundboardPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoundboardPath.ForeColor = System.Drawing.Color.Silver;
            this.txtSoundboardPath.Location = new System.Drawing.Point(143, 404);
            this.txtSoundboardPath.Name = "txtSoundboardPath";
            this.txtSoundboardPath.Size = new System.Drawing.Size(276, 25);
            this.txtSoundboardPath.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(14, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Soundboard Files";
            // 
            // txtLightningPath
            // 
            this.txtLightningPath.BackColor = System.Drawing.Color.Black;
            this.txtLightningPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLightningPath.ForeColor = System.Drawing.Color.Silver;
            this.txtLightningPath.Location = new System.Drawing.Point(143, 369);
            this.txtLightningPath.Name = "txtLightningPath";
            this.txtLightningPath.Size = new System.Drawing.Size(276, 25);
            this.txtLightningPath.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(14, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "LR Questions";
            // 
            // txtLibraryPath
            // 
            this.txtLibraryPath.BackColor = System.Drawing.Color.Black;
            this.txtLibraryPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLibraryPath.ForeColor = System.Drawing.Color.Silver;
            this.txtLibraryPath.Location = new System.Drawing.Point(143, 133);
            this.txtLibraryPath.Name = "txtLibraryPath";
            this.txtLibraryPath.Size = new System.Drawing.Size(276, 25);
            this.txtLibraryPath.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(14, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Track Library Root";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(14, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(367, 21);
            this.label9.TabIndex = 66;
            this.label9.Text = "Confirgure location of required files and directories.";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(328, 32);
            this.lblHeader.TabIndex = 65;
            this.lblHeader.Text = "CONFIGURATION SETTINGS";
            // 
            // bumperFolderSelector
            // 
            this.bumperFolderSelector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bumperFolderSelector.BackgroundImage")));
            this.bumperFolderSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bumperFolderSelector.Location = new System.Drawing.Point(425, 334);
            this.bumperFolderSelector.Name = "bumperFolderSelector";
            this.bumperFolderSelector.Size = new System.Drawing.Size(26, 22);
            this.bumperFolderSelector.TabIndex = 50;
            this.bumperFolderSelector.UseVisualStyleBackColor = true;
            this.bumperFolderSelector.Click += new System.EventHandler(this.bumperFolderSelector_Click_1);
            // 
            // advertFolderSelector
            // 
            this.advertFolderSelector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("advertFolderSelector.BackgroundImage")));
            this.advertFolderSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.advertFolderSelector.Location = new System.Drawing.Point(425, 299);
            this.advertFolderSelector.Name = "advertFolderSelector";
            this.advertFolderSelector.Size = new System.Drawing.Size(26, 22);
            this.advertFolderSelector.TabIndex = 48;
            this.advertFolderSelector.UseVisualStyleBackColor = true;
            this.advertFolderSelector.Click += new System.EventHandler(this.advertFolderSelector_Click_1);
            // 
            // dropsFolderSelector
            // 
            this.dropsFolderSelector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dropsFolderSelector.BackgroundImage")));
            this.dropsFolderSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dropsFolderSelector.Location = new System.Drawing.Point(425, 264);
            this.dropsFolderSelector.Name = "dropsFolderSelector";
            this.dropsFolderSelector.Size = new System.Drawing.Size(26, 22);
            this.dropsFolderSelector.TabIndex = 46;
            this.dropsFolderSelector.UseVisualStyleBackColor = true;
            this.dropsFolderSelector.Click += new System.EventHandler(this.dropsFolderSelector_Click_1);
            // 
            // sweeperFolderSelector
            // 
            this.sweeperFolderSelector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sweeperFolderSelector.BackgroundImage")));
            this.sweeperFolderSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sweeperFolderSelector.Location = new System.Drawing.Point(425, 229);
            this.sweeperFolderSelector.Name = "sweeperFolderSelector";
            this.sweeperFolderSelector.Size = new System.Drawing.Size(26, 22);
            this.sweeperFolderSelector.TabIndex = 44;
            this.sweeperFolderSelector.UseVisualStyleBackColor = true;
            this.sweeperFolderSelector.Click += new System.EventHandler(this.sweeperFolderSelector_Click_1);
            // 
            // dbFolderSelector
            // 
            this.dbFolderSelector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dbFolderSelector.BackgroundImage")));
            this.dbFolderSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dbFolderSelector.Location = new System.Drawing.Point(425, 98);
            this.dbFolderSelector.Name = "dbFolderSelector";
            this.dbFolderSelector.Size = new System.Drawing.Size(26, 22);
            this.dbFolderSelector.TabIndex = 40;
            this.dbFolderSelector.UseVisualStyleBackColor = true;
            this.dbFolderSelector.Click += new System.EventHandler(this.dbFolderSelector_Click_1);
            // 
            // soundboardFolderSelector
            // 
            this.soundboardFolderSelector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundboardFolderSelector.BackgroundImage")));
            this.soundboardFolderSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soundboardFolderSelector.Location = new System.Drawing.Point(425, 404);
            this.soundboardFolderSelector.Name = "soundboardFolderSelector";
            this.soundboardFolderSelector.Size = new System.Drawing.Size(26, 22);
            this.soundboardFolderSelector.TabIndex = 55;
            this.soundboardFolderSelector.UseVisualStyleBackColor = true;
            this.soundboardFolderSelector.Click += new System.EventHandler(this.soundboardFolderSelector_Click_1);
            // 
            // lrFolderSelector
            // 
            this.lrFolderSelector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lrFolderSelector.BackgroundImage")));
            this.lrFolderSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lrFolderSelector.Location = new System.Drawing.Point(425, 369);
            this.lrFolderSelector.Name = "lrFolderSelector";
            this.lrFolderSelector.Size = new System.Drawing.Size(26, 22);
            this.lrFolderSelector.TabIndex = 52;
            this.lrFolderSelector.UseVisualStyleBackColor = true;
            this.lrFolderSelector.Click += new System.EventHandler(this.lrFolderSelector_Click_1);
            // 
            // libraryFolderSelector
            // 
            this.libraryFolderSelector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("libraryFolderSelector.BackgroundImage")));
            this.libraryFolderSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.libraryFolderSelector.Location = new System.Drawing.Point(425, 133);
            this.libraryFolderSelector.Name = "libraryFolderSelector";
            this.libraryFolderSelector.Size = new System.Drawing.Size(26, 22);
            this.libraryFolderSelector.TabIndex = 42;
            this.libraryFolderSelector.UseVisualStyleBackColor = true;
            this.libraryFolderSelector.Click += new System.EventHandler(this.libraryFolderSelector_Click_1);
            // 
            // queueFolderSelector
            // 
            this.queueFolderSelector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("queueFolderSelector.BackgroundImage")));
            this.queueFolderSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.queueFolderSelector.Location = new System.Drawing.Point(425, 196);
            this.queueFolderSelector.Name = "queueFolderSelector";
            this.queueFolderSelector.Size = new System.Drawing.Size(26, 22);
            this.queueFolderSelector.TabIndex = 68;
            this.queueFolderSelector.UseVisualStyleBackColor = true;
            this.queueFolderSelector.Click += new System.EventHandler(this.queueFolderSelector_Click);
            // 
            // txtQueuePath
            // 
            this.txtQueuePath.BackColor = System.Drawing.Color.Black;
            this.txtQueuePath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQueuePath.ForeColor = System.Drawing.Color.Silver;
            this.txtQueuePath.Location = new System.Drawing.Point(143, 196);
            this.txtQueuePath.Name = "txtQueuePath";
            this.txtQueuePath.Size = new System.Drawing.Size(276, 25);
            this.txtQueuePath.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label10.Location = new System.Drawing.Point(14, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 69;
            this.label10.Text = "Queue Files";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(425, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 22);
            this.button1.TabIndex = 71;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlaylistPath
            // 
            this.txtPlaylistPath.BackColor = System.Drawing.Color.Black;
            this.txtPlaylistPath.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlaylistPath.ForeColor = System.Drawing.Color.Silver;
            this.txtPlaylistPath.Location = new System.Drawing.Point(143, 165);
            this.txtPlaylistPath.Name = "txtPlaylistPath";
            this.txtPlaylistPath.Size = new System.Drawing.Size(276, 25);
            this.txtPlaylistPath.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label11.Location = new System.Drawing.Point(14, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 72;
            this.label11.Text = "Playlist Files";
            // 
            // frmSetConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(480, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPlaylistPath);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.queueFolderSelector);
            this.Controls.Add(this.txtQueuePath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.bumperFolderSelector);
            this.Controls.Add(this.txtBumperPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.advertFolderSelector);
            this.Controls.Add(this.txtAdvertPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dropsFolderSelector);
            this.Controls.Add(this.txtDropPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sweeperFolderSelector);
            this.Controls.Add(this.txtSweeperPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dbFolderSelector);
            this.Controls.Add(this.txtDBPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soundboardFolderSelector);
            this.Controls.Add(this.txtSoundboardPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lrFolderSelector);
            this.Controls.Add(this.txtLightningPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.libraryFolderSelector);
            this.Controls.Add(this.txtLibraryPath);
            this.Controls.Add(this.label1);
            this.Name = "frmSetConfig";
            this.Text = "N.A.D.J.I.A. Configuration Settings";
            this.Load += new System.EventHandler(this.frmSetConfig_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

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


        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button bumperFolderSelector;
        private System.Windows.Forms.TextBox txtBumperPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button advertFolderSelector;
        private System.Windows.Forms.TextBox txtAdvertPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dropsFolderSelector;
        private System.Windows.Forms.TextBox txtDropPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sweeperFolderSelector;
        private System.Windows.Forms.TextBox txtSweeperPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button dbFolderSelector;
        private System.Windows.Forms.TextBox txtDBPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button soundboardFolderSelector;
        private System.Windows.Forms.TextBox txtSoundboardPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lrFolderSelector;
        private System.Windows.Forms.TextBox txtLightningPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button libraryFolderSelector;
        private System.Windows.Forms.TextBox txtLibraryPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHeader;
        private Button queueFolderSelector;
        private TextBox txtQueuePath;
        private Label label10;
        private Button button1;
        private TextBox txtPlaylistPath;
        private Label label11;
    }
}