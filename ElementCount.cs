using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayhw
{
    internal class ElementCount
    {
        public void Execute()
        {
            int[] arr = { 3, 10, 93, 29, 30, 10, 29 };
            Console.Write("Original Array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"Element {arr[i]} is in the array {counter} times");
            }
        }
    }
}
