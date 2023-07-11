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

    private void btnSubmit_Clicked(object sender, EventArgs e)
    {
        string email = mailEntry.Text;

        // Validate and process the email address
        // For example, display a message or perform an action
        DisplayAlert("Submitted", $"Email: {email}", "OK");
    }
}