namespace MauiAppLogin;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{

		} catch(Exception ex)
		{
            DisplayAlertAsync("Ops", ex.Message, "Fechar");
		}


    }
}