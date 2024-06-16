using Karaoke.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Songs
{
    public class SongCollection
    {
        public Dictionary<string, List<TableRow>> Songs { get; set; }
    }
}
