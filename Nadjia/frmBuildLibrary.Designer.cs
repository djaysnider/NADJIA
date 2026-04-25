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
            this.SuspendLayout();
            // 
            // btnRebuild
            // 
            this.btnRebuild.Location = new System.Drawing.Point(332, 6);
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
            this.progressBuildLibrary.Location = new System.Drawing.Point(12, 77);
            this.progressBuildLibrary.Name = "progressBuildLibrary";
            this.progressBuildLibrary.Size = new System.Drawing.Size(388, 23);
            this.progressBuildLibrary.TabIndex = 1;
            // 
            // lblBuildStatus
            // 
            this.lblBuildStatus.ForeColor = System.Drawing.Color.Gold;
            this.lblBuildStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBuildStatus.Location = new System.Drawing.Point(12, 114);
            this.lblBuildStatus.Name = "lblBuildStatus";
            this.lblBuildStatus.Size = new System.Drawing.Size(388, 51);
            this.lblBuildStatus.TabIndex = 2;
            this.lblBuildStatus.Text = "...";
            // 
            // lblTracksLoaded
            // 
            this.lblTracksLoaded.AutoSize = true;
            this.lblTracksLoaded.ForeColor = System.Drawing.Color.Gold;
            this.lblTracksLoaded.Location = new System.Drawing.Point(12, 9);
            this.lblTracksLoaded.Name = "lblTracksLoaded";
            this.lblTracksLoaded.Size = new System.Drawing.Size(35, 13);
            this.lblTracksLoaded.TabIndex = 4;
            this.lblTracksLoaded.Text = "label1";
            // 
            // lblLibraryPath
            // 
            this.lblLibraryPath.AutoSize = true;
            this.lblLibraryPath.ForeColor = System.Drawing.Color.Gold;
            this.lblLibraryPath.Location = new System.Drawing.Point(12, 35);
            this.lblLibraryPath.Name = "lblLibraryPath";
            this.lblLibraryPath.Size = new System.Drawing.Size(35, 13);
            this.lblLibraryPath.TabIndex = 5;
            this.lblLibraryPath.Text = "label2";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(332, 35);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(68, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(332, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBuildLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(412, 200);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblLibraryPath);
            this.Controls.Add(this.lblTracksLoaded);
            this.Controls.Add(this.lblBuildStatus);
            this.Controls.Add(this.progressBuildLibrary);
            this.Controls.Add(this.btnRebuild);
            this.Name = "frmBuildLibrary";
            this.Text = "Music Library Maintenance";
            this.Load += new System.EventHandler(this.frmBuildLibrary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRebuild;
        private System.Windows.Forms.ProgressBar progressBuildLibrary;
        private System.Windows.Forms.Label lblBuildStatus;
        private System.Windows.Forms.Label lblTracksLoaded;
        private System.Windows.Forms.Label lblLibraryPath;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClose;
    }
}