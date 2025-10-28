using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
	public class Motorcycle : FuelVehicle, IDriveable, IHorizintalMovable
    {
        public Motorcycle(string model, int fuel) : base(model, fuel)
        {
		}

        //---------------------------------------------------

        public override void Drive()
		{
			if (FuelPercentage > 5)
			{
				FuelPercentage -= 5;
				Console.WriteLine($"The motorcycle {ModelName} goes 'Neeeeow'. Fuel left: {FuelPercentage}%");
			}
			else
			{
				Console.WriteLine($"The motorcycle {ModelName} cannot drive. No fuel.");
			}
		}

        //---------------------------------------------------

        public override void Refuel()
		{
			Console.WriteLine($"Refueling {ModelName}...");
			base.Refuel();
        }

        //---------------------------------------------------

        public override void MoveLeft()
		{
			Console.WriteLine($"Motorcycle {ModelName} leans left.");
		}

        //---------------------------------------------------

        public override void MoveRight()
		{
			Console.WriteLine($"Motorcycle {ModelName} leans right.");
		}
	}

}
