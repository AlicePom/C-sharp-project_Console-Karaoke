using Karaoke.Abstractions;
using Karaoke.Songs;

namespace Karaoke.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loading of the JSON file
            var jsonDeserializer = new JsonDeserializer();
            var songs = jsonDeserializer.DeserializeSongs();

            // Introduction of the application and displaying the song selection
            var songManager = new SongManager();
            songManager.DisplaySongs();

            // Prompting the user to select a song from the list
            var userSelection = new UserSelection(songManager.SongsList);
          
            // Playing the selected song
            var songPlayer = new SongPlayer();
            songPlayer.PlaySong(userSelection.GetSongById(), songs);
            Console.WriteLine();
        }
    }
}