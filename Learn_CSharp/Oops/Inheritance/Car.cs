using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp.Oops.Inheritance
{
    internal class Car : Vehicle
    {
        public string Model { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}");
        }
    }
}


