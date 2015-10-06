namespace InternationalSystemOfUnits.TimeUnits
{
    class Millisecond : Second
    {
        public Millisecond(double value) : base(value)
        {

        }

        public override TimeUnit ConvertToBase()
        {
            return new Second(Value / 100);
        }
    }
}
