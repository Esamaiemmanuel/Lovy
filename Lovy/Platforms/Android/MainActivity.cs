﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace Lovy;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
       
        Window.SetStatusBarColor(Android.Graphics.Color.Black);
        Window.SetNavigationBarColor(Android.Graphics.Color.Black);
        Window.DecorView.SetBackgroundColor(Android.Graphics.Color.Red);
        

    }


}
