using MeasurementUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Temp
{
    public class C : ITemp
    {
        public double Value { get; set; }

        public double BaseReference { get { return 1; } }

        public C()
        {

        }

        public C(double value)
        {
            Value = value;
        }

       
        public static C ConvertFrom(TempUnits unit, double value)
        {
            switch (unit)
            {
                default:
                    return new C(value - 273.15);
                case (TempUnits.C):
                    return new C(value);
                case (TempUnits.F):
                    {
                        var step1 = value - 32;
                        var result = step1 / 1.8;
                        return new C(result);
                    }
            }
        }
    }
}
