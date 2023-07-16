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

    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        //Navigation.PopAsync(); // Go back to the previous page
        Shell.Current.GoToAsync(nameof(NamePage));
    }
}