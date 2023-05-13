using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstutionPrinciple.WithoutLSP
{
    public class OrangeWithoutLSP : AppleWithoutLSP
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
