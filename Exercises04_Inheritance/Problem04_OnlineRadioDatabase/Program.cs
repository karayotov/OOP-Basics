using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem04_OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int songsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < songsCount; i++)
            {
                try
                {
                    string[] songArgs = Console.ReadLine().Split(';');
                    string artist = songArgs[0];
                    string name = songArgs[1];

                    try
                    {
                        var tryParseDigits = songArgs[2].Split(':').Select(int.Parse).ToArray();// <------ da e var?

                    }
                    catch (Exception)
                    {
                        throw new InvalidSongLengthException();
                    }

                    int[] songLengthArgs = songArgs[2].Split(':').Select(int.Parse).ToArray();
                    int minutes = songLengthArgs[0];
                    int seconds = songLengthArgs[1];

                    Song song = new Song(artist, name, minutes, seconds);
                    songs.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException e)
                {

                    Console.WriteLine(e.Message);
                }
            }
            int totalDuration = songs.Sum(s => s.Minutes * 60 + s.Seconds);
            int totalHours = totalDuration / 60 / 60;
            int totalMinutes = (totalDuration / 60) - (totalHours * 60);
            int totalSeconds = totalDuration % 60;

            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");
        }
    }
}
