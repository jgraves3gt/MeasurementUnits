using MeasurementUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Temp
{
    class K : ITemp
    {
        public double Value { get; set; }

        public double BaseReference { get { return 1; } }

        public K()
        {

        }

        public K(double value)
        {
            Value = value;
        }

       
        public static K ConvertFrom(TempUnits unit, double value)
        {
            switch (unit)
            {
                default:
                    return new K(value);
                case (TempUnits.C):
                    return new K(value + 273.15);
                case (TempUnits.F):
                    {
                        var step1 = value - 32;
                        var step2 = step1 * 5;
                        var step3 = step2 / 9;
                        var result = step3 + 273.15;
                        return new K(result);
                    }
            }
        }
    }
}
