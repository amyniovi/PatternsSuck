using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
  public  class Loan
    {
        public int LoanId { get; set; }
        public int PersonId { get; set; }
        public bool IsDefault { get; set; }
    }
}
