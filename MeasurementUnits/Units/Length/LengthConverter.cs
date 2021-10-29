using MeasurementUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Length
{
    public static class LengthConverter
    {
        public static double GetLengthConverted(LengthUnits FromUnit, LengthUnits ToUnit, double FromValue)
        {
            switch (ToUnit)
            {
                default:
                    return mm.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.cm):
                    return cm.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.dm):
                    return dm.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.m):
                    return m.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.dam):
                    return dam.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.hm):
                    return hm.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.km):
                    return km.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.th):
                    return th.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits._in):
                    return _in.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.ft):
                    return ft.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.yd):
                    return yd.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.fur):
                    return fur.ConvertFrom(FromUnit, FromValue).Value;
                case (LengthUnits.mi):
                    return mi.ConvertFrom(FromUnit, FromValue).Value;
            }
        }
    }
}
