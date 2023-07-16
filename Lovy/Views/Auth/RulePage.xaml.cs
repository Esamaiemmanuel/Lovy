namespace Lovy.Views.Auth;

public partial class RulePage : ContentPage
{
	public RulePage()
	{
		InitializeComponent();
	}

    private void NextStep_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(NamePage));
    }
    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        Navigation.PopAsync(); // Go back to the previous page
    }
}