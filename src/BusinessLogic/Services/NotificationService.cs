using BusinessLogic.Models;

namespace BusinessLogic.Services
{
    public class NotificationService
    {
        private static List<Notification> _notifications = new List<Notification>();

        public List<Notification> GetUserNotifications(int userId)
        {
            return _notifications
                .Where(n => n.UserId == userId)
                .OrderByDescending(n => n.CreatedAt)
                .ToList();
        }

        public List<Notification> GetUnreadNotifications(int userId)
        {
            return _notifications
                .Where(n => n.UserId == userId && !n.IsRead)
                .OrderByDescending(n => n.CreatedAt)
                .ToList();
        }

        public void AddNotification(int userId, string title, string message, NotificationType type)
        {
            var notification = new Notification
            {
                Id = _notifications.Max(n => (int?)n.Id) ?? 0 + 1,
                UserId = userId,
                Title = title,
                Message = message,
                Type = type,
                IsRead = false,
                CreatedAt = DateTime.Now
            };

            _notifications.Add(notification);
        }

        public bool MarkAsRead(int notificationId)
        {
            var notification = _notifications.FirstOrDefault(n => n.Id == notificationId);
            if (notification == null) return false;

            notification.IsRead = true;
            return true;
        }

        public bool MarkAllAsRead(int userId)
        {
            var userNotifications = _notifications.Where(n => n.UserId == userId && !n.IsRead);
            foreach (var notification in userNotifications)
            {
                notification.IsRead = true;
            }
            return true;
        }

        public int GetUnreadCount(int userId)
        {
            return _notifications.Count(n => n.UserId == userId && !n.IsRead);
        }
    }
}
