namespace SolidNotificationSystem
{
    public class NotificationService
    {
        private static NotificationService _instance;
        private readonly Dictionary<NotificationType, INotificationSender> _notifications;

        private NotificationService()
        {
            _notifications = new Dictionary<NotificationType, INotificationSender>();
        }

        public static NotificationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NotificationService();
                }
                return _instance;
            }
        }

        public void AddNotification(NotificationType channel, INotificationSender sender)
        {
            _notifications.Add(channel, sender);
        }

        public void SendNotification(Notification notification)
        {
            if (_notifications.ContainsKey(notification.NotificationType))
            {
                INotificationSender notificationSender = _notifications[notification.NotificationType];
                notificationSender.SendNotification(notification);
            }
            else
            {
                throw new InvalidOperationException("Invalid notification type");
            }
        }
    }
}
