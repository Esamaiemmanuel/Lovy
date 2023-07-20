using Firebase.Database;
using Firebase.Database.Query;
using FirebaseAdmin.Auth;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Lovy.Models;
using FirebaseAdmin.Messaging;
using System.Reflection;
using System.IO;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Text;

namespace Lovy.Views.Auth;

public partial class PhoneNumber : ContentPage
{
    FirebaseClient firebaseClient = new FirebaseClient("https://lovy-a520b-default-rtdb.firebaseio.com/");

    public PhoneNumber()
    {
        InitializeComponent();
        // Load Firebase Admin SDK with service account credentials
        ReadFireBaseAdminSK();
        
    }

    private async void ReadFireBaseAdminSK()
    {
        var stream = await FileSystem.OpenAppPackageFileAsync("admin_sdk.json");
        var reader = new StreamReader(stream);
        var jsonContent = reader.ReadToEnd();

        if (FirebaseMessaging.DefaultInstance == null)
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromJson(jsonContent)
            });

        }
    }

    private void CountryCodeSelectedIndexChanged(object sender, EventArgs e)
    {
     
    }


    private async void NextButton_Clicked(object sender, EventArgs e)
    {
        // Add user with phone number to Firebase Authentication
            
            FirebaseAuth auth = FirebaseAuth.DefaultInstance;
            var user = await auth.CreateUserAsync(new UserRecordArgs
            {
                PhoneNumber = PhoneNumberEntry.Text,
            });

        string userId = user.Uid;

        // Store user data in Realtime Database
        var databaseUrl = "https://lovy-a520b-default-rtdb.firebaseio.com/"; // Replace with your database URL
        var firebaseClient = new FirebaseClient(databaseUrl);
        var usersReference = firebaseClient.Child("users");

        // Assuming you have some user data that you want to store in the database
        // Replace this with your own user data or modify as per your requirement
        var userData = new
        {
            PhoneNumber = PhoneNumberEntry.Text,
            // Add more properties if needed
        };

        // Now, add the user data along with the user ID to the 'users' node in the database
        await usersReference.Child(userId).PutAsync(userData);

        // Send the verification code to the provided phone number

        

        string twilioAccountSid = "ACda9b14c9637008af54609198b9d2fb52";
        string twilioAuthToken = "63dbd6a1a898f798d4e3a4b047bef785";
        string twilioPhoneNumber = "+12728880915";
        string phoneNumber = PhoneNumberEntry.Text;

        TwilioClient.Init(twilioAccountSid, twilioAuthToken);

        // Generate your verification code (you can replace this with your actual logic to generate a code)
        string verificationCode = GenerateVerificationCode();

        try
        {
            
            var message = MessageResource.Create(
                body: $"Your verification code for Lovy Dovy is: {verificationCode}",
                from: new Twilio.Types.PhoneNumber(twilioPhoneNumber),
                to: new Twilio.Types.PhoneNumber(phoneNumber)
            );

            // At this point, the verification code has been sent to the user's phone number
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur during the Twilio API call
            // and provide appropriate error handling and user feedback
        }


        // You can now use 'phoneAuthResult' to check the status of the verification request if needed.

        //var verification = await FirebaseAuth.DefaultInstance.SendPhoneVerificationCodeAsync(PhoneNumberEntry.Text);
        await Shell.Current.GoToAsync(nameof(PhoneCodePage));
        //var verificationResult = await FirebaseAuth.DefaultInstance.SendVerificationCodeAsync(phoneNumber, options);

    }
    public static string GenerateVerificationCode()
    {
        const int codeLength = 6;
        const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder codeBuilder = new StringBuilder();

        Random random = new Random();
        for (int i = 0; i < codeLength; i++)
        {
            int index = random.Next(0, allowedChars.Length);
            codeBuilder.Append(allowedChars[index]);
        }

        return codeBuilder.ToString();
    }
    private void OnImageTapped(object sender, EventArgs e)
    {
        // Handle the image tap event
        // Navigation.PopAsync(); // Go back to the previous page
        Shell.Current.GoToAsync(nameof(LoginPage));
    }
    


}