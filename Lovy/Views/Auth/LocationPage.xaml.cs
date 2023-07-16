namespace Lovy.Views.Auth;

public partial class LocationPage : ContentPage
{
	public LocationPage()
	{
		InitializeComponent();
        //CheckAndRequestLocationPermission();
    }
    /*private async void CheckAndRequestLocationPermission()
    {
        var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

        if (status != PermissionStatus.Granted)
        {
            status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
        }

        if (status == PermissionStatus.Granted)
        {
            // Permission has been granted, proceed to get the location
            GetLocation();
        }
        else
        {
            // Permission denied, handle accordingly
            // You may want to display an error message or disable location-related functionality
        }
    }
    private async void GetLocation()
    {
        try
        {
            var location = await Geolocation.GetLocationAsync();

            if (location != null)
            {
                var latitude = location.Latitude;
                var longitude = location.Longitude;

                // Do something with the latitude and longitude values
            }
            else
            {
                // Location data is unavailable
            }
        }
        catch (FeatureNotSupportedException)
        {
            // Geolocation is not supported on the device
        }
        catch (Exception ex)
        {
            // Other error occurred while retrieving location
        }
    } */
    private async void OnGetLocationClicked(object sender, EventArgs e)
    {
        try
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            if (status != PermissionStatus.Granted)
            {
                status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }

            if (status == PermissionStatus.Granted)
            {
                // Permission has been granted, proceed to get the location
                GetLocation();
            }
            else
            {
                // Permission denied, handle accordingly
                // You may want to display an error message or disable location-related functionality
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur during permission request
        }
    }

    private async void GetLocation()
    {
        try
        {
            var location = await Geolocation.GetLocationAsync();

            if (location != null)
            {
                var latitude = location.Latitude;
                var longitude = location.Longitude;

                Shell.Current.GoToAsync(nameof(AvoidPage));

                // Do something with the latitude and longitude values
            }
            else
            {
                // Location data is unavailable
            }
        }
        catch (FeatureNotSupportedException)
        {
            // Geolocation is not supported on the device
        }
        catch (Exception ex)
        {
            // Other error occurred while retrieving location
        }
    }
}