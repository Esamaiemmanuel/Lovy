using Firebase.Database;
using Firebase.Database.Query;
using Microsoft.Maui.ApplicationModel.Communication;

namespace Lovy.Views.Auth;

public partial class EmailPage : ContentPage
{
    FirebaseClient firebaseClient = new FirebaseClient("https://lovy-a520b-default-rtdb.firebaseio.com/");
    public string webApiKey = "AIzaSyBTIQSaK_zeVVnCYTy9ShYo9QmkTAXpz4s";
    public EmailPage()
	{
		InitializeComponent();
	}
    private async void NextButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            

            await Shell.Current.GoToAsync(nameof(RulePage));
        }
        catch (Exception ex)
        {
            await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
        }


    }
    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        // Navigation.PopAsync(); // Go back to the previous page
        Shell.Current.GoToAsync(nameof(LoginPage));
    }
}