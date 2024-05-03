using VM = WinUICsMarkupExamples.Presentation.Example.SearchViewModel;

namespace WinUICsMarkupExamples.Presentation.Example;

partial class SearchPage
{
    public void BuildUI() => Content(
        Grid(
            Rows(Auto, Star, Auto),

            Header,
            SearchResults .Grid_Row(1),
            Footer .Grid_Row(2)
        )
    )  .Background(Black);

    NavigationBar Header => NavigationBar(
        TextBox(PlaceholderText: "Search") .Style(ThemeResource.ComboBoxTextBoxStyle) .VerticalAlignment().Center() .Bind(vm?.SearchText, BindingMode.TwoWay),
        AppBarButton() .Icon("Images/search" ) .OnClick(vm!.SearchCommand),
        AppBarButton() .Icon("Images/forward") .OnClick(vm!.ForwardCommand)
    )  .HorizontalContentAlignment().Stretch()
       #if HAS_UNO
       .Style().AppResource("XamlDefaultNavigationBar")
       #endif
    ; 

    enum TweetRow { Title, Body, Actions }
    enum TweetColumn { AuthorImage, Content }

    ListView SearchResults => ListView(() =>
        Grid(
            Rows(
                (TweetRow.Title, Auto),
                (TweetRow.Body, Auto),
                (TweetRow.Actions, Auto)
            ),

            Columns(
                (TweetColumn.AuthorImage, 70),
                (TweetColumn.Content, Star)
            ),

            RoundImage(53)
                .Grid(TweetRow.Title, TweetRow.Actions, TweetColumn.AuthorImage) .HCenter() .Top() .Margins(left: 10, top: 4),

            TextBlock()
                .TextTrimming().CharacterEllipsis() .FontSize(16)
                .Grid(TweetRow.Title, TweetColumn.Content) .Margins(right: 10)
                .Bind(tweet.Header),

            TextBlock()
                .FontSize(15) .TextWrapping().WrapWholeWords()
                .Grid(TweetRow.Body, TweetColumn.Content) .Margins(right: 10)
                .OnDataContextChanged<Tweet?>(Format),

            LikeButton()
                .Grid(TweetRow.Actions, TweetColumn.Content) .Left() .Top()
                .BindCommand(vm?.LikeCommand, vm)

        )  .BorderThicknesses(top: 0.5) .BorderBrush(Gray)
           .Padding(0, 6) .RowSpacing(6) .ColumnSpacing(6)

    )  .Background("#171F2A") .SelectionMode().None()
       .Bind(vm?.SearchResults);

    static Ellipse RoundImage(double size) => Ellipse() .Size(size) .Fill(ImageBrush() .Bind(tweet.AuthorImage));

    void Format(UIControls.TextBlock textBlock, Tweet? tweet)
    {
        textBlock.Inlines.Clear();

        tweet?.Body?.ForEach(fragment => textBlock.Inlines.Add(
            fragment.IsMatch ?
            Link(fragment.Text, VM.LinkUri(fragment.Text)) .FontSize(15) :
            Run(fragment.Text)
        ));
    }

    static Button LikeButton() => Button() .Style().AppResource("LikeButtonStyle")
       .Foreground(White) .FontSize(20)
       .HorizontalContentAlignment().Center() .VerticalContentAlignment().Center() .Margin(0) .Size(32) .Padding(0)
       .Content().Bind(tweet.IsLikedByMe, convert: (bool like) => like ? "\u2764" : "\u2661");


    static TextBlock Footer => TextBlock("See ", Link("C# Markup 2 on GitHub", Constants.CsMarkupUri), " for more information")
       .FontSize(14) .Foreground(White)
       .HCenter()
       .Margins(bottom: 24);

    static Hyperlink Link(string text, Uri uri) => Hyperlink(uri, text) .Foreground(CornflowerBlue);
}
