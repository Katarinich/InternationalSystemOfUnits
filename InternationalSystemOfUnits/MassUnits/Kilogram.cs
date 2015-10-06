namespace InternationalSystemOfUnits.MassUnits
{
    class Kilogram : MassUnit
    {
        public Kilogram(double value)
        {
            Value = value;
        }

        protected override MassUnit __DoSubstraction(MassUnit right)
        {
            return new Kilogram(ConvertToBase().Value - right.ConvertToBase().Value);
        }

        protected override MassUnit __DoAddition(MassUnit right)
        {
            return new Kilogram(ConvertToBase().Value - right.ConvertToBase().Value);
        }

        public override MassUnit ConvertToBase()
        {
            return new Kilogram(Value);
        }
    }
}
