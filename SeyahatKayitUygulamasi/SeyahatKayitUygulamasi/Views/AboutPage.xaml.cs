using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SeyahatKayitUygulamasi.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            bool IsEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
            bool IsPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if (IsEmailEmpty || IsPasswordEmpty)
            {
                await DisplayAlert("Uyarı", "Girdiğiniz değerleri kontrol ediniz.", "Tamam");
            }
            else 
            { 
                Navigation.PushAsync(new HomePage());
            }


        }
    }
}