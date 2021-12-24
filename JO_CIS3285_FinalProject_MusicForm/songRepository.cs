using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    class songRepository : ISongRepository
    {
        List<ISong> songs;   // Tom added

        public songRepository()
        {
            songs = new List<ISong>();
        }

        public void createItem(ISong song)
        {
            songs.Add(song);
        }

        /*
         public void createItem(playlistItem playlist)
        {

        */

        public List<ISong> ReadAll()
        {
            return songs;
        }
    }
}
