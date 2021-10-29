using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Mass
{
    public enum MassUnits
    {
        [Display(Name = "Milligrams")]
        mg,
        [Display(Name = "Centigrams")]
        cg,
        [Display(Name = "Decigrams")]
        dg,
        [Display(Name = "Grams")]
        g,
        [Display(Name = "Dekagrams")]
        dag,
        [Display(Name = "Hectograms")]
        hg,
        [Display(Name = "Kilograms")]
        kg,
        [Display(Name = "Ounces")]
        oz,
        [Display(Name = "Pounds")]
        lb,
        [Display(Name = "Ton (US)")]
        t_us, 
        [Display(Name = "Tonne (Metric)")]
        t_met,
        [Display(Name = "Ton (Imperial)")]
        t_imp
    }
}
