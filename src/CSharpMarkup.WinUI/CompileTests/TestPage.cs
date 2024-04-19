#if DEBUG
// Any usings below that are unused are included to detect compile ambiguities
using System;
using Microsoft.UI;
using CSharpMarkup.WinUI;
using static Microsoft.UI.Colors;
using static CSharpMarkup.WinUI.Helpers;
using UI = Microsoft.UI.Xaml;
using Color = Windows.UI.Color;
using TextBloek = Microsoft.UI.Xaml.Controls.TextBlock;

namespace CompileTests
{
    partial class TestPage
    {
        StackPanel Markup => VStack(
            Button(),

            Button(TextBlock()),

            Button(Flyout()),

            StackPanel(),

            TextBlock (
                Text: "Hi"
            )  .Bind(vm.Title)
               .LineHeight(2.5)
               .TextAlignment().Right()
               .Grid(Row: 1) .Margin(2)
               .HorizontalAlignment().Bind(vm.Right, convert: (bool right) => right ? UI.HorizontalAlignment.Right : UI.HorizontalAlignment.Left),

            TextBlock(
                Run("A"),
                Hyperlink(new Uri(""))
            ),

            CheckBox("Check Me")
               .Bind(vm.IsOk),

            Rectangle()
               .Fill(SolidColorBrush(Blue)),

            Button(
                HStack(
                    TextBlock("Hi Again!"),

                    Image()
                       .Bind(vm.Avatar)
                       .Stretch() .UniformToFill()
                       .Rotation(37.5f)
                )
            )  .Grid(Row: 1, Column: 2, RowSpan: 4) .Grid_ColumnSpan(5) .Bind(vm.Columns) .Left()
               .BorderBrush(Blue)
               .Background(Blue)
               .Background(SolidColorBrush(Blue))

               .Background().Bind(vm.IsOk, convert: (bool isOk) => OkBrush(isOk))
               .Background(SolidColorBrush().Bind(vm.IsOk, converter: okBrushConverter))
               .Background(SolidColorBrush().Color().Bind(vm.IsOk, convert: (bool isOk) => OkColor(isOk))) // Note that this is type-safe; e.g. try using OkBrush
        );

        StackPanel Scrolling => VStack(
            ScrollViewer(
                TextBlock(new string('A', 100))
            )  .HorizontalScrollMode(UI.Controls.ScrollMode.Enabled)
               .HorizontalScrollMode().Enabled()
               .HorizontalScrollMode().Bind()
            ,

            ListView(() =>
                TextBlock("Item")
            )  .ScrollViewer_HorizontalScrollMode().Enabled()
               .ScrollViewer_HorizontalScrollMode().Bind()
               .ScrollViewer_HorizontalScrollMode(UI.Controls.ScrollMode.Enabled)
        );

        enum row { First, Second, Third }
        enum column { First, Second, Third }

        object[] Compare => new object[] // Note that the goal prio is 1 Readability, 2 Similarity to XAML, distant 3 Adhere to C# logic formatting and naming conventions
        {

            new TextBloek {
                Text = "Hi",
                LineHeight = 2.5,
                TextAlignment = UI.TextAlignment.Right, 
                OpticalMarginAlignment = UI.OpticalMarginAlignment.TrimSideBearings
            },

            TextBlock (
                Text: "Hi"
            )  .TextAlignment() .Right()
               .LineHeight (2.5)
               .OpticalMarginAlignment() .TrimSideBearings(),

            TextBlock(),

            ListView (() =>
                TextBlock("I'm a Template!")
            )  .ItemTemplate(DataTemplate(() => TextBlock("I'm a Template!")))
               .ItemTemplate(DataTemplate(AChildTemplate)),

            Grid (
                TextBlock("Hi")
                .Grid(0, 1, 0, 1)
                .Grid_Row(0)
                .Grid_RowSpan(1)
                .Grid_Column(0)
                .Grid_ColumnSpan(1),

                Button("Ho")
            ),

            Grid (
                Rows(10, 20, Auto, Star, Stars(2)),
                Columns(10, 20, Auto, Star, Stars(2)),

                TextBlock("Hi")
                .Grid(0, 1, 0, 1),

                Button("Ho")
            ),

            Grid (
                Rows ((row.First , 10), 
                      (row.Second, 20), 
                      (row.Third , Auto)),

                Columns ((column.First , 10), 
                         (column.Second, 20), 
                         (column.Third , Auto)),

                TextBlock("Hi")
                .Grid(row.Second, Last<row>(), First<column>(), column.Second)
                .Grid(row.First, column.First)
                .Grid_Row(row.Second)
                .Grid_Rows(row.Second, row.Third)
                .Grid_Column(column.Second)
                .Grid_Columns(column.Second, column.Third),

                Button("Ho")
            )

            // Color indicates which properties are defined by the view itself - so the ones specific for this type
            // This speeds up discovering the capabilities of a view type
            // Note that Pascal cased syntax reads better (consistent casing reduces noise) and changes less if it were replaced by a language feature like "omit new in expression builder"
            // Note that syntax coloring and whitespace formatting interact: less visible (colored) noise means less spaces in between needed for readability
        };

        static UIElement AChildTemplate() => TextBlock("I'm a template!");

        static void ARootTemplate(UI.DependencyObject root) =>
            ((Grid)root)
                .ColumnSpacing(123)
                .Children(
                    TextBlock("I'm a template!"),
                    Button()
                );
    }
}
#endif