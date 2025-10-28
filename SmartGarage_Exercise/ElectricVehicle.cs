using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public abstract class ElectricVehicle : Vehicle, IChargeable
    {
        public int BatteryPercentage
        {
            get; protected set;
        }

        //---------------------------------------------------

        protected ElectricVehicle(string model) : base(model)
        {
            BatteryPercentage = 100;
        }

        //---------------------------------------------------

        public virtual void ChargeBattery()
        {
            BatteryPercentage = 100;
        }
    }
}
