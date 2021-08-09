using System;
using System.Collections.Generic;
using System.Windows.Input;
using Newtonsoft.Json;
using Weather.Models;
using Weather.Services;
using Weather.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class City : BaseViewModel
    {
        public string CountryName { get; set; }
        private string _cityName;
        public string CityName
        {

            get => _cityName;
            set => SetProperty(ref _cityName, value);
        }
        //  

        private double _currentTemp;
        public double CurrentTemp
        {

            get => _currentTemp;
            set => SetProperty(ref _currentTemp, value);
        }
        //  public double CurrentTemp { get; set; }
        public string ImageUrl { get; set; }
    }

    public class CityListViewModel : BaseViewModel
    {
        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => SetProperty(ref _isRefreshing, value);
        }

        private City _SelectedCity = new City()
        {
            CityName = "A.A",
            CountryName = "Ethiopia",
            CurrentTemp = 20,
            ImageUrl = "moon.png"

        };
        public City SelectedCity
        {
            get => _SelectedCity;
            set => SetProperty(ref _SelectedCity, value);
        }

        public List<City> Cities { get; set; }

        public CityListViewModel()
        {
            Cities = new List<City>()
            {
                new City()
                {
                    CityName = "Addis Ababa",
                    CountryName = "Ethiopia",
                    CurrentTemp = 20,
                    ImageUrl = "moon.png"

                },
                new City()
                {
                    CityName = "Dire Dawa",
                    CountryName = "Ethiopia",
                    CurrentTemp = 18,
                    ImageUrl = "rain.png"

                },
                new City()
                {
                    CityName = "Adama",
                    CountryName = "Ethiopia",
                    CurrentTemp = 18,
                    ImageUrl = "full_sun.png"

                },new City()
                {
                    CityName = "Gondar",
                    CountryName = "Ethiopia",
                    CurrentTemp = 20,
                    ImageUrl = "moon.png"

                }
            };


            Title = "About";

            RefreshExecuteCommand = new Command(RefereshExecute);
            GetCityTempCommand = new Command(async () =>
                {

                    NavigationService service = DependencyService.Resolve<NavigationService>();
                   await service.Navigation(SelectedCity.CityName);
                    //  WeatherData data = await service.GetWeatherForCity("Addis Ababa");
                    // Console.WriteLine("Response data" + data.name);
                    //Console.WriteLine("Response data" + data.main.temp);



                    // Console.WriteLine("Clicked" + SelectedCity.CityName);
                    // var data = JsonConvert.SerializeObject(SelectedCity);
                    //  await Browser.OpenAsync("https://aka.ms/xamarin-quickstart");
                    //  aent.GoToAsync($    // "{nameof(DetailPage)}?Content={data}");
                }
);
        }

        public async void RefereshExecute()
        {
            foreach (var city in Cities)
            {
                WeatherService service = DependencyService.Resolve<WeatherService>();
                WeatherData data = await service.GetWeatherForCity(city.CityName);
                // SetProperty(ref city.CurrentTemp, data.main.temp) ;
                city.CurrentTemp = data.main.temp;

                Console.WriteLine(data.main.temp);


            }
            Console.WriteLine("Refereshing ...");
            IsRefreshing = false;
        }

        public ICommand RefreshExecuteCommand { get; }
        public ICommand GetCityTempCommand { get; }
    }
}