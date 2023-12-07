using Intercambio.Pages;

namespace Intercambio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            //MainPage = new NavigationPage(new Datos());
        }
    }
}
