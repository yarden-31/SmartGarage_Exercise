using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
	public static class SmartGarageTester
	{

        public static void MoveAllRight(IHorizintalMovable[] movingThings)
        {
            Console.WriteLine("\n--- Moving all vehicles to the right ---");
            {   
                foreach (var item in movingThings)
                {
                    item.MoveRight();
                }
            }
        }

        //---------------------------------------------------

        public static void MoveAllLeft(IHorizintalMovable[] movingThings)
        {
            Console.WriteLine("\n--- Moving all vehicles to the right ---");
            {
                foreach (var item in movingThings)
                {
                    item.MoveLeft();
                }
            }
        }

        //---------------------------------------------------

        public static void TestAllVehicles(Vehicle[] allVehicles)
        {
            Console.WriteLine("\n--- Commencing Vehicle diagnostics ---");
            foreach (var v in allVehicles)
            {
                Console.WriteLine($"-- Testing {v.ModelName} --");
                
                v.Drive();

                if (v is FuelVehicle vehicle)
                {
                    vehicle.Refuel();
                }
            }
        }

        //---------------------------------------------------

        public static void ChargeMoving(IChargeable[] moving)
        {
            Console.WriteLine("\n--- Commencing Charging diagnostics ---");
            foreach (var item in moving)
            {
                if (item is IChargeable)
                {
                    ((IChargeable)item).ChargeBattery();
                }
            }
        }

        internal static void RefuelAllCars(Car[] carFleet)
        {
            throw new NotImplementedException();
        }

        internal static void ChargeAllRobots(CleaningRobot[] robotFleet)
        {
            throw new NotImplementedException();
        }

        internal static void MoveAllRight(Car[] carFleet, Motorcycle[] bikeFleet, CleaningRobot[] robotFleet)
        {
            throw new NotImplementedException();
        }

        //---------------------------------------------------



    }

}
