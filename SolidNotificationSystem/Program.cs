namespace SolidNotificationSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var notificationService = NotificationService.Instance;
            notificationService.AddNotification(NotificationType.Email, new EmailSender());
            notificationService.AddNotification(NotificationType.SMS, new SMSSender());
            notificationService.AddNotification(NotificationType.Push, new PushNotificationSender());

            User firstUser = new User(1, "Inesa", "inesa@gmail.com", "+37379927987");
            User secondUser = new User(2, "Alice", "alice@gmail.com", "+37378932792");
            User thirdUser = new User(3, "Denis", "denis@gmail.com", "+37378324973");

            firstUser.SendMessage(NotificationType.Email, "Hello Alice!", secondUser);
            secondUser.SendMessage(NotificationType.SMS, "Hello Denis!", thirdUser);
        }
    }
}
