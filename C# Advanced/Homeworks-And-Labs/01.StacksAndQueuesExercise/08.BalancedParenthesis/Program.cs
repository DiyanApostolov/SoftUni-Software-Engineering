using System;
using System.Collections.Generic;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> openParenthesis = new Stack<char>();

            bool isBalanced = true;

            foreach (char symbol in input)
            {
                if (symbol == '(' || symbol == '{' || symbol == '[')
                {
                    openParenthesis.Push(symbol);
                }
                else
                {
                    if (openParenthesis.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    char lastSymbol = openParenthesis.Pop();

                    if (symbol == ')' && lastSymbol != '(')
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (symbol == '}' && lastSymbol != '{')
                    {
                        isBalanced = false;
                        break;
                    }
                    else if (symbol == ']' && lastSymbol != '[')
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
