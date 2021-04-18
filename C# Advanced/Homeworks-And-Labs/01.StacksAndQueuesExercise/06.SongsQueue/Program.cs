using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>();
            
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string song in input)
            {
                songs.Enqueue(song);
            }

            string command = Console.ReadLine();

            while (songs.Count > 0)
            {
                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string songToAdd = command.Substring(4);

                    if (!songs.Contains(songToAdd))
                    {
                        songs.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
