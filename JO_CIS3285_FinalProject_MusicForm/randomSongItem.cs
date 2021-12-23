using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO_CIS3285_FinalProject_MusicForm
{
    class randomSongItem
    {

        private readonly Random random = new Random();

        public int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

    }
}
