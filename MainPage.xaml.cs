using Plugin.LocalNotification;

namespace Astley_Aislie_POI_App_Prototype
{
    public partial class MainPage : ContentPage
    {
        private readonly INotificationService _notificationService;
        private int count = 0;

        public MainPage(INotificationService notificationService)
        {
            _notificationService = notificationService;
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            await _notificationService.ShowNotification("Near this", "Location", "this place is near");
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }


}
