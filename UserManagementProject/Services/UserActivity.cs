namespace UserManagementProject.Services;

public interface IUserActivity
{
    Action<string>? NewUserActivity { get; set; }

    void SendNewActivityNotification(string acitivity);
}
public class UserActivity : IUserActivity
{
    public Action<string>? NewUserActivity { get; set; }

    public void SendNewActivityNotification(string acitivity) => NewUserActivity?.Invoke(acitivity);
}
