namespace SolidNotificationSystem
{
    public interface IUserService
    {
        void AddUser(User user);
        User? FindUserById(int userId);
    }
}
