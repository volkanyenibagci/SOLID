using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstutionPrinciple.WithLSP
{
    public class AppleWithLSP : IFruitWithLSP
    {
        public string GetColor()
        {
            return "Red";
        }
    }
}
