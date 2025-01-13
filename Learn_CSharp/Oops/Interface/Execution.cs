using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn_CSharp.Oops.Abstraction;

namespace Learn_CSharp.Oops.Interface
{
    internal class Execution
    {
        static void Main(string[] args)
        {
            IShape triangle = new Triangle { Base = 10, Height = 5 };
            IShape square = new Square { Side = 4 };

            Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
            Console.WriteLine($"Square Area: {square.CalculateArea()}");
        }
    }
}
