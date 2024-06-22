using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Karaoke.Abstractions;

namespace Karaoke.Songs
{
    public class Song2 : SongBase
    {
        public override int Id => 2;
        public override string Title => "Atom Angel";
        public override string Author => "Waltari";
        public override string SongName => "song2";
    }
}
