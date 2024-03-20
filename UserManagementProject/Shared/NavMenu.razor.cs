namespace UserManagementProject.Shared;

public partial class NavMenu
{
    public int SelectedBookmark { get; set; } = 1;

    private void ChangeSelectedBookmark(int bookmark) => SelectedBookmark = bookmark;
}
