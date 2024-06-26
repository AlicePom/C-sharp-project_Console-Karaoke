using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karaoke.Abstractions;
using System.Text.Json;

namespace Karaoke.Songs
{
    public class JsonCatalogueProvider : ISongCatalogueProvider
    {
        public Dictionary<string, List<object>> DeserializeSongs()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "songs.json");
            string jsonString = File.ReadAllText(filePath);
            var songCollection = JsonSerializer.Deserialize<SongCollection>(jsonString);

            return songCollection.Songs.ToDictionary(
                kvp => kvp.Key,
                kvp => kvp.Value.Cast<object>().ToList()
            );
        }
    }
}
