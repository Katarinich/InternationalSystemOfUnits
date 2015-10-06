namespace InternationalSystemOfUnits.PressureUnits
{
    class Kilopascal : Pascal
    {
        public Kilopascal(double value) : base(value)
        {
        }

        public override PressureUnit ConvertToBase()
        {
            return new Pascal(Value * 1000);
        }
    }
}
