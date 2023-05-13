using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstutionPrinciple.WithoutLSP
{
    public class AppleWithoutLSP
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
}
