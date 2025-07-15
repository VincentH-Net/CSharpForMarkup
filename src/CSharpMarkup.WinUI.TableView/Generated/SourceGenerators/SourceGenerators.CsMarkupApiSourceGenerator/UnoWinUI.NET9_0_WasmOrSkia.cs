// Start of generated C# Markup API for Uno.WinUI
#if NET9_0 && __WASM_OR_SKIA__ && !DESKTOP && !BROWSERWASM

using System;
using System.Collections;
using System.Collections.Generic;
using CSharpMarkup.WinUI.GeneratedCodeUtilities;
using Xaml = Microsoft.UI.Xaml;
using TvUI = WinUI.TableView;

namespace CSharpMarkup.WinUI.TableView // TableViewDatePicker
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.Controls.TableViewDatePicker"/></summary>
        public static TableViewDatePicker TableViewDatePicker(object? SelectedDate = default)
        {
            var ui = new TvUI.Controls.TableViewDatePicker();
            if (SelectedDate is not null) ui.SelectedDate = SelectedDate;
            return CSharpMarkup.WinUI.TableView.TableViewDatePicker.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.Controls.TableViewDatePicker"/></summary>
        public static TableViewDatePicker TableViewDatePicker()
        {
            var ui = new TvUI.Controls.TableViewDatePicker();
            return CSharpMarkup.WinUI.TableView.TableViewDatePicker.StartChain(ui);
        }
    }

    public partial class TableViewDatePicker : CalendarDatePicker, IUI<TvUI.Controls.TableViewDatePicker>
    {
        static TableViewDatePicker instance;

        internal static TableViewDatePicker StartChain(TvUI.Controls.TableViewDatePicker ui)
        {
            if (instance == null) instance = new TableViewDatePicker();
            instance.UI = ui;
            return instance;
        }

        TvUI.Controls.TableViewDatePicker ui;

        public new TvUI.Controls.TableViewDatePicker UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TableViewDatePicker view) => view?.UI;

        public static implicit operator TvUI.Controls.TableViewDatePicker(TableViewDatePicker view) => view?.UI;

        public static implicit operator TableViewDatePicker(TvUI.Controls.TableViewDatePicker ui) => TableViewDatePicker.StartChain(ui);

        public TableViewDatePicker Invoke(Action<TvUI.Controls.TableViewDatePicker> action) { action?.Invoke(UI); return this; }

        protected TableViewDatePicker() { }
    }

    public static partial class TableViewDatePickerExtensions
    {
        /// <summary>Set <see cref="TvUI.Controls.TableViewDatePicker.SelectedDate"/></summary>
        public static TView SelectedDate<TView>(this TView view, object? value) where TView : TableViewDatePicker { view.UI.SelectedDate = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.Controls.TableViewDatePicker.SelectedDate"/></summary>
        public static DependencyProperty<TTarget, object?> SelectedDate<TTarget>(this TTarget target) where TTarget : TableViewDatePicker
        => DependencyProperty<TTarget, object?>.Get(target, TvUI.Controls.TableViewDatePicker.SelectedDateProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewTimePicker
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.Controls.TableViewTimePicker"/></summary>
        public static TableViewTimePicker TableViewTimePicker(string ClockIdentifier = default, int? MinuteIncrement = default, string? PlaceholderText = default, object? SelectedTime = default)
        {
            var ui = new TvUI.Controls.TableViewTimePicker();
            if (ClockIdentifier is not null) ui.ClockIdentifier = ClockIdentifier;
            if (MinuteIncrement is not null) ui.MinuteIncrement = MinuteIncrement.Value;
            if (PlaceholderText is not null) ui.PlaceholderText = PlaceholderText;
            if (SelectedTime is not null) ui.SelectedTime = SelectedTime;
            return CSharpMarkup.WinUI.TableView.TableViewTimePicker.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.Controls.TableViewTimePicker"/></summary>
        public static TableViewTimePicker TableViewTimePicker()
        {
            var ui = new TvUI.Controls.TableViewTimePicker();
            return CSharpMarkup.WinUI.TableView.TableViewTimePicker.StartChain(ui);
        }
    }

    public partial class TableViewTimePicker : Control, IUI<TvUI.Controls.TableViewTimePicker>
    {
        static TableViewTimePicker instance;

        internal static TableViewTimePicker StartChain(TvUI.Controls.TableViewTimePicker ui)
        {
            if (instance == null) instance = new TableViewTimePicker();
            instance.UI = ui;
            return instance;
        }

        TvUI.Controls.TableViewTimePicker ui;

        public new TvUI.Controls.TableViewTimePicker UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TableViewTimePicker view) => view?.UI;

        public static implicit operator TvUI.Controls.TableViewTimePicker(TableViewTimePicker view) => view?.UI;

        public static implicit operator TableViewTimePicker(TvUI.Controls.TableViewTimePicker ui) => TableViewTimePicker.StartChain(ui);

        public TableViewTimePicker Invoke(Action<TvUI.Controls.TableViewTimePicker> action) { action?.Invoke(UI); return this; }

        protected TableViewTimePicker() { }
    }

    public static partial class TableViewTimePickerExtensions
    {
        /// <summary>Set <see cref="TvUI.Controls.TableViewTimePicker.ClockIdentifier"/></summary>
        public static TView ClockIdentifier<TView>(this TView view, string value) where TView : TableViewTimePicker { view.UI.ClockIdentifier = value; return view; }

        /// <summary>Set <see cref="TvUI.Controls.TableViewTimePicker.MinuteIncrement"/></summary>
        public static TView MinuteIncrement<TView>(this TView view, int value) where TView : TableViewTimePicker { view.UI.MinuteIncrement = value; return view; }

        /// <summary>Set <see cref="TvUI.Controls.TableViewTimePicker.PlaceholderText"/></summary>
        public static TView PlaceholderText<TView>(this TView view, string? value) where TView : TableViewTimePicker { view.UI.PlaceholderText = value; return view; }

        /// <summary>Set <see cref="TvUI.Controls.TableViewTimePicker.SelectedTime"/></summary>
        public static TView SelectedTime<TView>(this TView view, object? value) where TView : TableViewTimePicker { view.UI.SelectedTime = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.Controls.TableViewTimePicker.ClockIdentifier"/></summary>
        public static DependencyProperty<TTarget, string> ClockIdentifier<TTarget>(this TTarget target) where TTarget : TableViewTimePicker
        => DependencyProperty<TTarget, string>.Get(target, TvUI.Controls.TableViewTimePicker.ClockIdentifierProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.Controls.TableViewTimePicker.MinuteIncrement"/></summary>
        public static DependencyProperty<TTarget, int> MinuteIncrement<TTarget>(this TTarget target) where TTarget : TableViewTimePicker
        => DependencyProperty<TTarget, int>.Get(target, TvUI.Controls.TableViewTimePicker.MinuteIncrementProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.Controls.TableViewTimePicker.PlaceholderText"/></summary>
        public static DependencyProperty<TTarget, string?> PlaceholderText<TTarget>(this TTarget target) where TTarget : TableViewTimePicker
        => DependencyProperty<TTarget, string?>.Get(target, TvUI.Controls.TableViewTimePicker.PlaceholderTextProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.Controls.TableViewTimePicker.SelectedTime"/></summary>
        public static DependencyProperty<TTarget, object?> SelectedTime<TTarget>(this TTarget target) where TTarget : TableViewTimePicker
        => DependencyProperty<TTarget, object?>.Get(target, TvUI.Controls.TableViewTimePicker.SelectedTimeProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // TableView
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableView"/></summary>
        public static TableView TableView(params CSharpMarkup.WinUI.UIObject[] Items)
        {
            var ui = new TvUI.TableView();
            for (int i = 0; i < Items.Length; i++)
            {
                var child = Items[i];
                if (child == null) continue;

                var subChildren = Spreader<CSharpMarkup.WinUI.UIObject>.ExtractChildren(child);
                if (subChildren is not null)
                    for (int j = 0; j < subChildren.Length; j++)
                        ui.Items.Add(subChildren[j].UI);
                else
                    ui.Items.Add(child.UI);
            }
            return CSharpMarkup.WinUI.TableView.TableView.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.TableView"/></summary>
        public static TableView TableView()
        {
            var ui = new TvUI.TableView();
            return CSharpMarkup.WinUI.TableView.TableView.StartChain(ui);
        }
    }

    public partial class TableView : ListView, IUI<TvUI.TableView>
    {
        static TableView instance;

        internal static TableView StartChain(TvUI.TableView ui)
        {
            if (instance == null) instance = new TableView();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableView ui;

        public new TvUI.TableView UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TableView view) => view?.UI;

        public static implicit operator TvUI.TableView(TableView view) => view?.UI;

        public static implicit operator TableView(TvUI.TableView ui) => TableView.StartChain(ui);

        public TableView Invoke(Action<TvUI.TableView> action) { action?.Invoke(UI); return this; }

        protected TableView() { }
    }

    public static partial class TableViewExtensions
    {
        /// <summary>Set <see cref="TvUI.TableView.AlternateRowBackground"/></summary>
        public static TView AlternateRowBackground<TView>(this TView view, CSharpMarkup.WinUI.to.Brush value) where TView : TableView { view.UI.AlternateRowBackground = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.AlternateRowBackground"/></summary>
        public static TView AlternateRowBackground<TView>(this TView view, Windows.UI.Color value) where TView : TableView { view.UI.AlternateRowBackground = new Xaml.Media.SolidColorBrush(value); return view; }

        /// <summary>Set <see cref="TvUI.TableView.AlternateRowBackground"/></summary>
        public static TView AlternateRowBackground<TView>(this TView view, string color) where TView : TableView { view.UI.AlternateRowBackground = new Xaml.Media.SolidColorBrush(color.ToColor()); return view; }

        /// <summary>Set <see cref="TvUI.TableView.AlternateRowForeground"/></summary>
        public static TView AlternateRowForeground<TView>(this TView view, CSharpMarkup.WinUI.to.Brush value) where TView : TableView { view.UI.AlternateRowForeground = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.AlternateRowForeground"/></summary>
        public static TView AlternateRowForeground<TView>(this TView view, Windows.UI.Color value) where TView : TableView { view.UI.AlternateRowForeground = new Xaml.Media.SolidColorBrush(value); return view; }

        /// <summary>Set <see cref="TvUI.TableView.AlternateRowForeground"/></summary>
        public static TView AlternateRowForeground<TView>(this TView view, string color) where TView : TableView { view.UI.AlternateRowForeground = new Xaml.Media.SolidColorBrush(color.ToColor()); return view; }

        /// <summary>Set <see cref="TvUI.TableView.AutoGenerateColumns"/></summary>
        public static TView AutoGenerateColumns<TView>(this TView view, bool value) where TView : TableView { view.UI.AutoGenerateColumns = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.CanFilterColumns"/></summary>
        public static TView CanFilterColumns<TView>(this TView view, bool value) where TView : TableView { view.UI.CanFilterColumns = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.CanResizeColumns"/></summary>
        public static TView CanResizeColumns<TView>(this TView view, bool value) where TView : TableView { view.UI.CanResizeColumns = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.CanSortColumns"/></summary>
        public static TView CanSortColumns<TView>(this TView view, bool value) where TView : TableView { view.UI.CanSortColumns = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.CellContextFlyout"/></summary>
        public static TView CellContextFlyout<TView>(this TView view, Xaml.Controls.Primitives.FlyoutBase? value) where TView : TableView { view.UI.CellContextFlyout = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.CellStyle"/></summary>
        public static TView CellStyle<TView>(this TView view, Xaml.Style value) where TView : TableView { view.UI.CellStyle = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.ColumnHeaderStyle"/></summary>
        public static TView ColumnHeaderStyle<TView>(this TView view, Xaml.Style value) where TView : TableView { view.UI.ColumnHeaderStyle = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.CornerButtonMode"/></summary>
        public static TView CornerButtonMode<TView>(this TView view, TvUI.TableViewCornerButtonMode value) where TView : TableView { view.UI.CornerButtonMode = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.CurrentCellSlot"/></summary>
        public static TView CurrentCellSlot<TView>(this TView view, TvUI.TableViewCellSlot? value) where TView : TableView { view.UI.CurrentCellSlot = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.FilterHandler"/></summary>
        public static TView FilterHandler<TView>(this TView view, TvUI.IColumnFilterHandler value) where TView : TableView { view.UI.FilterHandler = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.GridLinesVisibility"/></summary>
        public static TView GridLinesVisibility<TView>(this TView view, TvUI.TableViewGridLinesVisibility value) where TView : TableView { view.UI.GridLinesVisibility = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.HeaderGridLinesVisibility"/></summary>
        public static TView HeaderGridLinesVisibility<TView>(this TView view, TvUI.TableViewGridLinesVisibility value) where TView : TableView { view.UI.HeaderGridLinesVisibility = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.HeaderRowHeight"/></summary>
        public static TView HeaderRowHeight<TView>(this TView view, double value) where TView : TableView { view.UI.HeaderRowHeight = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.HorizontalGridLinesStroke"/></summary>
        public static TView HorizontalGridLinesStroke<TView>(this TView view, CSharpMarkup.WinUI.to.Brush value) where TView : TableView { view.UI.HorizontalGridLinesStroke = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.HorizontalGridLinesStroke"/></summary>
        public static TView HorizontalGridLinesStroke<TView>(this TView view, Windows.UI.Color value) where TView : TableView { view.UI.HorizontalGridLinesStroke = new Xaml.Media.SolidColorBrush(value); return view; }

        /// <summary>Set <see cref="TvUI.TableView.HorizontalGridLinesStroke"/></summary>
        public static TView HorizontalGridLinesStroke<TView>(this TView view, string color) where TView : TableView { view.UI.HorizontalGridLinesStroke = new Xaml.Media.SolidColorBrush(color.ToColor()); return view; }

        /// <summary>Set <see cref="TvUI.TableView.HorizontalGridLinesStrokeThickness"/></summary>
        public static TView HorizontalGridLinesStrokeThickness<TView>(this TView view, double value) where TView : TableView { view.UI.HorizontalGridLinesStrokeThickness = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.IsReadOnly"/></summary>
        public static TView IsReadOnly<TView>(this TView view, bool value) where TView : TableView { view.UI.IsReadOnly = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.ItemsSource"/></summary>
        public static TView ItemsSource<TView>(this TView view, IList? value) where TView : TableView { view.UI.ItemsSource = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.MaxColumnWidth"/></summary>
        public static TView MaxColumnWidth<TView>(this TView view, double value) where TView : TableView { view.UI.MaxColumnWidth = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.MinColumnWidth"/></summary>
        public static TView MinColumnWidth<TView>(this TView view, double value) where TView : TableView { view.UI.MinColumnWidth = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.RowContextFlyout"/></summary>
        public static TView RowContextFlyout<TView>(this TView view, Xaml.Controls.Primitives.FlyoutBase? value) where TView : TableView { view.UI.RowContextFlyout = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.RowHeight"/></summary>
        public static TView RowHeight<TView>(this TView view, double value) where TView : TableView { view.UI.RowHeight = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.RowMaxHeight"/></summary>
        public static TView RowMaxHeight<TView>(this TView view, double value) where TView : TableView { view.UI.RowMaxHeight = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.RowMinHeight"/></summary>
        public static TView RowMinHeight<TView>(this TView view, double value) where TView : TableView { view.UI.RowMinHeight = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.SelectionMode"/></summary>
        public static TView SelectionMode<TView>(this TView view, Xaml.Controls.ListViewSelectionMode value) where TView : TableView { view.UI.SelectionMode = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.SelectionUnit"/></summary>
        public static TView SelectionUnit<TView>(this TView view, TvUI.TableViewSelectionUnit value) where TView : TableView { view.UI.SelectionUnit = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.ShowExportOptions"/></summary>
        public static TView ShowExportOptions<TView>(this TView view, bool value) where TView : TableView { view.UI.ShowExportOptions = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.VerticalGridLinesStroke"/></summary>
        public static TView VerticalGridLinesStroke<TView>(this TView view, CSharpMarkup.WinUI.to.Brush value) where TView : TableView { view.UI.VerticalGridLinesStroke = value; return view; }

        /// <summary>Set <see cref="TvUI.TableView.VerticalGridLinesStroke"/></summary>
        public static TView VerticalGridLinesStroke<TView>(this TView view, Windows.UI.Color value) where TView : TableView { view.UI.VerticalGridLinesStroke = new Xaml.Media.SolidColorBrush(value); return view; }

        /// <summary>Set <see cref="TvUI.TableView.VerticalGridLinesStroke"/></summary>
        public static TView VerticalGridLinesStroke<TView>(this TView view, string color) where TView : TableView { view.UI.VerticalGridLinesStroke = new Xaml.Media.SolidColorBrush(color.ToColor()); return view; }

        /// <summary>Set <see cref="TvUI.TableView.VerticalGridLinesStrokeThickness"/></summary>
        public static TView VerticalGridLinesStrokeThickness<TView>(this TView view, double value) where TView : TableView { view.UI.VerticalGridLinesStrokeThickness = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.AlternateRowBackground"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.Brush> AlternateRowBackground<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.Brush>.Get(target, TvUI.TableView.AlternateRowBackgroundProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.AlternateRowForeground"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.Brush> AlternateRowForeground<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.Brush>.Get(target, TvUI.TableView.AlternateRowForegroundProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.AutoGenerateColumns"/></summary>
        public static DependencyProperty<TTarget, bool> AutoGenerateColumns<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableView.AutoGenerateColumnsProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.CanFilterColumns"/></summary>
        public static DependencyProperty<TTarget, bool> CanFilterColumns<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableView.CanFilterColumnsProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.CanResizeColumns"/></summary>
        public static DependencyProperty<TTarget, bool> CanResizeColumns<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableView.CanResizeColumnsProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.CanSortColumns"/></summary>
        public static DependencyProperty<TTarget, bool> CanSortColumns<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableView.CanSortColumnsProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.CellContextFlyout"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.Primitives.FlyoutBase?> CellContextFlyout<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, Xaml.Controls.Primitives.FlyoutBase?>.Get(target, TvUI.TableView.CellContextFlyoutProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.CellStyle"/></summary>
        public static DependencyProperty<TTarget, Xaml.Style> CellStyle<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, Xaml.Style>.Get(target, TvUI.TableView.CellStyleProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.ColumnHeaderStyle"/></summary>
        public static DependencyProperty<TTarget, Xaml.Style> ColumnHeaderStyle<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, Xaml.Style>.Get(target, TvUI.TableView.ColumnHeaderStyleProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.CornerButtonMode"/></summary>
        public static DependencyProperty<TTarget, TvUI.TableViewCornerButtonMode> CornerButtonMode<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, TvUI.TableViewCornerButtonMode>.Get(target, TvUI.TableView.CornerButtonModeProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.CurrentCellSlot"/></summary>
        public static DependencyProperty<TTarget, TvUI.TableViewCellSlot?> CurrentCellSlot<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, TvUI.TableViewCellSlot?>.Get(target, TvUI.TableView.CurrentCellSlotProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.GridLinesVisibility"/></summary>
        public static DependencyProperty<TTarget, TvUI.TableViewGridLinesVisibility> GridLinesVisibility<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, TvUI.TableViewGridLinesVisibility>.Get(target, TvUI.TableView.GridLinesVisibilityProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.HeaderGridLinesVisibility"/></summary>
        public static DependencyProperty<TTarget, TvUI.TableViewGridLinesVisibility> HeaderGridLinesVisibility<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, TvUI.TableViewGridLinesVisibility>.Get(target, TvUI.TableView.HeaderGridLinesVisibilityProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.HeaderRowHeight"/></summary>
        public static DependencyProperty<TTarget, double> HeaderRowHeight<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, double>.Get(target, TvUI.TableView.HeaderRowHeightProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.HorizontalGridLinesStroke"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.Brush> HorizontalGridLinesStroke<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.Brush>.Get(target, TvUI.TableView.HorizontalGridLinesStrokeProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.HorizontalGridLinesStrokeThickness"/></summary>
        public static DependencyProperty<TTarget, double> HorizontalGridLinesStrokeThickness<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, double>.Get(target, TvUI.TableView.HorizontalGridLinesStrokeThicknessProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.IsReadOnly"/></summary>
        public static DependencyProperty<TTarget, bool> IsReadOnly<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableView.IsReadOnlyProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.ItemsSource"/></summary>
        public static DependencyProperty<TTarget, IList?> ItemsSource<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, IList?>.Get(target, TvUI.TableView.ItemsSourceProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.MaxColumnWidth"/></summary>
        public static DependencyProperty<TTarget, double> MaxColumnWidth<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, double>.Get(target, TvUI.TableView.MaxColumnWidthProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.MinColumnWidth"/></summary>
        public static DependencyProperty<TTarget, double> MinColumnWidth<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, double>.Get(target, TvUI.TableView.MinColumnWidthProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.RowContextFlyout"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.Primitives.FlyoutBase?> RowContextFlyout<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, Xaml.Controls.Primitives.FlyoutBase?>.Get(target, TvUI.TableView.RowContextFlyoutProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.RowHeight"/></summary>
        public static DependencyProperty<TTarget, double> RowHeight<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, double>.Get(target, TvUI.TableView.RowHeightProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.RowMaxHeight"/></summary>
        public static DependencyProperty<TTarget, double> RowMaxHeight<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, double>.Get(target, TvUI.TableView.RowMaxHeightProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.RowMinHeight"/></summary>
        public static DependencyProperty<TTarget, double> RowMinHeight<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, double>.Get(target, TvUI.TableView.RowMinHeightProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.SelectionMode"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.ListViewSelectionMode> SelectionMode<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, Xaml.Controls.ListViewSelectionMode>.Get(target, TvUI.TableView.SelectionModeProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.SelectionUnit"/></summary>
        public static DependencyProperty<TTarget, TvUI.TableViewSelectionUnit> SelectionUnit<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, TvUI.TableViewSelectionUnit>.Get(target, TvUI.TableView.SelectionUnitProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.ShowExportOptions"/></summary>
        public static DependencyProperty<TTarget, bool> ShowExportOptions<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableView.ShowExportOptionsProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.VerticalGridLinesStroke"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.Brush> VerticalGridLinesStroke<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.Brush>.Get(target, TvUI.TableView.VerticalGridLinesStrokeProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.VerticalGridLinesStrokeThickness"/></summary>
        public static DependencyProperty<TTarget, double> VerticalGridLinesStrokeThickness<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, double>.Get(target, TvUI.TableView.VerticalGridLinesStrokeThicknessProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewBoundColumn
{
    public partial class TableViewBoundColumn : TableViewColumn, IUI<TvUI.TableViewBoundColumn>
    {
        TvUI.TableViewBoundColumn ui;

        public new TvUI.TableViewBoundColumn UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public TableViewBoundColumn Invoke(Action<TvUI.TableViewBoundColumn> action) { action?.Invoke(UI); return this; }

        protected TableViewBoundColumn() { }
    }

    public static partial class TableViewBoundColumnExtensions
    {
        /// <summary>Set <see cref="TvUI.TableViewBoundColumn.Binding"/></summary>
        public static TView Binding<TView>(this TView view, Xaml.Data.Binding value) where TView : TableViewBoundColumn { view.UI.Binding = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewBoundColumn.EditingElementStyle"/></summary>
        public static TView EditingElementStyle<TView>(this TView view, Xaml.Style value) where TView : TableViewBoundColumn { view.UI.EditingElementStyle = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewBoundColumn.ElementStyle"/></summary>
        public static TView ElementStyle<TView>(this TView view, Xaml.Style value) where TView : TableViewBoundColumn { view.UI.ElementStyle = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewBoundColumn.EditingElementStyle"/></summary>
        public static DependencyProperty<TTarget, Xaml.Style> EditingElementStyle<TTarget>(this TTarget target) where TTarget : TableViewBoundColumn
        => DependencyProperty<TTarget, Xaml.Style>.Get(target, TvUI.TableViewBoundColumn.EditingElementStyleProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewBoundColumn.ElementStyle"/></summary>
        public static DependencyProperty<TTarget, Xaml.Style> ElementStyle<TTarget>(this TTarget target) where TTarget : TableViewBoundColumn
        => DependencyProperty<TTarget, Xaml.Style>.Get(target, TvUI.TableViewBoundColumn.ElementStyleProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewCell
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewCell"/></summary>
        public static TableViewCell TableViewCell(UIObject Content)
        {
            var ui = new TvUI.TableViewCell();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.TableView.TableViewCell.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.TableViewCell"/></summary>
        public static TableViewCell TableViewCell()
        {
            var ui = new TvUI.TableViewCell();
            return CSharpMarkup.WinUI.TableView.TableViewCell.StartChain(ui);
        }
    }

    public partial class TableViewCell : ContentControl, IUI<TvUI.TableViewCell>
    {
        static TableViewCell instance;

        internal static TableViewCell StartChain(TvUI.TableViewCell ui)
        {
            if (instance == null) instance = new TableViewCell();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewCell ui;

        public new TvUI.TableViewCell UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TableViewCell view) => view?.UI;

        public static implicit operator TvUI.TableViewCell(TableViewCell view) => view?.UI;

        public static implicit operator TableViewCell(TvUI.TableViewCell ui) => TableViewCell.StartChain(ui);

        public TableViewCell Invoke(Action<TvUI.TableViewCell> action) { action?.Invoke(UI); return this; }

        protected TableViewCell() { }
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewCellsPresenter
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewCellsPresenter"/></summary>
        public static TableViewCellsPresenter TableViewCellsPresenter()
        {
            var ui = new TvUI.TableViewCellsPresenter();
            return CSharpMarkup.WinUI.TableView.TableViewCellsPresenter.StartChain(ui);
        }
    }

    public partial class TableViewCellsPresenter : Control, IUI<TvUI.TableViewCellsPresenter>
    {
        static TableViewCellsPresenter instance;

        internal static TableViewCellsPresenter StartChain(TvUI.TableViewCellsPresenter ui)
        {
            if (instance == null) instance = new TableViewCellsPresenter();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewCellsPresenter ui;

        public new TvUI.TableViewCellsPresenter UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TableViewCellsPresenter view) => view?.UI;

        public static implicit operator TvUI.TableViewCellsPresenter(TableViewCellsPresenter view) => view?.UI;

        public static implicit operator TableViewCellsPresenter(TvUI.TableViewCellsPresenter ui) => TableViewCellsPresenter.StartChain(ui);

        public TableViewCellsPresenter Invoke(Action<TvUI.TableViewCellsPresenter> action) { action?.Invoke(UI); return this; }

        protected TableViewCellsPresenter() { }
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewCheckBoxColumn
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewCheckBoxColumn"/></summary>
        public static TableViewCheckBoxColumn TableViewCheckBoxColumn()
        {
            var ui = new TvUI.TableViewCheckBoxColumn();
            return CSharpMarkup.WinUI.TableView.TableViewCheckBoxColumn.StartChain(ui);
        }
    }

    public partial class TableViewCheckBoxColumn : TableViewBoundColumn, IUI<TvUI.TableViewCheckBoxColumn>
    {
        static TableViewCheckBoxColumn instance;

        internal static TableViewCheckBoxColumn StartChain(TvUI.TableViewCheckBoxColumn ui)
        {
            if (instance == null) instance = new TableViewCheckBoxColumn();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewCheckBoxColumn ui;

        public new TvUI.TableViewCheckBoxColumn UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator TvUI.TableViewCheckBoxColumn(TableViewCheckBoxColumn view) => view?.UI;

        public static implicit operator TableViewCheckBoxColumn(TvUI.TableViewCheckBoxColumn ui) => TableViewCheckBoxColumn.StartChain(ui);

        public TableViewCheckBoxColumn Invoke(Action<TvUI.TableViewCheckBoxColumn> action) { action?.Invoke(UI); return this; }

        protected TableViewCheckBoxColumn() { }
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewColumn
{
    public partial class TableViewColumn : DependencyObject, IUI<TvUI.TableViewColumn>
    {
        TvUI.TableViewColumn ui;

        public new TvUI.TableViewColumn UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public TableViewColumn Invoke(Action<TvUI.TableViewColumn> action) { action?.Invoke(UI); return this; }

        protected TableViewColumn() { }
    }

    public static partial class TableViewColumnExtensions
    {
        /// <summary>Set <see cref="TvUI.TableViewColumn.ActualWidth"/></summary>
        public static TView ActualWidth<TView>(this TView view, double value) where TView : TableViewColumn { view.UI.ActualWidth = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.CanFilter"/></summary>
        public static TView CanFilter<TView>(this TView view, bool value) where TView : TableViewColumn { view.UI.CanFilter = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.CanResize"/></summary>
        public static TView CanResize<TView>(this TView view, bool value) where TView : TableViewColumn { view.UI.CanResize = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.CanSort"/></summary>
        public static TView CanSort<TView>(this TView view, bool value) where TView : TableViewColumn { view.UI.CanSort = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.CellStyle"/></summary>
        public static TView CellStyle<TView>(this TView view, Xaml.Style value) where TView : TableViewColumn { view.UI.CellStyle = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.DataContext"/></summary>
        public static TView DataContext<TView>(this TView view, object value) where TView : TableViewColumn { view.UI.DataContext = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.Header"/></summary>
        public static TView Header<TView>(this TView view, object value) where TView : TableViewColumn { view.UI.Header = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.HeaderStyle"/></summary>
        public static TView HeaderStyle<TView>(this TView view, Xaml.Style? value) where TView : TableViewColumn { view.UI.HeaderStyle = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.IsFiltered"/></summary>
        public static TView IsFiltered<TView>(this TView view, bool value) where TView : TableViewColumn { view.UI.IsFiltered = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.IsReadOnly"/></summary>
        public static TView IsReadOnly<TView>(this TView view, bool value) where TView : TableViewColumn { view.UI.IsReadOnly = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.MaxWidth"/></summary>
        public static TView MaxWidth<TView>(this TView view, double? value) where TView : TableViewColumn { view.UI.MaxWidth = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.MinWidth"/></summary>
        public static TView MinWidth<TView>(this TView view, double? value) where TView : TableViewColumn { view.UI.MinWidth = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.SortDirection"/></summary>
        public static TView SortDirection<TView>(this TView view, TvUI.SortDirection? value) where TView : TableViewColumn { view.UI.SortDirection = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.Tag"/></summary>
        public static TView Tag<TView>(this TView view, object value) where TView : TableViewColumn { view.UI.Tag = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.TemplatedParent"/></summary>
        public static TView TemplatedParent<TView>(this TView view, Xaml.DependencyObject value) where TView : TableViewColumn { view.UI.TemplatedParent = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.UseSingleElement"/></summary>
        public static TView UseSingleElement<TView>(this TView view, bool value) where TView : TableViewColumn { view.UI.UseSingleElement = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.Visibility"/></summary>
        public static TView Visibility<TView>(this TView view, Xaml.Visibility value) where TView : TableViewColumn { view.UI.Visibility = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewColumn.Width"/></summary>
        public static TView Width<TView>(this TView view, CSharpMarkup.WinUI.to.GridLength value) where TView : TableViewColumn { view.UI.Width = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.ActualWidth"/></summary>
        public static DependencyProperty<TTarget, double> ActualWidth<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, double>.Get(target, TvUI.TableViewColumn.ActualWidthProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.CanFilter"/></summary>
        public static DependencyProperty<TTarget, bool> CanFilter<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableViewColumn.CanFilterProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.CanResize"/></summary>
        public static DependencyProperty<TTarget, bool> CanResize<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableViewColumn.CanResizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.CanSort"/></summary>
        public static DependencyProperty<TTarget, bool> CanSort<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableViewColumn.CanSortProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.CellStyle"/></summary>
        public static DependencyProperty<TTarget, Xaml.Style> CellStyle<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, Xaml.Style>.Get(target, TvUI.TableViewColumn.CellStyleProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.DataContext"/></summary>
        public static DependencyProperty<TTarget, object> DataContext<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, object>.Get(target, TvUI.TableViewColumn.DataContextProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.Header"/></summary>
        public static DependencyProperty<TTarget, object> Header<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, object>.Get(target, TvUI.TableViewColumn.HeaderProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.HeaderStyle"/></summary>
        public static DependencyProperty<TTarget, Xaml.Style?> HeaderStyle<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, Xaml.Style?>.Get(target, TvUI.TableViewColumn.HeaderStyleProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.IsReadOnly"/></summary>
        public static DependencyProperty<TTarget, bool> IsReadOnly<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableViewColumn.IsReadOnlyProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.MaxWidth"/></summary>
        public static DependencyProperty<TTarget, double?> MaxWidth<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, double?>.Get(target, TvUI.TableViewColumn.MaxWidthProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.MinWidth"/></summary>
        public static DependencyProperty<TTarget, double?> MinWidth<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, double?>.Get(target, TvUI.TableViewColumn.MinWidthProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.Tag"/></summary>
        public static DependencyProperty<TTarget, object> Tag<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, object>.Get(target, TvUI.TableViewColumn.TagProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.TemplatedParent"/></summary>
        public static DependencyProperty<TTarget, Xaml.DependencyObject> TemplatedParent<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, Xaml.DependencyObject>.Get(target, TvUI.TableViewColumn.TemplatedParentProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.Visibility"/></summary>
        public static DependencyProperty<TTarget, Xaml.Visibility> Visibility<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, Xaml.Visibility>.Get(target, TvUI.TableViewColumn.VisibilityProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewColumn.Width"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.GridLength> Width<TTarget>(this TTarget target) where TTarget : TableViewColumn
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.GridLength>.Get(target, TvUI.TableViewColumn.WidthProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewColumnHeader
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewColumnHeader"/></summary>
        public static TableViewColumnHeader TableViewColumnHeader(UIObject Content)
        {
            var ui = new TvUI.TableViewColumnHeader();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.TableView.TableViewColumnHeader.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.TableViewColumnHeader"/></summary>
        public static TableViewColumnHeader TableViewColumnHeader()
        {
            var ui = new TvUI.TableViewColumnHeader();
            return CSharpMarkup.WinUI.TableView.TableViewColumnHeader.StartChain(ui);
        }
    }

    public partial class TableViewColumnHeader : ContentControl, IUI<TvUI.TableViewColumnHeader>
    {
        static TableViewColumnHeader instance;

        internal static TableViewColumnHeader StartChain(TvUI.TableViewColumnHeader ui)
        {
            if (instance == null) instance = new TableViewColumnHeader();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewColumnHeader ui;

        public new TvUI.TableViewColumnHeader UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TableViewColumnHeader view) => view?.UI;

        public static implicit operator TvUI.TableViewColumnHeader(TableViewColumnHeader view) => view?.UI;

        public static implicit operator TableViewColumnHeader(TvUI.TableViewColumnHeader ui) => TableViewColumnHeader.StartChain(ui);

        public TableViewColumnHeader Invoke(Action<TvUI.TableViewColumnHeader> action) { action?.Invoke(UI); return this; }

        protected TableViewColumnHeader() { }
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewComboBoxColumn
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewComboBoxColumn"/></summary>
        public static TableViewComboBoxColumn TableViewComboBoxColumn(string? DisplayMemberPath = default, bool? IsEditable = default, object? ItemsSource = default, Xaml.Data.Binding SelectedValueBinding = default, string? SelectedValuePath = default, Xaml.Data.Binding TextBinding = default)
        {
            var ui = new TvUI.TableViewComboBoxColumn();
            if (DisplayMemberPath is not null) ui.DisplayMemberPath = DisplayMemberPath;
            if (IsEditable is not null) ui.IsEditable = IsEditable.Value;
            if (ItemsSource is not null) ui.ItemsSource = ItemsSource;
            if (SelectedValueBinding is not null) ui.SelectedValueBinding = SelectedValueBinding;
            if (SelectedValuePath is not null) ui.SelectedValuePath = SelectedValuePath;
            if (TextBinding is not null) ui.TextBinding = TextBinding;
            return CSharpMarkup.WinUI.TableView.TableViewComboBoxColumn.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.TableViewComboBoxColumn"/></summary>
        public static TableViewComboBoxColumn TableViewComboBoxColumn()
        {
            var ui = new TvUI.TableViewComboBoxColumn();
            return CSharpMarkup.WinUI.TableView.TableViewComboBoxColumn.StartChain(ui);
        }
    }

    public partial class TableViewComboBoxColumn : TableViewBoundColumn, IUI<TvUI.TableViewComboBoxColumn>
    {
        static TableViewComboBoxColumn instance;

        internal static TableViewComboBoxColumn StartChain(TvUI.TableViewComboBoxColumn ui)
        {
            if (instance == null) instance = new TableViewComboBoxColumn();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewComboBoxColumn ui;

        public new TvUI.TableViewComboBoxColumn UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator TvUI.TableViewComboBoxColumn(TableViewComboBoxColumn view) => view?.UI;

        public static implicit operator TableViewComboBoxColumn(TvUI.TableViewComboBoxColumn ui) => TableViewComboBoxColumn.StartChain(ui);

        public TableViewComboBoxColumn Invoke(Action<TvUI.TableViewComboBoxColumn> action) { action?.Invoke(UI); return this; }

        protected TableViewComboBoxColumn() { }
    }

    public static partial class TableViewComboBoxColumnExtensions
    {
        /// <summary>Set <see cref="TvUI.TableViewComboBoxColumn.DisplayMemberPath"/></summary>
        public static TView DisplayMemberPath<TView>(this TView view, string? value) where TView : TableViewComboBoxColumn { view.UI.DisplayMemberPath = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewComboBoxColumn.IsEditable"/></summary>
        public static TView IsEditable<TView>(this TView view, bool value) where TView : TableViewComboBoxColumn { view.UI.IsEditable = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewComboBoxColumn.ItemsSource"/></summary>
        public static TView ItemsSource<TView>(this TView view, object? value) where TView : TableViewComboBoxColumn { view.UI.ItemsSource = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewComboBoxColumn.SelectedValueBinding"/></summary>
        public static TView SelectedValueBinding<TView>(this TView view, Xaml.Data.Binding value) where TView : TableViewComboBoxColumn { view.UI.SelectedValueBinding = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewComboBoxColumn.SelectedValuePath"/></summary>
        public static TView SelectedValuePath<TView>(this TView view, string? value) where TView : TableViewComboBoxColumn { view.UI.SelectedValuePath = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewComboBoxColumn.TextBinding"/></summary>
        public static TView TextBinding<TView>(this TView view, Xaml.Data.Binding value) where TView : TableViewComboBoxColumn { view.UI.TextBinding = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewComboBoxColumn.DisplayMemberPath"/></summary>
        public static DependencyProperty<TTarget, string?> DisplayMemberPath<TTarget>(this TTarget target) where TTarget : TableViewComboBoxColumn
        => DependencyProperty<TTarget, string?>.Get(target, TvUI.TableViewComboBoxColumn.DisplayMemberPathProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewComboBoxColumn.IsEditable"/></summary>
        public static DependencyProperty<TTarget, bool> IsEditable<TTarget>(this TTarget target) where TTarget : TableViewComboBoxColumn
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableViewComboBoxColumn.IsEditableProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewComboBoxColumn.ItemsSource"/></summary>
        public static DependencyProperty<TTarget, object?> ItemsSource<TTarget>(this TTarget target) where TTarget : TableViewComboBoxColumn
        => DependencyProperty<TTarget, object?>.Get(target, TvUI.TableViewComboBoxColumn.ItemsSourceProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewComboBoxColumn.SelectedValuePath"/></summary>
        public static DependencyProperty<TTarget, string?> SelectedValuePath<TTarget>(this TTarget target) where TTarget : TableViewComboBoxColumn
        => DependencyProperty<TTarget, string?>.Get(target, TvUI.TableViewComboBoxColumn.SelectedValuePathProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewDateColumn
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewDateColumn"/></summary>
        public static TableViewDateColumn TableViewDateColumn(string? DateFormat = default, string DayOfWeekFormat = default, Windows.Globalization.DayOfWeek? FirstDayOfWeek = default, bool? IsGroupLabelVisible = default, bool? IsOutOfScopeEnabled = default, bool? IsTodayHighlighted = default, DateTimeOffset? MaxDate = default, DateTimeOffset? MinDate = default, string? PlaceHolderText = default)
        {
            var ui = new TvUI.TableViewDateColumn();
            if (DateFormat is not null) ui.DateFormat = DateFormat;
            if (DayOfWeekFormat is not null) ui.DayOfWeekFormat = DayOfWeekFormat;
            if (FirstDayOfWeek is not null) ui.FirstDayOfWeek = FirstDayOfWeek.Value;
            if (IsGroupLabelVisible is not null) ui.IsGroupLabelVisible = IsGroupLabelVisible.Value;
            if (IsOutOfScopeEnabled is not null) ui.IsOutOfScopeEnabled = IsOutOfScopeEnabled.Value;
            if (IsTodayHighlighted is not null) ui.IsTodayHighlighted = IsTodayHighlighted.Value;
            if (MaxDate is not null) ui.MaxDate = MaxDate.Value;
            if (MinDate is not null) ui.MinDate = MinDate.Value;
            if (PlaceHolderText is not null) ui.PlaceHolderText = PlaceHolderText;
            return CSharpMarkup.WinUI.TableView.TableViewDateColumn.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.TableViewDateColumn"/></summary>
        public static TableViewDateColumn TableViewDateColumn()
        {
            var ui = new TvUI.TableViewDateColumn();
            return CSharpMarkup.WinUI.TableView.TableViewDateColumn.StartChain(ui);
        }
    }

    public partial class TableViewDateColumn : TableViewBoundColumn, IUI<TvUI.TableViewDateColumn>
    {
        static TableViewDateColumn instance;

        internal static TableViewDateColumn StartChain(TvUI.TableViewDateColumn ui)
        {
            if (instance == null) instance = new TableViewDateColumn();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewDateColumn ui;

        public new TvUI.TableViewDateColumn UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator TvUI.TableViewDateColumn(TableViewDateColumn view) => view?.UI;

        public static implicit operator TableViewDateColumn(TvUI.TableViewDateColumn ui) => TableViewDateColumn.StartChain(ui);

        public TableViewDateColumn Invoke(Action<TvUI.TableViewDateColumn> action) { action?.Invoke(UI); return this; }

        protected TableViewDateColumn() { }
    }

    public static partial class TableViewDateColumnExtensions
    {
        /// <summary>Set <see cref="TvUI.TableViewDateColumn.DateFormat"/></summary>
        public static TView DateFormat<TView>(this TView view, string? value) where TView : TableViewDateColumn { view.UI.DateFormat = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewDateColumn.DayOfWeekFormat"/></summary>
        public static TView DayOfWeekFormat<TView>(this TView view, string value) where TView : TableViewDateColumn { view.UI.DayOfWeekFormat = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewDateColumn.FirstDayOfWeek"/></summary>
        public static TView FirstDayOfWeek<TView>(this TView view, Windows.Globalization.DayOfWeek value) where TView : TableViewDateColumn { view.UI.FirstDayOfWeek = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewDateColumn.IsGroupLabelVisible"/></summary>
        public static TView IsGroupLabelVisible<TView>(this TView view, bool value) where TView : TableViewDateColumn { view.UI.IsGroupLabelVisible = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewDateColumn.IsOutOfScopeEnabled"/></summary>
        public static TView IsOutOfScopeEnabled<TView>(this TView view, bool value) where TView : TableViewDateColumn { view.UI.IsOutOfScopeEnabled = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewDateColumn.IsTodayHighlighted"/></summary>
        public static TView IsTodayHighlighted<TView>(this TView view, bool value) where TView : TableViewDateColumn { view.UI.IsTodayHighlighted = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewDateColumn.MaxDate"/></summary>
        public static TView MaxDate<TView>(this TView view, DateTimeOffset value) where TView : TableViewDateColumn { view.UI.MaxDate = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewDateColumn.MinDate"/></summary>
        public static TView MinDate<TView>(this TView view, DateTimeOffset value) where TView : TableViewDateColumn { view.UI.MinDate = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewDateColumn.PlaceHolderText"/></summary>
        public static TView PlaceHolderText<TView>(this TView view, string? value) where TView : TableViewDateColumn { view.UI.PlaceHolderText = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewDateColumn.DateFormat"/></summary>
        public static DependencyProperty<TTarget, string?> DateFormat<TTarget>(this TTarget target) where TTarget : TableViewDateColumn
        => DependencyProperty<TTarget, string?>.Get(target, TvUI.TableViewDateColumn.DateFormatProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewDateColumn.DayOfWeekFormat"/></summary>
        public static DependencyProperty<TTarget, string> DayOfWeekFormat<TTarget>(this TTarget target) where TTarget : TableViewDateColumn
        => DependencyProperty<TTarget, string>.Get(target, TvUI.TableViewDateColumn.DayOfWeekFormatProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewDateColumn.FirstDayOfWeek"/></summary>
        public static DependencyProperty<TTarget, Windows.Globalization.DayOfWeek> FirstDayOfWeek<TTarget>(this TTarget target) where TTarget : TableViewDateColumn
        => DependencyProperty<TTarget, Windows.Globalization.DayOfWeek>.Get(target, TvUI.TableViewDateColumn.FirstDayOfWeekProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewDateColumn.IsGroupLabelVisible"/></summary>
        public static DependencyProperty<TTarget, bool> IsGroupLabelVisible<TTarget>(this TTarget target) where TTarget : TableViewDateColumn
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableViewDateColumn.IsGroupLabelVisibleProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewDateColumn.IsOutOfScopeEnabled"/></summary>
        public static DependencyProperty<TTarget, bool> IsOutOfScopeEnabled<TTarget>(this TTarget target) where TTarget : TableViewDateColumn
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableViewDateColumn.IsOutOfScopeEnabledProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewDateColumn.IsTodayHighlighted"/></summary>
        public static DependencyProperty<TTarget, bool> IsTodayHighlighted<TTarget>(this TTarget target) where TTarget : TableViewDateColumn
        => DependencyProperty<TTarget, bool>.Get(target, TvUI.TableViewDateColumn.IsTodayHighlightedProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewDateColumn.MaxDate"/></summary>
        public static DependencyProperty<TTarget, DateTimeOffset> MaxDate<TTarget>(this TTarget target) where TTarget : TableViewDateColumn
        => DependencyProperty<TTarget, DateTimeOffset>.Get(target, TvUI.TableViewDateColumn.MaxDateProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewDateColumn.MinDate"/></summary>
        public static DependencyProperty<TTarget, DateTimeOffset> MinDate<TTarget>(this TTarget target) where TTarget : TableViewDateColumn
        => DependencyProperty<TTarget, DateTimeOffset>.Get(target, TvUI.TableViewDateColumn.MinDateProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewDateColumn.PlaceHolderText"/></summary>
        public static DependencyProperty<TTarget, string?> PlaceHolderText<TTarget>(this TTarget target) where TTarget : TableViewDateColumn
        => DependencyProperty<TTarget, string?>.Get(target, TvUI.TableViewDateColumn.PlaceHolderTextProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewHeaderRow
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewHeaderRow"/></summary>
        public static TableViewHeaderRow TableViewHeaderRow(TvUI.TableView? TableView = default)
        {
            var ui = new TvUI.TableViewHeaderRow();
            if (TableView is not null) ui.TableView = TableView;
            return CSharpMarkup.WinUI.TableView.TableViewHeaderRow.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.TableViewHeaderRow"/></summary>
        public static TableViewHeaderRow TableViewHeaderRow()
        {
            var ui = new TvUI.TableViewHeaderRow();
            return CSharpMarkup.WinUI.TableView.TableViewHeaderRow.StartChain(ui);
        }
    }

    public partial class TableViewHeaderRow : Control, IUI<TvUI.TableViewHeaderRow>
    {
        static TableViewHeaderRow instance;

        internal static TableViewHeaderRow StartChain(TvUI.TableViewHeaderRow ui)
        {
            if (instance == null) instance = new TableViewHeaderRow();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewHeaderRow ui;

        public new TvUI.TableViewHeaderRow UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TableViewHeaderRow view) => view?.UI;

        public static implicit operator TvUI.TableViewHeaderRow(TableViewHeaderRow view) => view?.UI;

        public static implicit operator TableViewHeaderRow(TvUI.TableViewHeaderRow ui) => TableViewHeaderRow.StartChain(ui);

        public TableViewHeaderRow Invoke(Action<TvUI.TableViewHeaderRow> action) { action?.Invoke(UI); return this; }

        protected TableViewHeaderRow() { }
    }

    public static partial class TableViewHeaderRowExtensions
    {
        /// <summary>Set <see cref="TvUI.TableViewHeaderRow.TableView"/></summary>
        public static TView TableView<TView>(this TView view, TvUI.TableView? value) where TView : TableViewHeaderRow { view.UI.TableView = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewHeaderRow.TableView"/></summary>
        public static DependencyProperty<TTarget, TvUI.TableView?> TableView<TTarget>(this TTarget target) where TTarget : TableViewHeaderRow
        => DependencyProperty<TTarget, TvUI.TableView?>.Get(target, TvUI.TableViewHeaderRow.TableViewProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewNumberColumn
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewNumberColumn"/></summary>
        public static TableViewNumberColumn TableViewNumberColumn()
        {
            var ui = new TvUI.TableViewNumberColumn();
            return CSharpMarkup.WinUI.TableView.TableViewNumberColumn.StartChain(ui);
        }
    }

    public partial class TableViewNumberColumn : TableViewBoundColumn, IUI<TvUI.TableViewNumberColumn>
    {
        static TableViewNumberColumn instance;

        internal static TableViewNumberColumn StartChain(TvUI.TableViewNumberColumn ui)
        {
            if (instance == null) instance = new TableViewNumberColumn();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewNumberColumn ui;

        public new TvUI.TableViewNumberColumn UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator TvUI.TableViewNumberColumn(TableViewNumberColumn view) => view?.UI;

        public static implicit operator TableViewNumberColumn(TvUI.TableViewNumberColumn ui) => TableViewNumberColumn.StartChain(ui);

        public TableViewNumberColumn Invoke(Action<TvUI.TableViewNumberColumn> action) { action?.Invoke(UI); return this; }

        protected TableViewNumberColumn() { }
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewRow
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewRow"/></summary>
        public static TableViewRow TableViewRow(UIObject Content)
        {
            var ui = new TvUI.TableViewRow();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.TableView.TableViewRow.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.TableViewRow"/></summary>
        public static TableViewRow TableViewRow()
        {
            var ui = new TvUI.TableViewRow();
            return CSharpMarkup.WinUI.TableView.TableViewRow.StartChain(ui);
        }
    }

    public partial class TableViewRow : ListViewItem, IUI<TvUI.TableViewRow>
    {
        static TableViewRow instance;

        internal static TableViewRow StartChain(TvUI.TableViewRow ui)
        {
            if (instance == null) instance = new TableViewRow();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewRow ui;

        public new TvUI.TableViewRow UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TableViewRow view) => view?.UI;

        public static implicit operator TvUI.TableViewRow(TableViewRow view) => view?.UI;

        public static implicit operator TableViewRow(TvUI.TableViewRow ui) => TableViewRow.StartChain(ui);

        public TableViewRow Invoke(Action<TvUI.TableViewRow> action) { action?.Invoke(UI); return this; }

        protected TableViewRow() { }
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewTemplateColumn
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewTemplateColumn"/></summary>
        public static TableViewTemplateColumn TableViewTemplateColumn(Xaml.DataTemplate? CellTemplate = default, Xaml.Controls.DataTemplateSelector? CellTemplateSelector = default, Xaml.DataTemplate? EditingTemplate = default, Xaml.Controls.DataTemplateSelector? EditingTemplateSelector = default)
        {
            var ui = new TvUI.TableViewTemplateColumn();
            if (CellTemplate is not null) ui.CellTemplate = CellTemplate;
            if (CellTemplateSelector is not null) ui.CellTemplateSelector = CellTemplateSelector;
            if (EditingTemplate is not null) ui.EditingTemplate = EditingTemplate;
            if (EditingTemplateSelector is not null) ui.EditingTemplateSelector = EditingTemplateSelector;
            return CSharpMarkup.WinUI.TableView.TableViewTemplateColumn.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.TableViewTemplateColumn"/></summary>
        public static TableViewTemplateColumn TableViewTemplateColumn()
        {
            var ui = new TvUI.TableViewTemplateColumn();
            return CSharpMarkup.WinUI.TableView.TableViewTemplateColumn.StartChain(ui);
        }
    }

    public partial class TableViewTemplateColumn : TableViewColumn, IUI<TvUI.TableViewTemplateColumn>
    {
        static TableViewTemplateColumn instance;

        internal static TableViewTemplateColumn StartChain(TvUI.TableViewTemplateColumn ui)
        {
            if (instance == null) instance = new TableViewTemplateColumn();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewTemplateColumn ui;

        public new TvUI.TableViewTemplateColumn UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator TvUI.TableViewTemplateColumn(TableViewTemplateColumn view) => view?.UI;

        public static implicit operator TableViewTemplateColumn(TvUI.TableViewTemplateColumn ui) => TableViewTemplateColumn.StartChain(ui);

        public TableViewTemplateColumn Invoke(Action<TvUI.TableViewTemplateColumn> action) { action?.Invoke(UI); return this; }

        protected TableViewTemplateColumn() { }
    }

    public static partial class TableViewTemplateColumnExtensions
    {
        /// <summary>Set <see cref="TvUI.TableViewTemplateColumn.CellTemplate"/></summary>
        public static TView CellTemplate<TView>(this TView view, Xaml.DataTemplate? value) where TView : TableViewTemplateColumn { view.UI.CellTemplate = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewTemplateColumn.CellTemplateSelector"/></summary>
        public static TView CellTemplateSelector<TView>(this TView view, Xaml.Controls.DataTemplateSelector? value) where TView : TableViewTemplateColumn { view.UI.CellTemplateSelector = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewTemplateColumn.EditingTemplate"/></summary>
        public static TView EditingTemplate<TView>(this TView view, Xaml.DataTemplate? value) where TView : TableViewTemplateColumn { view.UI.EditingTemplate = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewTemplateColumn.EditingTemplateSelector"/></summary>
        public static TView EditingTemplateSelector<TView>(this TView view, Xaml.Controls.DataTemplateSelector? value) where TView : TableViewTemplateColumn { view.UI.EditingTemplateSelector = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewTemplateColumn.CellTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate?> CellTemplate<TTarget>(this TTarget target) where TTarget : TableViewTemplateColumn
        => DependencyProperty<TTarget, Xaml.DataTemplate?>.Get(target, TvUI.TableViewTemplateColumn.CellTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewTemplateColumn.CellTemplateSelector"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.DataTemplateSelector?> CellTemplateSelector<TTarget>(this TTarget target) where TTarget : TableViewTemplateColumn
        => DependencyProperty<TTarget, Xaml.Controls.DataTemplateSelector?>.Get(target, TvUI.TableViewTemplateColumn.CellTemplateSelectorProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewTemplateColumn.EditingTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate?> EditingTemplate<TTarget>(this TTarget target) where TTarget : TableViewTemplateColumn
        => DependencyProperty<TTarget, Xaml.DataTemplate?>.Get(target, TvUI.TableViewTemplateColumn.EditingTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewTemplateColumn.EditingTemplateSelector"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.DataTemplateSelector?> EditingTemplateSelector<TTarget>(this TTarget target) where TTarget : TableViewTemplateColumn
        => DependencyProperty<TTarget, Xaml.Controls.DataTemplateSelector?>.Get(target, TvUI.TableViewTemplateColumn.EditingTemplateSelectorProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewTextColumn
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewTextColumn"/></summary>
        public static TableViewTextColumn TableViewTextColumn()
        {
            var ui = new TvUI.TableViewTextColumn();
            return CSharpMarkup.WinUI.TableView.TableViewTextColumn.StartChain(ui);
        }
    }

    public partial class TableViewTextColumn : TableViewBoundColumn, IUI<TvUI.TableViewTextColumn>
    {
        static TableViewTextColumn instance;

        internal static TableViewTextColumn StartChain(TvUI.TableViewTextColumn ui)
        {
            if (instance == null) instance = new TableViewTextColumn();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewTextColumn ui;

        public new TvUI.TableViewTextColumn UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator TvUI.TableViewTextColumn(TableViewTextColumn view) => view?.UI;

        public static implicit operator TableViewTextColumn(TvUI.TableViewTextColumn ui) => TableViewTextColumn.StartChain(ui);

        public TableViewTextColumn Invoke(Action<TvUI.TableViewTextColumn> action) { action?.Invoke(UI); return this; }

        protected TableViewTextColumn() { }
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewTimeColumn
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewTimeColumn"/></summary>
        public static TableViewTimeColumn TableViewTimeColumn(string ClockIdentifier = default, int? MinuteIncrement = default, string? PlaceholderText = default)
        {
            var ui = new TvUI.TableViewTimeColumn();
            if (ClockIdentifier is not null) ui.ClockIdentifier = ClockIdentifier;
            if (MinuteIncrement is not null) ui.MinuteIncrement = MinuteIncrement.Value;
            if (PlaceholderText is not null) ui.PlaceholderText = PlaceholderText;
            return CSharpMarkup.WinUI.TableView.TableViewTimeColumn.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.TableViewTimeColumn"/></summary>
        public static TableViewTimeColumn TableViewTimeColumn()
        {
            var ui = new TvUI.TableViewTimeColumn();
            return CSharpMarkup.WinUI.TableView.TableViewTimeColumn.StartChain(ui);
        }
    }

    public partial class TableViewTimeColumn : TableViewBoundColumn, IUI<TvUI.TableViewTimeColumn>
    {
        static TableViewTimeColumn instance;

        internal static TableViewTimeColumn StartChain(TvUI.TableViewTimeColumn ui)
        {
            if (instance == null) instance = new TableViewTimeColumn();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewTimeColumn ui;

        public new TvUI.TableViewTimeColumn UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator TvUI.TableViewTimeColumn(TableViewTimeColumn view) => view?.UI;

        public static implicit operator TableViewTimeColumn(TvUI.TableViewTimeColumn ui) => TableViewTimeColumn.StartChain(ui);

        public TableViewTimeColumn Invoke(Action<TvUI.TableViewTimeColumn> action) { action?.Invoke(UI); return this; }

        protected TableViewTimeColumn() { }
    }

    public static partial class TableViewTimeColumnExtensions
    {
        /// <summary>Set <see cref="TvUI.TableViewTimeColumn.ClockIdentifier"/></summary>
        public static TView ClockIdentifier<TView>(this TView view, string value) where TView : TableViewTimeColumn { view.UI.ClockIdentifier = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewTimeColumn.MinuteIncrement"/></summary>
        public static TView MinuteIncrement<TView>(this TView view, int value) where TView : TableViewTimeColumn { view.UI.MinuteIncrement = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewTimeColumn.PlaceholderText"/></summary>
        public static TView PlaceholderText<TView>(this TView view, string? value) where TView : TableViewTimeColumn { view.UI.PlaceholderText = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewTimeColumn.ClockIdentifier"/></summary>
        public static DependencyProperty<TTarget, string> ClockIdentifier<TTarget>(this TTarget target) where TTarget : TableViewTimeColumn
        => DependencyProperty<TTarget, string>.Get(target, TvUI.TableViewTimeColumn.ClockIdentifierProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewTimeColumn.MinuteIncrement"/></summary>
        public static DependencyProperty<TTarget, int> MinuteIncrement<TTarget>(this TTarget target) where TTarget : TableViewTimeColumn
        => DependencyProperty<TTarget, int>.Get(target, TvUI.TableViewTimeColumn.MinuteIncrementProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewTimeColumn.PlaceholderText"/></summary>
        public static DependencyProperty<TTarget, string?> PlaceholderText<TTarget>(this TTarget target) where TTarget : TableViewTimeColumn
        => DependencyProperty<TTarget, string?>.Get(target, TvUI.TableViewTimeColumn.PlaceholderTextProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // TableViewToggleSwitchColumn
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="TvUI.TableViewToggleSwitchColumn"/></summary>
        public static TableViewToggleSwitchColumn TableViewToggleSwitchColumn(object? OffContent = default, object? OnContent = default)
        {
            var ui = new TvUI.TableViewToggleSwitchColumn();
            if (OffContent is not null) ui.OffContent = OffContent;
            if (OnContent is not null) ui.OnContent = OnContent;
            return CSharpMarkup.WinUI.TableView.TableViewToggleSwitchColumn.StartChain(ui);
        }

        /// <summary>Create a <see cref="TvUI.TableViewToggleSwitchColumn"/></summary>
        public static TableViewToggleSwitchColumn TableViewToggleSwitchColumn()
        {
            var ui = new TvUI.TableViewToggleSwitchColumn();
            return CSharpMarkup.WinUI.TableView.TableViewToggleSwitchColumn.StartChain(ui);
        }
    }

    public partial class TableViewToggleSwitchColumn : TableViewBoundColumn, IUI<TvUI.TableViewToggleSwitchColumn>
    {
        static TableViewToggleSwitchColumn instance;

        internal static TableViewToggleSwitchColumn StartChain(TvUI.TableViewToggleSwitchColumn ui)
        {
            if (instance == null) instance = new TableViewToggleSwitchColumn();
            instance.UI = ui;
            return instance;
        }

        TvUI.TableViewToggleSwitchColumn ui;

        public new TvUI.TableViewToggleSwitchColumn UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator TvUI.TableViewToggleSwitchColumn(TableViewToggleSwitchColumn view) => view?.UI;

        public static implicit operator TableViewToggleSwitchColumn(TvUI.TableViewToggleSwitchColumn ui) => TableViewToggleSwitchColumn.StartChain(ui);

        public TableViewToggleSwitchColumn Invoke(Action<TvUI.TableViewToggleSwitchColumn> action) { action?.Invoke(UI); return this; }

        protected TableViewToggleSwitchColumn() { }
    }

    public static partial class TableViewToggleSwitchColumnExtensions
    {
        /// <summary>Set <see cref="TvUI.TableViewToggleSwitchColumn.OffContent"/></summary>
        public static TView OffContent<TView>(this TView view, object? value) where TView : TableViewToggleSwitchColumn { view.UI.OffContent = value; return view; }

        /// <summary>Set <see cref="TvUI.TableViewToggleSwitchColumn.OnContent"/></summary>
        public static TView OnContent<TView>(this TView view, object? value) where TView : TableViewToggleSwitchColumn { view.UI.OnContent = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewToggleSwitchColumn.OffContent"/></summary>
        public static DependencyProperty<TTarget, object?> OffContent<TTarget>(this TTarget target) where TTarget : TableViewToggleSwitchColumn
        => DependencyProperty<TTarget, object?>.Get(target, TvUI.TableViewToggleSwitchColumn.OffContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableViewToggleSwitchColumn.OnContent"/></summary>
        public static DependencyProperty<TTarget, object?> OnContent<TTarget>(this TTarget target) where TTarget : TableViewToggleSwitchColumn
        => DependencyProperty<TTarget, object?>.Get(target, TvUI.TableViewToggleSwitchColumn.OnContentProperty);
    }
}

namespace CSharpMarkup.WinUI.TableView // EnumPropertyValues
{
    public static partial class TableViewExtensions
    {
        /// <summary>Set to <see cref="Xaml.Controls.ListViewSelectionMode.Extended"/></summary>
        public static TTarget Extended<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.ListViewSelectionMode> property) where TTarget : TableView
        => property.Set(Xaml.Controls.ListViewSelectionMode.Extended);

        /// <summary>Set to <see cref="Xaml.Controls.ListViewSelectionMode.Multiple"/></summary>
        public static TTarget Multiple<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.ListViewSelectionMode> property) where TTarget : TableView
        => property.Set(Xaml.Controls.ListViewSelectionMode.Multiple);

        /// <summary>Set to <see cref="Xaml.Controls.ListViewSelectionMode.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.ListViewSelectionMode> property) where TTarget : TableView
        => property.Set(Xaml.Controls.ListViewSelectionMode.None);

        /// <summary>Set to <see cref="Xaml.Controls.ListViewSelectionMode.Single"/></summary>
        public static TTarget Single<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.ListViewSelectionMode> property) where TTarget : TableView
        => property.Set(Xaml.Controls.ListViewSelectionMode.Single);

        /// <summary>Set to <see cref="TvUI.TableViewCornerButtonMode.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, TvUI.TableViewCornerButtonMode> property) where TTarget : TableView
        => property.Set(TvUI.TableViewCornerButtonMode.None);

        /// <summary>Set to <see cref="TvUI.TableViewCornerButtonMode.Options"/></summary>
        public static TTarget Options<TTarget>(this DependencyProperty<TTarget, TvUI.TableViewCornerButtonMode> property) where TTarget : TableView
        => property.Set(TvUI.TableViewCornerButtonMode.Options);

        /// <summary>Set to <see cref="TvUI.TableViewCornerButtonMode.SelectAll"/></summary>
        public static TTarget SelectAll<TTarget>(this DependencyProperty<TTarget, TvUI.TableViewCornerButtonMode> property) where TTarget : TableView
        => property.Set(TvUI.TableViewCornerButtonMode.SelectAll);

        /// <summary>Set to <see cref="TvUI.TableViewGridLinesVisibility.All"/></summary>
        public static TTarget All<TTarget>(this DependencyProperty<TTarget, TvUI.TableViewGridLinesVisibility> property) where TTarget : TableView
        => property.Set(TvUI.TableViewGridLinesVisibility.All);

        /// <summary>Set to <see cref="TvUI.TableViewGridLinesVisibility.Horizontal"/></summary>
        public static TTarget Horizontal<TTarget>(this DependencyProperty<TTarget, TvUI.TableViewGridLinesVisibility> property) where TTarget : TableView
        => property.Set(TvUI.TableViewGridLinesVisibility.Horizontal);

        /// <summary>Set to <see cref="TvUI.TableViewGridLinesVisibility.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, TvUI.TableViewGridLinesVisibility> property) where TTarget : TableView
        => property.Set(TvUI.TableViewGridLinesVisibility.None);

        /// <summary>Set to <see cref="TvUI.TableViewGridLinesVisibility.Vertical"/></summary>
        public static TTarget Vertical<TTarget>(this DependencyProperty<TTarget, TvUI.TableViewGridLinesVisibility> property) where TTarget : TableView
        => property.Set(TvUI.TableViewGridLinesVisibility.Vertical);

        /// <summary>Set to <see cref="TvUI.TableViewSelectionUnit.Cell"/></summary>
        public static TTarget Cell<TTarget>(this DependencyProperty<TTarget, TvUI.TableViewSelectionUnit> property) where TTarget : TableView
        => property.Set(TvUI.TableViewSelectionUnit.Cell);

        /// <summary>Set to <see cref="TvUI.TableViewSelectionUnit.CellOrRow"/></summary>
        public static TTarget CellOrRow<TTarget>(this DependencyProperty<TTarget, TvUI.TableViewSelectionUnit> property) where TTarget : TableView
        => property.Set(TvUI.TableViewSelectionUnit.CellOrRow);

        /// <summary>Set to <see cref="TvUI.TableViewSelectionUnit.Row"/></summary>
        public static TTarget Row<TTarget>(this DependencyProperty<TTarget, TvUI.TableViewSelectionUnit> property) where TTarget : TableView
        => property.Set(TvUI.TableViewSelectionUnit.Row);
    }

    public static partial class TableViewColumnExtensions
    {
        /// <summary>Set to <see cref="Xaml.Visibility.Collapsed"/></summary>
        public static TTarget Collapsed<TTarget>(this DependencyProperty<TTarget, Xaml.Visibility> property) where TTarget : TableViewColumn
        => property.Set(Xaml.Visibility.Collapsed);

        /// <summary>Set to <see cref="Xaml.Visibility.Visible"/></summary>
        public static TTarget Visible<TTarget>(this DependencyProperty<TTarget, Xaml.Visibility> property) where TTarget : TableViewColumn
        => property.Set(Xaml.Visibility.Visible);
    }

    public static partial class TableViewDateColumnExtensions
    {
        /// <summary>Set to <see cref="Windows.Globalization.DayOfWeek.Friday"/></summary>
        public static TTarget Friday<TTarget>(this DependencyProperty<TTarget, Windows.Globalization.DayOfWeek> property) where TTarget : TableViewDateColumn
        => property.Set(Windows.Globalization.DayOfWeek.Friday);

        /// <summary>Set to <see cref="Windows.Globalization.DayOfWeek.Monday"/></summary>
        public static TTarget Monday<TTarget>(this DependencyProperty<TTarget, Windows.Globalization.DayOfWeek> property) where TTarget : TableViewDateColumn
        => property.Set(Windows.Globalization.DayOfWeek.Monday);

        /// <summary>Set to <see cref="Windows.Globalization.DayOfWeek.Saturday"/></summary>
        public static TTarget Saturday<TTarget>(this DependencyProperty<TTarget, Windows.Globalization.DayOfWeek> property) where TTarget : TableViewDateColumn
        => property.Set(Windows.Globalization.DayOfWeek.Saturday);

        /// <summary>Set to <see cref="Windows.Globalization.DayOfWeek.Sunday"/></summary>
        public static TTarget Sunday<TTarget>(this DependencyProperty<TTarget, Windows.Globalization.DayOfWeek> property) where TTarget : TableViewDateColumn
        => property.Set(Windows.Globalization.DayOfWeek.Sunday);

        /// <summary>Set to <see cref="Windows.Globalization.DayOfWeek.Thursday"/></summary>
        public static TTarget Thursday<TTarget>(this DependencyProperty<TTarget, Windows.Globalization.DayOfWeek> property) where TTarget : TableViewDateColumn
        => property.Set(Windows.Globalization.DayOfWeek.Thursday);

        /// <summary>Set to <see cref="Windows.Globalization.DayOfWeek.Tuesday"/></summary>
        public static TTarget Tuesday<TTarget>(this DependencyProperty<TTarget, Windows.Globalization.DayOfWeek> property) where TTarget : TableViewDateColumn
        => property.Set(Windows.Globalization.DayOfWeek.Tuesday);

        /// <summary>Set to <see cref="Windows.Globalization.DayOfWeek.Wednesday"/></summary>
        public static TTarget Wednesday<TTarget>(this DependencyProperty<TTarget, Windows.Globalization.DayOfWeek> property) where TTarget : TableViewDateColumn
        => property.Set(Windows.Globalization.DayOfWeek.Wednesday);
    }
}

#endif
// End of generated C# Markup API for Uno.WinUI
