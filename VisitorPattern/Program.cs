using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var salesman = new Salesman();


        }
    }

    public class Salesman : ISaleAmount
    {
        List<ISaleAmount> SaleAmounts = new List<ISaleAmount>();

        public void Accept(ISaleVisitor visitor)
        {
            foreach (var amount in SaleAmounts)
            {
                amount.Accept(visitor);
            }
        }
    }
    public class Product : ISaleAmount
    {
        public double Price { get; set; }

        public void Accept(ISaleVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class SalesCost : ISaleAmount
    {
        public double AdvertisingCost { get; set; }

        public void Accept(ISaleVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Salary : ISaleAmount
    {
        public double Income { get; set; }

        public void Accept(ISaleVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
