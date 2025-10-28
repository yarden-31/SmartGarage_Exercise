using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public interface IHorizintalMovable
    {
        public void MoveLeft();
        public void MoveRight();
    }

    public interface IVerticalMovable
    {
        public void MoveUp();
        public void MoveDown();
    }
}
