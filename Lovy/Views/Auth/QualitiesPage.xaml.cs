namespace Lovy.Views.Auth;

public partial class QualitiesPage : ContentPage
{
	public QualitiesPage()
	{
		InitializeComponent();
	}

    private void NextBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(HomePage));
    }
}