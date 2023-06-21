using Xaml = Microsoft.UI.Xaml;

namespace CSharpMarkup.WinUI;

public partial class MenuFlyoutItemBase
{
    public static implicit operator Xaml.Controls.MenuFlyoutItemBase(MenuFlyoutItemBase item) => item.UI;
}