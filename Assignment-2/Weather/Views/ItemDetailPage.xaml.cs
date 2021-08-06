using System.ComponentModel;
using Weather.ViewModels;
using Xamarin.Forms;

namespace Weather.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}