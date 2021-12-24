﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    class songListController
    {
        private songList songs;
        private songRepository songRepository;

        public songListController()
        {

            songRepository = new songRepository();
            songs = new songList(songRepository.ReadAll());
        }

        //public void CreateSong(string name, string song, string album, string genre)
        public ISong CreateSong(string name, string song, string album, string genre)
        {
            songItem newSong = new songItem(name, song, album, genre);
            this.songs.addItem(newSong);     // Tom fix
            //song.addItem(newSong);    

            songRepository.createItem(newSong);
            return newSong;
        }
    }
}

