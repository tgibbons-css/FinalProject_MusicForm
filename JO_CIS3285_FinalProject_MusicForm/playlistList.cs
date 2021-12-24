using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    class playlistList
    {
        List<playlistItem> playlist;

        public playlistList(List<ISong> songItems)
        {
            playlist = new List<playlistItem>();
        }

        public playlistList(List<playlistItem> newplaySongList)
        {
            playlist = newplaySongList;
        }

        public void addItem(playlistItem playlistItem)
        {
            playlist.Add(playlistItem);
        }
    }
}
