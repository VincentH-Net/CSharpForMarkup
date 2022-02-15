using System;
using System.Globalization;
using Microsoft.UI.Xaml;
using Xaml = Microsoft.UI.Xaml;
using Controls = Microsoft.UI.Xaml.Controls;

// TODO: check what is the appropriate symbol for WinUI 3 Desktop #if NETFX_CORE
#if WINUI
using _Length = CSharpMarkup.WinUI.ConvertedGridLength;
#else
using _Length = Microsoft.UI.Xaml.GridLength;
#endif

namespace CSharpMarkup.WinUI
{
    public static partial class Helpers
    {
        public static Grid Grid(RowHeights rowHeights, params Xaml.UIElement[] children) => Grid(rowHeights, Columns(), children);

        public static Grid Grid(ColumnWidths columnWidths, params Xaml.UIElement[] children) => Grid(Rows(), columnWidths, children);

        public static Grid Grid(RowHeights rowHeights, ColumnWidths columnWidths, params Xaml.UIElement[] children)
        {
            var grid = Grid(children);
            foreach (var height in rowHeights.Lengths) grid.UI.RowDefinitions.Add(new Controls.RowDefinition { Height = height });
            foreach (var width in columnWidths.Lengths) grid.UI.ColumnDefinitions.Add(new Controls.ColumnDefinition { Width = width });
            return grid;
        }

        public static RowHeights Rows(params _Length[] heights) => new RowHeights { Lengths = heights };

        public static RowHeights Rows<TEnum>(params (TEnum name, _Length height)[] rows) where TEnum : Enum
        {
            var rowHeights = new RowHeights { Lengths = new _Length[rows.Length] };
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

        public static ColumnWidths Columns(params _Length[] widths) => new ColumnWidths { Lengths = widths };

        public static ColumnWidths Columns<TEnum>(params (TEnum name, _Length width)[] columns) where TEnum : Enum
        {
            var columnWidths = new ColumnWidths{ Lengths = new _Length[columns.Length] };
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

        public struct RowHeights { internal _Length[] Lengths; }

        public struct ColumnWidths { internal _Length[] Lengths; }

#if WINDOWS_UWP
        public static GridLength Auto => new GridLength { GridUnitType = GridUnitType.Auto };

        public static GridLength Star = new GridLength { Value = 1, GridUnitType = GridUnitType.Star };

        public static GridLength Stars(double value) => new GridLength { Value = value, GridUnitType = GridUnitType.Star };
#else
        public static GridLength Auto => GridLength.Auto;

        public static GridLength Star = new GridLength(1, GridUnitType.Star);

        public static GridLength Stars(double value) => new GridLength(value, GridUnitType.Star);
#endif

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

#if WINUI
    public struct ConvertedGridLength
    {
        readonly GridLength length;

        public ConvertedGridLength(GridLength length) => this.length = length;

        public static implicit operator ConvertedGridLength(GridLength gridLength) => new ConvertedGridLength(gridLength);
        public static implicit operator ConvertedGridLength(double pixels) => new ConvertedGridLength(
#if WINDOWS_UWP
        new GridLength { Value = pixels, GridUnitType = GridUnitType.Pixel }
#else
        new GridLength(pixels)
#endif
        );
        public static implicit operator GridLength(ConvertedGridLength convertedGridLength) => convertedGridLength.length;
    }
#endif
}