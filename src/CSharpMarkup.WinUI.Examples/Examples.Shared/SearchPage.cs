using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace WinUICsMarkupExamples;

public partial class SearchPage
{
    public void Build() => Content =

    StackPanel (
        Header .Assign (out header),
        SearchResults,
        Footer
    )  .Background (Black) .WithHotReloadButton();

    StackPanel Header => HStack (
        Button ("\u22EF") .Style (HeaderButton)
           .Width (50)
           .Bind (vm.BackCommand),

        TextBox(PlaceholderText: "Search") .Foreground (White)
           .VCenter ()
           .Bind (vm.SearchText, Microsoft.UI.Xaml.Data.BindingMode.TwoWay),

        Button("\U0001F50D").Style(HeaderButton)
           .Width(50)
           .Bind(vm.SearchCommand)
    );

    enum TweetRow    { Title, Body, Actions }
    enum TweetColumn { AuthorImage, Content }

    ListView SearchResults => ListView(() =>
        Grid (
            Rows (
                (TweetRow.Title  , Auto),
                (TweetRow.Body   , Auto),
                (TweetRow.Actions, Auto)
            ),

            Columns (
                (TweetColumn.AuthorImage, 70),
                (TweetColumn.Content    , Star)
            ),

            RoundImage  (53)
                        .Grid (TweetRow.Title, TweetRow.Actions, TweetColumn.AuthorImage) .HCenter() .Top() .Margins (left: 10, top: 4),

            TextBlock ().TextTrimming().CharacterEllipsis() .FontSize (16)
                        .Grid (TweetRow.Title, TweetColumn.Content) .Margins (right: 10)
                        .Bind (tweet.Header),

            TextBlock   (FontSize: 15)
                        .TextWrapping().WrapWholeWords()
                        .Grid (TweetRow.Body, TweetColumn.Content) .Margins (right: 10)
                        .OnDataContextChanged<TextBlock, UI.Controls.TextBlock, Tweet> (Format),

            LikeButton ()
                        .Grid (TweetRow.Actions, TweetColumn.Content) .Left () .Top ()
                        .BindCommand (vm.LikeCommand, vm)

        )  .BorderThicknesses (top: 0.5) .BorderBrush (Gray)
           .Padding (0, 6) .RowSpacing (6) .ColumnSpacing (6)

    )  .Background ("#171F2A") .SelectionMode().None()
       .Bind (vm.SearchResults);

    Ellipse RoundImage(double size) => Ellipse()
       .Width (size) .Height (size) .Fill (ImageBrush().ImageSource().Bind (tweet.AuthorImage));

    void Format(UI.Controls.TextBlock textBlock, Tweet tweet)
    {
        textBlock.Inlines.Clear();

        tweet?.Body?.ForEach(fragment => textBlock.Inlines.Add(fragment.IsMatch ?
            Link (fragment.Text, vm?.LinkUri(fragment.Text)) .FontSize (15) .UI :
            (UI.Documents.Inline) Run (fragment.Text)
        ));
    }

    Button LikeButton() => Button()
       .Foreground (White) .FontSize (20)
       .HorizontalContentAlignment().Center() .VerticalContentAlignment().Center() .Margin (0) .Size (32) .Padding (0)
       .Content().Bind (tweet.IsLikedByMe, convert: (bool like) => like ? "\u2764" : "\u2661");

    Hyperlink Link(string text, Uri uri) => Hyperlink (uri, text) .Foreground (CornflowerBlue);
    
    TextBlock Footer => TextBlock (Inlines(
        Run  ("See "),
        Link ("C# Markup on GitHub", CsMarkupUri),
		Run  (" for more information")
    )) .FontSize (14) .Foreground (White)
       .HCenter()
       .Margins (bottom: 6);
}