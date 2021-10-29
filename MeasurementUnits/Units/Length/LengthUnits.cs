using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUnits.Units.Length
{
    public enum LengthUnits
    {
        [Display(Name = "Millimeters")]
        mm,
        [Display(Name = "Centimeters")]
        cm,
        [Display(Name = "Decimeters")]
        dm,
        [Display(Name = "Meters")]
        m,
        [Display(Name = "Dekameters")]
        dam,
        [Display(Name = "Hectometers")]
        hm,
        [Display(Name = "Kilometers")]
        km,
        [Display(Name = "Thou")]
        th,
        [Display(Name = "Inches")]
        _in,
        [Display(Name = "Feet")]
        ft,
        [Display(Name = "Yards")]
        yd,
        [Display(Name = "Furlongs")]
        fur,
        [Display(Name = "Miles")]
        mi
    }
}
