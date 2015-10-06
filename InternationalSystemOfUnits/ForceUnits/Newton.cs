namespace InternationalSystemOfUnits.ForceUnits
{
    class Newton : ForceUnit
    {
        public Newton(double value)
        {
            Value = value;
        }

        protected override ForceUnit __DoSubstraction(ForceUnit right)
        {
            return new Newton(Value - right.Value);
        }

        protected override ForceUnit __DoAddition(ForceUnit right)
        {
            return new Newton(Value + right.Value);
        }
    }
}
