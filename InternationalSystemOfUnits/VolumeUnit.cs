namespace InternationalSystemOfUnits
{
    abstract class VolumeUnit : MeasurementUnit
    {
        public static VolumeUnit operator +(VolumeUnit left, VolumeUnit right)
        {
            return left.__DoAddition(right);
        }

        public static VolumeUnit operator -(VolumeUnit left, VolumeUnit right)
        {
            return left.__DoSubstraction(right);
        }

        protected abstract VolumeUnit __DoSubstraction(VolumeUnit right);

        protected abstract VolumeUnit __DoAddition(VolumeUnit right);

        public abstract VolumeUnit ConvertToBase();
    }
}
