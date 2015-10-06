namespace InternationalSystemOfUnits.PressureUnits
{
    class Bar : Pascal
    {
        public Bar(double value) : base(value)
        {
        }

        public override PressureUnit ConvertToBase()
        {
            return new Pascal(Value * 100000);
        }
    }
}
