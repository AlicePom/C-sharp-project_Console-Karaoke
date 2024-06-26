using Karaoke.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karaoke.ConsoleClient
{
    internal class UserSelection
    {
        public List<ISong> songsList;

        public UserSelection(List<ISong> songsList)
        {
            this.songsList = songsList;       
        }

        // A method that prompts the user to choose the song by the number (int) input referred to as "inputId"
        // The input (InputId), if entered within the required range, will be attributed to the Id of a song available in the "songs" List
        public string GetSongById()
        {
            ISong selectedSong = null;
            string selectedSongName = null;

            do
            {
                // Prompting the user to select a song by entering the song ID
                Console.Write($"Select a song to play - enter the corresponding number (1 to {songsList.Count()}): ");

                bool parsedInput = int.TryParse(Console.ReadLine(), out int inputId);

                if (parsedInput) // if the input was entered correctly
                {
                    selectedSong = songsList.FirstOrDefault(song => song.Id == inputId);

                    if (selectedSong != null) // if the input was within the required range, the song is chosen
                    {
                        selectedSongName = selectedSong.SongName;
                    }
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
