using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Karaoke.Songs
{
    internal class Song2 : ISong
    {
        public int Id => 2;
        public string Title => "Atom Angel";
        public string Author => "Waltari";
        public string SongName => "song2";
    }
}
