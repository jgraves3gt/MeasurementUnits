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
        private const double twoPi = 2.0 * Math.PI;
        private const double totalDegrees = 360.0;
        private const double degreesToRadians = Math.PI / 180.0;
        private const double meanEarthRadiusInKilometers = 6371.0;
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

        public static double GetLengthFromGPSPoints(double lat1, double lon1, double lat2, double lon2, LengthUnits ToUnits)
        {
            var length = CoordinatesToKilometers(lat1, lon1, lat2, lon2);

            return GetLengthConverted(LengthUnits.km, ToUnits, length);
        }

        private static double CoordinatesToKilometers(double lat1, double lon1, double lat2, double lon2)
        {
            if (lat1 == lat2 && lon1 == lon2)
                return 0;

            var dLat = DegreesToRadians(lat2 - lat1);
            var dLon = DegreesToRadians(lon2 - lon1);

            lat1 = DegreesToRadians(lat1);
            lat2 = DegreesToRadians(lat2);

            var dLat2 = Math.Sin(dLat / 2) * Math.Sin(dLat / 2);
            var dLon2 = Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            var a = dLat2 + (dLon2 * Math.Cos(lat1) * Math.Cos(lat2));
            var c = 2 * Math.Asin(Math.Sqrt(a));

            return meanEarthRadiusInKilometers * c;
        }

        private static double DegreesToRadians(double degrees) =>
            degrees * degreesToRadians;

        private static double RadiansToDegrees(double radians) =>
            radians / degreesToRadians;
    }
}
