using Karaoke.Abstractions;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Songs
{
    public static class SongListCreator
    {
        // A method that creates the List of songs based on all classes that inherit from the SongBase class
        public static List<ISong> CreateSongsList()
        {
            var songsList = new List<ISong>();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            var songTypes = assemblies.SelectMany(assembly => assembly.GetTypes())
                                      .Where(s => typeof(ISong).IsAssignableFrom(s) && !s.IsInterface && !s.IsAbstract)
                                      .ToList();

            foreach (var type in songTypes)
            {
                if (Activator.CreateInstance(type) is ISong song)
                {
                    songsList.Add(song);
                }
            }

            return songsList;
        }
    }
}
