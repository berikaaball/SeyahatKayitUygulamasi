using SeyahatKayitUygulamasi.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SeyahatKayitUygulamasi.Views
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