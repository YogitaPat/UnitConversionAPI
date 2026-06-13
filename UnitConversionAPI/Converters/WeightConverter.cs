namespace UnitConversionAPI.Converters;

public static class WeightConverter
{
    private static readonly Dictionary<string, double> Units =
        new()
        {
            { "kg", 1 },
            { "gram", 0.001 },
            { "pound", 0.453592 }
        };

    public static double Convert(double value, string fromUnit, string toUnit)
    {
        if (!Units.ContainsKey(fromUnit) ||
            !Units.ContainsKey(toUnit))
        {
            throw new Exception("Unsupported weight unit.");
        }

        double valueInKg = value * Units[fromUnit];
        return valueInKg / Units[toUnit];
    }
}