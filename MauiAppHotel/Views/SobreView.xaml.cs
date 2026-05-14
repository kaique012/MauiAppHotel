namespace MauiAppHotel.Views;

public partial class SobreView : ContentPage
{
    public SobreView()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}