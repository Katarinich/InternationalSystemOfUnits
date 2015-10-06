namespace InternationalSystemOfUnits.SurfaceUnits
{
    class Metre2 : SurfaceUnit
    {
        public Metre2(double value)
        {
            Value = value;
        }

        protected override SurfaceUnit __DoSubstraction(SurfaceUnit right)
        {
            return new Metre2(Value - right.Value);
        }

        protected override SurfaceUnit __DoAddition(SurfaceUnit right)
        {
            return new Metre2(Value + right.Value);
        }
    }
}
