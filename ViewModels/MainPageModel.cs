using System;
using CommunityToolkit.Mvvm.Input;

namespace NextMAUIApp.ViewModels
{
    public partial class MainPageModel : BaseViewModel
    {
        private IGeolocation geolocation;

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
        }

        public MainPageModel(IGeolocation geolocation)
        {
            this.PageTitle = "Main Page";
            this.geolocation = geolocation;
        }
    }
}

