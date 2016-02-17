using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class PersonBuilder
    {
        protected Person person;
        public Person GetPerson()
        {
            return person;
        }

        public void CreateBasicPerson()
        {
            person = new Person();
        }
        public abstract void CreatePersonAddress();
        public abstract void ApplyCreditScore();
        public abstract void CreateLoanWithPersonId();
    }
}
