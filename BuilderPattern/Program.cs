using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseBuilder = new BasePersonBuilder(new DefaultedLoanPersonBuilder());
            baseBuilder.BuildPerson();
            var badCreditScorePerson = baseBuilder.GetPerson();
            foreach (var loan in badCreditScorePerson.Loans)
                Console.WriteLine("Loan with id : " + loan.LoanId + "is " + (loan.IsDefault ? "" : "not ") + "default");
            Console.ReadLine();
        }
    }
}
