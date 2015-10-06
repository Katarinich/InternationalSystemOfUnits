namespace InternationalSystemOfUnits.LengthUnits
{
    public class Centimeter : Meter
    {
        public Centimeter(double value) : base(value)
        {
        }

        public override LengthUnit ConvertToBase()
        {
            return new Meter(Value / 100);
        }
    }
}
