namespace CadastroDeEventos.Views;

public partial class TabelaDePrecos : ContentPage
{
    public TabelaDePrecos()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}