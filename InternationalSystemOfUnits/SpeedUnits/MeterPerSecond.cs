namespace InternationalSystemOfUnits.SpeedUnits
{
    class MeterPerSecond : SpeedUnit
    {
        public MeterPerSecond(double value)
        {
            Value = value;
        }

        protected override SpeedUnit __DoSubstraction(SpeedUnit right)
        {
            return new MeterPerSecond(ConvertToBase().Value - right.ConvertToBase().Value);
        }

        protected override SpeedUnit __DoAddition(SpeedUnit right)
        {
            return new MeterPerSecond(ConvertToBase().Value + right.ConvertToBase().Value);
        }

        public override SpeedUnit ConvertToBase()
        {
            return new MeterPerSecond(Value);
        }
    }
}
