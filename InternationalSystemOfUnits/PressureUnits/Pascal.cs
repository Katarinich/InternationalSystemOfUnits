namespace InternationalSystemOfUnits.PressureUnits
{
    class Pascal : PressureUnit
    {
        public Pascal(double value)
        {
            Value = value;
        }

        protected override PressureUnit __DoSubstraction(PressureUnit right)
        {
            return new Pascal(ConvertToBase().Value - right.ConvertToBase().Value);
        }

        protected override PressureUnit __DoAddition(PressureUnit right)
        {
            return new Pascal(ConvertToBase().Value + right.ConvertToBase().Value);
        }

        public override PressureUnit ConvertToBase()
        {
            return new Pascal(Value);
        }
    }
}
