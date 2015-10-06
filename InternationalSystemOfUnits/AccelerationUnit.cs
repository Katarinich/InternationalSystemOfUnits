using InternationalSystemOfUnits.ForceUnits;

namespace InternationalSystemOfUnits
{
    public abstract class AccelerationUnit : MeasurementUnit
    {
        public static AccelerationUnit operator +(AccelerationUnit left, AccelerationUnit right)
        {
            return left.__DoAddition(right);
        }

        public static AccelerationUnit operator -(AccelerationUnit left, AccelerationUnit right)
        {
            return left.__DoSubstraction(right);
        }

        public static ForceUnit operator /(AccelerationUnit left, TimeUnit right)
        {
            return new Newton(left.Value / right.ConvertToBase().Value);
        }

        protected abstract AccelerationUnit __DoSubstraction(AccelerationUnit right);

        protected abstract AccelerationUnit __DoAddition(AccelerationUnit right);
    }
}
