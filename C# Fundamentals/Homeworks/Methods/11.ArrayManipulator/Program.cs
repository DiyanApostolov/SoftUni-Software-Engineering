    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayManipulatorStart
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");
            int[] numbers = Array.ConvertAll(input, int.Parse);

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] instructions = command.Split(" ");

                if (instructions[0] == "exchange")
                {
                    int second = int.Parse(instructions[1]);
                    if (second > numbers.Length - 1 || second < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers = Exchange(numbers, second);
                    }
                }
                else if (instructions[0] == "max")
                {
                    if (instructions[1] == "odd")
                    {
                        int result = MaxOdd(numbers);
                        if (result < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                    else if (instructions[1] == "even")
                    {
                        int result = MaxEven(numbers);
                        if (result < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                }
                else if (instructions[0] == "min")
                {
                    if (instructions[1] == "odd")
                    {
                        int result = MinOdd(numbers);
                        if (result < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                    else if (instructions[1] == "even")
                    {
                        int result = MinEven(numbers);
                        if (result < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                }
                else if (instructions[0] == "first")
                {
                    int secondInstruction = int.Parse(instructions[1]);
                    if (secondInstruction > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    else if (instructions[2] == "odd")
                    {
                        List<int> temp = FirstOdds(numbers, secondInstruction);
                        if (temp.Count <= secondInstruction)
                        {
                            Console.WriteLine("[" + string.Join(", ", temp) + "]");
                        }
                        else if (temp.Count > secondInstruction)
                        {
                            temp.RemoveRange(secondInstruction, temp.Count - secondInstruction);
                            Console.WriteLine("[" + string.Join(", ", temp) + "]");
                        }
                    }
                    else if (instructions[2] == "even")
                    {
                        List<int> temp = FirstEvens(numbers, secondInstruction);
                        if (temp.Count <= secondInstruction)
                        {
                            Console.WriteLine("[" + string.Join(", ", temp) + "]");
                        }
                        else if (temp.Count > secondInstruction)
                        {
                            temp.RemoveRange(secondInstruction, temp.Count - secondInstruction);
                            Console.WriteLine("[" + string.Join(", ", temp) + "]");
                        }
                    }
                }
                else if (instructions[0] == "last")
                {
                    int secondInstruction = int.Parse(instructions[1]);
                    if (secondInstruction > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    else if (instructions[2] == "odd")
                    {
                        List<int> temp = FirstOdds(numbers, secondInstruction);
                        if (temp.Count <= secondInstruction)
                        {
                            Console.WriteLine("[" + string.Join(", ", temp) + "]");
                        }
                        else if (temp.Count > secondInstruction)
                        {
                            temp.RemoveRange(0, temp.Count - secondInstruction);
                            Console.WriteLine("[" + string.Join(", ", temp) + "]");
                        }
                    }
                    else if (instructions[2] == "even")
                    {
                        List<int> temp = FirstEvens(numbers, secondInstruction);
                        if (temp.Count <= secondInstruction)
                        {
                            Console.WriteLine("[" + string.Join(", ", temp) + "]");
                        }
                        else if (temp.Count > secondInstruction)
                        {
                            temp.RemoveRange(0, temp.Count - secondInstruction);
                            Console.WriteLine("[" + string.Join(", ", temp) + "]");
                        }
                    }
                }
            }
            
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
        
        static int[] Exchange(int[] nums, int index)
        {
            int[] firstHalf = new int[index + 1];
            int[] secondHalf = new int[nums.Length];
            if (index >= 0 && index < nums.Length - 1)
            {
                Array.Copy(nums, 0, firstHalf, 0, index + 1);
                Array.Copy(nums, index + 1, secondHalf, 0, secondHalf.Length - firstHalf.Length);
                Array.Copy(firstHalf, 0, secondHalf, secondHalf.Length - firstHalf.Length, firstHalf.Length);
                return secondHalf;
            }
            else
            {
                return nums;
            }

        }

        static int MaxOdd(int[] nums)
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    odds.Add(nums[i]);
                }
            }
            if (odds.Count == 0)
            {
                return -1;
            }
            else
            {
                int max = odds.Max();
                return nums.ToList().LastIndexOf(max);
            }
        }

        static int MaxEven(int[] nums)
        {
            List<int> evens = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evens.Add(nums[i]);
                }
            }
            
            if (evens.Count == 0)
            {
                return -1;
            }
            else
            {
                int max = evens.Max();
                return nums.ToList().LastIndexOf(max);
            }
        }

        static int MinOdd(int[] nums)
        {
            List<int> odds = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    odds.Add(nums[i]);
                }
            }
            
            if (odds.Count == 0)
            {
                return -1;
            }
            else
            {
                int max = odds.Min();
                return nums.ToList().LastIndexOf(max);
            }
        }

        static int MinEven(int[] nums)
        {
            List<int> evens = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evens.Add(nums[i]);
                }
            }
            
            if (evens.Count == 0)
            {
                return -1;
            }
            else
            {
                int max = evens.Min();
                return nums.ToList().LastIndexOf(max);
            }
        }
        
        static List<int> FirstEvens(int[] nums, int len)
        {
            List<int> evens = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evens.Add(nums[i]);
                }
            }
            return evens;
        }

        static List<int> FirstOdds(int[] nums, int len)
        {
            List<int> odds = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    odds.Add(nums[i]);
                }
            }
            return odds;
        }
    }
