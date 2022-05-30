using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Bogus;

namespace UserManagmentAPI.Fake
{
    public static class FakeData
    {
        private static List<WeatherForecast> _weatherForecasts;

        

        public static List<WeatherForecast> GetWeatherForecasts(int number)
        {
            _weatherForecasts = new Faker<WeatherForecast>()
                .RuleFor(w => w.Id, f => f.IndexFaker)
                .RuleFor(w => w.FirstName, f => f.Name.FirstName())
                .RuleFor(w => w.LastName, f => f.Name.LastName())
                .RuleFor(w => w.Adress, f => f.Address.FullAddress()).Generate(number);

            return _weatherForecasts;
                  
                
        }


    }
}
