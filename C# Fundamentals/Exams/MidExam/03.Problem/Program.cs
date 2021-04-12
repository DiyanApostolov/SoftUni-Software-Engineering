using System;
using System.Collections.Generic;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<string> chat = new List<string>();

            while (cmdArg[0] != "end")
            {
                string command = cmdArg[0];
                switch (command)
                {
                    case "Chat":
                        chat.Add(cmdArg[1]);
                        break;
                    case "Delete":
                        if (chat.Contains(cmdArg[1]))
                        {
                            chat.Remove(cmdArg[1]);
                        }
                        break;
                    case "Edit":
                        if (chat.Contains(cmdArg[1]))
                        {
                            int index = chat.IndexOf(cmdArg[1]);
                            chat.Insert(index, cmdArg[2]);
                            chat.RemoveAt(index + 1);
                        }
                        break;
                    case "Pin":
                        if (chat.Contains(cmdArg[1]))
                        {
                            int index = chat.IndexOf(cmdArg[1]);
                            chat.Add(chat[index]);
                            chat.RemoveAt(index);
                        }
                        break;
                    case "Spam":
                        for (int i = 1; i < cmdArg.Length; i++)
                        {
                            chat.Add(cmdArg[i]);
                        }
                        break;
                    default:
                        break;
                }

                cmdArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in chat)
            {
                Console.WriteLine(item);
            }
        }
    }
}
