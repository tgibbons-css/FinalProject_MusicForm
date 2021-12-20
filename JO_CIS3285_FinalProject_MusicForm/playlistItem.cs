using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    class playlistItem : ISongs
    {
        String artistName;
        String songName;
        String albumName;
        String songGenre;
        private List<songItem> songItems;

        public playlistItem(string artist, string song, string album, string genre)
        {
            this.artistName = artist;
            this.songName = song;
            this.albumName = album;
            this.songGenre = genre;
        }

        public playlistItem(List<songItem> songItems)
        {
            this.songItems = songItems;
        }

        public string Name { get => artistName; set => artistName = value; }
        public string Song { get => songName; set => songName = value; }
        public string Album { get => albumName; set => albumName = value; }
        public string Genre { get => songGenre; set => songGenre = value; }

        public string Description { get => getDescription(); }

        string ISongs.artistName => this.artistName;

        string ISongs.songName => this.songName;

        string ISongs.albumName => this.albumName;

        string ISongs.songGenre => this.songGenre;

        public string toString()
        {
            return getDescription();
        }

        public string getDescription()
        {
            string description = "Artist name:" + Name + " Song name: " + Song + " Album:" + Album + " Genre:" + Genre;
            return description;
        }
    }

}
