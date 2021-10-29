using MeasurementUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Length
{
    /// <summary>
    /// Mile
    /// </summary>
    public class mi : ILength
    {
        public double Value { get; set; }
        public double BaseReference { get { return 1609344; } }

        public mi()
        {

        }

        public mi(double value)
        {
            Value = value;
        }



        public static mi FromLengthUnit<TLength>(TLength source) where TLength : ILength
        {
            var result = new mi();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static mi ConvertFrom<TLength>(TLength source) where TLength : ILength
        {
            var result = new mi();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static mi ConvertFrom(LengthUnits unit, double value)
        {
            switch (unit)
            {
                default:
                    return ConvertFrom(new mm(value));
                case (LengthUnits.cm):
                    return ConvertFrom(new cm(value));
                case (LengthUnits.dm):
                    return ConvertFrom(new dm(value));
                case (LengthUnits.m):
                    return ConvertFrom(new m(value));
                case (LengthUnits.dam):
                    return ConvertFrom(new dam(value));
                case (LengthUnits.hm):
                    return ConvertFrom(new hm(value));
                case (LengthUnits.km):
                    return ConvertFrom(new km(value));
                case (LengthUnits.th):
                    return ConvertFrom(new th(value));
                case (LengthUnits._in):
                    return ConvertFrom(new _in(value));
                case (LengthUnits.ft):
                    return ConvertFrom(new ft(value));
                case (LengthUnits.yd):
                    return ConvertFrom(new yd(value));
                case (LengthUnits.fur):
                    return ConvertFrom(new fur(value));
                case (LengthUnits.mi):
                    return ConvertFrom(new mi(value));

            }
        }
    }
}
