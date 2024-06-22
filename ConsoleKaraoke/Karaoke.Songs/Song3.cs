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
    internal class Song3 : SongBase
    {
        public override int Id => 3;
        public override string Title => "Bloody Mary";
        public override string Author => "Lady Gaga";
        public override string SongName => "song3";
    }
}
