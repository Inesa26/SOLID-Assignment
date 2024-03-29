namespace SolidNotificationSystem
{
    public class EmailSender : INotificationSender
    {
        public void SendNotification(Notification notification)
        {
            Console.WriteLine($"An email was sent from {notification.Sender.Name} to {notification.Receiver.Name}! Message: {notification.Message}");
        }
    }
}
