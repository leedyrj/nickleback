using System;
using System.Collections.Generic;

namespace nickleback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();

            HashSet<(string, string)> allSongs = new HashSet<(string, string)>(){
                ("In My Life", "The Beatles"),
                ("Ways to Go", "Grouplove"),
                ("Gold Rush", "Deathcab for Cutie"),
                ("Something Human", "Muse"),
                ("Photographs", "Nickleback"),
                ("Some Other Song by Nickleback", "Nickleback"),
                ("Rut", "The Killers")
            };

            foreach ((string, string) song in allSongs)
            {
                if (song.Item2 != "Nickleback")
                {
                    goodSongs.Add(song);
                }
            }
            foreach ((string, string) item in goodSongs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
