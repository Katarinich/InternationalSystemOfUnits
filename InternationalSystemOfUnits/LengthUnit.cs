namespace InternationalSystemOfUnits
{
    public abstract class LengthUnit : MeasurementUnit
    {
        public static LengthUnit operator +(LengthUnit left, LengthUnit right)
        {
            return left.__DoAddition(right);
        }

        public static LengthUnit operator -(LengthUnit left, LengthUnit right)
        {
            return left.__DoSubstraction(right);
        }

        protected abstract LengthUnit __DoSubstraction(LengthUnit right);

        protected abstract LengthUnit __DoAddition(LengthUnit right);

        public abstract LengthUnit ConvertToBase();
    }
}
