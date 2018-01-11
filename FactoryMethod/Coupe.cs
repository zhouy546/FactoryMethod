using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Coupe:AbstractCar
    {
        public Coupe(IEngine engine) : this(engine, VehicleColour.Unpainted) { }

        public Coupe(IEngine engine, VehicleColour colour) : base(engine,colour) { }

    }
}
