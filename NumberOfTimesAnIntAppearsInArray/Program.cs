using System;
using System.Collections.Generic;

namespace NumberOfTimesAnIntAppearsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNums = { 0, 0, 1, 1, 1, 2, 57, 0, 4, 7, 9, 9, 57, 57, 57, 57 };
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int counter = 0;
            foreach (var number in arrayOfNums)
            {
                if (!dict.ContainsKey(number))
                {
                    dict.Add(number, 1);
                }
                else {
                    dict[number] += 1;
                }
               
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{ item.Key} appears {item.Value} times.");
            }
        }
    }
}
