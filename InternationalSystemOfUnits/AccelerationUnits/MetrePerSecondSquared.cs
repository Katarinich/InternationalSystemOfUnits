namespace InternationalSystemOfUnits.AccelerationUnits
{
    class MetrePerSecondSquared : AccelerationUnit
    {
        public MetrePerSecondSquared(double value)
        {
            Value = value;
        }

        protected override AccelerationUnit __DoSubstraction(AccelerationUnit right)
        {
            return new MetrePerSecondSquared(Value - right.Value);
        }

        protected override AccelerationUnit __DoAddition(AccelerationUnit right)
        {
            return new MetrePerSecondSquared(Value + right.Value);
        }
    }
}
