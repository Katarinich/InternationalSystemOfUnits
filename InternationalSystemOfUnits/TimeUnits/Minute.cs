namespace InternationalSystemOfUnits.TimeUnits
{
    class Minute : Second
    {
        public Minute(double value) : base(value)
        {
        }

        public override TimeUnit ConvertToBase()
        {
            return new Second(Value / 60);
        }
    }
}
