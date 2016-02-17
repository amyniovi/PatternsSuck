using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FrapDecorator : Frap
    {
        protected Frap frap;
        public FrapDecorator(Frap frap)
        {
            this.frap = frap;
        }
        public override double GetCost()
        {
            return frap.GetCost();
        }

        public override string GetDescription()
        {
            return frap.GetDescription();
        }
    }
}
