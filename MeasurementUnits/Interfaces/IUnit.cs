using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Interfaces
{
    public interface IUnit
    {
        double Value { get; set; }
        double BaseReference { get; }
    }


}
