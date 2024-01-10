using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22__Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs song = new Songs("Holiday","vision",4);
            Songs song2 = new Songs("Broken", "vision", 4);

            Console.WriteLine(Songs.songsCount);
        }
    }
}
