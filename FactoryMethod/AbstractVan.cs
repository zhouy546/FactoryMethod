using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AbstractVan:AbstractVehicle
    {
        public AbstractVan(IEngine engine) : this(engine, VehicleColour.Unpainted) { }

        public AbstractVan(IEngine engine, VehicleColour colour) : base(engine, colour) { }
    }
}
