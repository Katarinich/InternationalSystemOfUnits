namespace InternationalSystemOfUnits.LengthUnits
{
    class Millimeter : Meter
    {
        public Millimeter(double value) : base(value)
        {
        }

        public override LengthUnit ConvertToBase()
        {
            return new Meter(Value / 1000);
        }
    }
}
