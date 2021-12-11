
namespace JO_CIS3285_FinalProject_MusicForm
{
    partial class Form1
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
            this.addToSongsButton = new System.Windows.Forms.Button();
            this.addToPlaylistButton = new System.Windows.Forms.Button();
            this.playRandomSongButton = new System.Windows.Forms.Button();
            this.songsList = new System.Windows.Forms.ListBox();
            this.playlistList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.songTextBox = new System.Windows.Forms.TextBox();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addToSongsButton
            // 
            this.addToSongsButton.Location = new System.Drawing.Point(80, 182);
            this.addToSongsButton.Name = "addToSongsButton";
            this.addToSongsButton.Size = new System.Drawing.Size(128, 23);
            this.addToSongsButton.TabIndex = 0;
            this.addToSongsButton.Text = "Add To Songs";
            this.addToSongsButton.UseVisualStyleBackColor = true;
            this.addToSongsButton.Click += new System.EventHandler(this.addToSongsButton_Click);
            // 
            // addToPlaylistButton
            // 
            this.addToPlaylistButton.Location = new System.Drawing.Point(346, 182);
            this.addToPlaylistButton.Name = "addToPlaylistButton";
            this.addToPlaylistButton.Size = new System.Drawing.Size(128, 23);
            this.addToPlaylistButton.TabIndex = 1;
            this.addToPlaylistButton.Text = "Add To Playlist";
            this.addToPlaylistButton.UseVisualStyleBackColor = true;
            this.addToPlaylistButton.Click += new System.EventHandler(this.addToPlaylistButton_Click);
            // 
            // playRandomSongButton
            // 
            this.playRandomSongButton.Location = new System.Drawing.Point(603, 182);
            this.playRandomSongButton.Name = "playRandomSongButton";
            this.playRandomSongButton.Size = new System.Drawing.Size(128, 23);
            this.playRandomSongButton.TabIndex = 2;
            this.playRandomSongButton.Text = "Play Random";
            this.playRandomSongButton.UseVisualStyleBackColor = true;
            this.playRandomSongButton.Click += new System.EventHandler(this.playRandomSongButton_Click);
            // 
            // songsList
            // 
            this.songsList.FormattingEnabled = true;
            this.songsList.ItemHeight = 16;
            this.songsList.Location = new System.Drawing.Point(100, 226);
            this.songsList.Name = "songsList";
            this.songsList.Size = new System.Drawing.Size(273, 212);
            this.songsList.TabIndex = 10;
            this.songsList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // playlistList
            // 
            this.playlistList.FormattingEnabled = true;
            this.playlistList.ItemHeight = 16;
            this.playlistList.Location = new System.Drawing.Point(495, 226);
            this.playlistList.Name = "playlistList";
            this.playlistList.Size = new System.Drawing.Size(293, 212);
            this.playlistList.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Songs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Playlist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Artist:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Song:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Album:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Genre:";
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(100, 25);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(670, 22);
            this.artistTextBox.TabIndex = 18;
            // 
            // songTextBox
            // 
            this.songTextBox.Location = new System.Drawing.Point(100, 60);
            this.songTextBox.Name = "songTextBox";
            this.songTextBox.Size = new System.Drawing.Size(670, 22);
            this.songTextBox.TabIndex = 19;
            // 
            // albumTextBox
            // 
            this.albumTextBox.Location = new System.Drawing.Point(100, 95);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(670, 22);
            this.albumTextBox.TabIndex = 20;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(100, 132);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(670, 22);
            this.genreTextBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(this.songTextBox);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playlistList);
            this.Controls.Add(this.songsList);
            this.Controls.Add(this.playRandomSongButton);
            this.Controls.Add(this.addToPlaylistButton);
            this.Controls.Add(this.addToSongsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addToSongsButton;
        private System.Windows.Forms.Button addToPlaylistButton;
        private System.Windows.Forms.Button playRandomSongButton;
        private System.Windows.Forms.ListBox songsList;
        private System.Windows.Forms.ListBox playlistList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.TextBox songTextBox;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
    }
}

