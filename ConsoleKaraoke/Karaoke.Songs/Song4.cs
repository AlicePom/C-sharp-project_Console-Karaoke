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
    public class Song4 : SongBase
    {
        public override int Id => 4;
        public override string Title => "L' Amour Toujours";
        public override string Author => "Gigi D'Agostino";
        public override string SongName => "song4";
    }
}
