namespace InternationalSystemOfUnits.PressureUnits
{
    class Atmosphere : Pascal
    {
        public Atmosphere(double value) : base(value)
        {
        }

        public override PressureUnit ConvertToBase()
        {
            return new Pascal(Value * 101325.0);
        }
    }
}
