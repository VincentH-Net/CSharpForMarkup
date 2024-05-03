using Uno.Extensions.Hosting;

namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public sealed partial class Shell : BaseUserControl<ShellViewModel>, IContentControlProvider, IBuildUI
{
    public Shell() => BuildUI();

    public UIControls.ContentControl ContentControl { get; private set; } = null!;
}
