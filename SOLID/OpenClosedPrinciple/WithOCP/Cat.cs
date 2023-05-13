using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple.WithOCP
{
    public class Cat : IAnimalWithOCP
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
