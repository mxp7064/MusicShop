namespace MusicShop
{
    partial class PlayUserProductsForm
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
            this.productsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.songsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chooseDownloadFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.musicPlayerLabel = new System.Windows.Forms.Label();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.nextSongButton = new System.Windows.Forms.Button();
            this.previousSongButton = new System.Windows.Forms.Button();
            this.songPlayingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productsPanel
            // 
            this.productsPanel.AutoScroll = true;
            this.productsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productsPanel.Location = new System.Drawing.Point(30, 318);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(550, 142);
            this.productsPanel.TabIndex = 2;
            // 
            // songsPanel
            // 
            this.songsPanel.AutoScroll = true;
            this.songsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.songsPanel.Location = new System.Drawing.Point(30, 118);
            this.songsPanel.Name = "songsPanel";
            this.songsPanel.Size = new System.Drawing.Size(550, 142);
            this.songsPanel.TabIndex = 3;
            // 
            // chooseDownloadFolder
            // 
            this.chooseDownloadFolder.Location = new System.Drawing.Point(30, 31);
            this.chooseDownloadFolder.Name = "chooseDownloadFolder";
            this.chooseDownloadFolder.Size = new System.Drawing.Size(170, 31);
            this.chooseDownloadFolder.TabIndex = 4;
            this.chooseDownloadFolder.Text = "Choose Download Folder";
            this.chooseDownloadFolder.UseVisualStyleBackColor = true;
            this.chooseDownloadFolder.Click += new System.EventHandler(this.chooseDownloadFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your songs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your other products";
            // 
            // musicPlayerLabel
            // 
            this.musicPlayerLabel.AutoSize = true;
            this.musicPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicPlayerLabel.Location = new System.Drawing.Point(405, 16);
            this.musicPlayerLabel.Name = "musicPlayerLabel";
            this.musicPlayerLabel.Size = new System.Drawing.Size(97, 16);
            this.musicPlayerLabel.TabIndex = 7;
            this.musicPlayerLabel.Text = "Music Player";
            // 
            // playPauseButton
            // 
            this.playPauseButton.Location = new System.Drawing.Point(415, 62);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(75, 23);
            this.playPauseButton.TabIndex = 8;
            this.playPauseButton.Text = "Play";
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // nextSongButton
            // 
            this.nextSongButton.Location = new System.Drawing.Point(497, 62);
            this.nextSongButton.Name = "nextSongButton";
            this.nextSongButton.Size = new System.Drawing.Size(75, 23);
            this.nextSongButton.TabIndex = 9;
            this.nextSongButton.Text = "Next";
            this.nextSongButton.UseVisualStyleBackColor = true;
            this.nextSongButton.Click += new System.EventHandler(this.nextSongButton_Click);
            // 
            // previousSongButton
            // 
            this.previousSongButton.Location = new System.Drawing.Point(334, 62);
            this.previousSongButton.Name = "previousSongButton";
            this.previousSongButton.Size = new System.Drawing.Size(75, 23);
            this.previousSongButton.TabIndex = 10;
            this.previousSongButton.Text = "Previous";
            this.previousSongButton.UseVisualStyleBackColor = true;
            this.previousSongButton.Click += new System.EventHandler(this.previousSongButton_Click);
            // 
            // songPlayingLabel
            // 
            this.songPlayingLabel.AutoSize = true;
            this.songPlayingLabel.Location = new System.Drawing.Point(433, 40);
            this.songPlayingLabel.Name = "songPlayingLabel";
            this.songPlayingLabel.Size = new System.Drawing.Size(35, 13);
            this.songPlayingLabel.TabIndex = 11;
            this.songPlayingLabel.Text = "label3";
            // 
            // PlayUserProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 493);
            this.Controls.Add(this.songPlayingLabel);
            this.Controls.Add(this.previousSongButton);
            this.Controls.Add(this.nextSongButton);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.musicPlayerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseDownloadFolder);
            this.Controls.Add(this.songsPanel);
            this.Controls.Add(this.productsPanel);
            this.Name = "PlayUserProductsForm";
            this.Text = "PlayUserProductsForm";
            this.Load += new System.EventHandler(this.PlayUserProductsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel productsPanel;
        private System.Windows.Forms.FlowLayoutPanel songsPanel;
        private System.Windows.Forms.Button chooseDownloadFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label musicPlayerLabel;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button nextSongButton;
        private System.Windows.Forms.Button previousSongButton;
        private System.Windows.Forms.Label songPlayingLabel;
    }
}