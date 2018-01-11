using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PickUp :AbstractVan
    {
        public PickUp(IEngine engine) : this(engine, VehicleColour.Unpainted) { }
        public PickUp(IEngine engine, VehicleColour colour) : base(engine, colour) { }
    }
}
