using System;
using MeasurementUnits.Units.Mass;
using MeasurementUnits.Units.Length;
using MeasurementUnits.Units.Volume;
using MeasurementUnits.Units.Temp;

namespace MeasurementUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Enter an amount of milligrams to test with.");
            double startValueMass = Convert.ToDouble(Console.In.ReadLine());

            Console.Out.WriteLine("Enter an amount of milliliters to test with.");
            double startValueVol = Convert.ToDouble(Console.In.ReadLine());

            Console.Out.WriteLine("Enter an amount of millimeters to test with.");
            double startValueLen = Convert.ToDouble(Console.In.ReadLine());

            Console.Out.WriteLine("Enter a temperature to test with in Kelvin.");
            double startValueTemp = Convert.ToDouble(Console.In.ReadLine());



            RunMassTests(startValueMass);
            RunVolumeTests(startValueVol);
            RunLengthTests(startValueLen);
            RunTempTests(startValueTemp);
        }


        public static void RunMassTests(double value)
        {
            Console.Out.WriteLine("==================================");
            Console.Out.WriteLine("| Starting Mass Tests...         |");
            Console.Out.WriteLine("----------------------------------");

            Console.Out.WriteLine($"| You Entered: {value}mg         |");

            var _mg = new mg(value);
            var _cg = cg.FromMassUnit(_mg);
            var _dag = dag.FromMassUnit(_mg);
            var _dg = dg.FromMassUnit(_mg);
            var _g = g.FromMassUnit(_mg);
            var _hg = hg.FromMassUnit(_mg);
            var _kg = kg.FromMassUnit(_mg);
            var _lb = lb.FromMassUnit(_mg);
            var _oz = oz.FromMassUnit(_mg);
            var _tm = t_met.FromMassUnit(_mg);
            var _tim = t_imp.FromMassUnit(_mg);
            var _tus = t_us.FromMassUnit(_mg);

            Console.Out.WriteLine("==================================");
            Console.Out.WriteLine($"| Centigrams: {_cg.Value}cg         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Decigrams: {_dg.Value}dg         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Grams: {_g.Value}g         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Dekagrams: {_dag.Value}dag         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Hectograms: {_hg.Value}hg         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Kilograms: {_kg.Value}kg         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Megagrams: {_tm.Value}Mg         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Ounces: {_oz.Value}oz         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Pounds: {_lb.Value}lb         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Imperial Tons: {_tim.Value}t (imp)         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| US Tons: {_tus.Value}t (US)         |");
            Console.Out.WriteLine("==================================");
        }

        public static void RunVolumeTests(double value)
        {
            Console.Out.WriteLine("==================================");
            Console.Out.WriteLine("| Starting Volume Tests...         |");

            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| You Entered: {value}ml         |");

            var _ml = new ml(value);
            var _cl = cl.FromVolumeUnit(_ml);
            var _daL = dl.FromVolumeUnit(_ml);
            var _dl = L.FromVolumeUnit(_ml);
            var _L = daL.FromVolumeUnit(_ml);
            var _hL = hL.FromVolumeUnit(_ml);
            var _kL = kL.FromVolumeUnit(_ml);
            var _flozimp = fl_oz_imp.FromVolumeUnit(_ml);
            var _flozus = fl_oz_us.FromVolumeUnit(_ml);
            var _ptimp = pt_imp.FromVolumeUnit(_ml);
            var _ptus = pt_us.FromVolumeUnit(_ml);
            var _qtimp = qt_imp.FromVolumeUnit(_ml);
            var _qtus = qt_us.FromVolumeUnit(_ml);
            var _galus = gal_us.FromVolumeUnit(_ml);
            var _galimp = gal_imp.FromVolumeUnit(_ml);

            Console.Out.WriteLine("==================================");
            Console.Out.WriteLine($"| Centiliters: {_cl.Value}cl         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Deciliters: {_dl.Value}dl         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Liters: {_L.Value}L         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Dekaliters: {_daL.Value}daL         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Hectoliters: {_hL.Value}hL         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Kiloliters: {_kL.Value}kL         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Fluid Ounces (US): {_flozus.Value}fl oz         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Fluid Ounces (Imp): {_flozimp.Value}fl oz         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Pints (US): {_ptus.Value}pt         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Pints (Imp): {_ptimp.Value}pt         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Quarts (US): {_qtus.Value}qt         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Quarts (Imp): {_qtimp.Value}qt         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Gallons (US): {_galus.Value}Gal         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Gallons (Imp): {_galimp.Value}Gal         |");
            Console.Out.WriteLine("==================================");
        }


        public static void RunLengthTests(double value)
        {
            Console.Out.WriteLine("==================================");
            Console.Out.WriteLine("| Starting Length Tests...         |");

            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| You Entered: {value}mm         |");

            var _mm = new mm(value);
            //var _cm = cm.FromLengthUnit(_mm);
            //var _dam = dam.FromLengthUnit(_mm);
            //var _dm = dm.FromLengthUnit(_mm);
            //var _m = m.FromLengthUnit(_mm);
            //var _hm = hm.FromLengthUnit(_mm);
            //var _km = km.FromLengthUnit(_mm);
            //var _ft = ft.FromLengthUnit(_mm);
            //var _yd = yd.FromLengthUnit(_mm);
            //var _mi = mi.FromLengthUnit(_mm);
            //var _th = th.FromLengthUnit(_mm);
            //var _inch = _in.FromLengthUnit(_mm);
            //var _fur = fur.FromLengthUnit(_mm);

            //var _cm = cm.ConvertFrom(_mm);
            //var _dam = dam.ConvertFrom(_mm);
            //var _dm = dm.ConvertFrom(_mm);
            //var _m = m.ConvertFrom(_mm);
            //var _hm = hm.ConvertFrom(_mm);
            //var _km = km.ConvertFrom(_mm);
            //var _ft = ft.ConvertFrom(_mm);
            //var _yd = yd.ConvertFrom(_mm);
            //var _mi = mi.ConvertFrom(_mm);
            //var _th = th.ConvertFrom(_mm);
            //var _inch = _in.ConvertFrom(_mm);
            //var _fur = fur.ConvertFrom(_mm);

            var _cm = cm.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _dam = dam.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _dm = dm.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _m = m.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _hm = hm.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _km = km.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _ft = ft.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _yd = yd.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _mi = mi.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _th = th.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _inch = _in.ConvertFrom(LengthUnits.mm, _mm.Value);
            var _fur = fur.ConvertFrom(LengthUnits.mm, _mm.Value);




            Console.Out.WriteLine("==================================");
            Console.Out.WriteLine($"| Centimeters: {_cm.Value}cm         |", ConsoleColor.Red);
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Decimeters: {_dm.Value}dm         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Meters: {_m.Value}m         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Dekameters: {_dam.Value}dam         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Hectometers: {_hm.Value}hm         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Kilometers: {_km.Value}km         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Thou: {_th.Value}th         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Inch (Imp): {_inch.Value}in         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Feet (US): {_ft.Value}ft         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Yards (Imp): {_yd.Value}yd         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Mile (US): {_mi.Value}mi         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Furlong (Imp): {_fur.Value}fur         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Coords: ({41.731363},{-111.834969}), ({41.733271},{-111.834902}) to feet       |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Distance: ({LengthConverter.GetLengthFromGPSPoints(41.731363, -111.834969, 41.733271, -111.834902, LengthUnits.ft)}) feet       |");

            Console.Out.WriteLine("==================================");
        }

        public static void RunTempTests(double value)
        {
            Console.Out.WriteLine("==================================");
            Console.Out.WriteLine("| Starting Temp Tests...          |");

            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| You Entered: {value}K         |");

            var _c = C.ConvertFrom(TempUnits.K, value);
            var _f = F.ConvertFrom(TempUnits.K, value);


            Console.Out.WriteLine("==================================");
            Console.Out.WriteLine($"| Celcius: {_c.Value}         |");
            Console.Out.WriteLine("----------------------------------");
            Console.Out.WriteLine($"| Fahrenheit : {_f.Value}         |");
        
            Console.Out.WriteLine("==================================");
        }
    }
}
