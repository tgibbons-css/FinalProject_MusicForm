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

        public songList(List<songItem> song)
        {
            songs = new List<songItem>();
        }

        public void addItem(songItem newSongItem)
        {
            songs.Add(newSongItem);
        }
    }
}
