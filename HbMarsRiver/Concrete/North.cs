using HbMarsRiver.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HbMarsRiver.Concrete
{
    public class North : IDirection
    {
        public string Direction { get { return "Kuzey"; } }
        public bool IsAwail(Area area, Coordinate coordinate)
        {
            bool awail = false;
            if (area.YDimLength >= coordinate.YCoordinate + 1)
                awail = true;
            return awail;
        }

        public void Move(Coordinate coordinate)
        {
            coordinate.YCoordinate += 1;
        }

        public IDirection TurnLeft()
        {
            return new West();
        }

        public IDirection TurnRight()
        {
            return new East();
        }
    }
}
