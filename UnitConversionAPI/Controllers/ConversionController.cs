using Microsoft.AspNetCore.Mvc;
using UnitConversionAPI.Models;

[ApiController]
[Route("api/[controller]")]
public class ConversionController : ControllerBase
{
    private readonly IConversionService _service;

    public ConversionController(
        IConversionService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Convert(ConversionRequest request)
    {
        try
        {
            var result = _service.Convert(request);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(new
            {
                Message = ex.Message
            });
        }
    }
}