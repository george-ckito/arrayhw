using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayhw
{
    internal class DuplicateElement
    {
        public void Execute()
        {
            int[] arr = { 3, 10, 93, 29, 30, 10, 29 };
            Console.Write("Original Array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"\nDuplicate Elements: ");
            for (int i = 0; i < arr.Length; i++) { 
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write($"{arr[i]} ");
                    }
                }
            }
        }
    }
}
