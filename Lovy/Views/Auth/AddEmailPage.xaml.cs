namespace Lovy.Views.Auth;

public partial class AddEmailPage : ContentPage
{
	public AddEmailPage()
	{
		InitializeComponent();
	}

    private void BtnCancel_Clicked(object sender, EventArgs e)
    {
         Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

    private void BtnSubmit_Clicked(object sender, EventArgs e)
    {
        string email = mailEntry.Text;

        // Validate and process the email address
        // For example, display a message or perform an action
        DisplayAlert("Submitted", $"Email: {email}", "OK");
        Shell.Current.GoToAsync(nameof(RulePage));
    }

    private void OnGoogleLoginClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

  

  
}