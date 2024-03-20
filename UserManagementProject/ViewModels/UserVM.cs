namespace UserManagementProject.ViewModels;

public class UserVM
{
    public string Name { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string AssignedGroup { get; set; } = string.Empty;

    public string Image => Name + LastName;
}
