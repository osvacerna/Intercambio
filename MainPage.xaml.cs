using System.Collections.Generic;
using Intercambio.Pages;

namespace Intercambio
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnC_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Datos());
        }
    }
}
