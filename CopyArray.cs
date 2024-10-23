using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayhw
{
    internal class CopyArray
    {
        public void Execute()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Copy via For or Copy method? (for/copy)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "for":
                    int[] arr2 = new int[arr.Length];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr2[i] = arr[i];
                    }
                    break;
                case "copy":
                    int[] arr3 = new int[arr.Length];
                    Array.Copy(arr, arr3, arr.Length);
                    break;
                default:
                    Console.WriteLine("choose a valid option (nothing has been done to the array)");
                    break;
            }
            

        }
    }
}
