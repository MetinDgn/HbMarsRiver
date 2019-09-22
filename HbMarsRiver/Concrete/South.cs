using HbMarsRiver.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HbMarsRiver.Concrete
{
    public class South : IDirection
    {
        public string Direction { get { return "Güney"; } }
        public bool IsAwail(Area area, Coordinate coordinate)
        {
            bool awail = false;
            if (coordinate.YCoordinate - 1 >= 0)
                awail = true;
            return awail;
        }

        public void Move(Coordinate coordinate)
        {
            coordinate.YCoordinate -= 1;
        }

        public IDirection TurnLeft()
        {
            return new East();
        }

        public IDirection TurnRight()
        {
            return new West();
        }
    }
}
