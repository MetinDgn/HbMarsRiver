using HbMarsRiver.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HbMarsRiver.Concrete
{
    public class West : IDirection
    {
        public string Direction { get { return "Batı"; } }

        public bool IsAwail(Area area, Coordinate coordinate)
        {
            bool awail = false;
            if (coordinate.XCoordinate - 1 >= 0)
                awail = true;
            return awail;
        }

        public void Move(Coordinate coordinate)
        {
            coordinate.XCoordinate -= 1;
        }

        public IDirection TurnLeft()
        {
            return new South();
        }

        public IDirection TurnRight()
        {
            return new North();
        }
    }
}
