namespace InternationalSystemOfUnits.MassUnits
{
    class Ton : Gram
    {
        public Ton(double value) : base(value)
        {
        }

        public override MassUnit ConvertToBase()
        {
            return new Gram(Value * 1000000);
        }
    }
}
