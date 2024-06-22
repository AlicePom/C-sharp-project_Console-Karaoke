using Karaoke.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Songs
{
    public static class SongListCreator
    {
        // A method that creates the List of songs based on all classes that inherit from the SongBase class
        public static List<SongBase> CreateSongsList()
        {
            var songsList = new List<SongBase>();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies(); // Since the base class SongBase is a in different assembly than Song1 and Song2

            var songTypes = assemblies.SelectMany(assembly => assembly.GetTypes())
                                      .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(SongBase)))
                                      .ToList();

            foreach (var type in songTypes)
            {
                if (Activator.CreateInstance(type) is SongBase song)
                {
                    songsList.Add(song);
                }
            }

            return songsList;
        }
    }
}
