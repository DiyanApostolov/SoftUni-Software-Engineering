using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {           
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                    
            int biggestCounter = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currElement = arr[i];
                int counter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int secondElement = arr[j];                    
                    if (currElement == secondElement)                  
                    {                      
                        counter ++;                                                                    
                    }
                    else
                    {
                        break;
                    }                                      
                }
                
                if (counter > biggestCounter)
                {
                    biggestCounter = counter;
                    bestIndex = arr[i];
                }               
            }
            
            for (int i = 0; i < biggestCounter; i++)
            {
                Console.Write(bestIndex + " ");
            }           
        }
    }
}
