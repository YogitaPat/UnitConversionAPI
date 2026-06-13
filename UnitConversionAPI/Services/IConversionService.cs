using UnitConversionAPI.Models;

public interface IConversionService
{
    ConversionResponse Convert(ConversionRequest request);
}