using CSharpForMarkup;
using Xamarin.Forms;

namespace CSharpForMarkupExample.Views.Controls
{
    public static class PageHeader
    {
        static double rowHeight = 25;

        public static double ButtonDistanceFromTopOfPage => rowHeight * 2;

        public static double ButtonHeight => rowHeight;

        public static Grid Create(
            double pageMarginSize, 
            string titlePropertyName = null, 
            string subTitlePropertyName = null, 
            string returnToPreviousViewCommandPropertyName = null, 
            string allowBackNavigationPropertyName = null, 
            Colors backgroundColor = Colors.ColorValuePrimary,
            bool centerTitle = false)
        {
            var grid = new Grid
            {
                BackgroundColor = backgroundColor.ToColor(),

                ColumnSpacing = 0,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = 60 },
                    new ColumnDefinition { },
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = GridLength.Auto },
                },

                RowDefinitions = {
                    new RowDefinition { Height = Device.RuntimePlatform == Device.iOS ? rowHeight : 0 },
                    new RowDefinition { Height = rowHeight },
                    new RowDefinition { Height = rowHeight },
                },

                Children = {
                    new ContentView { Content = (returnToPreviousViewCommandPropertyName != null) ?
                        new Button { Text = "<" } .Font (FontSizes._24, FontAttributes.Bold) .TextColor (Colors.White) .BackgroundColor (backgroundColor)
                        .Left() .CenterV()
                        .Bind(Button.CommandProperty, returnToPreviousViewCommandPropertyName)
                        : null
                    }.Row (1, 2) .Padding (pageMarginSize, 0)
                     .Invoke(b => { if (allowBackNavigationPropertyName != null) b.Bind(ContentView.IsVisibleProperty, allowBackNavigationPropertyName); }),

                    new Label { 
                        LineBreakMode = LineBreakMode.TailTruncation, 
                        HorizontalOptions = centerTitle ? LayoutOptions.Center : LayoutOptions.Start,
                        VerticalOptions = subTitlePropertyName != null ? LayoutOptions.End : LayoutOptions.Center 
                    }.Font (FontAttributes.Bold) .TextColor (Colors.White)
                     .Row (1, subTitlePropertyName != null ? 1 : 2) .Col (centerTitle ? 0 : 1, centerTitle ? 4 : 1)
                     .Invoke(l => { if (titlePropertyName != null) l.Bind(titlePropertyName); })
                }
            };

            if (subTitlePropertyName != null) grid.Children.Add(
                new Label { 
                    LineBreakMode = LineBreakMode.TailTruncation, 
                    HorizontalOptions = centerTitle ? LayoutOptions.Center : LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Start 
                }.Font (FontAttributes.Bold) .TextColor (Colors.White)
                 .Row (2) .Col (centerTitle ? 0 : 1, centerTitle ? 4 : 1)
                 .Bind(subTitlePropertyName)
            );
            return grid;
        }
    }
}
