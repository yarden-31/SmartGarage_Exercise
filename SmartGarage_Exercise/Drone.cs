using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    internal abstract class Drone : IMoveleftable, IMoverightable
    {
        public int BatteryPercentage
        {
            get; private set;
        }

        //---------------------------------------------------

        public Drone(int battery)
        {
            BatteryPercentage = Math.Clamp(battery, 0, 100);
        }

        //---------------------------------------------------

        public void Fly()
        {
            if (BatteryPercentage > 15)
            {
                BatteryPercentage -= 15;
                Console.WriteLine($"The drone is fyling. Battery left: {BatteryPercentage}%");
            }
            else
            {
                Console.WriteLine($"The drone cannot fly. Battery low.");
            }
        }

        //---------------------------------------------------

        public override void Moveleft()
        {
            Console.WriteLine($"Drone moves left.");
        }

        //---------------------------------------------------

        public override void MoveRight()
        {
            Console.WriteLine($"Drone moves right.");
        }
    }
}
