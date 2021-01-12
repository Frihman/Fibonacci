using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[21];
            
            Console.WriteLine(numbers[0] = 0);
            Console.WriteLine(numbers[1] = 1);

            for (int i = 2; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] = numbers[i - 2] + numbers[i - 1]);
            }
        }
    }
}
