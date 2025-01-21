using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp.java
{
    internal class PrintNum
    {
        static void Main(string[] args)
        {
            // Loop from 1 to 200
            for (int i = 1; i <= 200; i++)
            {
                if (i <= 100)
                {
                    // Print numbers from 1 to 100
                    Console.Write(i + " ");
                }
                else
                {
                    // Print numbers from 100 to 1
                    Console.Write((201 - i) + " ");
                }

                // Add a new line after completing the first sequence
                if (i == 100)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
