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
}