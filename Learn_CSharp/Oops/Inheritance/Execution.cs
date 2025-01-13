using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp.Oops.Inheritance
{
    internal class Execution
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Brand = "Mahindra";
            myCar.Model = "THAR";
            myCar.DisplayDetails();
            myCar.Honk();
        }
    }
}
