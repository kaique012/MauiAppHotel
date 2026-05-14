namespace MauiAppHotel;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        // NÃO COLOQUE "MainPage = ..." AQUI!
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // Aqui definimos a página inicial corretamente
        var navegacao = new NavigationPage(new Views.ContratacaoHospedagem());

        return new Window(navegacao)
        {
            Width = 400,
            Height = 600
        };
    }
}