using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp.java
{
    internal class FindSmallestNumInArray
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 2, 9, 4, 1, 5 };

            // Sort the array in ascending order
            Array.Sort(numbers);

            // Get the 3rd smallest number (index 2)
            int thirdSmallest = numbers[2];

            Console.WriteLine("The 3rd smallest number is: " + thirdSmallest);

            Array.Reverse(numbers);

            // Get the 3rd highest number (index 2)
            int thirdHighest = numbers[2];

            Console.WriteLine("The 3rd highest number is: " + thirdHighest);

           
        }
    }
}
