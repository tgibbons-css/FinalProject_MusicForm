using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JO_CIS3285_FinalProject_MusicForm
{
    public partial class Form1 : Form
    {
        songListController songListCtrl;
        public Form1()
        {
            InitializeComponent();
            songListCtrl = new songListController();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addToSongsButton_Click(object sender, EventArgs e)
        {
            ISong newSong = songListCtrl.CreateSong(artistTextBox.Text.ToString(), songTextBox.Text.ToString(), albumTextBox.Text.ToString(), genreTextBox.Text.ToString());
            songsList.Items.Add(newSong.Description);
        }

        private void addToPlaylistButton_Click(object sender, EventArgs e)
        {

        }

        private void playRandomSongButton_Click(object sender, EventArgs e)
        {

        }
    }
}
