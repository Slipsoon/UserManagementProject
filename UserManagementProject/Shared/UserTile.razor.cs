using Microsoft.AspNetCore.Components;
using UserManagementProject.ViewModels;

namespace UserManagementProject.Shared;

public partial class UserTile
{
    [Parameter]
    public UserVM? User { get; set; }

    private string GetUserGroupImage() => User?.AssignedGroup switch
    {
        "0" => "circle",
        "1" => "star-filled",
        "2" => "flower-filled",
        "3" => "smile-filled",
        "4" => "triangle-filled",
        "5" => "square-filled",
        _ => string.Empty,
    };
}
