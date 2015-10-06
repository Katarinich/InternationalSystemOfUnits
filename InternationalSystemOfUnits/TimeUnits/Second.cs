namespace InternationalSystemOfUnits.TimeUnits
{
    class Second : TimeUnit
    {
        public Second(double value)
        {
            Value = value;
        }

        protected override TimeUnit __DoSubstraction(TimeUnit right)
        {
            return new Second(ConvertToBase().Value - right.ConvertToBase().Value);
        }

        protected override TimeUnit __DoAddition(TimeUnit right)
        {
            return new Second(ConvertToBase().Value + right.ConvertToBase().Value);
        }

        public override TimeUnit ConvertToBase()
        {
            return new Second(Value);
        }
    }
}
