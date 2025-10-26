using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise;
	
		internal abstract class Car : Vehicles, IDriveable, IMoveleftable, IMoverightable, IChargeable
		{

			public int FuelPercentage
			{
				get; private set;
			}

			//---------------------------------------------------

			public Car(string model, int fuel) : base(model)
			{
				ModelName = model;
				FuelPercentage = Math.Clamp(fuel, 0, 100);
			}
	
			//---------------------------------------------------

			public override void Drive()
			{
				if (FuelPercentage > 10)
				{
					FuelPercentage -= 10;
					Console.WriteLine($"The car {ModelName} goes is driving. Fuel left: {FuelPercentage}%");
				}
				else
				{
					Console.WriteLine($"The car {ModelName} cannot drive. No fuel.");
				}
			}

			//---------------------------------------------------

			public override void Refuel()
			{
				Console.WriteLine($"Refueling {ModelName}...");
				FuelPercentage = 100;
			}

			//---------------------------------------------------

			public override void Moveleft()
			{
				Console.WriteLine($"Car {ModelName} turns left.");
			}

			//---------------------------------------------------

			public override void MoveRight()
			{
				Console.WriteLine($"Car {ModelName} turns right.");
			}
		}

	
