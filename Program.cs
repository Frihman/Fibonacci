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
            
            numbers[0] = 0;
            numbers[1] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {

                numbers[i] = numbers[i - 2] + numbers[i - 1];
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
