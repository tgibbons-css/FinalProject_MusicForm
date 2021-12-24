using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    class playlistListController
    {
        private playlistList playlist;
        private songRepository songRepository;

        public playlistListController()
        {
            
            songRepository = new songRepository();
            playlist = new playlistList(songRepository.ReadAll());
        }

        public void CreatePlaylist(string name, string song, string album, string genre)
        {
            playlistItem newPlaylist = new playlistItem(name, song, album, genre);
            playlist.addItem(newPlaylist);
            //songRepository.createItem(newPlaylist);   // Tom
        }
    }
}
