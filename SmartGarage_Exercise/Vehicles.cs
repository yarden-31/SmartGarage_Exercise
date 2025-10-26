using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    internal abstract class Vehicles : IDriveable, IMoveleftable, IMoverightable, IChargeable
    {
        public string name { get; set; }

        //---------------------------------------------------

        public string ModelName
        {
            get; set;
        }

        //---------------------------------------------------

        public Vehicles(string name)
        {
            this.name = name;
        }

        //---------------------------------------------------

        public abstract void Drive();

        public abstract void Moveleft();

        public abstract void MoveRight();

        public abstract void Refuel();


    }
}
