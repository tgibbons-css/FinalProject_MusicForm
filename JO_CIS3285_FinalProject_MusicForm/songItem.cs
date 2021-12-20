using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    class songItem : ISongs
    {

        String artistName;
        String songName;
        String albumName;
        String songGenre;
        String description;

        public songItem(string artist, string song, string album, string genre)
        {
            this.artistName = artist;
            this.songName = song;
            this.albumName = album;
            this.songGenre = genre;
        }

        public string Name { get => artistName; set => artistName = value; }
        public string Song { get => songName; set => songName = value; }
        public string Album { get => albumName; set => albumName = value; }
        public string Genre { get => songGenre; set => songGenre = value; }
        public string Description { get => description; set => description = value; }

        string ISongs.artistName => this.artistName;

        string ISongs.songName => this.songName;

        string ISongs.albumName => this.albumName;

        string ISongs.songGenre => this.songGenre;

        string ISongs.Description => this.description;
    }
}
