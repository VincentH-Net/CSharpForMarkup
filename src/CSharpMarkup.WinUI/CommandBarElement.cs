using Xaml = Microsoft.UI.Xaml;

namespace CSharpMarkup.WinUI;

public class CommandBarElement : Xaml.Controls.ICommandBarElement
{
    readonly Xaml.Controls.ICommandBarElement element;

    #region ICommandBarElement implementation
    public int DynamicOverflowOrder { get => element.DynamicOverflowOrder; set => element.DynamicOverflowOrder = value; }
    public bool IsCompact { get => element.IsCompact; set => element.IsCompact = value; }
    public bool IsInOverflow => element.IsInOverflow;
    #endregion

    public static implicit operator CommandBarElement(AppBarButton e)           => new (e.UI);
    public static implicit operator CommandBarElement(AppBarElementContainer e) => new (e.UI);
    public static implicit operator CommandBarElement(AppBarSeparator e)        => new (e.UI);
    public static implicit operator CommandBarElement(AppBarToggleButton e)     => new (e.UI);

    public CommandBarElement(Xaml.Controls.ICommandBarElement element) => this.element = element;
}