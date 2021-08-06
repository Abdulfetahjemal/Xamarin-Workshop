using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Weather.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
   // [QueryProperty(nameof(Content), nameof(Content))]
    public partial class DetailPage : ContentPage
    {
        public string Content = "";
        public DetailPage()
        {
            InitializeComponent();
         //   BindingContext = this;
          //  var content = JsonConvert.DeserializeObject <City>(Content);
           // Console.Write(content.CityName);

        }
    }
}