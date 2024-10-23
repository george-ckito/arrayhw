using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayhw
{
    internal class ArraySort
    {
        public void Execute()
        {
            int[] arr = { 3, 10, 93, 29, 30 };
            Console.Write("Original Array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Array.Sort(arr);
            Console.Write("\nSorted Array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

        }
    }
}
