namespace UnitConversionAPI.Converters;

public static class VolumeConverter
{
    private static readonly Dictionary<string, double> Units =
        new()
        {
            { "liter", 1 },
            { "milliliter", 0.001 },
            { "gallon", 3.78541 }
        };

    public static double Convert(double value, string fromUnit, string toUnit)
    {
        if (!Units.ContainsKey(fromUnit) ||
            !Units.ContainsKey(toUnit))
        {
            throw new Exception("Unsupported volume unit.");
        }

        double valueInLiters = value * Units[fromUnit];
        return valueInLiters / Units[toUnit];
    }
}