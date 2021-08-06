using System;
using Weather.Services;
using Weather.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("poppins_black.ttf", Alias = "Poppins-Black")]
[assembly: ExportFont("poppins_bold.ttf", Alias = "Poppins-Bold")]
[assembly: ExportFont("poppins_light.ttf", Alias = "Poppins-Light")]
[assembly: ExportFont("poppins_medium.ttf", Alias = "Poppins-Medium")]
[assembly: ExportFont("poppins_regular.ttf", Alias = "Poppins-Regular")]

[assembly: ExportFont("poppins_extraLight.ttf", Alias = "Poppins-ExtraLight")]
namespace Weather
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell(); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
