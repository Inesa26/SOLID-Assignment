namespace SolidNotificationSystem
{
    internal class PushNotificationSender : INotificationSender
    {
        public void SendNotification(Notification notification)
        {
            Console.WriteLine($"A push notification was sent from {notification.Sender.Name} to {notification.Receiver.Name}! Message: {notification.Message}");
        }
    }
}
