using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class AutoFactory
    {
        Dictionary<string, Type> _availableAutos = new Dictionary<string, Type>();

        public IAuto CreateInstance(string carName)
        {
            IAuto car = null;
            LoadAvailableAutos();

            foreach (var keyvaluepair in _availableAutos)
            {
                if (keyvaluepair.Key == carName)

                     car = Activator.CreateInstance(Assembly.GetExecutingAssembly().GetName().Name,keyvaluepair.Value.Name) as IAuto;
            }

            return car;
        }

        
        private void LoadAvailableAutos()
        {
            var typesAvail = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in typesAvail)
            {
                if (type.GetInterfaces().Contains<Type>(typeof(IAuto)))
                    _availableAutos.Add(type.Name, type);
            }
        }
    }
}
