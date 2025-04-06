using Plugin.LocalNotification;

public class LocalNotificationService : INotificationService
{
    public async Task ShowNotification(string title, string subtitle, string description)
    {
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = title,
            Subtitle = subtitle,
            Description = description,
            BadgeNumber = 26,
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(1),
            },
        };
        await LocalNotificationCenter.Current.Show(request);
    }
}
