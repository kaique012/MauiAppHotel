namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Navega para a tela Sobre (ou a tela de Resumo que você criar)
                await Navigation.PushAsync(new SobreView());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }