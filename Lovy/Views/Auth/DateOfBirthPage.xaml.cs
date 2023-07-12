namespace Lovy.Views.Auth;

public partial class DateOfBirthPage : ContentPage
{
	public DateOfBirthPage()
	{
		InitializeComponent();
	}

    private void NextBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(GenderPage));
    }

    private void BtnBack_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(NamePage));
    }
}