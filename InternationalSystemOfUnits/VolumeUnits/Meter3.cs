namespace InternationalSystemOfUnits.VolumeUnits
{
    class Meter3 : VolumeUnit
    {
        public Meter3(double value)
        {
            Value = value;
        }

        protected override VolumeUnit __DoSubstraction(VolumeUnit right)
        {
            return new Meter3(ConvertToBase().Value - right.ConvertToBase().Value);
        }

        protected override VolumeUnit __DoAddition(VolumeUnit right)
        {
            return new Meter3(ConvertToBase().Value + right.ConvertToBase().Value);
        }

        public override VolumeUnit ConvertToBase()
        {
            return new Meter3(Value);
        }
    }
}
