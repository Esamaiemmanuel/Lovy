namespace Lovy.Views.Auth;

public partial class PhoneCodePage : ContentPage
{
	public PhoneCodePage()
	{
		InitializeComponent();
	}
    private void NextButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(RulePage));
    }
    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        // Navigation.PopAsync(); // Go back to the previous page
        Shell.Current.GoToAsync(nameof(PhoneNumber));
    }
}