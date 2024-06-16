using Karaoke.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Karaoke.Songs
{
    // Deserialization of the Json file 
    public class JsonDeserializer
    {
        public Dictionary<string, List<TableRow>> DeserializeSongs(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            var songCollection = JsonSerializer.Deserialize<SongCollection>(jsonString);
            return songCollection.Songs;
        }
    }
}
