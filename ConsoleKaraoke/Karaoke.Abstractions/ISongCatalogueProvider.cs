using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Abstractions
{
    public interface ISongCatalogueProvider
    {
        Dictionary<string, List<object>> DeserializeSongs();
    }
}
