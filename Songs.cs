using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22__Static_Attribute
{
    internal class Songs
    {
        public string title;
        public string artist;
        public int duration;

        public static int songsCount =0;
        public Songs(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            songsCount++;
        }
    }
}
