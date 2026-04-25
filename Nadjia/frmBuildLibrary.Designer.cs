using System;
using System.Drawing;
using System.Windows.Forms;


namespace Nadjia
{
    partial class frmBuildLibrary
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
            this.btnRebuild = new System.Windows.Forms.Button();
            this.progressBuildLibrary = new System.Windows.Forms.ProgressBar();
            this.lblBuildStatus = new System.Windows.Forms.Label();
            this.lblTracksLoaded = new System.Windows.Forms.Label();
            this.lblLibraryPath = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubheader = new System.Windows.Forms.Label();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.lblLibraryCaption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRebuild
            // 
            this.btnRebuild.Location = new System.Drawing.Point(458, 285);
            this.btnRebuild.Name = "btnRebuild";
            this.btnRebuild.Size = new System.Drawing.Size(68, 23);
            this.btnRebuild.TabIndex = 0;
            this.btnRebuild.Text = "Rebuild";
            this.btnRebuild.UseVisualStyleBackColor = true;
            this.btnRebuild.Click += new System.EventHandler(this.btnBuildLibrary_Click);
            // 
            // progressBuildLibrary
            // 
            this.progressBuildLibrary.ForeColor = System.Drawing.Color.Gold;
            this.progressBuildLibrary.Location = new System.Drawing.Point(20, 180);
            this.progressBuildLibrary.Name = "progressBuildLibrary";
            this.progressBuildLibrary.Size = new System.Drawing.Size(580, 18);
            this.progressBuildLibrary.TabIndex = 1;
            this.progressBuildLibrary.Click += new System.EventHandler(this.progressBuildLibrary_Click);
            // 
            // lblBuildStatus
            // 
            this.lblBuildStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.lblBuildStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBuildStatus.Location = new System.Drawing.Point(20, 205);
            this.lblBuildStatus.Name = "lblBuildStatus";
            this.lblBuildStatus.Size = new System.Drawing.Size(388, 51);
            this.lblBuildStatus.TabIndex = 2;
            this.lblBuildStatus.Text = "...";
            this.lblBuildStatus.Click += new System.EventHandler(this.lblBuildStatus_Click);
            // 
            // lblTracksLoaded
            // 
            this.lblTracksLoaded.AutoSize = true;
            this.lblTracksLoaded.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracksLoaded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.lblTracksLoaded.Location = new System.Drawing.Point(20, 135);
            this.lblTracksLoaded.Name = "lblTracksLoaded";
            this.lblTracksLoaded.Size = new System.Drawing.Size(0, 17);
            this.lblTracksLoaded.TabIndex = 4;
            this.lblTracksLoaded.Click += new System.EventHandler(this.lblTracksLoaded_Click);
            // 
            // lblLibraryPath
            // 
            this.lblLibraryPath.AutoSize = true;
            this.lblLibraryPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryPath.ForeColor = System.Drawing.Color.White;
            this.lblLibraryPath.Location = new System.Drawing.Point(206, 114);
            this.lblLibraryPath.Name = "lblLibraryPath";
            this.lblLibraryPath.Size = new System.Drawing.Size(0, 17);
            this.lblLibraryPath.TabIndex = 5;
            this.lblLibraryPath.Click += new System.EventHandler(this.lblLibraryPath_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(384, 285);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(68, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(532, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(18, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(196, 32);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "MUSIC LIBRARY";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // lblSubheader
            // 
            this.lblSubheader.AutoSize = true;
            this.lblSubheader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubheader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblSubheader.Location = new System.Drawing.Point(22, 50);
            this.lblSubheader.Name = "lblSubheader";
            this.lblSubheader.Size = new System.Drawing.Size(100, 23);
            this.lblSubheader.TabIndex = 0;
            this.lblSubheader.Text = "Rebuild Nadjia’s XML catalog from MP3 files";
            // 
            // lblProgressPercent
            // 
            this.lblProgressPercent.Location = new System.Drawing.Point(0, 0);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(100, 23);
            this.lblProgressPercent.TabIndex = 0;
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblCurrentFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblCurrentFile.Location = new System.Drawing.Point(20, 225);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentFile.TabIndex = 0;
            // 
            // lblLibraryCaption
            // 
            this.lblLibraryCaption.AutoSize = true;
            this.lblLibraryCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblLibraryCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblLibraryCaption.Location = new System.Drawing.Point(20, 90);
            this.lblLibraryCaption.Name = "lblLibraryCaption";
            this.lblLibraryCaption.Size = new System.Drawing.Size(100, 23);
            this.lblLibraryCaption.TabIndex = 0;
            this.lblLibraryCaption.Text = "CURRENT LIBRARY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rebuild Nadjia\'s XML catalog from MP3 tags.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(20, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current Track Library Location:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmBuildLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(620, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblLibraryPath);
            this.Controls.Add(this.lblTracksLoaded);
            this.Controls.Add(this.lblBuildStatus);
            this.Controls.Add(this.progressBuildLibrary);
            this.Controls.Add(this.btnRebuild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBuildLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Music Library Maintenance";
            this.Load += new System.EventHandler(this.frmBuildLibrary_Load);
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

        private System.Windows.Forms.Button btnRebuild;
        private System.Windows.Forms.ProgressBar progressBuildLibrary;
        private System.Windows.Forms.Label lblBuildStatus;
        private System.Windows.Forms.Label lblTracksLoaded;
        private System.Windows.Forms.Label lblLibraryPath;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubheader;
        private System.Windows.Forms.Label lblLibraryCaption;
        private System.Windows.Forms.Label lblProgressPercent;
        private System.Windows.Forms.Label lblCurrentFile;
        private Label label1;
        private Label label2;
    }




}