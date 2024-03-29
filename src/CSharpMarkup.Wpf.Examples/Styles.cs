﻿using CSharpMarkup.Wpf;
using System.Diagnostics;
using static CSharpMarkup.Wpf.Helpers;
namespace WpfCsMarkupExamples;

public static class Styles
{
    static Style<Button>? headerButton;

#if DEBUG // Hot reload support
    internal static void ClearCache() { headerButton = null; }
#endif

    public static Style<Button> HeaderButton => headerButton ??= new Style<Button>(
        (Button_UI.ForegroundProperty, SolidColorBrush(CornflowerBlue)),
        (Button_UI.FontSizeProperty, 24.0)
    )   .BasedOn (Implicit.Buttons);

    public static class Implicit
    {
        static UI.ResourceDictionary? dictionary;
        static Style<Button>? buttons;
        static Style<TextBlock>? textBlocks;
        static Style<TextBox>? textBoxes;
        static Style<ListViewItem>? listViewItems;

#if DEBUG // Hot reload support
        internal static void ClearCache() { dictionary = null; buttons = null; textBlocks = null; textBoxes = null; listViewItems = null; }
#endif

        public static UI.ResourceDictionary Dictionary => dictionary ??= CreateResourceDictionary(
            TextBlocks, Buttons, TextBoxes, ListViewItems
        );

        public static Style<TextBlock> TextBlocks => textBlocks ??= new Style<TextBlock>(
            (TextBlock_UI.ForegroundProperty, SolidColorBrush(White))
        );

        public static Style<Button> Buttons => buttons ??= new Style<Button>(
            (Button_UI.BackgroundProperty, SolidColorBrush(Transparent)),
            (Button_UI.BorderThicknessProperty, Thickness(0))
        );

        public static Style<TextBox> TextBoxes => textBoxes ??= new Style<TextBox>(
            (TextBox_UI.ForegroundProperty, SolidColorBrush(White)),
            (TextBox_UI.BackgroundProperty, SolidColorBrush(Black))
        );

        public static Style<ListViewItem> ListViewItems => listViewItems ??= new Style<ListViewItem>(
            (ListViewItem_UI.HorizontalContentAlignmentProperty, UI.HorizontalAlignment.Stretch),
            (ListViewItem_UI.FocusableProperty, false),
            (ListViewItem_UI.PaddingProperty, Thickness(0)),
            (ListViewItem_UI.MarginProperty, Thickness(0))
        );

        static UI.ResourceDictionary CreateResourceDictionary(params UI.Style[] styles)
        {
            var resources = new UI.ResourceDictionary();
            foreach (var style in styles) resources.Add(style.TargetType, style);
            return resources;
        }
    }
}