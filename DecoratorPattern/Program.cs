using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Frap myFrap = new CreamFrap();
            Console.WriteLine("frap1:  " + myFrap.GetDescription());
            myFrap = new CreamDecorator(myFrap);
            Console.WriteLine("frap2:  " + myFrap.GetDescription());
            Console.ReadLine();

        }
    }
}
