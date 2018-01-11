using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class VanFactory:VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if ((style == DrivingStyle.Economical || style == DrivingStyle.Midrange))
            {
                return new PickUp(new StandardEngine(2200));
            }
            else {
                return new BoxVan(new TurboEngine(2500));
            }
        }
    }
}
