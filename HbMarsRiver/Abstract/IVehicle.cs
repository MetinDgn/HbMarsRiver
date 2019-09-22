using HbMarsRiver.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HbMarsRiver.Abstract
{
    public interface IVehicle
    {
        Coordinate Coordinate { get; set; }
        Area Area { get; set; }
        IDirection Direction { get; set; }
    }
}
