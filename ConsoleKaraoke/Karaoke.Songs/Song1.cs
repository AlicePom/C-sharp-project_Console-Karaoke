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
    public class Song1 : SongBase
    {
        public override int Id => 1;
        public override string Title => "Hýkal";
        public override string Author => "Zrní";
        public override string SongName => "song1";
    }
}