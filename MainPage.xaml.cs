using Plugin.LocalNotification;

namespace Astley_Aislie_POI_App_Prototype
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            var request = new NotificationRequest
            {
                NotificationId = 1337,
                Title = "Near this",
                Subtitle = "Location",
                Description = "this place is near",
                BadgeNumber = 26,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(1),
                },
            };
            LocalNotificationCenter.Current.Show(request);
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
