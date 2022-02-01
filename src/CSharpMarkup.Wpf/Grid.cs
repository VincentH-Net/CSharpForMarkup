using System;
using System.Globalization;
using Windows = System.Windows;
using Controls = System.Windows.Controls;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        public static Grid Grid(RowHeights rowHeights, params Windows.UIElement[] children) => Grid(rowHeights, Columns(), children);

        public static Grid Grid(ColumnWidths columnWidths, params Windows.UIElement[] children) => Grid(Rows(), columnWidths, children);

        public static Grid Grid(RowHeights rowHeights, ColumnWidths columnWidths, params Windows.UIElement[] children)
        {
            var grid = Grid(children);
            foreach (var height in rowHeights.Lengths) grid.UI.RowDefinitions.Add(new Controls.RowDefinition { Height = height });
            foreach (var width in columnWidths.Lengths) grid.UI.ColumnDefinitions.Add(new Controls.ColumnDefinition { Width = width });
            return grid;
        }

        public static RowHeights Rows(params Windows.GridLength[] heights) => new RowHeights { Lengths = heights };

        public static RowHeights Rows<TEnum>(params (TEnum name, Windows.GridLength height)[] rows) where TEnum : Enum
        {
            var rowHeights = new RowHeights { Lengths = new Windows.GridLength[rows.Length] };
            for (int i = 0; i < rows.Length; i++)
            {
                if (i != rows[i].name.ToInt())
                    throw new ArgumentException(
                        $"Value of row name { rows[i].name } is not { i }. " +
                        "Rows must be defined with enum names whose values form the sequence 0,1,2,..."
                    );
                rowHeights.Lengths[i] = rows[i].height;
            }
            return rowHeights;
        }

        public static ColumnWidths Columns(params Windows.GridLength[] widths) => new ColumnWidths { Lengths = widths };

        public static ColumnWidths Columns<TEnum>(params (TEnum name, Windows.GridLength width)[] columns) where TEnum : Enum
        {
            var columnWidths = new ColumnWidths{ Lengths = new Windows.GridLength[columns.Length] };
            for (int i = 0; i < columns.Length; i++)
            {
                if (i != columns[i].name.ToInt())
                    throw new ArgumentException(
                        $"Value of column name { columns[i].name } is not { i }. " +
                        "Columns must be defined with enum names whose values form the sequence 0,1,2,..."
                    );
                columnWidths.Lengths[i]= columns[i].width;
            }
            return columnWidths;
        }

        public struct RowHeights { internal Windows.GridLength[] Lengths; }

        public struct ColumnWidths { internal Windows.GridLength[] Lengths; }

        public static Windows.GridLength Auto => Windows.GridLength.Auto;

        public static Windows.GridLength Star = new Windows.GridLength(1, Windows.GridUnitType.Star);

        public static Windows.GridLength Stars(double value) => new Windows.GridLength(value, Windows.GridUnitType.Star);

        public static int All<TEnum>() where TEnum : Enum
        {
            var values = Enum.GetValues(typeof(TEnum));
            int span = (int)values.GetValue(values.Length - 1) + 1;
            return span;
        }

        public static TEnum First<TEnum>() where TEnum : Enum
        {
            var values = Enum.GetValues(typeof(TEnum));
            return (TEnum)values.GetValue(0);
        }

        public static TEnum Last<TEnum>() where TEnum : Enum
        {
            var values = Enum.GetValues(typeof(TEnum));
            return (TEnum)values.GetValue(values.Length - 1);
        }

        static int ToInt(this Enum enumValue) => Convert.ToInt32(enumValue, CultureInfo.InvariantCulture);
    }
}