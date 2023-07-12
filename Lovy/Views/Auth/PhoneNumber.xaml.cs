namespace Lovy.Views.Auth;

public partial class PhoneNumber : ContentPage
{
	public PhoneNumber()
	{
		InitializeComponent();
	}
    private void CountryCodeSelectedIndexChanged(object sender, EventArgs e)
    {
     
    }

    private void NextButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(RulePage));
    }

    
}