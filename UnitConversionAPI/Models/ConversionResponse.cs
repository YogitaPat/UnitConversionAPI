namespace UnitConversionAPI.Models;

public class ConversionResponse
{
     public string Category { get; set; }

    public double OriginalValue { get; set; }

    public string FromUnit { get; set; }

    public string ToUnit { get; set; }

    public double ConvertedValue { get; set; }
}