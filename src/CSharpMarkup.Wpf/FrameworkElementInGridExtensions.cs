using System;
using System.Globalization;
using Controls = System.Windows.Controls;

namespace CSharpMarkup.Wpf
{
	public static class FrameworkElementInGridExtensions
    {
		public static TFrameworkElement Grid_Row<TFrameworkElement, TRow>(this TFrameworkElement element, TRow row) where TFrameworkElement : FrameworkElement where TRow : Enum
		{
			int rowIndex = row.ToInt();
			element.UI.SetValue(Controls.Grid.RowProperty, rowIndex);
			return element;
		}

		public static TFrameworkElement Grid_Rows<TFrameworkElement, TRow>(this TFrameworkElement element, TRow first, TRow last) where TFrameworkElement : FrameworkElement where TRow : Enum
		{
			int rowIndex = first.ToInt();
			int span = last.ToInt() - rowIndex + 1;
			element.UI.SetValue(Controls.Grid.RowProperty, rowIndex);
			element.UI.SetValue(Controls.Grid.RowSpanProperty, span);
			return element;
		}

		public static TFrameworkElement Grid_Rows<TFrameworkElement>(this TFrameworkElement element, int first, int last) where TFrameworkElement : FrameworkElement
		{
			element.UI.SetValue(Controls.Grid.RowProperty, first);
			element.UI.SetValue(Controls.Grid.RowSpanProperty, last + 1 - first);
			return element;
		}

		public static TFrameworkElement Grid_Column<TFrameworkElement, TColumn>(this TFrameworkElement element, TColumn column) where TFrameworkElement : FrameworkElement where TColumn : Enum
		{
			int columnIndex = column.ToInt();
			element.UI.SetValue(Controls.Grid.ColumnProperty, columnIndex);
			return element;
		}

		public static TFrameworkElement Grid_Columns<TFrameworkElement>(this TFrameworkElement element, int first, int last) where TFrameworkElement : FrameworkElement
		{
			element.UI.SetValue(Controls.Grid.ColumnProperty, first);
			element.UI.SetValue(Controls.Grid.ColumnSpanProperty, last + 1 - first);
			return element;
		}

		public static TFrameworkElement Grid_Columns<TFrameworkElement, TColumn>(this TFrameworkElement element, TColumn first, TColumn last) where TFrameworkElement : FrameworkElement where TColumn : Enum
		{
			int columnIndex = first.ToInt();
			int span = last.ToInt() + 1 - columnIndex;
			element.UI.SetValue(Controls.Grid.ColumnProperty, columnIndex);
			element.UI.SetValue(Controls.Grid.ColumnSpanProperty, span);
			return element;
		}

		public static TFrameworkElement Grid<TFrameworkElement, TRow, TColumn>(this TFrameworkElement element, TRow row, TColumn column)
			where TFrameworkElement : FrameworkElement where TRow : Enum where TColumn : Enum
		{
			int rowIndex = row.ToInt();
			int columnIndex = column.ToInt();
			element.UI.SetValue(Controls.Grid.RowProperty, rowIndex);
			element.UI.SetValue(Controls.Grid.ColumnProperty, columnIndex);
			return element;
		}

		public static TFrameworkElement Grid<TFrameworkElement, TRow, TColumn>(this TFrameworkElement element, TRow firstRow, TRow lastRow, TColumn firstColumn, TColumn lastColumn = default)
			where TFrameworkElement : FrameworkElement where TRow : Enum where TColumn : Enum
		{
			int rowIndex = firstRow.ToInt();
			int rowSpan = lastRow.ToInt() - rowIndex + 1;
			int columnIndex = firstColumn.ToInt();
			int columnSpan = lastColumn is not null ? lastColumn.ToInt() + 1 - columnIndex : 1;
			element.UI.SetValue(Controls.Grid.RowProperty, rowIndex);
			element.UI.SetValue(Controls.Grid.RowSpanProperty, rowSpan);
			element.UI.SetValue(Controls.Grid.ColumnProperty, columnIndex);
			element.UI.SetValue(Controls.Grid.ColumnSpanProperty, columnSpan);
			return element;
		}

		static int ToInt(this Enum enumValue) => Convert.ToInt32(enumValue, CultureInfo.InvariantCulture);
	}
}
