using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class DefaultedLoanPersonBuilder : PersonBuilder
    {

        public override void ApplyCreditScore()
        {
            var loan = new Loan { LoanId = 2343, IsDefault = true, PersonId = person.Id };
            person.Loans.Add(loan);
        }

        public override void CreateLoanWithPersonId()
        {
            
        }

        public override void CreatePersonAddress()
        {
           
        }
    }
}
