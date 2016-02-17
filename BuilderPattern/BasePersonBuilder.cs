using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class BasePersonBuilder
    {
        private PersonBuilder _builder;
        public BasePersonBuilder(PersonBuilder builder)
        {
            _builder = builder;
        }


        public void BuildPerson()
        {
            _builder.CreateBasicPerson();
            _builder.CreatePersonAddress();
            _builder.ApplyCreditScore();
            _builder.CreateLoanWithPersonId();
        }

        public Person GetPerson()
        {
            return _builder.GetPerson();
        }
    }
}
