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
            ThemeColors backgroundColor = ThemeColors.ColorValuePrimary,
            bool centerTitle = false)
        {
            var grid = new Grid
            {
                BackgroundColor = backgroundColor.ToColor(),

                ColumnSpacing = 0,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = 40 },
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
                    new ContentView { Content =
                        (returnToPreviousViewCommandPropertyName != null) ?
                        new ImageButton { Source = "arrow_back.png", TapOnParent = true }
                        .Left() .CenterV()
                        .Bind(ImageButton.CommandProperty, returnToPreviousViewCommandPropertyName)
                        : null
                    }.Row(1, 2) .Padding(pageMarginSize, 0)
                     .Invoke(b => { if (allowBackNavigationPropertyName != null) b.Bind(ContentView.IsVisibleProperty, allowBackNavigationPropertyName); }),

                    new Label { 
                        TextColor = ThemeColors.White.ToColor(), 
                        FontAttributes = FontAttributes.Bold,
                        LineBreakMode = LineBreakMode.TailTruncation, 
                        HorizontalOptions = centerTitle ? LayoutOptions.Center : LayoutOptions.Start,
                        VerticalOptions = subTitlePropertyName != null ? LayoutOptions.End : LayoutOptions.Center 
                    }.SetFontSize(ThemeFontSizes.Size13)
                     .Row(1, subTitlePropertyName != null ? 1 : 2) .Col(centerTitle ? 0 : 1, centerTitle ? 4 : 1)
                     .Invoke(l => { if (titlePropertyName != null) l.Bind(titlePropertyName); })
                }
            };

            if (subTitlePropertyName != null) grid.Children.Add(
                new Label { 
                    TextColor = ThemeColors.White.ToColor(), 
                    FontAttributes = FontAttributes.Bold, 
                    LineBreakMode = LineBreakMode.TailTruncation, 
                    HorizontalOptions = centerTitle ? LayoutOptions.Center : LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Start 
                }.SetFontSize(ThemeFontSizes.Size13)
                 .Row(2) .Col(centerTitle ? 0 : 1, centerTitle ? 4 : 1)
                 .Bind(subTitlePropertyName)
            );
            return grid;
        }
    }
}
