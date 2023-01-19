using CSharpMarkup.WinUI;
namespace WinUICsMarkupExamples;

public static class Styles
{
    static Style<Button>? headerButton;

    public static Style<Button> HeaderButton => headerButton ??= new Style<Button>(
        (Button_UI.ForegroundProperty, CornflowerBlue),
        (Button_UI.FontSizeProperty, 24)
    )   .BasedOn (Implicit.Buttons);

    public static class Implicit
    {
        static UI.ResourceDictionary? dictionary;
        static Style<Button>? buttons;
        static Style<TextBlock>? textBlocks;
        static Style<TextBox>? textBoxes;
        static Style<ListViewItem>? listViewItems;

        public static UI.ResourceDictionary Dictionary => dictionary ??= CreateResourceDictionary(
            TextBlocks, Buttons, TextBoxes, ListViewItems
        );

        public static Style<TextBlock> TextBlocks => textBlocks ??= new (
            (TextBlock_UI.ForegroundProperty, White)
        );

        public static Style<Button> Buttons => buttons ??= new (
            (Button_UI.BackgroundProperty, Transparent)
        );

        public static Style<TextBox> TextBoxes => textBoxes ??= new (
            (TextBox_UI.ForegroundProperty, White),
            (TextBox_UI.BackgroundProperty, Black)
        );

        public static Style<ListViewItem> ListViewItems => listViewItems ??= new (
            (ListViewItem_UI.HorizontalContentAlignmentProperty, UI.HorizontalAlignment.Stretch),
            (ListViewItem_UI.PaddingProperty, "0"),
            (ListViewItem_UI.MarginProperty, "0")
        );

        static UI.ResourceDictionary CreateResourceDictionary(params UI.Style[] styles)
        {
            var resources = new UI.ResourceDictionary();
            foreach (var style in styles) resources.Add(style.TargetType, style);
            return resources;
        }
    }
}
