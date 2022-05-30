using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UserManagmentAPI.Fake;

namespace UserManagmentAPI.Controllers
{
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private List<WeatherForecast> _weatherForecasts = FakeData.GetWeatherForecasts(200);
        [HttpGet]
        public List<WeatherForecast> Get()
        {
            return _weatherForecasts;
        }
        [HttpGet("{id}")]
        public WeatherForecast Get(int id)
        {
            var weatherForecast = _weatherForecasts.FirstOrDefault(x => x.Id == id);
            return weatherForecast;
        }
        [HttpPost]
        public WeatherForecast Post([FromBody] WeatherForecast weatherForecast)
        {
            _weatherForecasts.Add(weatherForecast);
            return weatherForecast;
        }
        [HttpPut]
        public WeatherForecast Put([FromBody] WeatherForecast weatherForecast)
        {
            var editWeatherforecast = _weatherForecasts.FirstOrDefault(x => x.Id == weatherForecast.Id);
            editWeatherforecast.FirstName = weatherForecast.FirstName;
            editWeatherforecast.LastName = weatherForecast.LastName;
            editWeatherforecast.Adress = weatherForecast.Adress;


            
            return weatherForecast;
        }
        [HttpDelete]
        public void Delete(int id)
        {

            var moveWeatherforecast = _weatherForecasts.FirstOrDefault(x => x.Id == id);
            _weatherForecasts.Remove(moveWeatherforecast);
            
            
            
        }
    }
}