using MauiEvento.Models;

namespace MauiEvento.Views;

public partial class EventoPage : ContentPage
{
    public EventoPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }
}
