using UnitConversionAPI.Converters;

namespace UnitConversionAPI.Tests;

public class ConversionTests
{
    [Fact]
    public void Meter_To_Feet_Should_Return_Correct_Value()
    {
        // Act
        var result = LengthConverter.Convert(1, "meter", "feet");

        // Assert
        Assert.Equal(3.28084, result, 5);
    }

    [Fact]
    public void Kg_To_Pound_Should_Return_Correct_Value()
    {
        // Act
        var result = WeightConverter.Convert(1, "kg", "pound");

        // Assert
        Assert.Equal(2.20462, result, 5);
    }

    [Fact]
    public void Celsius_To_Fahrenheit_Should_Return_Correct_Value()
    {
        // Act
        var result = TemperatureConverter.Convert(
            0,
            "celsius",
            "fahrenheit");

        // Assert
        Assert.Equal(32, result);
    }
}