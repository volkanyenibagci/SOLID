using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple.WithISP
{
    public class BirdWithISP : IFlyableWithISP, IRunnableWithISP
    {
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
