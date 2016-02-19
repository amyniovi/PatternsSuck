using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var carName = args[0];

            var factory = new AutoFactory();

            IAuto car = factory.CreateInstance(carName);

            car.SwitchOn();
            car.Accelerate();

            Console.ReadLine();

        }
    }
}
