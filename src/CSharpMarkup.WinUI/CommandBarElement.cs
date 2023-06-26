using Xaml = Microsoft.UI.Xaml;

namespace CSharpMarkup.WinUI;

public class CommandBarElement : IAnyUI<Xaml.Controls.ICommandBarElement>
{
    public Xaml.Controls.ICommandBarElement UI { get; }

    public static implicit operator CommandBarElement(AppBarButton e)           => new (e.UI);
    public static implicit operator CommandBarElement(AppBarElementContainer e) => new (e.UI);
    public static implicit operator CommandBarElement(AppBarSeparator e)        => new (e.UI);
    public static implicit operator CommandBarElement(AppBarToggleButton e)     => new (e.UI);

    public CommandBarElement(Xaml.Controls.ICommandBarElement ui) => this.UI = ui;
}