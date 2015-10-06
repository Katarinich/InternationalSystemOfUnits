using InternationalSystemOfUnits.SpeedUnits;
using InternationalSystemOfUnits.TimeUnits;

namespace InternationalSystemOfUnits
{
    public abstract class TimeUnit : MeasurementUnit
    {
        public static TimeUnit operator +(TimeUnit left, TimeUnit right)
        {
            return left.__DoAddition(right);
        }

        public static TimeUnit operator -(TimeUnit left, TimeUnit right)
        {
            return left.__DoSubstraction(right);
        }

        public static TimeUnit operator *(TimeUnit left, TimeUnit right)
        {
            return new Second(left.ConvertToBase().Value * right.ConvertToBase().Value);
        }

        public static SpeedUnit operator *(TimeUnit left, AccelerationUnit right)
        {
            return new MeterPerSecond(left.ConvertToBase().Value * right.Value);
        }

        protected abstract TimeUnit __DoSubstraction(TimeUnit right);

        protected abstract TimeUnit __DoAddition(TimeUnit right);

        public abstract TimeUnit ConvertToBase();
    }
}
