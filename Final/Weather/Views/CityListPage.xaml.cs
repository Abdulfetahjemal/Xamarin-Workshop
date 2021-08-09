using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Weather.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
    public partial class AboutPage : ContentPage
    {
        private CityListViewModel contextCityListViewModel = new CityListViewModel();
        //public int Current =0;
        public AboutPage()
        {

            InitializeComponent();
            BindingContext = contextCityListViewModel;
            contextCityListViewModel.RefereshExecute();
            // CollectionView.ItemsSource= Cities;

        }

     

    }
}