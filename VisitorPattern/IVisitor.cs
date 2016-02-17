using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
   public interface ISaleVisitor
    {
        void Visit(Product product);
        void Visit(SalesCost cost);
        void Visit(Salary income);

    }
}
