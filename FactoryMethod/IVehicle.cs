using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour{get;}
        void Paint(VehicleColour colour);
    }
}
