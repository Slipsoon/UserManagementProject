using Microsoft.AspNetCore.Components;
using UserManagementProject.ViewModels;

namespace UserManagementProject.Shared;

public partial class UserTile
{
    [Parameter]
    public UserVM User { get; set; }

    [Parameter]
    public int TileOrderNumber { get; set; }
}
