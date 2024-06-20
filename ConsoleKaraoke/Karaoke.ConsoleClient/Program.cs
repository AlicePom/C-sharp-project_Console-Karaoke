using Karaoke.Abstractions;
using Karaoke.Songs;

namespace Karaoke.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jsonDeserializer = new JsonDeserializer();
            var songPlayer = new SongPlayer();
            var songManager = new SongManager();    

            // Loading of the JSON file
            var songs = jsonDeserializer.DeserializeSongs();

            // Introduction of the application and displaying the song selection
            songManager.DisplaySongs();
                   
            // Prompting the user to select a song from the list
            // Displaying the song Title and Author
            // Playing the song
            songPlayer.PlaySong(songManager.GetSongById(), songs);
            Console.WriteLine();
        }
    }
}