using HbMarsRiver.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HbMarsRiver.Concrete
{
    public class Vehicle : IVehicle
    {
        public Vehicle()
        {
            this.Coordinate = new Coordinate();
            this.Area = new Area();
        }
        public Coordinate Coordinate { get; set; }
        public IDirection Direction { get; set; }
        public Area Area { get; set; }
    }
}
