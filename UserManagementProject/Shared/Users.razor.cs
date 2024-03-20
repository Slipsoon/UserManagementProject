using Microsoft.AspNetCore.Components;
using UserManagementProject.Services;

namespace UserManagementProject.Shared;

public partial class Users : IDisposable
{
    private List<string> _userAcitivities = new();

    [Inject]
    public IUserActivity UserActivity { get; set; } = null!;

    protected override void OnInitialized()
    {
        UserActivity.NewUserActivity += OnNewUserActivity;
        base.OnInitialized();
    }

    private void OnNewUserActivity(string activity)
    {
        _userAcitivities.Insert(0, activity);
        StateHasChanged();
    }

    public void Dispose()
    {
        UserActivity.NewUserActivity -= OnNewUserActivity;
    }
}
