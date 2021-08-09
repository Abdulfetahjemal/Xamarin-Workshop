using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Weather.Models;

namespace Weather.Services
{
    interface IWeatherService
    {
        Task<WeatherData> GetWeatherForCity(string city);
    }
    class WeatherService : IWeatherService
    {
        // private List<WeatherData> data { get; set; }
        private const string WeatherApiKey = "457edc63371a5b8faa754d65c7d3e392";
        private const string Units = "metric";
        private const string reqUrl = "https://api.openweathermap.org/data/2.5/weather";
        public async Task<WeatherData> GetWeatherForCity(string city)
        {
            Console.WriteLine("Working Serive");
            string req = $"{reqUrl}?q={city}&units={Units}&appid={WeatherApiKey}";
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(req);
            var data = JsonConvert.DeserializeObject<WeatherData>(response);
            return data;
        }
    }
}
