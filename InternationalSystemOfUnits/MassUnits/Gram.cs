namespace InternationalSystemOfUnits.MassUnits
{
    class Gram : Kilogram
    {
        public Gram(double value) : base(value)
        {
        }

        public override MassUnit ConvertToBase()
        {
            return new Kilogram(Value * 1000);
        }
    }
}
