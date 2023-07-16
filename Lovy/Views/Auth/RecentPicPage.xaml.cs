namespace Lovy.Views.Auth;

public partial class RecentPicPage : ContentPage
{
    public Color TileColor1 { get; set; } = Colors.Gray;
    public RecentPicPage()
	{
		InitializeComponent();
	}
    private void NextBtn_Clicked(object sender, EventArgs e)
    {
        //Shell.Current.GoToAsync(nameof(HomePage));
        Shell.Current.GoToAsync(nameof(LocationPage));
    }
    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        // Navigation.PopAsync(); // Go back to the previous page
        Shell.Current.GoToAsync(nameof(IntoPage));
    }

    private void OnTileTapped(object sender, EventArgs e)
    {
        var frame = (Frame)sender;
        frame.BorderColor = Colors.Red; // Change the color of the tapped tile
    }
    private void OnAddPcClicked(object sender, EventArgs e)
    {
        var frame = (Frame)sender;
        frame.BorderColor = Colors.Red; // Change the color of the tapped tile
    }
}