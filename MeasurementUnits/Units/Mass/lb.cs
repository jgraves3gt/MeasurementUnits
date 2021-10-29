using MeasurementUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Mass
{
    /// <summary>
    /// Pounds
    /// </summary>
    public class lb : IMass
    {
        public double Value { get; set; }

        public double BaseReference { get { return 453592; } }

        public lb()
        {

        }

        public lb(double value)
        {
            Value = value;
        }



        public static lb FromMassUnit<TMass>(TMass source) where TMass : IMass
        {
            var result = new lb();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static lb ConvertFrom<TMass>(TMass source) where TMass : IMass
        {
            var result = new lb();
            var baseValue = source.Value * source.BaseReference;
            result.Value = baseValue / result.BaseReference;
            return result;
        }

        public static lb ConvertFrom(MassUnits unit, double value)
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
}
