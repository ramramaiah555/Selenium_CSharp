using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp.Oops.Inheritance
{
    internal class Vehicle
    {
        public string Brand { get; set; }

        public void Honk()
        {
            Console.WriteLine("Beep! Beep!");
        }
    }

}

