using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
   public abstract class Frap
    {
        protected string Description { get; set; }
        public abstract double GetCost();
        public abstract string GetDescription();
    }
}
