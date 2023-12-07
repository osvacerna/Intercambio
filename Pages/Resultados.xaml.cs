using System.Collections.Generic;
using Intercambio.Models;

namespace Intercambio.Pages;

public partial class Resultados : ContentPage
{
	public Resultados()
	{
		InitializeComponent();
	}

    private async void btnResultado_Clicked(object sender, EventArgs e)
    {
        if (participantes.Participantes.Contains(txtp.Text))
        {
            participantes.Participantes = participantes.Participantes.OrderBy(x => Random.Shared.Next()).ToList();
            int aux = (participantes.Participantes.FindIndex(x => x == txtp.Text) + 1) % participantes.Participantes.Count;
            await DisplayAlert("Debes dar regalo a...", participantes.Participantes[aux], "Ok");
        }
        else
        {
            await DisplayAlert("Error", "El nombre no forma parte del intercambio", "Ok");
        }
    }

    private async void btnRegresar_Clicked(object sender, EventArgs e)
    {
        participantes.Participantes.Clear();
        await Navigation.PushAsync(new MainPage());
    }
}