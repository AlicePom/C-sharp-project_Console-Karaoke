using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Abstractions
{
    public interface ISongPlayer
    {
        void PlaySong(string songName, Dictionary<string, List<object>> songs);
    }
}
