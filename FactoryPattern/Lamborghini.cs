using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Lamborghini : IAuto
    {
        public void Accelerate()
        {
            Console.WriteLine("From 20 to 150 m/h in 5s");
        }

        public void SwitchOn()
        {
            Console.WriteLine("wake peops uuup");
        }
    }
}
