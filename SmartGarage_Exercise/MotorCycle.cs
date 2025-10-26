using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
	internal abstract class Motorcycle : Vehicles, IDriveable, IMoveleftable, IMoverightable, IChargeable
    {
		public int FuelPercentage
		{
			get; private set;
		}

        //---------------------------------------------------

        public Motorcycle(string model, int fuel) : base(model)
        {
			ModelName = model;
			FuelPercentage = Math.Clamp(fuel, 0, 100);
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
			FuelPercentage = 100;
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
