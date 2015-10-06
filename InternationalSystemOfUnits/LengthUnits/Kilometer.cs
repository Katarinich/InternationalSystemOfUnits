namespace InternationalSystemOfUnits.LengthUnits
{
    class Kilometer : Meter
    {
        public Kilometer(double value) : base(value)
        {
        }

        public override LengthUnit ConvertToBase()
        {
            return new Meter(Value * 1000);
        }
    }
}
