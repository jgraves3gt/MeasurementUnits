# MeasurementUnits
A .net library to convert common units of measure including Mass, Volume and Length.

***Please note that at this time there is no way to allow conversions between the measurement types (ie. Cannot convert a Mass Unit to Length)*** 

## Uses
The following example converts 3.875 kilometers to miles by creating a mile object then calling the `FromLengthUnit()` method that is a part of each length unit class


```
var _km = new km(3.875);

var _mi = mi.FromLengthUnit(_km);

Console.Out.WriteLine($"3.875 kilometers converted to miles equals {_mi.Value}");
```

You can also convert a value directly without instantiating the starting value type object by calling the `ConvertFrom()` method. 
It takes a `LengthUnits` enum value, and the starting value as parameters:


```
var _mi = mi.ConvertFrom(LengthUnits.km, 3.875);

Console.Out.WriteLine($"3.875 kilometers converted to miles equals {_mi.Value}");
```

## The following tables show the available unit types

### Length Units

| Class Name  | Unit Name     |
| :---        |          ---: |
| cm          | centimeters   |
| dm          | decimeters    |
| m           | meters        |
| dam         | dekameters    |
| hm          | hectometers   |
| km          | kilometers    |
| thou        | thou          |
| _in         | inches        |
| ft          | feet          |
| yd          | yards         |
| mi          | miles         |
| fur         | furlongs      |

Length Units can now be determined by providing GeoCoordinates (Latitude and Longitude).
Simply provide the lat1, lon1, lat2, lon2, and desired result unit type and the distance will be returned as a `double`.
```
var distanceInFeet = LengthConverter.GetLengthFromGPSPoints(41.731363, -111.834969, 41.733271, -111.834902, LengthUnits.ft);
```


### Mass Units

| Class Name |      Unit Name |
| :--------- | -------------: |
| mg         |     milligrams |
| cg         |     centigrams |
| dg         |      decigrams |
| g          |          grams |
| dag        |      dekagrams |
| hg         |     hectograms |
| kg         |      kilograms |
| oz         |         ounces |
| lb         |         pounds |
| t_us       |       ton (US) |
| t_met      | tonne (metric) |
| t_imp      | ton (imperial) |


### Volume Units

| Class Name |               Unit Name |
| :--------- | ----------------------: |
| ml         |             milliliters |
| cl         |             centiliters |
| dl         |              deciliters |
| L          |                  liters |
| daL        |              dekaliters |
| hL         |             hectoliters |
| kL         |              kiloliters |
| fl_oz_us   |       fluid ounces (US) |
| fl_oz_imp  | fluid ounces (imperial) |
| pt_us      |              pints (US) |
| pt_imp     |        pints (imperial) |
| qt_us      |             quarts (US) |
| qt_imp     |       quarts (imperial) |
| gal_us     |            gallons (US) |
| gal_imp    |      gallons (imperial) |


### Temperature Units

| Class Name |               Unit Name |
| :--------- | ----------------------: |
| K          |                  Kelvin |
| C          |                 Celcius |
| F          |              Fahrenheit |

Since temperatures don't convert the same way distances do (ie. temperatures aren't mere ratios of each other like distances are and 0 is not always 0 across the board), there isn't a `FromTempUnit()` method. Instead use the `ConvertFrom()` method that takes a start value and a start unit enum. Or use the `TempConverter.GetTempConverted` static method.
