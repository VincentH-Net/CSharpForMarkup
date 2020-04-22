using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Markup.LeftToRight;
using static Xamarin.Forms.Markup.GridRowsColumns;

namespace CSharpMarkupIntro
{
    public partial class SearchPage
    {
        enum ItemRow { Title, Body, Actions }
        enum ItemColumn { AuthorImage, Content }

        void Build()
        {
            Content = new StackLayout 
            { 
                Children =
                {
                    Header,
                    //new StackLayout
                    //{
                    //    Orientation = StackOrientation.Horizontal,
                    //    Children =
                    //    {
                    //        new Button { Text = "\u1438" }
                    //                    .Width (50),

                    //        new Entry { Placeholder = "Search" }
                    //                   .FillExpandHorizontal (),

                    //        new Button { Text = "Cancel" }
                    //    }
                    //},

                    new Grid // TODO: Make this an item template in a collectionview
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
                            new Image { Source = "icon.png" }
                                        .RowSpan (All<ItemRow>()),

                            new Label { Text = "Title" }
                                        .Row (ItemRow.Title) .Column (ItemColumn.Content),

                            new Label { Text = "Body" }  // TODO: Make this a collection of spans, with only a bool to say it is the search term style
                                        .Row (ItemRow.Body) .Column (ItemColumn.Content),

                            new Button { Text = "O" }
                                        .Row (ItemRow.Actions) .Column (ItemColumn.Content) .Left ()
                        }
                    }
                }
            };
        }

        View Header => new StackLayout 
        {
            Orientation = StackOrientation.Horizontal,
            Children =
            {
                new Button { Text = "\u1438" }
                            .Width (50),

                new Entry { Placeholder = "Search" }
                            .FillExpandHorizontal (),

                new Button { Text = "Cancel" }
            }
        };
    }
}
