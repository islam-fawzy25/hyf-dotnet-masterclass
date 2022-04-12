using Microsoft.AspNetCore.Mvc;
using homework.Models;

namespace homework.Controllers;

[ApiController]
[Route("[controller]")]
public class ConverterController : ControllerBase
{
    [HttpGet("GallonsToLitres")]
    public double GallonsToLitres(int liters)
    {
        return liters * 3.785412;
    }
    [HttpGet("ConvertMiles")]
    public Distance ConvertMiles(int miles)
    {
        return new Distance() { Miles = miles, Kilometers = (miles * 1.609) };
    }
}



