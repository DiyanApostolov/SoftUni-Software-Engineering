using System;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();

            string[] command = Console.ReadLine().Split(">>>");

            while (command[0] != "Generate")
            {
                if (command[0] == "Contains")
                {
                    string substring = command[1];
                    if (rawKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command[0] == "Flip")
                {
                    if (command[1] == "Upper")
                    {
                        string current = string.Empty;
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);

                        for (int i = 0; i < rawKey.Length; i++)
                        {
                            char ch = rawKey[i];
                            if (i >= startIndex && i < endIndex)
                            {
                                ch = Char.ToUpper(ch);
                                current += ch;
                            }
                            else
                            {
                                current += ch;    
                            }
                        }
                        rawKey = current;
                        Console.WriteLine(rawKey);
                    }
                    else if (command[1] == "Lower")
                    {
                        string current = string.Empty;
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);

                        for (int i = 0; i < rawKey.Length; i++)
                        {
                            char ch = rawKey[i];
                            if (i >= startIndex && i < endIndex)
                            {
                                ch = Char.ToLower(ch);
                                current += ch;
                            }
                            else
                            {
                                current += ch;
                            }
                        }
                        rawKey = current;
                        Console.WriteLine(rawKey);
                    }
                }
                else if (command[0] == "Slice")
                {
                    string current = string.Empty;
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    for (int i = 0; i < rawKey.Length; i++)
                    {
                        char ch = rawKey[i];
                        if (i >= startIndex && i < endIndex)
                        {
                            continue;
                        }
                        else
                        {
                            current += ch;
                        }
                    }
                    rawKey = current;
                    Console.WriteLine(rawKey);
                }

                command = Console.ReadLine().Split(">>>");
            }

            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
