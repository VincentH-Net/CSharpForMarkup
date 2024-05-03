namespace WinUICsMarkupExamples.Presentation.Core;

public abstract partial class BaseUserControl<TViewModel> : BaseUserControl where TViewModel : class
{
    protected TViewModel? vm => DataContext as TViewModel;
}

// Because instances of this class are created with new instead of with a C# Markup 2 helper,
// derive this class from the UI type instead of from the C# Markup 2 type
public abstract partial class BaseUserControl : UIControls.UserControl
{
    new public UserControl Content(UI.Xaml.UIElement content)
        => CSharpMarkup.WinUI.Helpers.Content(this, content);
}
