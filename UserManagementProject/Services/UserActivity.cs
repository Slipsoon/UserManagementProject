namespace UserManagementProject.Services;

public interface IUserActivity
{
    Action<(string, string)>? NewUserActivity { get; set; }

    void SendNewActivityNotification(string acitivity, string assignedGroup);
}
public class UserActivity : IUserActivity
{
    public Action<(string, string)>? NewUserActivity { get; set; }

    public void SendNewActivityNotification(string acitivity, string assignedGroup) => NewUserActivity?.Invoke((acitivity, assignedGroup));
}
