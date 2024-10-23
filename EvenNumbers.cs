using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayhw
{
    internal class EvenNumbers
    {
        public void Execute()
        {
            int[] arr = { 3, 10, 93, 29, 30 };
            Console.Write("Original Array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nEven Numbers: ");
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
