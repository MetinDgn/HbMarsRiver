using HbMarsRiver.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HbMarsRiver.Abstract
{
    public interface IDirection
    {
        IDirection TurnLeft();
        IDirection TurnRight();
        string Direction { get; }
        void Move(Coordinate coordinate);
        bool IsAwail(Area area, Coordinate coordinate);
    }
}
