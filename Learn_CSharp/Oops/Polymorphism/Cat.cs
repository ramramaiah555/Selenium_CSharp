using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp.Oops.Polymorphism
{
    internal class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat says: Meow Meow");
        }
    }
}
