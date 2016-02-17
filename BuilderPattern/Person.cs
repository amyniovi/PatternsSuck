using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Person
    {
        private List<Loan> _loans = new List<Loan>();
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Loan> Loans
        {
            get { return _loans; }
            set { _loans = value; }
        }
    }
}
