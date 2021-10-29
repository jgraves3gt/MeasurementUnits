using MeasurementUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Mass
{
    /// <summary>
    /// Megagrams or Metric Tons
    /// </summary>
    public class t_met : IMass
    {
        public double Value { get; set; }

        public double BaseReference { get { return 1000000000; } }

        public t_met()
        {

        }

        public t_met(double value)
        {
            Value = value;
        }



        public static t_met FromMassUnit<TMass>(TMass source) where TMass : IMass
        {
            var result = new t_met();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static t_met ConvertFrom<TMass>(TMass source) where TMass : IMass
        {
            var result = new t_met();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static t_met ConvertFrom(MassUnits unit, double value)
        {
            switch (unit)
            {
                default:
                    return ConvertFrom(new mg(value));
                case (MassUnits.cg):
                    return ConvertFrom(new cg(value));
                case (MassUnits.dg):
                    return ConvertFrom(new dg(value));
                case (MassUnits.g):
                    return ConvertFrom(new g(value));
                case (MassUnits.dag):
                    return ConvertFrom(new dag(value));
                case (MassUnits.hg):
                    return ConvertFrom(new hg(value));
                case (MassUnits.kg):
                    return ConvertFrom(new kg(value));
                case (MassUnits.oz):
                    return ConvertFrom(new oz(value));
                case (MassUnits.lb):
                    return ConvertFrom(new lb(value));
                case (MassUnits.t_us):
                    return ConvertFrom(new t_us(value));
                case (MassUnits.t_imp):
                    return ConvertFrom(new t_imp(value));
                case (MassUnits.t_met):
                    return ConvertFrom(new t_met(value));
            }
        }
    }

    /// <summary>
    /// Tons (Imperial)
    /// </summary>
    public class t_imp : IMass
    {
        public double Value { get; set; }

        public double BaseReference { get { return 1016050000; } }

        public t_imp()
        {

        }

        public t_imp(double value)
        {
            Value = value;
        }



        public static t_imp FromMassUnit<TMass>(TMass source) where TMass : IMass
        {
            var result = new t_imp();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static t_imp ConvertFrom<TMass>(TMass source) where TMass : IMass
        {
            var result = new t_imp();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static t_imp ConvertFrom(MassUnits unit, double value)
        {
            switch (unit)
            {
                default:
                    return ConvertFrom(new mg(value));
                case (MassUnits.cg):
                    return ConvertFrom(new cg(value));
                case (MassUnits.dg):
                    return ConvertFrom(new dg(value));
                case (MassUnits.g):
                    return ConvertFrom(new g(value));
                case (MassUnits.dag):
                    return ConvertFrom(new dag(value));
                case (MassUnits.hg):
                    return ConvertFrom(new hg(value));
                case (MassUnits.kg):
                    return ConvertFrom(new kg(value));
                case (MassUnits.oz):
                    return ConvertFrom(new oz(value));
                case (MassUnits.lb):
                    return ConvertFrom(new lb(value));
                case (MassUnits.t_us):
                    return ConvertFrom(new t_us(value));
                case (MassUnits.t_met):
                    return ConvertFrom(new t_met(value));
            }
        }
    }

    /// <summary>
    /// Tons (US)
    /// </summary>
    public class t_us : IMass
    {
        public double Value { get; set; }

        public double BaseReference { get { return 907184000; } }

        public t_us()
        {

        }

        public t_us(double value)
        {
            Value = value;
        }



        public static t_us FromMassUnit<TMass>(TMass source) where TMass : IMass
        {
            var result = new t_us();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static t_us ConvertFrom<TMass>(TMass source) where TMass : IMass
        {
            var result = new t_us();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static t_us ConvertFrom(MassUnits unit, double value)
        {
            switch (unit)
            {
                default:
                    return ConvertFrom(new mg(value));
                case (MassUnits.cg):
                    return ConvertFrom(new cg(value));
                case (MassUnits.dg):
                    return ConvertFrom(new dg(value));
                case (MassUnits.g):
                    return ConvertFrom(new g(value));
                case (MassUnits.dag):
                    return ConvertFrom(new dag(value));
                case (MassUnits.hg):
                    return ConvertFrom(new hg(value));
                case (MassUnits.kg):
                    return ConvertFrom(new kg(value));
                case (MassUnits.oz):
                    return ConvertFrom(new oz(value));
                case (MassUnits.lb):
                    return ConvertFrom(new lb(value));
                case (MassUnits.t_us):
                    return ConvertFrom(new t_us(value));
                case (MassUnits.t_met):
                    return ConvertFrom(new t_met(value));
            }
        }
    }
}
