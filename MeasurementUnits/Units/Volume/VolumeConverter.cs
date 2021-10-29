using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Volume
{
    public static class VolumeConverter
    {
        public static double GetVolumeConverted(VolumeUnits FromVolumeUnit, VolumeUnits ToVolumeUnit, double FromVolumeValue)
        {
            switch (ToVolumeUnit)
            {
                default:
                    return ml.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.cl):
                    return cl.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.dl):
                    return dl.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.L):
                    return L.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.daL):
                    return daL.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.hL):
                    return hL.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.kL):
                    return kL.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.fl_oz_us):
                    return fl_oz_us.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.fl_oz_imp):
                    return fl_oz_imp.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.pt_us):
                    return pt_us.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.pt_imp):
                    return pt_imp.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.qt_us):
                    return qt_us.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.qt_imp):
                    return qt_imp.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.gal_us):
                    return gal_us.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
                case (VolumeUnits.gal_imp):
                    return gal_imp.ConvertFrom(FromVolumeUnit, FromVolumeValue).Value;
            }
        }
    }
}
