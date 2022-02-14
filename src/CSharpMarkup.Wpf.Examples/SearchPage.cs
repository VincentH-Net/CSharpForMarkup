using CSharpMarkup.Wpf;
using static CSharpMarkup.Wpf.Helpers;
namespace WpfCsMarkupExamples;

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

        TextBox() .Foreground (White)
           .VCenter () .Width (350)
           .Bind (vm.SearchText, BindingMode.TwoWay),

        Button("\U0001F50D") .Style (HeaderButton)
           .Width (50)
           .Bind (vm.SearchCommand)
    );

    enum TweetRow    { Title, Body, Actions }
    enum TweetColumn { AuthorImage, Content }

    ListView SearchResults => ListView(() =>
        Border ( Grid (
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

            TextBlock   ()
                        .FontSize (15) .TextWrapping().Wrap()
                        .Grid (TweetRow.Body, TweetColumn.Content) .Margins (top: 6, right: 10, bottom: 6)
                        .OnDataContextChanged<Tweet> (Format),

            LikeButton ()
                        .Grid (TweetRow.Actions, TweetColumn.Content) .Left () .Top ()
                        .BindCommand (vm.LikeCommand, vm)

        )) .MaxWidth(500) .BorderThicknesses (top: 0.5) .BorderBrush (Gray) .Padding (0, 6)

    )  .Background ("#171F2A")
       .Bind (vm.SearchResults);

    Ellipse RoundImage(double size) => Ellipse() .Size (size) .Fill (ImageBrush().Bind (tweet.AuthorImage, convert: (string uri) => UriImage(uri)));

    void Format(TextBlock_UI textBlock, Tweet tweet)
    {
        textBlock.Inlines.Clear();

        tweet?.Body?.ForEach(fragment => textBlock.Inlines.Add(
            fragment.IsMatch ?
            Link (fragment.Text, SearchViewModel.LinkUri(fragment.Text)) .FontSize (15) :
            Run (fragment.Text)
        ));
    }

    Button LikeButton() => Button (
        TextBlock()
           .Foreground (Red) .FontSize (20) 
           .Bind(tweet.IsLikedByMe, convert: (bool like) => like ? "\u2764" : "\u2661")
    )  .HorizontalContentAlignment().Center() .VerticalContentAlignment().Center() .Margin (0) .Size (32) .Padding (0);

    TextBlock Footer => TextBlock ("See ", Link ("C# Markup on GitHub", CsMarkupUri), " for more information")
       .FontSize (14)
       .HCenter()
       .Margins (bottom: 6);

    Hyperlink Link(string text, Uri uri) => Hyperlink(text)
       .Foreground (CornflowerBlue)
       .Invoke(l => l.Click += (_, _) => App.LaunchUri(uri));
}