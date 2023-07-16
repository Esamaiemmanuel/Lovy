namespace Lovy.Views.Auth;

public partial class GenderPage : ContentPage
{
	public GenderPage()
	{
		InitializeComponent();
	}

    private void NextBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(QualitiesPage));
    }

    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        // Navigation.PopAsync(); // Go back to the previous page
        Shell.Current.GoToAsync(nameof(DateOfBirthPage));
    }

    private void OnGenderButtonClicked(object sender, EventArgs e)
    {
        // Reset border color for all buttons
        maleButton.BorderColor = (Color)Resources["DefaultBorderColor"];
        femaleButton.BorderColor = (Color)Resources["DefaultBorderColor"];

        // Set border color for the selected button
        var button = (Button)sender;
        button.BorderColor = (Color)Resources["SelectedBorderColor"];
    }
}