using Intercambio.Models;
namespace Intercambio.Pages;

public partial class Datos : ContentPage
{
	public Datos()
	{
        InitializeComponent();
	}

    private async void btnIngresar_Clicked(object sender, EventArgs e)
    {
        if (txtP.Text != null)
        {
            participantes.Participantes.Add(txtP.Text);
            await Navigation.PushAsync(new Datos());
        }
        else
        {
            await DisplayAlert("Error", "Ingresa un nombre", "Ok");
        }
    }

    private async void btnDetener_Clicked(object sender, EventArgs e)
    {
        if(txtP.Text != null)
        {
            participantes.Participantes.Add(txtP.Text);
            await Navigation.PushAsync(new Resultados());
        }
        else
        {
            await DisplayAlert("Error", "Ingresa un nombre", "Ok");
        }
    }
}