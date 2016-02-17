using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class NetSaleWorthVisitor : ISaleVisitor
    {
        public double NetSaleWorth { get; set; }
        public void Visit(Salary income)
        {
            NetSaleWorth -= income.Income;
        }

        public void Visit(SalesCost cost)
        {
            NetSaleWorth -= cost.AdvertisingCost;
        }

        public void Visit(Product product)
        {
            NetSaleWorth += product.Price;
        }
    }
}
