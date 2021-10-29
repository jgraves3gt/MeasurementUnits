using MeasurementUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Volume
{
    /// <summary>
    /// Quart (Imperial)
    /// </summary>
    public class qt_imp : IVolume
    {
        public double Value { get; set; }

        public double BaseReference { get { return 1136.5225; } }

        public qt_imp()
        {

        }

        public qt_imp(double value)
        {
            Value = value;
        }



        public static qt_imp FromVolumeUnit<TVolume>(TVolume source) where TVolume : IVolume
        {
            var result = new qt_imp();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }
        public static qt_imp ConvertFrom<TVolume>(TVolume source) where TVolume : IVolume
        {
            var result = new qt_imp();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static qt_imp ConvertFrom(VolumeUnits unit, double value)
        {
            switch (unit)
            {
                default:
                    return ConvertFrom(new ml(value));
                case (VolumeUnits.cl):
                    return ConvertFrom(new cl(value));
                case (VolumeUnits.dl):
                    return ConvertFrom(new dl(value));
                case (VolumeUnits.L):
                    return ConvertFrom(new L(value));
                case (VolumeUnits.daL):
                    return ConvertFrom(new daL(value));
                case (VolumeUnits.hL):
                    return ConvertFrom(new hL(value));
                case (VolumeUnits.kL):
                    return ConvertFrom(new kL(value));
                case (VolumeUnits.fl_oz_us):
                    return ConvertFrom(new fl_oz_us(value));
                case (VolumeUnits.fl_oz_imp):
                    return ConvertFrom(new fl_oz_imp(value));
                case (VolumeUnits.pt_us):
                    return ConvertFrom(new pt_us(value));
                case (VolumeUnits.pt_imp):
                    return ConvertFrom(new pt_imp(value));
                case (VolumeUnits.qt_us):
                    return ConvertFrom(new qt_us(value));
                case (VolumeUnits.qt_imp):
                    return ConvertFrom(new qt_imp(value));
                case (VolumeUnits.gal_us):
                    return ConvertFrom(new gal_us(value));
                case (VolumeUnits.gal_imp):
                    return ConvertFrom(new gal_imp(value));
            }
        }
    }

    /// <summary>
    /// Quart (US)
    /// </summary>
    public class qt_us : IVolume
    {
        public double Value { get; set; }

        public double BaseReference { get { return 946.353; } }

        public qt_us()
        {

        }

        public qt_us(double value)
        {
            Value = value;
        }



        public static qt_us FromVolumeUnit<TVolume>(TVolume source) where TVolume : IVolume
        {
            var result = new qt_us();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }
        public static qt_us ConvertFrom<TVolume>(TVolume source) where TVolume : IVolume
        {
            var result = new qt_us();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static qt_us ConvertFrom(VolumeUnits unit, double value)
        {
            switch (unit)
            {
                default:
                    return ConvertFrom(new ml(value));
                case (VolumeUnits.cl):
                    return ConvertFrom(new cl(value));
                case (VolumeUnits.dl):
                    return ConvertFrom(new dl(value));
                case (VolumeUnits.L):
                    return ConvertFrom(new L(value));
                case (VolumeUnits.daL):
                    return ConvertFrom(new daL(value));
                case (VolumeUnits.hL):
                    return ConvertFrom(new hL(value));
                case (VolumeUnits.kL):
                    return ConvertFrom(new kL(value));
                case (VolumeUnits.fl_oz_us):
                    return ConvertFrom(new fl_oz_us(value));
                case (VolumeUnits.fl_oz_imp):
                    return ConvertFrom(new fl_oz_imp(value));
                case (VolumeUnits.pt_us):
                    return ConvertFrom(new pt_us(value));
                case (VolumeUnits.pt_imp):
                    return ConvertFrom(new pt_imp(value));
                case (VolumeUnits.qt_us):
                    return ConvertFrom(new qt_us(value));
                case (VolumeUnits.qt_imp):
                    return ConvertFrom(new qt_imp(value));
                case (VolumeUnits.gal_us):
                    return ConvertFrom(new gal_us(value));
                case (VolumeUnits.gal_imp):
                    return ConvertFrom(new gal_imp(value));
            }
        }
    }
}
