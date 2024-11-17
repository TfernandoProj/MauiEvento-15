using MauiEvento.Models;
using MauiEvento.Views;

namespace MauiEvento;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new Evento(); 
    }

    private async void OnResumoClicked(object sender, EventArgs e)
    {
        if (BindingContext is Evento evento)
        {
            await Navigation.PushAsync(new EventoPage(evento));
        }
    }
}
