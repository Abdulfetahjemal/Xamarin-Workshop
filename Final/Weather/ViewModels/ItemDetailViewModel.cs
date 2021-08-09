using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Weather.Models;
using Weather.Services;
using Weather.ViewModels;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    [QueryProperty("CityName", "CityName")]   
    public class ItemDetailViewModel : BaseViewModel
    {
        private City _currentCity = new City();

        public City CurrentCity
        {
            get => _currentCity;
            set => SetProperty(ref _currentCity, value);

        }

        private string _cityName;
       // private string text;
       // private string description;       public string Id { get; set; }

        
         
        public string CityName
        {
            get => _cityName;
            set
            {
                SetProperty(ref _cityName, value);
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string city)
        {
            try
            {
                WeatherService service = DependencyService.Resolve<WeatherService>();
                WeatherData data = await service.GetWeatherForCity(city);
                CurrentCity.CityName = data.name;
                CurrentCity.CurrentTemp = data.main.temp;

            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
