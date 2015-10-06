using InternationalSystemOfUnits.PressureUnits;
using InternationalSystemOfUnits.SurfaceUnits;

namespace InternationalSystemOfUnits
{
    abstract class ForceUnit : MeasurementUnit
    {
        public static ForceUnit operator +(ForceUnit left, ForceUnit right)
        {
            return left.__DoAddition(right);
        }

        public static ForceUnit operator -(ForceUnit left, ForceUnit right)
        {
            return left.__DoSubstraction(right);
        }

        public static PressureUnit operator /(ForceUnit left, SurfaceUnit right)
        {
            return new Pascal(left.Value / right.Value);
        }

        public static SurfaceUnit operator /(ForceUnit left, PressureUnit right)
        {
            return new Metre2(left.Value / right.Value);
        }

        protected abstract ForceUnit __DoSubstraction(ForceUnit right);

        protected abstract ForceUnit __DoAddition(ForceUnit right);
    }
}
