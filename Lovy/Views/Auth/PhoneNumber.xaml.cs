using Firebase.Database;
using Firebase.Database.Query;
using Lovy.Models;


namespace Lovy.Views.Auth;

public partial class PhoneNumber : ContentPage
{
    FirebaseClient firebaseClient = new FirebaseClient("https://lovy-a520b-default-rtdb.firebaseio.com/");



    public PhoneNumber()
	{
		InitializeComponent();
        // Initialize the Firebase AuthProvider
       //authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
      

    }

    private void CountryCodeSelectedIndexChanged(object sender, EventArgs e)
    {
     
    }


    private  void NextButton_Clicked(object sender, EventArgs e)
    {
        firebaseClient.Child("User").PostAsync(new Phone
            {
                Phonenumber = PhoneNumberEntry.Text,
            });  
             Shell.Current.GoToAsync(nameof(PhoneCodePage));
        
    }
    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        // Navigation.PopAsync(); // Go back to the previous page
        Shell.Current.GoToAsync(nameof(LoginPage));
    }
    


}