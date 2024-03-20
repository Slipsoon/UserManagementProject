using Microsoft.AspNetCore.Components;
using MudBlazor;
using UserManagementProject.Services;
using UserManagementProject.ViewModels;

namespace UserManagementProject.Pages;

public partial class UsersManagement
{
    private const string UserDefaultGroup = "0";

    private List<UserVM> _users = new()
    {
        new UserVM(){ Name = "Adam", LastName = "Kowalski", City = "Radom", AssignedGroup = UserDefaultGroup },
        new UserVM(){ Name = "Piotr", LastName = "Piotrowski", City = "Radom", AssignedGroup = UserDefaultGroup },
        new UserVM(){ Name = "Magda", LastName = "Nowakowska", City = "Warszawa", AssignedGroup = UserDefaultGroup },
        new UserVM(){ Name = "Jan", LastName = "Nowak", City = "Radom", AssignedGroup = UserDefaultGroup }
    };

    public string ActivityLog { get; set; } = string.Empty;

    [Inject]
    public IUserActivity UserActivity { get; set; } = null!;

    private void ItemUpdated(MudItemDropInfo<UserVM> dropItem)
    {
        if (dropItem.Item.AssignedGroup == dropItem.DropzoneIdentifier) return;

        NotifyUserMove(dropItem);
        dropItem.Item.AssignedGroup = dropItem.DropzoneIdentifier;
    }

    private void NotifyUserMove(MudItemDropInfo<UserVM> dropItem)
    {
        if (dropItem.DropzoneIdentifier == UserDefaultGroup)
        {
            UserActivity.SendNewActivityNotification($"Użytkownik {dropItem.Item.Name} {dropItem.Item.LastName} został usunięty z Grupy {dropItem.Item.AssignedGroup}");
        }
        else
        {
            UserActivity.SendNewActivityNotification($"Użytkownik {dropItem.Item.Name} {dropItem.Item.LastName} został przeniesiony do Grupy {dropItem.DropzoneIdentifier}");
        }
    }
}
