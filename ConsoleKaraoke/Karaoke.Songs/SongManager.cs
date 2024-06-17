using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.Songs
{
    public class SongManager
    {
        private List<ISong> songs;

        public SongManager()
        {
            songs = new List<ISong>
            {
                new Song1(),
                new Song2()
            };
        }

        // A method that displays the list of songs to the console for user selection
        public void DisplaySongs()
        {
            Console.WriteLine("This is a Karaoke Console Application that will play a song from the following list:");
            Console.WriteLine();

            foreach (var song in songs)
            {
                Console.WriteLine($"{song.Id} - {song.Title} by {song.Author}");
            }

            Console.WriteLine();
        }

        // A method that will prompt the user to choose the song by the number (int) input referred to as "inputId"
        // The input (InputId), if entered within the required range, will be attributed to the Id of a song available in the "songs" List
        public string GetSongById()
        {
            ISong selectedSong = null;
            string selectedSongName = null;

            do
            {
                // Prompting the user to select a song by entering the song ID
                Console.Write("Select a song to play - enter the corresponding number (1 to 2): ");
                
                bool parsedInput = int.TryParse(Console.ReadLine(), out int inputId);
                
                if (parsedInput) // if the input was entered correctly
                {
                    selectedSong = songs.FirstOrDefault(song => song.Id == inputId);

                    if (selectedSong != null) // if the input was within the required range, the song is chosen
                    {
                        selectedSongName = selectedSong.SongName;
                    }
         
            } while (selectedSong == null);

            Console.WriteLine();

            // Printing the selected Title and the Author on the console
            selectedSong.SongAuthorTitle();
            Console.WriteLine();

            return selectedSongName;
        }
    }
}
