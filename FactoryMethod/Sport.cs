using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Sport:AbstractCar
    {
        public Sport(IEngine engine) : this(engine, VehicleColour.Unpainted) { }
        public Sport(IEngine engine, VehicleColour colour) : base(engine, colour) { }
    }
}
