using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Abstractions
{
    public interface ISong
    {
        int Id { get; }
        string Title { get; }
        string Author { get; }
        string SongName { get; }
        void SongAuthorTitle();
    }
}
