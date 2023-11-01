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
}
#endif
