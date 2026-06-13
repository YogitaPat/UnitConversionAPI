namespace UnitConversionAPI.Converters;

public static class TemperatureConverter
{
    public static double Convert(double value, string fromUnit, string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();

        if (fromUnit == "celsius" && toUnit == "fahrenheit")
            return (value * 9 / 5) + 32;

        if (fromUnit == "fahrenheit" && toUnit == "celsius")
            return (value - 32) * 5 / 9;

        if (fromUnit == "celsius" && toUnit == "kelvin")
            return value + 273.15;

        if (fromUnit == "kelvin" && toUnit == "celsius")
            return value - 273.15;

        throw new Exception("Unsupported temperature unit.");
    }
}