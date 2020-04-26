using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Markup.LeftToRight;
using static Xamarin.Forms.Markup.GridRowsColumns;
using static CSharpMarkupIntro.SearchViewModel;
using static CSharpMarkupIntro.Styles;

namespace CSharpMarkupIntro
{
    public partial class SearchPage
    {
        void Build() => Content = 
            new StackLayout { Children = {
                Header,
                SearchResults,
                Footer
            }};

        StackLayout Header => new StackLayout { Children = {
            new Button { Text = "\u1438" } .Style (HeaderButton)
                        .Width (50)
                        .Bind (nameof(vm.BackCommand)),

            new Entry { Placeholder = "Search" }
                       .FillExpandHorizontal ()
                       .Bind (nameof(vm.SearchText))
        }} .Horizontal ();

        enum TweetRow { Separator, Title, Body, Actions }
        enum TweetColumn { AuthorImage, Content }

        CollectionView SearchResults => new CollectionView { ItemTemplate = new DataTemplate(() => 
            new Grid {
                RowDefinitions = Rows.Define (
                    (TweetRow.Separator, 2   ),
                    (TweetRow.Title    , Auto),
                    (TweetRow.Body     , Auto),
                    (TweetRow.Actions  , 32  )
                ),

                ColumnDefinitions = Columns.Define (
                    (TweetColumn.AuthorImage, 70  ),
                    (TweetColumn.Content    , Star)
                ),

                Children = {
                    new Label { },
                }
            } .Rainbow ())}.Background (Color.FromHex("171F2A")) 
               .Bind (nameof(vm.SearchResults));

        Label Footer => new Label { Text = "Footer" };
    }
}