using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class VanDirector : VehicleDirector 
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildReinforceStorageArea();
            builder.BuildWindow();
            return builder.Vehicle;
        }
    }
}
