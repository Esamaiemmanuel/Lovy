namespace Lovy.Views;

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