using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Astley_Aislie_POI_App_Prototype
{
    /// <summary>
    /// The NotificationReceived event allows an app to handle incoming notifications.
    /// The SendNotification method sends a notification at an optional DateTime.
    /// The ReceiveNotification method processes a notification when received by the underlying platform.
    /// </summary>
    public interface INotificationManagerService
    {
        event EventHandler NotificationReceived;
        void SendNotification(string title, string message, DateTime? notifyTime = null);
        void ReceiveNotification(string title, string message);
    }
}
