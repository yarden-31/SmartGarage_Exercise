using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    internal abstract class Drone : ElectricVehicle, IVerticalMovable
    {

        public int Velocity
        {
            get; set;
        }

        //---------------------------------------------------

        public Drone(string model, int battery) : base(model)
        {
        }

        //---------------------------------------------------

        private void Fly()
        {
            MoveUp();
            Console.WriteLine(  "drone moves up");
        }

        //---------------------------------------------------

        public override void Drive()
        {
            Fly();
        }

        //---------------------------------------------------

        public override void MoveLeft()
        {
            Console.WriteLine($"Drone moves left.");
        }

        //---------------------------------------------------

        public override void MoveRight()
        {
            Console.WriteLine($"Drone moves right.");
        }

        //---------------------------------------------------

        public void MoveUp()
        {
            Console.WriteLine($"Drone moves up.");
            Velocity--;
        }

        //---------------------------------------------------

        public void MoveDown()
        {
            Console.WriteLine($"Drone moves down.");
            Velocity++;
        }
    }
}
