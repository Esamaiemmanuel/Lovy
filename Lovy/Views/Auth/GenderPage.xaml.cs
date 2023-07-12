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

    private void BtnBack_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(DateOfBirthPage));
    }
}