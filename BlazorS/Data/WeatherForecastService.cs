using System;
using System.Linq;
using System.Threading.Tasks;
using VertragsLibrary;

namespace BlazorS.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };



        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            Vertrag v1 = new Vertrag();
            Versicherungsnehmer VN = new Versicherungsnehmer();
            VN.Nachname = "Schweizer";
      

            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 7).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                Name= VN.Nachname
            }).ToArray());
        }
    }
}
