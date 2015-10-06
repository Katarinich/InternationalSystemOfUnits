using System;
namespace InternationalSystemOfUnits
{
    class Program
    {
        static void Main()
        {
            var a = new Unit(10, LengthUnits.KiloMeter);
            var b = new Unit(100, TimeUnits.Minute);
         //   var d = new Unit("meter/second", "m/s", LengthUnits.Meter / TimeUnits.Second);
            var c = a*b;
            Console.WriteLine(c.Value);
        }
    }
}
