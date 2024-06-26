using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Abstractions
{
    public interface ISongManager
    {
        void DisplaySongs();
        List<ISong> GetSongs();
    }
}
