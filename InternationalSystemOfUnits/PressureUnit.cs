using InternationalSystemOfUnits.ForceUnits;

namespace InternationalSystemOfUnits
{
    public abstract class PressureUnit : MeasurementUnit
    {
        public static PressureUnit operator +(PressureUnit left, PressureUnit right)
        {
            return left.__DoAddition(right);
        }

        public static PressureUnit operator -(PressureUnit left, PressureUnit right)
        {
            return left.__DoSubstraction(right);
        }

        public static ForceUnit operator *(PressureUnit left, SurfaceUnit right)
        {
            return new Newton(left.ConvertToBase().Value * right.Value);
        }

        protected abstract PressureUnit __DoSubstraction(PressureUnit right);

        protected abstract PressureUnit __DoAddition(PressureUnit right);

        public abstract PressureUnit ConvertToBase();
    }
}
