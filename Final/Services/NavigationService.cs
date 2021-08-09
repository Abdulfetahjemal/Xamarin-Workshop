using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Views;
using Xamarin.Forms;

namespace Weather.Services
{
    interface INavigationService
    {
        Task Navigation(string city);
    }
    class NavigationService : INavigationService
    {
        public Task Navigation(string city)
        {

            return Shell.Current.GoToAsync($"{nameof(DetailPage)}?CityName={city}");

        }
    }
}
