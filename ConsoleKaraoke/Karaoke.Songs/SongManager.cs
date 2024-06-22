using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karaoke.Abstractions;

namespace Karaoke.Songs
{
    public class SongManager
    {
        public List<SongBase> SongsList;

        public SongManager()
        {
            SongsList = SongListCreator.CreateSongsList();
        }

        // A method that displays the list of songs to the console for user selection
        public void DisplaySongs()
        {
            Console.WriteLine("This is a Karaoke Console Application that will play a song from the following list:");
            Console.WriteLine();

            foreach (var song in SongsList)
            {
                Console.WriteLine($"{song.Id} - {song.Title} by {song.Author}");
            }

            Console.WriteLine();
        }
    }
}
