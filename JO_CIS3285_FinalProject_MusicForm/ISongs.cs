using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    interface ISongs
    {
        String artistName { get; }
        String songName { get; }
        String albumName { get; }
        String songGenre { get; }
        
    }
}
