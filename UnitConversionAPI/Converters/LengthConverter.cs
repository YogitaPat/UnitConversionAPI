namespace UnitConversionAPI.Converters;

public static class LengthConverter
{
    private static readonly Dictionary<string, double> Units =
        new()
        {
            { "meter", 1 },
            { "kilometer", 1000 },
            { "feet", 0.3048 },
            { "inch", 0.0254 }
        };

    public static double Convert(double value, string fromUnit, string toUnit)
    {
        if (!Units.ContainsKey(fromUnit) ||
            !Units.ContainsKey(toUnit))
        {
            throw new Exception("Unsupported length unit.");
        }

        double valueInMeters = value * Units[fromUnit];
        return valueInMeters / Units[toUnit];
    }
}