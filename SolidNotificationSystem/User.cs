namespace SolidNotificationSystem
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public User() { }
        public User(int id, string name, string email, string phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void SendMessage(NotificationType notificationType, string message, User receiver)
        {
            var notificationService = NotificationService.Instance;
            Notification notification = new(notificationType, message, this, receiver);
            notificationService.SendNotification(notification);
        }

    }
}
