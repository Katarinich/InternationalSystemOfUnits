namespace InternationalSystemOfUnits
{
    //public class Unit
    //{
    //    public string Name { get; }
    //    public string Symbol { get; }
    //    public double Value { get; }
    //    public UnitType Type { get; }
    //    public Unit BaseUnit { get; }

    //    public Unit(double value, string name, UnitType type, string symbol)
    //    {
    //        Name = name;
    //        Value = value;
    //        Type = type;
    //        Symbol = symbol;
    //    }

    //    public Unit(double value, Unit siUnit)
    //    {
    //        Value = value;
    //        Name = siUnit.Name;
    //        Type = siUnit.Type;
    //        Symbol = siUnit.Symbol;
    //        BaseUnit = siUnit.BaseUnit;
    //    }

    //    public Unit(string name, string symbol, Unit baseUnit)
    //    {
    //        Name = name;
    //        Symbol = symbol;
    //        Type = baseUnit.Type;
    //        BaseUnit = baseUnit;
    //    }

    //    public Unit(string name, string symbol, UnitType type)
    //    {
    //        Name = name;
    //        Symbol = symbol;
    //        Type = type;
    //    }

    //    public static Unit operator *(Unit left, Unit right)
    //    {
    //        var baseLeft = ConvertToBase(left);
    //        var baseRight = ConvertToBase(right);

    //        return new Unit(baseLeft.Value * baseRight.Value, $"({baseLeft.Name}*{baseRight.Name})", GetUnitType(baseLeft.Type, baseRight.Type),
    //            baseLeft.Symbol + "*" + baseRight.Symbol);
    //    }

    //    public static Unit operator *(Unit left, double right)
    //    {
    //        return new Unit(left.Value * right, left.Name, left.Type, left.Symbol);
    //    }

    //    public static Unit operator /(Unit left, Unit right)
    //    {
    //        var baseLeft = ConvertToBase(left);
    //        var baseRight = ConvertToBase(right);

    //        return new Unit(baseLeft.Value / baseRight.Value, $"({baseLeft.Name}/{baseRight.Name})", GetUnitType(baseLeft.Type, baseRight.Type),
    //            baseLeft.Symbol + "/" + baseRight.Symbol);
    //    }

    //    public static Unit operator +(Unit left, Unit right)
    //    {
    //        if (left.Type != right.Type) return null;

    //        var baseLeft = ConvertToBase(left);
    //        var baseRight = ConvertToBase(right);
    //        return new Unit(baseLeft.Value + baseRight.Value, $"({baseRight.Name})", baseLeft.Type, baseLeft.Symbol);
    //    }

    //    public static Unit operator -(Unit left, Unit right)
    //    {
    //        if (left.Type != right.Type) return null;

    //        var baseLeft = ConvertToBase(left);
    //        var baseRight = ConvertToBase(right);
    //        return new Unit(baseLeft.Value - baseRight.Value, $"({baseRight.Name})", baseLeft.Type, baseLeft.Symbol);
    //    }

    //    private static UnitType GetUnitType(UnitType type, UnitType unitType)
    //    {
    //        return new UnitType();
    //    }

    //    private static Unit ConvertToBase(Unit unit)
    //    {
    //        return unit.BaseUnit == null ? unit : new Unit(unit.Value * unit.Factor, unit.BaseUnit);
    //    }
    //}
}
