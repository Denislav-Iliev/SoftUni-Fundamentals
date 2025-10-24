using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int numberOfSongs = int.Parse(Console.ReadLine());
        List<Song> songs = new();

        for (int i = 0; i < numberOfSongs; i++)
        {
            string[] data = Console.ReadLine().Split("_");
            string type = data[0];
            string name = data[1];
            string time = data[2];

            Song song = new Song
            {
                TypeList = type,
                Name = name,
                Time = time
            };

            songs.Add(song);
        }

        string filterType = Console.ReadLine();

        if (filterType == "all")
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (Song song in songs.Where(s => s.TypeList == filterType))
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}
