using InternationalSystemOfUnits.ForceUnits;

namespace InternationalSystemOfUnits
{
    public abstract class SurfaceUnit : MeasurementUnit
    {
        public static SurfaceUnit operator +(SurfaceUnit left, SurfaceUnit right)
        {
            return left.__DoAddition(right);
        }

        public static SurfaceUnit operator -(SurfaceUnit left, SurfaceUnit right)
        {
            return left.__DoSubstraction(right);
        }

        public static ForceUnit operator *(SurfaceUnit left, PressureUnit right)
        {
            return new Newton(left.Value * right.ConvertToBase().Value);
        }

        protected abstract SurfaceUnit __DoSubstraction(SurfaceUnit right);

        protected abstract SurfaceUnit __DoAddition(SurfaceUnit right);
    }
}
