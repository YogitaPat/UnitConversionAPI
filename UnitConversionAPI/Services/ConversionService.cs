using UnitConversionAPI.Converters;
using UnitConversionAPI.Models;

public class ConversionService : IConversionService
{
    public ConversionResponse Convert(ConversionRequest request)
    {
        double result;

        switch (request.Category.ToLower())
        {
            case "length":
                result = LengthConverter.Convert(
                    request.Value,
                    request.FromUnit.ToLower(),
                    request.ToUnit.ToLower());
                break;

            case "weight":
                result = WeightConverter.Convert(
                    request.Value,
                    request.FromUnit.ToLower(),
                    request.ToUnit.ToLower());
                break;

            case "temperature":
                result = TemperatureConverter.Convert(
                    request.Value,
                    request.FromUnit,
                    request.ToUnit);
                break;
                case "volume":
    result = VolumeConverter.Convert(
        request.Value,
        request.FromUnit.ToLower(),
        request.ToUnit.ToLower());
    break;

            default:
                throw new Exception("Unsupported category.");
        }

        return new ConversionResponse
        {
            Category = request.Category,
            OriginalValue = request.Value,
            FromUnit = request.FromUnit,
            ToUnit = request.ToUnit,
            ConvertedValue = result
        };
    }
}