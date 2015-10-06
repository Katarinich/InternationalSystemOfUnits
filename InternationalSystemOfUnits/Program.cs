using InternationalSystemOfUnits.LengthUnits;
using InternationalSystemOfUnits.ForceUnits;
using InternationalSystemOfUnits.MassUnits;
using InternationalSystemOfUnits.SurfaceUnits;
using InternationalSystemOfUnits.PressureUnits;
using InternationalSystemOfUnits.VolumeUnits;
using InternationalSystemOfUnits.SpeedUnits;
using InternationalSystemOfUnits.TimeUnits;

namespace InternationalSystemOfUnits
{
    class Program
    {
        static void Main()
        {
            //давление
            var F = new Newton(5);
            var S = new Metre2(50);
            var P = F / S;

            //работает в разных вариантах
            F = (Newton) (P*S);
            F = (Newton) (S*P);
            S = (Metre2) (F/P);

            //плотность
            var m = new Kilogram(10);
            var V = new Meter3(5);
            var p = m/V;

            //ускорение
            var U = new MeterPerSecond(10);
            var t1 = new Second(20);
            var t2 = new Second(10);
            var a = U/(t1*t2);
        }
    }
}
