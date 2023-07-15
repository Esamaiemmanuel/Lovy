using Lovy.Views.Profile;

namespace Lovy.Views.Auth;


public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void BtnProfile_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(ProfileDashboard));
    }
}