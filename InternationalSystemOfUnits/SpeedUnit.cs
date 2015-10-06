using InternationalSystemOfUnits.AccelerationUnits;
using InternationalSystemOfUnits.TimeUnits;

namespace InternationalSystemOfUnits
{
    public abstract class SpeedUnit : MeasurementUnit
    {
        public static SpeedUnit operator +(SpeedUnit left, SpeedUnit right)
        {
            return left.__DoAddition(right);
        }

        public static SpeedUnit operator -(SpeedUnit left, SpeedUnit right)
        {
            return left.__DoSubstraction(right);
        }

        public static AccelerationUnit operator /(SpeedUnit left, TimeUnit right)
        {
            return new MetrePerSecondSquared(left.ConvertToBase().Value / right.ConvertToBase().Value);
        }

        public static TimeUnit operator /(SpeedUnit left, AccelerationUnit right)
        {
            return new Second(left.ConvertToBase().Value / right.Value);
        }

        protected abstract SpeedUnit __DoSubstraction(SpeedUnit right);

        protected abstract SpeedUnit __DoAddition(SpeedUnit right);

        public abstract SpeedUnit ConvertToBase();
    }
}
