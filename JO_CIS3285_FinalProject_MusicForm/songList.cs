using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    class songList
    {
        List<songItem> songs;

        public songList()
        {
            songs = new List<songItem>();
        }

        public songList(List<songItem> newSongList)
        {
            songs = newSongList;
        }

        public void addItem(songItem newSongItem)
        {
            songs.Add(newSongItem);
        }
    }
}
