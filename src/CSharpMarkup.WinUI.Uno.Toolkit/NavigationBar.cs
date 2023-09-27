using Xaml = Microsoft.UI.Xaml;

namespace CSharpMarkup.WinUI.Uno.Toolkit
{
    public static partial class Helpers {
        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBar"/> with <paramref name="Content"/> </summary>
        public static NavigationBar NavigationBar(object Content, params CSharpMarkup.WinUI.CommandBarElement[] PrimaryCommands)
        {
            var bar = NavigationBar(PrimaryCommands);
            bar.UI.Content = Content;
            return bar;
        }
    }
}
