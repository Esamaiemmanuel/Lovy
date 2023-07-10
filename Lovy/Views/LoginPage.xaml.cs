using Microsoft.Maui.Controls;
using System;

namespace Lovy.Views
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
            Shell.Current.GoToAsync(nameof(CodeVerification));
        }

        private void OnPhoneNumberLoginClicked(object sender, EventArgs e)
        {
            // Handle phone number login button click event
            // Perform actions for phone number login
            Shell.Current.GoToAsync(nameof(CodeVerification));
        }
    }
}
