using MudBlazor;
using UserManagementProject.ViewModels;

namespace UserManagementProject.Pages;

public partial class UsersManagement
{
    private const string UserDefaultGroup = "0";

    private void ItemUpdated(MudItemDropInfo<UserVM> dropItem)
    {
        dropItem.Item.AssignedGroup = dropItem.DropzoneIdentifier;
    }

    private List<UserVM> _users = new()
    {
        new UserVM(){ Name = "Adam", LastName = "Kowalski", City = "Radom", AssignedGroup = UserDefaultGroup },
        new UserVM(){ Name = "Piotr", LastName = "Piotrowski", City = "Radom", AssignedGroup = UserDefaultGroup },
        new UserVM(){ Name = "Magda", LastName = "Nowakowska", City = "Warszawa", AssignedGroup = UserDefaultGroup },
        new UserVM(){ Name = "Jan", LastName = "Nowak", City = "Radom", AssignedGroup = UserDefaultGroup }
    };
}
