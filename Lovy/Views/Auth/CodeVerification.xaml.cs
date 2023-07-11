namespace Lovy.Views.Auth;

public partial class CodeVerification : ContentPage
{
	public CodeVerification()
	{
		//InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}