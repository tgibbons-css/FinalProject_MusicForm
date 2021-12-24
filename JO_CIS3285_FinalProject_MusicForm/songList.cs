using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    class songList
    {
        List<ISong> songs;

        public songList(List<ISong> song)
        {
            songs = new List<ISong>();
        }

        public void addItem(songItem newSongItem)
        {
            songs.Add(newSongItem);
        }
    }
}
