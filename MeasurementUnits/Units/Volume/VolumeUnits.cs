using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Volume
{
    public enum VolumeUnits
    {
        [Display(Name = "Milliliters")]
        ml,
        [Display(Name = "Centiliters")] 
        cl,
        [Display(Name = "Deciliters")]
        dl,
        [Display(Name = "Liters")]
        L,
        [Display(Name = "Dekaliters")]
        daL,
        [Display(Name = "Hectoliters")]
        hL,
        [Display(Name = "Kiloliters")]
        kL,
        [Display(Name = "Fluid Ounces (US)")]
        fl_oz_us,
        [Display(Name = "Fluid Ounces (Imperial)")]
        fl_oz_imp,
        [Display(Name = "Pints (US)")]
        pt_us,
        [Display(Name = "Pints (Imperial)")]
        pt_imp,
        [Display(Name = "Quarts (US)")]
        qt_us,
        [Display(Name = "Quarts (Imperial)")]
        qt_imp,
        [Display(Name = "Gallons (US)")]
        gal_us,
        [Display(Name = "Gallons (Imperial)")]
        gal_imp,
    }
}
