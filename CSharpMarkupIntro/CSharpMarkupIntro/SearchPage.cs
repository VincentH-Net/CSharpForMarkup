using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Markup.LeftToRight;
using static Xamarin.Forms.Markup.GridRowsColumns;
using static CSharpMarkupIntro.SearchViewModel;
using System.Collections.Generic;

namespace CSharpMarkupIntro
{
    public partial class SearchPage
    {
        void Build()
        {
            BackgroundColor = Color.Black;

            Content = new StackLayout
            {
                Children =
                {
                    Header () .Assign (out header),
                    SearchResults ()
                }
            }  .Margins(top: 40) .Rainbow ();
        }

        View Header() => new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Children =
            {
                new Button { Text = "\u1438" }
                            .Width (50)
                            .Bind (nameof(vm.BackCommand)),

                new Entry { Placeholder = "Search" }
                           .FillExpandHorizontal ()
                           .Invoke (entry => 
                           {
                               entry.Focused +=Search_FocusChanged; 
                               entry.Unfocused += Search_FocusChanged; 
                           })
                           .Bind (nameof(vm.SearchText))
            }
        };

        enum ItemRow { Title, Body, Actions }
        enum ItemColumn { AuthorImage, Content }

        CollectionView SearchResults() => new CollectionView
        {
            ItemTemplate = new DataTemplate(() => new Grid
            {
                RowDefinitions = Rows.Define(
                    (ItemRow.Title, Auto),
                    (ItemRow.Body, Auto),
                    (ItemRow.Actions, Auto)
                ),

                ColumnDefinitions = Columns.Define(
                    (ItemColumn.AuthorImage, 100),
                    (ItemColumn.Content, Star)
                ),

                Children =
                {
                    RoundImage (90, nameof(Tweet.AuthorImage))
                               .RowSpan (All<ItemRow>()) .Column (ItemColumn.AuthorImage) .CenterHorizontal () .Top () .Margins (top: 10),


                    new Label { }
                               .Row (ItemRow.Title) .Column (ItemColumn.Content)
                               .Bind (nameof(Tweet.Header)),

                    new Label { }
                               .Row (ItemRow.Body) .Column (ItemColumn.Content)
                               .Bind (Label.FormattedTextProperty, nameof(Tweet.Body), convert: (List<TextFragment> fragments) => Format(fragments)),

                    new Button { }
                                .Row (ItemRow.Actions) .Column (ItemColumn.Content) .Left () .Margins (left: -5)
                                .Bind (Button.TextProperty, nameof(Tweet.IsLikedByMe), convert: (bool like) => like ? "\u2764" : "\u2661")
                                .BindCommand (nameof(vm.LikeCommand), source: vm)
                }
            }
        )} .Bind (nameof(vm.SearchResults));

        Frame RoundImage(float size, string path) => new Frame
        {
            IsClippedToBounds = true,
            CornerRadius = size / 2,
            Content = new Image { } .Bind (path)
        }  .Size (size) .Padding (0);

        FormattedString Format(List<TextFragment> fragments)
        {
            var s = new FormattedString();
            fragments?.ForEach(fragment => s.Spans.Add(new Span { 
                Text = fragment.Text,
                FontAttributes = fragment.IsMatch ? FontAttributes.Bold : FontAttributes.None 
            }));
            return s;
        }
    }
}