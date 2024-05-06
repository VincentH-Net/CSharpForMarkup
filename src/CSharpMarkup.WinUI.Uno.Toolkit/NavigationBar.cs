#if !GENERATE
using UnoToolkitUI = Uno.Toolkit.UI;

namespace CSharpMarkup.WinUI.Uno.Toolkit
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBar"/> with <paramref name="Content"/> </summary>
        public static NavigationBar NavigationBar(UIObject Content, params CommandBarElement[] PrimaryCommands)
        {
            var bar = NavigationBar(PrimaryCommands);
            bar.UI.Content = Content.UI;
            return bar;
        }
    }

    public static partial class NavigationBarExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.SecondaryCommands"/></summary>
        public static TView SecondaryCommands<TView>(this TView view, params CommandBarElement[] SecondaryCommands) where TView : NavigationBar
        {
            // TODO: Add support to generate non-primary collection type properties setters - taking care not to allow chain breaking;
            // below code is currently only generated for the primary children of layouts in helpers, not in property setters.
            // For now, code the rare case where this occurs and is safe wrt chain breaking (meaning nested subchains of the same type
            // as a parent chain cannot occur) manually, like below.
            var ui = view.UI;
            for (int i = 0; i < SecondaryCommands.Length; i++)
            {
                var child = SecondaryCommands[i];
                if (child == null) continue;

                var subChildren = Spreader<CommandBarElement>.ExtractChildren(child);
                if (subChildren is not null)
                    for (int j = 0; j < subChildren.Length; j++)
                        ui.SecondaryCommands.Add(subChildren[j].UI);
                else
                    ui.SecondaryCommands.Add(child.UI);
            }
            return view;
        }
    }
}
#endif
