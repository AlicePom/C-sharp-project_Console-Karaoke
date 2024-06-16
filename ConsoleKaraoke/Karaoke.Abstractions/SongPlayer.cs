namespace Karaoke.Abstractions
{
    public class SongPlayer
    {
        // A dictionary defining Tone frequency - 3 octaves (C3 - C6)
        protected Dictionary<string, int> toneFrequency = new Dictionary<string, int>
        {
            { "C3", 131 },
            { "Cis3", 139 },
            { "D3", 147 },
            { "Dis3", 156 },
            { "E3", 165 },
            { "F3", 175 },
            { "Fis3", 185 },
            { "G3", 196 },
            { "Gis3", 208 },
            { "A3", 220 },
            { "B3", 233 },
            { "H3", 247 },
            { "C4", 262 },
            { "Cis4", 277 },
            { "D4", 294 },
            { "Dis4", 311 },
            { "E4", 330 },
            { "F4", 349 },
            { "Fis4", 370 },
            { "G4", 392 },
            { "Gis4", 415 },
            { "A4", 440 },
            { "B4", 466 },
            { "H4", 494 },
            { "C5", 523 },
            { "Cis5", 554 },
            { "D5", 587 },
            { "Dis5", 622 },
            { "E5", 659 },
            { "F5", 699 },
            { "Fis5", 740 },
            { "G5", 784 },
            { "Gis5", 831 },
            { "A5", 880 },
            { "B5", 932 },
            { "H5", 988 },
            { "C6", 1047 },
        };

        // A dictionary defining tone length
        protected Dictionary<string, int> toneLength = new Dictionary<string, int>
        {
            { "whole", 2875 }, // whole = 8*eighth + (8-1)*sixteenth (pause length)
            { "half", 1375 }, // half = 4*eighth + (4-1)*sixteenth (pause length)
            { "3eighth", 1000}, // 3*eighth = 3*eighth + (3-1)*sixteenth (pause length)
            { "quarter", 625 }, // quarter = 2*eighth + (2-1)*sixteenth (pause length)
            { "eighth", 250 }, // eighth = 2*sixteenth (the shortest tone within the song)
            { "sixteenth", 125 } // sixteenth; it is equal to pause length
        };

        // A method that iterates through the TableRow List and plays the song tone by tone, displaying syllable after syllable
        public void PlaySong(string songName, Dictionary<string, List<TableRow>> songs)
        {
            List<TableRow> chosenSong = songs[songName];

            foreach (var row in chosenSong)
            {
                if (!string.IsNullOrEmpty(row.Syllable)) // a tone is beeped upon the corresponding syllable printed to the console
                {
                    // printing a syllable
                    Console.Write(row.Syllable);
                    // beeping a tone
                    Console.Beep(toneFrequency[row.Tone], toneLength[row.Length]);
                    // making a pause - necessary between each 2 tones + makes dashes if intended
                    Thread.Sleep(row.Pause * (toneLength["sixteenth"] + toneLength["eighth"]) + toneLength["sixteenth"]);
                }
                else // a gap in song text is printed on the console; no tone is beeped
                {
                    Console.WriteLine();
                }
            }
        }
    }
}