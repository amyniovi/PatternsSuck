using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class CreamDecorator : FrapDecorator
    {
        public CreamDecorator(Frap frap) : base(frap)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription()  + " with Cream " ;
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.25 ;
        }
    }
}
