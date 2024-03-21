using Microsoft.AspNetCore.Components;
using UserManagementProject.Services;

namespace UserManagementProject.Shared;

public partial class Users : IDisposable
{
    private List<KeyValuePair<string, string>> _userAcitivities = new();

    [Inject]
    public IUserActivity UserActivity { get; set; } = null!;

    protected override void OnInitialized()
    {
        UserActivity.NewUserActivity += OnNewUserActivity;
        base.OnInitialized();
    }

    private void OnNewUserActivity((string, string) tuple)
    {
        _userAcitivities.Insert(0, new KeyValuePair<string, string>(tuple.Item1, tuple.Item2));
        StateHasChanged();
    }

    private string GetUserGroupImage(string groupType) => groupType switch
    {
        // missing some white filled icons from Figma
        "0" => "circle",
        "1" => "star-white-filled",
        "2" => "flower-white-filled",
        "3" => "smile-white-filled",
        "4" => "triangle-filled",
        "5" => "square-filled",
        _ => string.Empty,
    };

    public void Dispose()
    {
        UserActivity.NewUserActivity -= OnNewUserActivity;
    }
}
