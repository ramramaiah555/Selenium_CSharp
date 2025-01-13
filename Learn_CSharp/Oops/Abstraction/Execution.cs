using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp.Oops.Abstraction
{
    internal class Execution
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle { Radius = 5 };
            Shape rectangle = new Rectangle { Length = 10, Width = 5 };

            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        }
    }
}
