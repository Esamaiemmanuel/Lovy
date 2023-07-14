using Microsoft.Maui.Controls;
using System;

namespace Lovy.Views.Auth
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnGoogleLoginClicked(object sender, EventArgs e)
        {
            // Handle Google login button click event
            // Perform actions for Google login
            Shell.Current.GoToAsync(nameof(AddEmailPage));
        }

        private void OnPhoneNumberLoginClicked(object sender, EventArgs e)
        {
            // Handle phone number login button click event
            // Perform actions for phone number login
            Shell.Current.GoToAsync(nameof(PhoneNumber));
        }

        private void BtnFacebook_Clicked(object sender, EventArgs e)
        {
            //Shell.Current.GoToAsync(nameof(CodeVerification));
            Shell.Current.GoToAsync(nameof(RulePage));

        }
        private void ForgetLabel_Tapped(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new RegisterPage());
        }
    }
}
