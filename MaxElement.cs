using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayhw
{
    internal class MaxElement
    {
        public void Execute()
        {
            int[] arr = { 3, 10, 93, 29, 30 };
            Console.Write("Original Array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nOption a, Option b or Option c?");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "a":
                    Console.WriteLine($"Max Element: {arr.Max()}");
                    break;
                case "b":
                    for(int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] > arr[0])
                        {
                            arr[0] = arr[i];
                        }
                    }
                    Console.WriteLine($"Max Element: {arr[0]}");
                    break;
                case "c":
                    Console.WriteLine($"Min Element: {arr.Min()}");
                    break;
                default:
                    Console.WriteLine("choose a valid option");
                    break;
            }
        }
    }
}
