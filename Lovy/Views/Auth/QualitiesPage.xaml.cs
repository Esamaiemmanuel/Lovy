namespace Lovy.Views.Auth;

public partial class QualitiesPage : ContentPage
{
    
    public Color TileColor1 { get; set; } = Colors.Gray; // Initial color of tile 1
                                                        // Add similar properties for other tiles
    public QualitiesPage()
	{
		InitializeComponent();
	}

    private void NextBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(HomePage));
    }
    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        // Navigation.PopAsync(); // Go back to the previous page
        Shell.Current.GoToAsync(nameof(GenderPage));
    }

    private void OnTileTapped(object sender, EventArgs e)
    {
        var frame = (Frame)sender;
        frame.BorderColor = Colors.Red; // Change the color of the tapped tile
    }
}