using HbMarsRiver.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HbMarsRiver.Concrete
{
    public class East : IDirection
    {
        public string Direction { get { return "Doğu"; } }
        public bool IsAwail(Area area, Coordinate coordinate)
        {
            bool awail = false;
            if (area.XDimLength >= coordinate.XCoordinate + 1)
                awail = true;
            return awail;
        }

        public void Move(Coordinate coordinate)
        {
            coordinate.XCoordinate += 1;
        }

        public IDirection TurnLeft()
        {
            return new North();
        }

        public IDirection TurnRight()
        {
            return new South();
        }
    }
}
