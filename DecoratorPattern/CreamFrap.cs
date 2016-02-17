using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class CreamFrap : Frap
    {
        public CreamFrap()
        {
            Description = "Cream Frappuccino";
        }   
        
        public override double GetCost()
        {
            return 3.20;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
