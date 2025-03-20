using DeliveryOrdersWebApi.Controllers;
using LES_USER_ADMINISTRATION_LIB;
using LES_USER_ADMINISTRATION_LIB.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DeliveryOrdersWebApi
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }


    
}