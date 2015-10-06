using InternationalSystemOfUnits.MassUnits;

namespace InternationalSystemOfUnits
{
    abstract class DensityUnit : MeasurementUnit
    {
        public static DensityUnit operator +(DensityUnit left, DensityUnit right)
        {
            return left.__DoAddition(right);
        }

        public static DensityUnit operator -(DensityUnit left, DensityUnit right)
        {
            return left.__DoSubstraction(right);
        }

        public static MassUnit operator *(DensityUnit left, VolumeUnit right)
        {
            return new Kilogram(left.Value * right.ConvertToBase().Value);
        }

        protected abstract DensityUnit __DoSubstraction(DensityUnit right);

        protected abstract DensityUnit __DoAddition(DensityUnit right);
    }
}
