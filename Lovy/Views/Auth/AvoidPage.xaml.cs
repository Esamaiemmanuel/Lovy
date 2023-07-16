namespace Lovy.Views.Auth;

public partial class AvoidPage : ContentPage
{
	public AvoidPage()
	{
		InitializeComponent();
	}
    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        //Navigation.PopAsync(); // Go back to the previous page
        Shell.Current.GoToAsync(nameof(LocationPage));
    }
    private void OnLinkTapped(object sender, EventArgs e)
    {
        Launcher.OpenAsync(new Uri("https://www.urs-tec.com"));
    }
    private void NextBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HomePage));
    }
}