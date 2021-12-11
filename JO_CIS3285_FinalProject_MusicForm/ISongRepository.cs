using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    interface ISongRepository
    {
        void createItem(songItem song);
        List<songItem> ReadAll();
    }
}
