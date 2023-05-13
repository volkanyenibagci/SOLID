using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple.WithoutOCP
{
    public class AnimalSoundWithoutOCP
    {
        public void MakeDogSound()
        {
            Console.WriteLine("Hav");
        }

        public void MakeCatSound()
        {
            Console.WriteLine("Meow");
        }

        public void MakeCowSound()
        {
            Console.WriteLine("Moo");
        }
    }
}
