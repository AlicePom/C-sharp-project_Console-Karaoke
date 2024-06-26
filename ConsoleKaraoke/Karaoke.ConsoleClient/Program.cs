using Karaoke.Abstractions;
using Karaoke.Songs;

namespace Karaoke.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loading of the JSON file
            ISongCatalogueProvider catalogueProvider = new JsonCatalogueProvider();
            var songs = catalogueProvider.DeserializeSongs();

            // Introduction of the application and displaying the song selection
            ISongManager songManager = new SongManager();
            songManager.DisplaySongs();

            // Prompting the user to select a song from the list
            var userSelection = new UserSelection(songManager.GetSongs());
            var selectedSongName = userSelection.GetSongById();

            // Playing the selected song
            ISongPlayer songPlayer = new ConsoleSongPlayer();
            songPlayer.PlaySong(selectedSongName, songs);
            Console.WriteLine();
        }
    }
}