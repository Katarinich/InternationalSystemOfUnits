namespace InternationalSystemOfUnits.TimeUnits
{
    class Hour : Second
    {
        public Hour(double value) : base(value)
        {
            
        }

        public override TimeUnit ConvertToBase()
        {
            return new Second(Value * 3600);
        }
    }
}
