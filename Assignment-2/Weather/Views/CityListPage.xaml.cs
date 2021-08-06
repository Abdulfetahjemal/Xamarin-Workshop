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
        private AboutViewModel contextAboutViewModel = new AboutViewModel();
        //public int Current =0;
        public AboutPage()
        {

            InitializeComponent();
            BindingContext = contextAboutViewModel; 

           // CollectionView.ItemsSource= Cities;

        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var model =BindingContext as AboutViewModel;
            Console.WriteLine("Current Index");
            Console.WriteLine(contextAboutViewModel.SelectedCity.CityName);
            //Shell.Current.GoToAsync(nameof(DetailPage));
             
        }
         
    }
}