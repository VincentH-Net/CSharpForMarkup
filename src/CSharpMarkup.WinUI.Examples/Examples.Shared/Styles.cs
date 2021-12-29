using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace WinUICsMarkupExamples;

public static class Styles
{
    static Style<Button> headerButton;

    public static Style<Button> HeaderButton => headerButton ??= new Style<Button>(
        (UI.Controls.Button.ForegroundProperty, CornflowerBlue),
        (UI.Controls.Button.FontSizeProperty, 24)
    )   .BasedOn (Implicit.Buttons);

    public static class Implicit
    {
        static UI.ResourceDictionary dictionary;
        static Style<Button> buttons;
        static Style<TextBlock> textBlocks;
        static Style<TextBox> textBoxes;
        static Style<ListViewItem> listViewItems;

        public static UI.ResourceDictionary Dictionary => dictionary ??= CreateResourceDictionary(
            TextBlocks, Buttons, TextBoxes, ListViewItems
        );

        public static Style<TextBlock> TextBlocks => textBlocks ??= new Style<TextBlock>(
            (UI.Controls.TextBlock.ForegroundProperty, White)
        );

        public static Style<Button> Buttons => buttons ??= new Style<Button>(
            (UI.Controls.Button.BackgroundProperty, Transparent)
        );

        public static Style<TextBox> TextBoxes => textBoxes ??= new Style<TextBox>(
            (UI.Controls.TextBox.ForegroundProperty, White),
            (UI.Controls.TextBox.BackgroundProperty, Black)
        );

        public static Style<ListViewItem> ListViewItems => listViewItems ??= new Style<ListViewItem>(
            (UI.Controls.ListViewItem.HorizontalContentAlignmentProperty, UI.HorizontalAlignment.Stretch),
            (UI.Controls.ListViewItem.PaddingProperty, Thickness(0)),
            (UI.Controls.ListViewItem.MarginProperty, Thickness(0))
        );

        static UI.ResourceDictionary CreateResourceDictionary(params UI.Style[] styles)
        {
            var resources = new UI.ResourceDictionary();
            foreach (var style in styles) resources.Add(style.TargetType, style);
            return resources;
        }
    }
}