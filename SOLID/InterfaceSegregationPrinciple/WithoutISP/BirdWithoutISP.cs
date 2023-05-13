using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple.WithoutISP
{
    public class BirdWithoutISP : IAnimalWithoutISP
    {
        public void bark()
        {
            Console.WriteLine("Boşa implement edildi. Kuş havlayamaz");
        }

        public void fly()
        {
            Console.WriteLine("Kuş uçar");
        }

        public void run()
        {
            Console.WriteLine("Kuş koşar");
        }
    }
}
