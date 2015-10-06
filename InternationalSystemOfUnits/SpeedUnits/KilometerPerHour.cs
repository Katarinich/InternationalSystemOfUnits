namespace InternationalSystemOfUnits.SpeedUnits
{
    class KilometerPerHour : MeterPerSecond
    {
        public KilometerPerHour(double value) : base(value)
        {
        }

        public override SpeedUnit ConvertToBase()
        {
            return new MeterPerSecond(Value * 1000 / 3600);
        }
    }
}
