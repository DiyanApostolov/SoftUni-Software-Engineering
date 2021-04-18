using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceForBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locksInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int inteligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsInput);
            Queue<int> locks = new Queue<int>(locksInput);

            int barrelsCounter = 0;

            while (bullets.Any() && locks.Any())
            {
                
                int currBullet = bullets.Pop();
                int currLock = locks.Peek();

                if (currBullet <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    barrelsCounter++;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    barrelsCounter++;
                }
                
                if (bullets.Any() && barrelsCounter % sizeOfGunBarrel == 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int totalMoneyForBullets = barrelsCounter * priceForBullet;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${inteligenceValue - totalMoneyForBullets}");
            }
        }
    }
}
