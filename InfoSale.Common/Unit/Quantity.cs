using System;

namespace InfoSale.Common.Unit
{
    /// <summary>
    /// Base class for Quantity
    /// </summary>
    public abstract class Quantity
    {
        public abstract string Label { get; }

        public abstract string ShortLabel { get; }

        public override string ToString() => $"{Label} ({ShortLabel})";

        public string ToString(double value) => $"{value} {ShortLabel}";

        public string ToString(double value, uint digitsAfterDecimal) 
            => $"{value.ToString($"F{digitsAfterDecimal}")} {ShortLabel}";
    }


    public class Liter : Quantity
    {
        public override string Label { get; } = "Liter";
        public override string ShortLabel { get; } = "L";
    }
    public class Meter : Quantity
    {
        public override string Label { get; } = "Meter";
        public override string ShortLabel { get; } = "m";
    }

    public class Kilogram : Quantity
    {
        public override string Label { get; } = "Kilogram";
        public override string ShortLabel { get; } = "kg";
    }
}
