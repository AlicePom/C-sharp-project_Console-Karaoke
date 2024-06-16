using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Songs
{
    public interface ISong
    {
        int Id { get; }
        string Title { get; }
        string Author { get; }
        string SongName { get; }

        void SongAuthorTitle()
        {
            Console.WriteLine(new string('-', 100));
            Console.WriteLine($"Playing the song {Title} by {Author}");
        }
    }
}

