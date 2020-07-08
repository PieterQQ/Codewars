using System;
using System.Linq;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LargestPairSum(new int[] {-8,-8,-16,-19 });
        }
       
            public static int LargestPairSum(int[] numbers)
            {
     Array.Sort(numbers);
            Array.Reverse(numbers);

            return numbers[0] + numbers[1];            }
        
    }
}
