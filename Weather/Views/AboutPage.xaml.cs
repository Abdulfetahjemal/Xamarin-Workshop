using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
   public class City
    {
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string CurrentTemp { get; set; }
        public string ImageUrl { get; set; }
    }
    public partial class AboutPage : ContentPage
    {
        

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
        public AboutPage()
        {

            InitializeComponent();
            BindingContext = this;
            CollectionView.ItemsSource= Cities;

        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(DetailPage));
             
        }
         
    }
}