using MeasurementUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Temp
{
    public class F : ITemp
    {
        public double Value { get; set; }

        public double BaseReference { get { return 1; } }

        public F()
        {

        }

        public F(double value)
        {
            Value = value;
        }

        
        public static F ConvertFrom(TempUnits unit, double value)
        {
            switch (unit)
            {
                default:
                    {
                        return ConvertFrom(TempUnits.C, value - 273.15);
                    }
                case (TempUnits.C):
                    {
                        var step1 = value * 1.8;
                        var result = step1 + 32;
                        return new F(result);
                    }
                case (TempUnits.F):
                    return new F(value);
            }
        }
    }
}
