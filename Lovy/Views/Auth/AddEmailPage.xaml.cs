namespace Lovy.Views.Auth;

public partial class AddEmailPage : ContentPage
{
	public AddEmailPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
         Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}