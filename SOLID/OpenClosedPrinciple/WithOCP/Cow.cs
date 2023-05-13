using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple.WithOCP
{
    public class Cow : IAnimalWithOCP
    {
        public void MakeSound()
        {
            Console.WriteLine("Mooo");
        }
    }
}
