namespace InternationalSystemOfUnits.MassUnits
{
    class Milligram : Gram
    {
        public Milligram(double value) : base(value)
        {
        }

        public override MassUnit ConvertToBase()
        {
            return new Gram(Value / 100);
        }
    }
}
