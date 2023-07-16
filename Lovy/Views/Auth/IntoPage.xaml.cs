namespace Lovy.Views.Auth;

public partial class IntoPage : ContentPage
{
	public IntoPage()
	{
		InitializeComponent();
	}
    private void NextStep_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(RecentPicPage));
    }
    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        // Navigation.PopAsync(); // Go back to the previous page
        Shell.Current.GoToAsync(nameof(StudyPage));
    }
}