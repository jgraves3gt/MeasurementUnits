using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Temp
{
    public static class TempConverter
    {
        public static double GetTempConverted(TempUnits FromTempUnit, TempUnits ToTempUnit, double FromTempValue)
        {
            switch (ToTempUnit)
            {
                default:
                    return K.ConvertFrom(FromTempUnit, FromTempValue).Value;
                case (TempUnits.C):
                    return C.ConvertFrom(FromTempUnit, FromTempValue).Value;
                case (TempUnits.F):
                    return F.ConvertFrom(FromTempUnit, FromTempValue).Value;
                
            }
        }
    }
}
