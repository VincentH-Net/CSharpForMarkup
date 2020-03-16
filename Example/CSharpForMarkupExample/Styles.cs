using Xamarin.Forms.Markup;
using Xamarin.Forms;

namespace CSharpForMarkupExample
{
    public static class Styles
    {
        static Style<Button> buttons, filledButton;
        static Style<Label> labels;
        static Style<Span> link;

        #region Implicit styles

        public static ResourceDictionary Implicit => new ResourceDictionary { Buttons, Labels };

        public static Style<Button> Buttons => buttons ?? (buttons = new Style<Button>(
            (Button.HeightRequestProperty    , 44),
            (Button.FontSizeProperty         , 13),
            (Button.HorizontalOptionsProperty, LayoutOptions.Center),
            (Button.VerticalOptionsProperty  , LayoutOptions.Center)
        ));

        public static Style<Label> Labels => labels ?? (labels = new Style<Label>(
            (Label.FontSizeProperty , 13),
            (Label.TextColorProperty, Colors.BgBlue1.ToColor())
        ));

        #endregion Implicit styles

        #region Explicit styles

        public static Style<Button> FilledButton => filledButton ?? (filledButton = new Style<Button>( 
            (Button.TextColorProperty, Colors.White.ToColor()),
            (Button.BackgroundColorProperty, Colors.ColorValueAccent.ToColor())
        )) .BasedOn (Buttons);

        public static Style<Span> Link => link ?? (link = new Style<Span>(
            (Span.TextColorProperty, Color.Blue),
            (Span.TextDecorationsProperty, TextDecorations.Underline)
        ));

        #endregion Explicit styles
    }
}
