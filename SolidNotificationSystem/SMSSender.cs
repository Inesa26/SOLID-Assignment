namespace SolidNotificationSystem
{
    public class SMSSender : INotificationSender
    {
        public void SendNotification(Notification notification)
        {
            Console.WriteLine($"SMS was sent from {notification.Sender.Name} to {notification.Receiver.Name}! Message: {notification.Message}");
        }
    }
}
