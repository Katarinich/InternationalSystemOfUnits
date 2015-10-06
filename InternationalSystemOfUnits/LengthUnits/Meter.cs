namespace InternationalSystemOfUnits.LengthUnits
{
    public class Meter : LengthUnit
    {
        public Meter(double value)
        {
            Value = value;
        }

        protected override LengthUnit __DoSubstraction(LengthUnit right)
        {
            return new Meter(ConvertToBase().Value - right.ConvertToBase().Value);
        }

        protected override LengthUnit __DoAddition(LengthUnit right)
        {
            return new Meter(ConvertToBase().Value + right.ConvertToBase().Value);
        }

        public override LengthUnit ConvertToBase()
        {
            return new Meter(Value);
        }
    }
}
