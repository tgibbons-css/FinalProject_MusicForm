using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    class songItem : ISong
    {

        /*
        String artistName;
        String songName;
        String albumName;
        String songGenre;
        String description;
        private List<playlistItem> playlistItems;


        public songItem(string artist, string song, string album, string genre)
        {
            this.artistName = artist;
            this.songName = song;
            this.albumName = album;
            this.songGenre = genre;
        }

        public songItem(List<playlistItem> playlistItems)
        {
            //this.playlistItems = playlistItem;
            this.playlistItems = playlistItems;   // Tom fix

        }
        */

        public songItem(string artist, string song, string album, string genre)
        {
            this.artistName = artist;
            this.songName = song;
            this.albumName = album;
            this.songGenre = genre;
        }

        public string artistName { get; private set; }
        public string songName { get; private set; }
        public string albumName { get; private set; }
        public string songGenre { get; private set; }
        public string Description { get => getDescription(); }
        /*
        string ISong.artistName => this.artistName;

        string ISong.songName => this.songName;

        string ISong.albumName => this.albumName;

        string ISong.songGenre => this.songGenre;

        string ISong.Description => this.description;
        */

        public string toString()
        {
            return getDescription();
        }

        public string getDescription()
        {
            string description = "Artist name:" + artistName + " Song name: " + songName + " Album:" + albumName + " Genre:" + songGenre;
            return description;
        }
    }
}
