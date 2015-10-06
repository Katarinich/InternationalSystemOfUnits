namespace InternationalSystemOfUnits.DensityUnits
{
    class KilogramPerCubicMeter : DensityUnit
    {
        public KilogramPerCubicMeter(double value)
        {
            Value = value;
        }

        protected override DensityUnit __DoSubstraction(DensityUnit right)
        {
            return new KilogramPerCubicMeter(Value - right.Value);
        }

        protected override DensityUnit __DoAddition(DensityUnit right)
        {
            return new KilogramPerCubicMeter(Value + right.Value);
        }
    }
}
