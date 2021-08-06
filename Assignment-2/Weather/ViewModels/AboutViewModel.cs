using System;
using System.Collections.Generic;
using System.Windows.Input;
using Newtonsoft.Json;
using Weather.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class City
    {
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string CurrentTemp { get; set; }
        public string ImageUrl { get; set; }
    }

    public class AboutViewModel : BaseViewModel
    {
        private City _SelectedCity = new City()
        {
            CityName = "A.A",
            CountryName = "Ethiopia",
            CurrentTemp = "20°C",
            ImageUrl = "moon.png"

        };
        public City SelectedCity
        {
            get => _SelectedCity;
            set => SetProperty(ref _SelectedCity, value);
        }

        public List<City> Cities { get; } = new List<City>()
        {
            new City()
            {
                CityName = "A.A",
                CountryName = "Ethiopia",
                CurrentTemp = "20°C",
                ImageUrl = "moon.png"

            },
            new City()
            {
                CityName = "Dire Dawa",
                CountryName = "Ethiopia",
                CurrentTemp = "18°C",
                ImageUrl = "rain.png"

            },
            new City()
            {
                CityName = "Adama",
                CountryName = "Ethiopia",
                CurrentTemp = "18°C",
                ImageUrl = "full_sun.png"

            },new City()
            {
                CityName = "Gondar",
                CountryName = "Ethiopia",
                CurrentTemp = "20°C",
                ImageUrl = "moon.png"

            }
        };

        public AboutViewModel()
        {

            Title = "About";
            OpenWebCommand = new Command(async () =>
                {
                    Console.WriteLine("Clicked" + SelectedCity.CityName);
                    var data = JsonConvert.SerializeObject(SelectedCity);
                    await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Content={data}");
                }           
);
        }

        public ICommand OpenWebCommand { get; }
    }
}