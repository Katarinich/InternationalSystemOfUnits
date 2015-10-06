namespace InternationalSystemOfUnits.VolumeUnits
{
    class Liter : Meter3
    {
        public Liter(double value) : base(value)
        {
        }

        public override VolumeUnit ConvertToBase()
        {
            return new Meter3(Value * 0.001);
        }
    }
}
