using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayhw
{
    internal class ReverseArray
    {
        public void Execute()
        {
            int[] arr = {3, 10, 93, 29, 30 };
            Console.Write("Original Array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nOption a Or Option b?");
            string choice = Console.ReadLine();
            switch (choice) {
                case "a":
                    Array.Reverse(arr);
                    break;
                case "b":
                    int[] arr2 = new int[arr.Length];
                    for(int i = 0; i < arr.Length; i++)
                    {
                        arr2[i] = arr[arr.Length - 1 - i];
                    }
                    Array.Copy(arr2, arr, arr.Length);
                    break;
                default:
                    Console.WriteLine("choose a valid option (nothing has been done to the array)");
                    break;
            }
            Console.WriteLine("Result Array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }   
    }
}
