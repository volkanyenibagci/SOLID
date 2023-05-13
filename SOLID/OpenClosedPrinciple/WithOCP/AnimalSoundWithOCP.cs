using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple.WithOCP
{
    public class AnimalSoundWithOCP
    {
        public void MakeAnimalSoundWithOCP(IAnimalWithOCP animal)
        {
            animal.MakeSound();
        }
    }
}
