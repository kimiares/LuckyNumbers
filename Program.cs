using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Type a number between 4 and 8 digits: ");

                string input = Console.ReadLine();
                if ((input.Length > 3) && (input.Length < 9))
                {
                    int inputNumber = int.Parse(input);
                    int[] arr = inputNumber.ToString().ToCharArray().Select(x => x - '0').ToArray();


                    if (arr.Length % 2 == 0)
                    {
                        Console.WriteLine(CheckLucky(arr));

                    }
                    else
                    {
                        int[] test = ReverseAddArray(arr);
                        Console.WriteLine(CheckLucky(test));
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input");

                }

            }

        }

        public static string CheckLucky(int[] array)
        {
            int[] left = array.Take(array.Length / 2).ToArray();
            int[] right = array.Skip(array.Length / 2).ToArray();
            string result;
            if (left.Sum() == right.Sum())
            {
                result = "This is lucky number";
            }
            else
            {
                result = "Sorry, your number is unlucky";
            }
            return result;
        }

        public static int[] ReverseAddArray(int[] array)
        {
            
            int[] temp = array.Reverse().Concat(new int[] { 0 }).ToArray();
            int[] result = temp.Reverse().ToArray();
            return result;
        }


    }
}
