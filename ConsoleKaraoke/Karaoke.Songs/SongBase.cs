using Karaoke.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karaoke.Abstractions;

namespace Karaoke.Songs
{
    public abstract class SongBase : ISong
    {
        public abstract int Id { get; }
        public abstract string Title { get; }
        public abstract string Author { get; }
        public abstract string SongName { get; }

        public void SongAuthorTitle()
        {
            Console.WriteLine(new string('-', 100));
            Console.WriteLine($"Playing the song {Title} by {Author}");
        }
    }
}
