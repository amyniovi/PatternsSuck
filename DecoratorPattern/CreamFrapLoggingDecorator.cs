using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class CreamFrapLoggingDecorator : CreamFrap
    {
        public override string GetDescription()
        {
            Console.WriteLine("Retrieving Cream Frap GetDescription()");
            return base.GetDescription();
        }

        public override double GetCost()
        {
            Console.WriteLine("Retrieving Cream Frap GetCost()");
            return base.GetCost();
        }
    }
}
