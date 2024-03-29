namespace SolidNotificationSystem
{
    public class Notification
    {
        public NotificationType NotificationType { get; set; }
        public string Message { get; set; }
        public User Receiver { get; set; }
        public User Sender { get; set; }
        public Notification(NotificationType notificationlType, string message, User sender, User receiver)
        {
            NotificationType = notificationlType;
            Message = message;
            Receiver = receiver;
            Sender = sender;
        }
    }
}
