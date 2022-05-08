using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NextMAUIApp.ViewModels
{
    public partial class MainPageModel : BaseViewModel
    {
        /// <summary>
        /// Geo Location
        /// </summary>
        private IGeolocation geolocation;

        /// <summary>
        /// Location Text
        /// </summary>
        [ObservableProperty]
        private string locationText;

        /// <summary>
        /// GetLocation
        /// </summary>
        /// <returns></returns>
        [ICommand]
        public async Task GetLocation()
        {
            // Get cached location, else get real location.
            var location = await geolocation.GetLastKnownLocationAsync();
            if (location == null)
            {
                location = await geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                });
            }

            this.LocationText = "Location => " + location.Longitude.ToString() + " | " + location.Latitude.ToString();
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="geolocation"></param>
        public MainPageModel(IGeolocation geolocation)
        {
            this.PageTitle = "Main Page";

            // Set Location Service
            this.geolocation = geolocation;
        }
    }
}

