using System.Diagnostics;

namespace Astley_Aislie_POI_App_Prototype
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // Made these methods private since they're only used within this class
        private async Task AskForNotificationPermission()
        {
            bool answer = await Shell.Current.DisplayAlert("Enable Notifications",
                "Would you like to receive important updates and alerts?",
                "Yes", "Not Now");

            if (answer)
            {
                await RequestNotificationPermission();
            }
        }

        private async Task RequestNotificationPermission()
        {
            try
            {
                var status = await Permissions.RequestAsync<Permissions.PostNotifications>();

                if (status == PermissionStatus.Granted)
                {
                    await Shell.Current.DisplayAlert("Success", "Notifications enabled!", "OK");
                }
                else
                {
                    await Shell.Current.DisplayAlert("Permission Required",
                        "Please enable notifications in settings to receive alerts.", "OK");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Permission exception: {ex}");
                await Shell.Current.DisplayAlert("Error", "Failed to request notification permissions.", "OK");
            }
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            // First check if we have permission
            var status = await Permissions.CheckStatusAsync<Permissions.PostNotifications>();

            if (status != PermissionStatus.Granted)
            {
                // Request permission if we don't have it
                await AskForNotificationPermission();
                return; // Exit if we don't have permission
            }

            await Navigation.PushAsync(new HomePage());
        }


    }
}
