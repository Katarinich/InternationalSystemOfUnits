using InternationalSystemOfUnits.DensityUnits;
using InternationalSystemOfUnits.ForceUnits;
using InternationalSystemOfUnits.VolumeUnits;

namespace InternationalSystemOfUnits
{
    public abstract class MassUnit : MeasurementUnit
    {
        public static MassUnit operator +(MassUnit left, MassUnit right)
        {
            return left.__DoAddition(right);
        }

        public static MassUnit operator -(MassUnit left, MassUnit right)
        {
            return left.__DoSubstraction(right);
        }

        public static DensityUnit operator /(MassUnit left, VolumeUnit right)
        {
            return new KilogramPerCubicMeter(left.ConvertToBase().Value / right.ConvertToBase().Value);
        }

        public static VolumeUnit  operator /(MassUnit left, DensityUnit  right)
        {
            return new Meter3(left.ConvertToBase().Value / right.Value);
        }

        public static ForceUnit operator *(MassUnit left, AccelerationUnit right)
        {
            return new Newton(left.ConvertToBase().Value * right.Value);
        }

        protected abstract MassUnit __DoSubstraction(MassUnit right);

        protected abstract MassUnit __DoAddition(MassUnit right);

        public abstract MassUnit ConvertToBase();
    }
}
