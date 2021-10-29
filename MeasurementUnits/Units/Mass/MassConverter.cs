using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Mass
{
    public static class MassConverter
    {
        public static double GetMassConverted(MassUnits FromMassUnit, MassUnits ToMassUnit, double FromMassValue)
        {
            switch (ToMassUnit)
            {
                default:
                    return mg.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.cg):
                    return cg.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.dg):
                    return cg.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.g):
                    return g.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.dag):
                    return dag.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.hg):
                    return hg.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.kg):
                    return kg.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.oz):
                    return oz.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.lb):
                    return lb.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.t_us):
                    return t_us.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.t_imp):
                    return t_imp.ConvertFrom(FromMassUnit, FromMassValue).Value;
                case (MassUnits.t_met):
                    return t_met.ConvertFrom(FromMassUnit, FromMassValue).Value;
            }
        }
    }
}
