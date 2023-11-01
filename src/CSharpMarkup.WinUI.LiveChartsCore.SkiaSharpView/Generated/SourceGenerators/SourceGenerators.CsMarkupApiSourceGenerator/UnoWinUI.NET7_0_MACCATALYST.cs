// Start of generated C# Markup API for Uno.WinUI
#if NET7_0_MACCATALYST && HAS_UNO && !WINDOWS_UWP

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Input;
using System.Runtime.Versioning;
using Microsoft;
using CSharpMarkup.WinUI.GeneratedCodeUtilities;
using UI = Microsoft.UI;
using Collections = System.Collections;
using Xaml = Microsoft.UI.Xaml;
using VirtualKey = Windows.System.VirtualKey;
using VirtualKeyModifiers = Windows.System.VirtualKeyModifiers;
using Drawing = System.Drawing;
using LiveCharts = LiveChartsCore;
using LiveChartsSkiaSharpView = LiveChartsCore.SkiaSharpView;
using LiveChartsSkiaWinUI = LiveChartsCore.SkiaSharpView.WinUI;

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // CartesianChart
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.CartesianChart"/></summary>
        public static CartesianChart CartesianChart(UIObject Content)
        {
            var ui = new LiveChartsSkiaWinUI.CartesianChart();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.CartesianChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.CartesianChart"/></summary>
        public static CartesianChart CartesianChart(CSharpMarkup.WinUI.to.TimeSpan? AnimationsSpeed = default, bool? AutoUpdateEnabled = default, ICommand ChartPointPointerDownCommand = default, ICommand DataPointerDownCommand = default, LiveCharts.Measure.Margin DrawMargin = default, LiveCharts.DrawMarginFrame<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? DrawMarginFrame = default, Func<float, float> EasingFunction = default, LiveCharts.Kernel.Sketches.IChartLegend<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Legend = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? LegendBackgroundPaint = default, LiveCharts.Measure.LegendPosition? LegendPosition = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? LegendTextPaint = default, double? LegendTextSize = default, ICommand? PointerMoveCommand = default, ICommand? PointerPressedCommand = default, ICommand? PointerReleasedCommand = default, IEnumerable<LiveCharts.Section<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> Sections = default, IEnumerable<LiveCharts.ISeries> Series = default, object SyncContext = default, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Title = default, LiveCharts.Kernel.Sketches.IChartTooltip<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Tooltip = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? TooltipBackgroundPaint = default, LiveCharts.Measure.TooltipFindingStrategy? TooltipFindingStrategy = default, LiveCharts.Measure.TooltipPosition? TooltipPosition = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? TooltipTextPaint = default, double? TooltipTextSize = default, CSharpMarkup.WinUI.to.TimeSpan? UpdaterThrottler = default, ICommand? UpdateStartedCommand = default, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> VisualElements = default, ICommand? VisualElementsPointerDownCommand = default, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis> XAxes = default, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis> YAxes = default, double? ZoomingSpeed = default, LiveCharts.Measure.ZoomAndPanMode? ZoomMode = default, UIObject Content = default)
        {
            var ui = new LiveChartsSkiaWinUI.CartesianChart();
            if (AnimationsSpeed is not null) ui.AnimationsSpeed = AnimationsSpeed.Value;
            if (AutoUpdateEnabled is not null) ui.AutoUpdateEnabled = AutoUpdateEnabled.Value;
            if (ChartPointPointerDownCommand is not null) ui.ChartPointPointerDownCommand = ChartPointPointerDownCommand;
            if (DataPointerDownCommand is not null) ui.DataPointerDownCommand = DataPointerDownCommand;
            if (DrawMargin is not null) ui.DrawMargin = DrawMargin;
            if (DrawMarginFrame is not null) ui.DrawMarginFrame = DrawMarginFrame;
            if (EasingFunction is not null) ui.EasingFunction = EasingFunction;
            if (Legend is not null) ui.Legend = Legend;
            if (LegendBackgroundPaint is not null) ui.LegendBackgroundPaint = LegendBackgroundPaint;
            if (LegendPosition is not null) ui.LegendPosition = LegendPosition.Value;
            if (LegendTextPaint is not null) ui.LegendTextPaint = LegendTextPaint;
            if (LegendTextSize is not null) ui.LegendTextSize = LegendTextSize;
            if (PointerMoveCommand is not null) ui.PointerMoveCommand = PointerMoveCommand;
            if (PointerPressedCommand is not null) ui.PointerPressedCommand = PointerPressedCommand;
            if (PointerReleasedCommand is not null) ui.PointerReleasedCommand = PointerReleasedCommand;
            if (Sections is not null) ui.Sections = Sections;
            if (Series is not null) ui.Series = Series;
            if (SyncContext is not null) ui.SyncContext = SyncContext;
            if (Title is not null) ui.Title = Title;
            if (Tooltip is not null) ui.Tooltip = Tooltip;
            if (TooltipBackgroundPaint is not null) ui.TooltipBackgroundPaint = TooltipBackgroundPaint;
            if (TooltipFindingStrategy is not null) ui.TooltipFindingStrategy = TooltipFindingStrategy.Value;
            if (TooltipPosition is not null) ui.TooltipPosition = TooltipPosition.Value;
            if (TooltipTextPaint is not null) ui.TooltipTextPaint = TooltipTextPaint;
            if (TooltipTextSize is not null) ui.TooltipTextSize = TooltipTextSize;
            if (UpdaterThrottler is not null) ui.UpdaterThrottler = UpdaterThrottler.Value;
            if (UpdateStartedCommand is not null) ui.UpdateStartedCommand = UpdateStartedCommand;
            if (VisualElements is not null) ui.VisualElements = VisualElements;
            if (VisualElementsPointerDownCommand is not null) ui.VisualElementsPointerDownCommand = VisualElementsPointerDownCommand;
            if (XAxes is not null) ui.XAxes = XAxes;
            if (YAxes is not null) ui.YAxes = YAxes;
            if (ZoomingSpeed is not null) ui.ZoomingSpeed = ZoomingSpeed.Value;
            if (ZoomMode is not null) ui.ZoomMode = ZoomMode.Value;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.CartesianChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.CartesianChart"/></summary>
        public static CartesianChart CartesianChart()
        {
            var ui = new LiveChartsSkiaWinUI.CartesianChart();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.CartesianChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.CartesianChart"/></summary>
        public static CartesianChart CartesianChart(nint handle)
        {
            var ui = new LiveChartsSkiaWinUI.CartesianChart(handle);
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.CartesianChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.CartesianChart"/></summary>
        public static CartesianChart CartesianChart(ObjCRuntime.NativeHandle handle)
        {
            var ui = new LiveChartsSkiaWinUI.CartesianChart(handle);
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.CartesianChart.StartChain(ui);
        }
    }

    public partial class CartesianChart : UserControl, IUI<LiveChartsSkiaWinUI.CartesianChart>
    {
        static CartesianChart instance;

        internal static CartesianChart StartChain(LiveChartsSkiaWinUI.CartesianChart ui)
        {
            if (instance == null) instance = new CartesianChart();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.CartesianChart ui;

        public new LiveChartsSkiaWinUI.CartesianChart UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(CartesianChart view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.CartesianChart(CartesianChart view) => view?.UI;

        public static implicit operator CartesianChart(LiveChartsSkiaWinUI.CartesianChart ui) => CartesianChart.StartChain(ui);

        public CartesianChart Invoke(Action<LiveChartsSkiaWinUI.CartesianChart> action) { action?.Invoke(UI); return this; }

        protected CartesianChart() { }
    }

    public static partial class CartesianChartExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.AnimationsSpeed"/></summary>
        public static TView AnimationsSpeed<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : CartesianChart { view.UI.AnimationsSpeed = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.AutoUpdateEnabled"/></summary>
        public static TView AutoUpdateEnabled<TView>(this TView view, bool value) where TView : CartesianChart { view.UI.AutoUpdateEnabled = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.ChartPointPointerDownCommand"/></summary>
        public static TView ChartPointPointerDownCommand<TView>(this TView view, ICommand value) where TView : CartesianChart { view.UI.ChartPointPointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.DataPointerDownCommand"/></summary>
        public static TView DataPointerDownCommand<TView>(this TView view, ICommand value) where TView : CartesianChart { view.UI.DataPointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.DrawMargin"/></summary>
        public static TView DrawMargin<TView>(this TView view, LiveCharts.Measure.Margin value) where TView : CartesianChart { view.UI.DrawMargin = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.DrawMarginFrame"/></summary>
        public static TView DrawMarginFrame<TView>(this TView view, LiveCharts.DrawMarginFrame<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : CartesianChart { view.UI.DrawMarginFrame = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.EasingFunction"/></summary>
        public static TView EasingFunction<TView>(this TView view, Func<float, float> value) where TView : CartesianChart { view.UI.EasingFunction = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.Legend"/></summary>
        public static TView Legend<TView>(this TView view, LiveCharts.Kernel.Sketches.IChartLegend<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : CartesianChart { view.UI.Legend = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.LegendBackgroundPaint"/></summary>
        public static TView LegendBackgroundPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : CartesianChart { view.UI.LegendBackgroundPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.LegendPosition"/></summary>
        public static TView LegendPosition<TView>(this TView view, LiveCharts.Measure.LegendPosition value) where TView : CartesianChart { view.UI.LegendPosition = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.LegendTextPaint"/></summary>
        public static TView LegendTextPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : CartesianChart { view.UI.LegendTextPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.LegendTextSize"/></summary>
        public static TView LegendTextSize<TView>(this TView view, double? value) where TView : CartesianChart { view.UI.LegendTextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.PointerMoveCommand"/></summary>
        public static TView PointerMoveCommand<TView>(this TView view, ICommand? value) where TView : CartesianChart { view.UI.PointerMoveCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.PointerPressedCommand"/></summary>
        public static TView PointerPressedCommand<TView>(this TView view, ICommand? value) where TView : CartesianChart { view.UI.PointerPressedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.PointerReleasedCommand"/></summary>
        public static TView PointerReleasedCommand<TView>(this TView view, ICommand? value) where TView : CartesianChart { view.UI.PointerReleasedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.Sections"/></summary>
        public static TView Sections<TView>(this TView view, IEnumerable<LiveCharts.Section<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> value) where TView : CartesianChart { view.UI.Sections = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.Series"/></summary>
        public static TView Series<TView>(this TView view, IEnumerable<LiveCharts.ISeries> value) where TView : CartesianChart { view.UI.Series = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.SyncContext"/></summary>
        public static TView SyncContext<TView>(this TView view, object value) where TView : CartesianChart { view.UI.SyncContext = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.Title"/></summary>
        public static TView Title<TView>(this TView view, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : CartesianChart { view.UI.Title = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.Tooltip"/></summary>
        public static TView Tooltip<TView>(this TView view, LiveCharts.Kernel.Sketches.IChartTooltip<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : CartesianChart { view.UI.Tooltip = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.TooltipBackgroundPaint"/></summary>
        public static TView TooltipBackgroundPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : CartesianChart { view.UI.TooltipBackgroundPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.TooltipFindingStrategy"/></summary>
        public static TView TooltipFindingStrategy<TView>(this TView view, LiveCharts.Measure.TooltipFindingStrategy value) where TView : CartesianChart { view.UI.TooltipFindingStrategy = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.TooltipPosition"/></summary>
        public static TView TooltipPosition<TView>(this TView view, LiveCharts.Measure.TooltipPosition value) where TView : CartesianChart { view.UI.TooltipPosition = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.TooltipTextPaint"/></summary>
        public static TView TooltipTextPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : CartesianChart { view.UI.TooltipTextPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.TooltipTextSize"/></summary>
        public static TView TooltipTextSize<TView>(this TView view, double? value) where TView : CartesianChart { view.UI.TooltipTextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.UpdaterThrottler"/></summary>
        public static TView UpdaterThrottler<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : CartesianChart { view.UI.UpdaterThrottler = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.UpdateStartedCommand"/></summary>
        public static TView UpdateStartedCommand<TView>(this TView view, ICommand? value) where TView : CartesianChart { view.UI.UpdateStartedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.VisualElements"/></summary>
        public static TView VisualElements<TView>(this TView view, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> value) where TView : CartesianChart { view.UI.VisualElements = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.VisualElementsPointerDownCommand"/></summary>
        public static TView VisualElementsPointerDownCommand<TView>(this TView view, ICommand? value) where TView : CartesianChart { view.UI.VisualElementsPointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.XAxes"/></summary>
        public static TView XAxes<TView>(this TView view, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis> value) where TView : CartesianChart { view.UI.XAxes = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.YAxes"/></summary>
        public static TView YAxes<TView>(this TView view, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis> value) where TView : CartesianChart { view.UI.YAxes = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.ZoomingSpeed"/></summary>
        public static TView ZoomingSpeed<TView>(this TView view, double value) where TView : CartesianChart { view.UI.ZoomingSpeed = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.CartesianChart.ZoomMode"/></summary>
        public static TView ZoomMode<TView>(this TView view, LiveCharts.Measure.ZoomAndPanMode value) where TView : CartesianChart { view.UI.ZoomMode = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.AnimationsSpeed"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan> AnimationsSpeed<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan>.Get(target, LiveChartsSkiaWinUI.CartesianChart.AnimationsSpeedProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.ChartPointPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> ChartPointPointerDownCommand<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsSkiaWinUI.CartesianChart.ChartPointPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.DataPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> DataPointerDownCommand<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsSkiaWinUI.CartesianChart.DataPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.DrawMarginFrame"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.DrawMarginFrame<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> DrawMarginFrame<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.DrawMarginFrame<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.DrawMarginFrameProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.DrawMargin"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.Margin> DrawMargin<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.Measure.Margin>.Get(target, LiveChartsSkiaWinUI.CartesianChart.DrawMarginProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.EasingFunction"/></summary>
        public static DependencyProperty<TTarget, Func<float, float>> EasingFunction<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, Func<float, float>>.Get(target, LiveChartsSkiaWinUI.CartesianChart.EasingFunctionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.LegendBackgroundPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> LegendBackgroundPaint<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.LegendBackgroundPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.LegendPosition"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> LegendPosition<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition>.Get(target, LiveChartsSkiaWinUI.CartesianChart.LegendPositionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.LegendTextPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> LegendTextPaint<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.LegendTextPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.LegendTextSize"/></summary>
        public static DependencyProperty<TTarget, double?> LegendTextSize<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.LegendTextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.PointerMoveCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerMoveCommand<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.PointerMoveCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.PointerPressedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerPressedCommand<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.PointerPressedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.PointerReleasedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerReleasedCommand<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.PointerReleasedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.Sections"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Section<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>> Sections<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Section<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>>.Get(target, LiveChartsSkiaWinUI.CartesianChart.SectionsProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.Series"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.ISeries>> Series<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.ISeries>>.Get(target, LiveChartsSkiaWinUI.CartesianChart.SeriesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.SyncContext"/></summary>
        public static DependencyProperty<TTarget, object> SyncContext<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, object>.Get(target, LiveChartsSkiaWinUI.CartesianChart.SyncContextProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.Title"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> Title<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.TitleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.TooltipBackgroundPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> TooltipBackgroundPaint<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.TooltipBackgroundPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.TooltipFindingStrategy"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.TooltipFindingStrategy> TooltipFindingStrategy<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.Measure.TooltipFindingStrategy>.Get(target, LiveChartsSkiaWinUI.CartesianChart.TooltipFindingStrategyProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.TooltipPosition"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> TooltipPosition<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition>.Get(target, LiveChartsSkiaWinUI.CartesianChart.TooltipPositionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.TooltipTextPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> TooltipTextPaint<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.TooltipTextPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.TooltipTextSize"/></summary>
        public static DependencyProperty<TTarget, double?> TooltipTextSize<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.TooltipTextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.UpdateStartedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> UpdateStartedCommand<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.UpdateStartedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.VisualElementsPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> VisualElementsPointerDownCommand<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.CartesianChart.VisualElementsPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.VisualElements"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>> VisualElements<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>>.Get(target, LiveChartsSkiaWinUI.CartesianChart.VisualElementsProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.XAxes"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis>> XAxes<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis>>.Get(target, LiveChartsSkiaWinUI.CartesianChart.XAxesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.YAxes"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis>> YAxes<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis>>.Get(target, LiveChartsSkiaWinUI.CartesianChart.YAxesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.ZoomingSpeed"/></summary>
        public static DependencyProperty<TTarget, double> ZoomingSpeed<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.CartesianChart.ZoomingSpeedProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.CartesianChart.ZoomMode"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> ZoomMode<TTarget>(this TTarget target) where TTarget : CartesianChart
        => DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode>.Get(target, LiveChartsSkiaWinUI.CartesianChart.ZoomModeProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // GeoMap
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.GeoMap"/></summary>
        public static GeoMap GeoMap(UIObject Content)
        {
            var ui = new LiveChartsSkiaWinUI.GeoMap();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.GeoMap.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.GeoMap"/></summary>
        public static GeoMap GeoMap(LiveCharts.Geo.CoreMap<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext> ActiveMap = default, bool? AutoUpdateEnabled = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Fill = default, LiveCharts.Geo.MapProjection? MapProjection = default, IEnumerable<LiveCharts.Geo.IGeoSeries> Series = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Stroke = default, object SyncContext = default, object? ViewCommand = default, UIObject Content = default)
        {
            var ui = new LiveChartsSkiaWinUI.GeoMap();
            if (ActiveMap is not null) ui.ActiveMap = ActiveMap;
            if (AutoUpdateEnabled is not null) ui.AutoUpdateEnabled = AutoUpdateEnabled.Value;
            if (Fill is not null) ui.Fill = Fill;
            if (MapProjection is not null) ui.MapProjection = MapProjection.Value;
            if (Series is not null) ui.Series = Series;
            if (Stroke is not null) ui.Stroke = Stroke;
            if (SyncContext is not null) ui.SyncContext = SyncContext;
            if (ViewCommand is not null) ui.ViewCommand = ViewCommand;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.GeoMap.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.GeoMap"/></summary>
        public static GeoMap GeoMap()
        {
            var ui = new LiveChartsSkiaWinUI.GeoMap();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.GeoMap.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.GeoMap"/></summary>
        public static GeoMap GeoMap(nint handle)
        {
            var ui = new LiveChartsSkiaWinUI.GeoMap(handle);
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.GeoMap.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.GeoMap"/></summary>
        public static GeoMap GeoMap(ObjCRuntime.NativeHandle handle)
        {
            var ui = new LiveChartsSkiaWinUI.GeoMap(handle);
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.GeoMap.StartChain(ui);
        }
    }

    public partial class GeoMap : UserControl, IUI<LiveChartsSkiaWinUI.GeoMap>
    {
        static GeoMap instance;

        internal static GeoMap StartChain(LiveChartsSkiaWinUI.GeoMap ui)
        {
            if (instance == null) instance = new GeoMap();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.GeoMap ui;

        public new LiveChartsSkiaWinUI.GeoMap UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(GeoMap view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.GeoMap(GeoMap view) => view?.UI;

        public static implicit operator GeoMap(LiveChartsSkiaWinUI.GeoMap ui) => GeoMap.StartChain(ui);

        public GeoMap Invoke(Action<LiveChartsSkiaWinUI.GeoMap> action) { action?.Invoke(UI); return this; }

        protected GeoMap() { }
    }

    public static partial class GeoMapExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.GeoMap.ActiveMap"/></summary>
        public static TView ActiveMap<TView>(this TView view, LiveCharts.Geo.CoreMap<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext> value) where TView : GeoMap { view.UI.ActiveMap = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.GeoMap.AutoUpdateEnabled"/></summary>
        public static TView AutoUpdateEnabled<TView>(this TView view, bool value) where TView : GeoMap { view.UI.AutoUpdateEnabled = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.GeoMap.Fill"/></summary>
        public static TView Fill<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : GeoMap { view.UI.Fill = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.GeoMap.MapProjection"/></summary>
        public static TView MapProjection<TView>(this TView view, LiveCharts.Geo.MapProjection value) where TView : GeoMap { view.UI.MapProjection = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.GeoMap.Series"/></summary>
        public static TView Series<TView>(this TView view, IEnumerable<LiveCharts.Geo.IGeoSeries> value) where TView : GeoMap { view.UI.Series = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.GeoMap.Stroke"/></summary>
        public static TView Stroke<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : GeoMap { view.UI.Stroke = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.GeoMap.SyncContext"/></summary>
        public static TView SyncContext<TView>(this TView view, object value) where TView : GeoMap { view.UI.SyncContext = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.GeoMap.ViewCommand"/></summary>
        public static TView ViewCommand<TView>(this TView view, object? value) where TView : GeoMap { view.UI.ViewCommand = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.GeoMap.ActiveMap"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Geo.CoreMap<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> ActiveMap<TTarget>(this TTarget target) where TTarget : GeoMap
        => DependencyProperty<TTarget, LiveCharts.Geo.CoreMap<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>.Get(target, LiveChartsSkiaWinUI.GeoMap.ActiveMapProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.GeoMap.Fill"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> Fill<TTarget>(this TTarget target) where TTarget : GeoMap
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.GeoMap.FillProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.GeoMap.MapProjection"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Geo.MapProjection> MapProjection<TTarget>(this TTarget target) where TTarget : GeoMap
        => DependencyProperty<TTarget, LiveCharts.Geo.MapProjection>.Get(target, LiveChartsSkiaWinUI.GeoMap.MapProjectionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.GeoMap.Series"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Geo.IGeoSeries>> Series<TTarget>(this TTarget target) where TTarget : GeoMap
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Geo.IGeoSeries>>.Get(target, LiveChartsSkiaWinUI.GeoMap.SeriesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.GeoMap.Stroke"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> Stroke<TTarget>(this TTarget target) where TTarget : GeoMap
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.GeoMap.StrokeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.GeoMap.SyncContext"/></summary>
        public static DependencyProperty<TTarget, object> SyncContext<TTarget>(this TTarget target) where TTarget : GeoMap
        => DependencyProperty<TTarget, object>.Get(target, LiveChartsSkiaWinUI.GeoMap.SyncContextProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.GeoMap.ViewCommand"/></summary>
        public static DependencyProperty<TTarget, object?> ViewCommand<TTarget>(this TTarget target) where TTarget : GeoMap
        => DependencyProperty<TTarget, object?>.Get(target, LiveChartsSkiaWinUI.GeoMap.ViewCommandProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // MotionCanvas
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.MotionCanvas"/></summary>
        public static MotionCanvas MotionCanvas(UIObject Content)
        {
            var ui = new LiveChartsSkiaWinUI.MotionCanvas();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.MotionCanvas.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.MotionCanvas"/></summary>
        public static MotionCanvas MotionCanvas(double? MaxFps = default, List<LiveCharts.Kernel.PaintSchedule<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> PaintTasks = default, UIObject Content = default)
        {
            var ui = new LiveChartsSkiaWinUI.MotionCanvas();
            if (MaxFps is not null) ui.MaxFps = MaxFps.Value;
            if (PaintTasks is not null) ui.PaintTasks = PaintTasks;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.MotionCanvas.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.MotionCanvas"/></summary>
        public static MotionCanvas MotionCanvas()
        {
            var ui = new LiveChartsSkiaWinUI.MotionCanvas();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.MotionCanvas.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.MotionCanvas"/></summary>
        public static MotionCanvas MotionCanvas(nint handle)
        {
            var ui = new LiveChartsSkiaWinUI.MotionCanvas(handle);
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.MotionCanvas.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.MotionCanvas"/></summary>
        public static MotionCanvas MotionCanvas(ObjCRuntime.NativeHandle handle)
        {
            var ui = new LiveChartsSkiaWinUI.MotionCanvas(handle);
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.MotionCanvas.StartChain(ui);
        }
    }

    public partial class MotionCanvas : UserControl, IUI<LiveChartsSkiaWinUI.MotionCanvas>
    {
        static MotionCanvas instance;

        internal static MotionCanvas StartChain(LiveChartsSkiaWinUI.MotionCanvas ui)
        {
            if (instance == null) instance = new MotionCanvas();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.MotionCanvas ui;

        public new LiveChartsSkiaWinUI.MotionCanvas UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(MotionCanvas view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.MotionCanvas(MotionCanvas view) => view?.UI;

        public static implicit operator MotionCanvas(LiveChartsSkiaWinUI.MotionCanvas ui) => MotionCanvas.StartChain(ui);

        public MotionCanvas Invoke(Action<LiveChartsSkiaWinUI.MotionCanvas> action) { action?.Invoke(UI); return this; }

        protected MotionCanvas() { }
    }

    public static partial class MotionCanvasExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.MotionCanvas.MaxFps"/></summary>
        public static TView MaxFps<TView>(this TView view, double value) where TView : MotionCanvas { view.UI.MaxFps = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.MotionCanvas.PaintTasks"/></summary>
        public static TView PaintTasks<TView>(this TView view, List<LiveCharts.Kernel.PaintSchedule<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> value) where TView : MotionCanvas { view.UI.PaintTasks = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.MotionCanvas.PaintTasks"/></summary>
        public static DependencyProperty<TTarget, List<LiveCharts.Kernel.PaintSchedule<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>> PaintTasks<TTarget>(this TTarget target) where TTarget : MotionCanvas
        => DependencyProperty<TTarget, List<LiveCharts.Kernel.PaintSchedule<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>>.Get(target, LiveChartsSkiaWinUI.MotionCanvas.PaintTasksProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // PieChart
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.PieChart"/></summary>
        public static PieChart PieChart(UIObject Content)
        {
            var ui = new LiveChartsSkiaWinUI.PieChart();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PieChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.PieChart"/></summary>
        public static PieChart PieChart(CSharpMarkup.WinUI.to.TimeSpan? AnimationsSpeed = default, bool? AutoUpdateEnabled = default, ICommand ChartPointPointerDownCommand = default, ICommand DataPointerDownCommand = default, LiveCharts.Measure.Margin DrawMargin = default, Func<float, float> EasingFunction = default, double? InitialRotation = default, bool? IsClockwise = default, LiveCharts.Kernel.Sketches.IChartLegend<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Legend = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? LegendBackgroundPaint = default, LiveCharts.Measure.LegendPosition? LegendPosition = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? LegendTextPaint = default, double? LegendTextSize = default, double? MaxAngle = default, double? MaxValue = default, double? MinValue = default, ICommand? PointerMoveCommand = default, ICommand? PointerPressedCommand = default, ICommand? PointerReleasedCommand = default, IEnumerable<LiveCharts.ISeries> Series = default, object SyncContext = default, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Title = default, LiveCharts.Kernel.Sketches.IChartTooltip<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Tooltip = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? TooltipBackgroundPaint = default, LiveCharts.Measure.TooltipPosition? TooltipPosition = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? TooltipTextPaint = default, double? TooltipTextSize = default, double? Total = default, CSharpMarkup.WinUI.to.TimeSpan? UpdaterThrottler = default, ICommand? UpdateStartedCommand = default, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> VisualElements = default, ICommand? VisualElementsPointerDownCommand = default, UIObject Content = default)
        {
            var ui = new LiveChartsSkiaWinUI.PieChart();
            if (AnimationsSpeed is not null) ui.AnimationsSpeed = AnimationsSpeed.Value;
            if (AutoUpdateEnabled is not null) ui.AutoUpdateEnabled = AutoUpdateEnabled.Value;
            if (ChartPointPointerDownCommand is not null) ui.ChartPointPointerDownCommand = ChartPointPointerDownCommand;
            if (DataPointerDownCommand is not null) ui.DataPointerDownCommand = DataPointerDownCommand;
            if (DrawMargin is not null) ui.DrawMargin = DrawMargin;
            if (EasingFunction is not null) ui.EasingFunction = EasingFunction;
            if (InitialRotation is not null) ui.InitialRotation = InitialRotation.Value;
            if (IsClockwise is not null) ui.IsClockwise = IsClockwise.Value;
            if (Legend is not null) ui.Legend = Legend;
            if (LegendBackgroundPaint is not null) ui.LegendBackgroundPaint = LegendBackgroundPaint;
            if (LegendPosition is not null) ui.LegendPosition = LegendPosition.Value;
            if (LegendTextPaint is not null) ui.LegendTextPaint = LegendTextPaint;
            if (LegendTextSize is not null) ui.LegendTextSize = LegendTextSize;
            if (MaxAngle is not null) ui.MaxAngle = MaxAngle.Value;
            if (MaxValue is not null) ui.MaxValue = MaxValue;
            if (MinValue is not null) ui.MinValue = MinValue.Value;
            if (PointerMoveCommand is not null) ui.PointerMoveCommand = PointerMoveCommand;
            if (PointerPressedCommand is not null) ui.PointerPressedCommand = PointerPressedCommand;
            if (PointerReleasedCommand is not null) ui.PointerReleasedCommand = PointerReleasedCommand;
            if (Series is not null) ui.Series = Series;
            if (SyncContext is not null) ui.SyncContext = SyncContext;
            if (Title is not null) ui.Title = Title;
            if (Tooltip is not null) ui.Tooltip = Tooltip;
            if (TooltipBackgroundPaint is not null) ui.TooltipBackgroundPaint = TooltipBackgroundPaint;
            if (TooltipPosition is not null) ui.TooltipPosition = TooltipPosition.Value;
            if (TooltipTextPaint is not null) ui.TooltipTextPaint = TooltipTextPaint;
            if (TooltipTextSize is not null) ui.TooltipTextSize = TooltipTextSize;
            if (Total is not null) ui.Total = Total;
            if (UpdaterThrottler is not null) ui.UpdaterThrottler = UpdaterThrottler.Value;
            if (UpdateStartedCommand is not null) ui.UpdateStartedCommand = UpdateStartedCommand;
            if (VisualElements is not null) ui.VisualElements = VisualElements;
            if (VisualElementsPointerDownCommand is not null) ui.VisualElementsPointerDownCommand = VisualElementsPointerDownCommand;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PieChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.PieChart"/></summary>
        public static PieChart PieChart()
        {
            var ui = new LiveChartsSkiaWinUI.PieChart();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PieChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.PieChart"/></summary>
        public static PieChart PieChart(nint handle)
        {
            var ui = new LiveChartsSkiaWinUI.PieChart(handle);
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PieChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.PieChart"/></summary>
        public static PieChart PieChart(ObjCRuntime.NativeHandle handle)
        {
            var ui = new LiveChartsSkiaWinUI.PieChart(handle);
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PieChart.StartChain(ui);
        }
    }

    public partial class PieChart : UserControl, IUI<LiveChartsSkiaWinUI.PieChart>
    {
        static PieChart instance;

        internal static PieChart StartChain(LiveChartsSkiaWinUI.PieChart ui)
        {
            if (instance == null) instance = new PieChart();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.PieChart ui;

        public new LiveChartsSkiaWinUI.PieChart UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(PieChart view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.PieChart(PieChart view) => view?.UI;

        public static implicit operator PieChart(LiveChartsSkiaWinUI.PieChart ui) => PieChart.StartChain(ui);

        public PieChart Invoke(Action<LiveChartsSkiaWinUI.PieChart> action) { action?.Invoke(UI); return this; }

        protected PieChart() { }
    }

    public static partial class PieChartExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.AnimationsSpeed"/></summary>
        public static TView AnimationsSpeed<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : PieChart { view.UI.AnimationsSpeed = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.AutoUpdateEnabled"/></summary>
        public static TView AutoUpdateEnabled<TView>(this TView view, bool value) where TView : PieChart { view.UI.AutoUpdateEnabled = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.ChartPointPointerDownCommand"/></summary>
        public static TView ChartPointPointerDownCommand<TView>(this TView view, ICommand value) where TView : PieChart { view.UI.ChartPointPointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.DataPointerDownCommand"/></summary>
        public static TView DataPointerDownCommand<TView>(this TView view, ICommand value) where TView : PieChart { view.UI.DataPointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.DrawMargin"/></summary>
        public static TView DrawMargin<TView>(this TView view, LiveCharts.Measure.Margin value) where TView : PieChart { view.UI.DrawMargin = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.EasingFunction"/></summary>
        public static TView EasingFunction<TView>(this TView view, Func<float, float> value) where TView : PieChart { view.UI.EasingFunction = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.InitialRotation"/></summary>
        public static TView InitialRotation<TView>(this TView view, double value) where TView : PieChart { view.UI.InitialRotation = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.IsClockwise"/></summary>
        public static TView IsClockwise<TView>(this TView view, bool value) where TView : PieChart { view.UI.IsClockwise = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.Legend"/></summary>
        public static TView Legend<TView>(this TView view, LiveCharts.Kernel.Sketches.IChartLegend<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PieChart { view.UI.Legend = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.LegendBackgroundPaint"/></summary>
        public static TView LegendBackgroundPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PieChart { view.UI.LegendBackgroundPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.LegendPosition"/></summary>
        public static TView LegendPosition<TView>(this TView view, LiveCharts.Measure.LegendPosition value) where TView : PieChart { view.UI.LegendPosition = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.LegendTextPaint"/></summary>
        public static TView LegendTextPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PieChart { view.UI.LegendTextPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.LegendTextSize"/></summary>
        public static TView LegendTextSize<TView>(this TView view, double? value) where TView : PieChart { view.UI.LegendTextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.MaxAngle"/></summary>
        public static TView MaxAngle<TView>(this TView view, double value) where TView : PieChart { view.UI.MaxAngle = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.MaxValue"/></summary>
        public static TView MaxValue<TView>(this TView view, double? value) where TView : PieChart { view.UI.MaxValue = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.MinValue"/></summary>
        public static TView MinValue<TView>(this TView view, double value) where TView : PieChart { view.UI.MinValue = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.PointerMoveCommand"/></summary>
        public static TView PointerMoveCommand<TView>(this TView view, ICommand? value) where TView : PieChart { view.UI.PointerMoveCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.PointerPressedCommand"/></summary>
        public static TView PointerPressedCommand<TView>(this TView view, ICommand? value) where TView : PieChart { view.UI.PointerPressedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.PointerReleasedCommand"/></summary>
        public static TView PointerReleasedCommand<TView>(this TView view, ICommand? value) where TView : PieChart { view.UI.PointerReleasedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.Series"/></summary>
        public static TView Series<TView>(this TView view, IEnumerable<LiveCharts.ISeries> value) where TView : PieChart { view.UI.Series = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.SyncContext"/></summary>
        public static TView SyncContext<TView>(this TView view, object value) where TView : PieChart { view.UI.SyncContext = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.Title"/></summary>
        public static TView Title<TView>(this TView view, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PieChart { view.UI.Title = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.Tooltip"/></summary>
        public static TView Tooltip<TView>(this TView view, LiveCharts.Kernel.Sketches.IChartTooltip<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PieChart { view.UI.Tooltip = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.TooltipBackgroundPaint"/></summary>
        public static TView TooltipBackgroundPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PieChart { view.UI.TooltipBackgroundPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.TooltipPosition"/></summary>
        public static TView TooltipPosition<TView>(this TView view, LiveCharts.Measure.TooltipPosition value) where TView : PieChart { view.UI.TooltipPosition = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.TooltipTextPaint"/></summary>
        public static TView TooltipTextPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PieChart { view.UI.TooltipTextPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.TooltipTextSize"/></summary>
        public static TView TooltipTextSize<TView>(this TView view, double? value) where TView : PieChart { view.UI.TooltipTextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.Total"/></summary>
        public static TView Total<TView>(this TView view, double? value) where TView : PieChart { view.UI.Total = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.UpdaterThrottler"/></summary>
        public static TView UpdaterThrottler<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : PieChart { view.UI.UpdaterThrottler = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.UpdateStartedCommand"/></summary>
        public static TView UpdateStartedCommand<TView>(this TView view, ICommand? value) where TView : PieChart { view.UI.UpdateStartedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.VisualElements"/></summary>
        public static TView VisualElements<TView>(this TView view, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> value) where TView : PieChart { view.UI.VisualElements = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PieChart.VisualElementsPointerDownCommand"/></summary>
        public static TView VisualElementsPointerDownCommand<TView>(this TView view, ICommand? value) where TView : PieChart { view.UI.VisualElementsPointerDownCommand = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.AnimationsSpeed"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan> AnimationsSpeed<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan>.Get(target, LiveChartsSkiaWinUI.PieChart.AnimationsSpeedProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.ChartPointPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> ChartPointPointerDownCommand<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsSkiaWinUI.PieChart.ChartPointPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.DataPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> DataPointerDownCommand<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsSkiaWinUI.PieChart.DataPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.DrawMargin"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.Margin> DrawMargin<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, LiveCharts.Measure.Margin>.Get(target, LiveChartsSkiaWinUI.PieChart.DrawMarginProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.EasingFunction"/></summary>
        public static DependencyProperty<TTarget, Func<float, float>> EasingFunction<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, Func<float, float>>.Get(target, LiveChartsSkiaWinUI.PieChart.EasingFunctionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.InitialRotation"/></summary>
        public static DependencyProperty<TTarget, double> InitialRotation<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.PieChart.InitialRotationProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.IsClockwise"/></summary>
        public static DependencyProperty<TTarget, bool> IsClockwise<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.PieChart.IsClockwiseProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.LegendBackgroundPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> LegendBackgroundPaint<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.PieChart.LegendBackgroundPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.LegendPosition"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> LegendPosition<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition>.Get(target, LiveChartsSkiaWinUI.PieChart.LegendPositionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.LegendTextPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> LegendTextPaint<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.PieChart.LegendTextPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.LegendTextSize"/></summary>
        public static DependencyProperty<TTarget, double?> LegendTextSize<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.PieChart.LegendTextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.MaxAngle"/></summary>
        public static DependencyProperty<TTarget, double> MaxAngle<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.PieChart.MaxAngleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.MaxValue"/></summary>
        public static DependencyProperty<TTarget, double?> MaxValue<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.PieChart.MaxValueProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.MinValue"/></summary>
        public static DependencyProperty<TTarget, double> MinValue<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.PieChart.MinValueProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.PointerMoveCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerMoveCommand<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.PieChart.PointerMoveCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.PointerPressedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerPressedCommand<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.PieChart.PointerPressedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.PointerReleasedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerReleasedCommand<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.PieChart.PointerReleasedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.Series"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.ISeries>> Series<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.ISeries>>.Get(target, LiveChartsSkiaWinUI.PieChart.SeriesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.SyncContext"/></summary>
        public static DependencyProperty<TTarget, object> SyncContext<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, object>.Get(target, LiveChartsSkiaWinUI.PieChart.SyncContextProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.Title"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> Title<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.PieChart.TitleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.TooltipBackgroundPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> TooltipBackgroundPaint<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.PieChart.TooltipBackgroundPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.TooltipPosition"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> TooltipPosition<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition>.Get(target, LiveChartsSkiaWinUI.PieChart.TooltipPositionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.TooltipTextPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> TooltipTextPaint<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.PieChart.TooltipTextPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.TooltipTextSize"/></summary>
        public static DependencyProperty<TTarget, double?> TooltipTextSize<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.PieChart.TooltipTextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.UpdateStartedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> UpdateStartedCommand<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.PieChart.UpdateStartedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.VisualElementsPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> VisualElementsPointerDownCommand<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.PieChart.VisualElementsPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PieChart.VisualElements"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>> VisualElements<TTarget>(this TTarget target) where TTarget : PieChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>>.Get(target, LiveChartsSkiaWinUI.PieChart.VisualElementsProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // PolarChart
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.PolarChart"/></summary>
        public static PolarChart PolarChart(UIObject Content)
        {
            var ui = new LiveChartsSkiaWinUI.PolarChart();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PolarChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.PolarChart"/></summary>
        public static PolarChart PolarChart(IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis> AngleAxes = default, CSharpMarkup.WinUI.to.TimeSpan? AnimationsSpeed = default, bool? AutoUpdateEnabled = default, ICommand ChartPointPointerDownCommand = default, ICommand DataPointerDownCommand = default, LiveCharts.Measure.Margin? DrawMargin = default, Func<float, float> EasingFunction = default, bool? FitToBounds = default, double? InitialRotation = default, double? InnerRadius = default, LiveCharts.Kernel.Sketches.IChartLegend<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Legend = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? LegendBackgroundPaint = default, LiveCharts.Measure.LegendPosition? LegendPosition = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? LegendTextPaint = default, double? LegendTextSize = default, ICommand? PointerMoveCommand = default, ICommand? PointerPressedCommand = default, ICommand? PointerReleasedCommand = default, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis> RadiusAxes = default, IEnumerable<LiveCharts.ISeries> Series = default, object SyncContext = default, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Title = default, LiveCharts.Kernel.Sketches.IChartTooltip<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? Tooltip = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? TooltipBackgroundPaint = default, LiveCharts.Measure.TooltipPosition? TooltipPosition = default, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? TooltipTextPaint = default, double? TooltipTextSize = default, double? TotalAngle = default, CSharpMarkup.WinUI.to.TimeSpan? UpdaterThrottler = default, ICommand? UpdateStartedCommand = default, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> VisualElements = default, ICommand? VisualElementsPointerDownCommand = default, UIObject Content = default)
        {
            var ui = new LiveChartsSkiaWinUI.PolarChart();
            if (AngleAxes is not null) ui.AngleAxes = AngleAxes;
            if (AnimationsSpeed is not null) ui.AnimationsSpeed = AnimationsSpeed.Value;
            if (AutoUpdateEnabled is not null) ui.AutoUpdateEnabled = AutoUpdateEnabled.Value;
            if (ChartPointPointerDownCommand is not null) ui.ChartPointPointerDownCommand = ChartPointPointerDownCommand;
            if (DataPointerDownCommand is not null) ui.DataPointerDownCommand = DataPointerDownCommand;
            if (DrawMargin is not null) ui.DrawMargin = DrawMargin;
            if (EasingFunction is not null) ui.EasingFunction = EasingFunction;
            if (FitToBounds is not null) ui.FitToBounds = FitToBounds.Value;
            if (InitialRotation is not null) ui.InitialRotation = InitialRotation.Value;
            if (InnerRadius is not null) ui.InnerRadius = InnerRadius.Value;
            if (Legend is not null) ui.Legend = Legend;
            if (LegendBackgroundPaint is not null) ui.LegendBackgroundPaint = LegendBackgroundPaint;
            if (LegendPosition is not null) ui.LegendPosition = LegendPosition.Value;
            if (LegendTextPaint is not null) ui.LegendTextPaint = LegendTextPaint;
            if (LegendTextSize is not null) ui.LegendTextSize = LegendTextSize;
            if (PointerMoveCommand is not null) ui.PointerMoveCommand = PointerMoveCommand;
            if (PointerPressedCommand is not null) ui.PointerPressedCommand = PointerPressedCommand;
            if (PointerReleasedCommand is not null) ui.PointerReleasedCommand = PointerReleasedCommand;
            if (RadiusAxes is not null) ui.RadiusAxes = RadiusAxes;
            if (Series is not null) ui.Series = Series;
            if (SyncContext is not null) ui.SyncContext = SyncContext;
            if (Title is not null) ui.Title = Title;
            if (Tooltip is not null) ui.Tooltip = Tooltip;
            if (TooltipBackgroundPaint is not null) ui.TooltipBackgroundPaint = TooltipBackgroundPaint;
            if (TooltipPosition is not null) ui.TooltipPosition = TooltipPosition.Value;
            if (TooltipTextPaint is not null) ui.TooltipTextPaint = TooltipTextPaint;
            if (TooltipTextSize is not null) ui.TooltipTextSize = TooltipTextSize;
            if (TotalAngle is not null) ui.TotalAngle = TotalAngle.Value;
            if (UpdaterThrottler is not null) ui.UpdaterThrottler = UpdaterThrottler.Value;
            if (UpdateStartedCommand is not null) ui.UpdateStartedCommand = UpdateStartedCommand;
            if (VisualElements is not null) ui.VisualElements = VisualElements;
            if (VisualElementsPointerDownCommand is not null) ui.VisualElementsPointerDownCommand = VisualElementsPointerDownCommand;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PolarChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.PolarChart"/></summary>
        public static PolarChart PolarChart()
        {
            var ui = new LiveChartsSkiaWinUI.PolarChart();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PolarChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.PolarChart"/></summary>
        public static PolarChart PolarChart(nint handle)
        {
            var ui = new LiveChartsSkiaWinUI.PolarChart(handle);
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PolarChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.PolarChart"/></summary>
        public static PolarChart PolarChart(ObjCRuntime.NativeHandle handle)
        {
            var ui = new LiveChartsSkiaWinUI.PolarChart(handle);
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PolarChart.StartChain(ui);
        }
    }

    public partial class PolarChart : UserControl, IUI<LiveChartsSkiaWinUI.PolarChart>
    {
        static PolarChart instance;

        internal static PolarChart StartChain(LiveChartsSkiaWinUI.PolarChart ui)
        {
            if (instance == null) instance = new PolarChart();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.PolarChart ui;

        public new LiveChartsSkiaWinUI.PolarChart UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(PolarChart view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.PolarChart(PolarChart view) => view?.UI;

        public static implicit operator PolarChart(LiveChartsSkiaWinUI.PolarChart ui) => PolarChart.StartChain(ui);

        public PolarChart Invoke(Action<LiveChartsSkiaWinUI.PolarChart> action) { action?.Invoke(UI); return this; }

        protected PolarChart() { }
    }

    public static partial class PolarChartExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.AngleAxes"/></summary>
        public static TView AngleAxes<TView>(this TView view, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis> value) where TView : PolarChart { view.UI.AngleAxes = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.AnimationsSpeed"/></summary>
        public static TView AnimationsSpeed<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : PolarChart { view.UI.AnimationsSpeed = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.AutoUpdateEnabled"/></summary>
        public static TView AutoUpdateEnabled<TView>(this TView view, bool value) where TView : PolarChart { view.UI.AutoUpdateEnabled = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.ChartPointPointerDownCommand"/></summary>
        public static TView ChartPointPointerDownCommand<TView>(this TView view, ICommand value) where TView : PolarChart { view.UI.ChartPointPointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.DataPointerDownCommand"/></summary>
        public static TView DataPointerDownCommand<TView>(this TView view, ICommand value) where TView : PolarChart { view.UI.DataPointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.DrawMargin"/></summary>
        public static TView DrawMargin<TView>(this TView view, LiveCharts.Measure.Margin? value) where TView : PolarChart { view.UI.DrawMargin = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.EasingFunction"/></summary>
        public static TView EasingFunction<TView>(this TView view, Func<float, float> value) where TView : PolarChart { view.UI.EasingFunction = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.FitToBounds"/></summary>
        public static TView FitToBounds<TView>(this TView view, bool value) where TView : PolarChart { view.UI.FitToBounds = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.InitialRotation"/></summary>
        public static TView InitialRotation<TView>(this TView view, double value) where TView : PolarChart { view.UI.InitialRotation = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.InnerRadius"/></summary>
        public static TView InnerRadius<TView>(this TView view, double value) where TView : PolarChart { view.UI.InnerRadius = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.Legend"/></summary>
        public static TView Legend<TView>(this TView view, LiveCharts.Kernel.Sketches.IChartLegend<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PolarChart { view.UI.Legend = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.LegendBackgroundPaint"/></summary>
        public static TView LegendBackgroundPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PolarChart { view.UI.LegendBackgroundPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.LegendPosition"/></summary>
        public static TView LegendPosition<TView>(this TView view, LiveCharts.Measure.LegendPosition value) where TView : PolarChart { view.UI.LegendPosition = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.LegendTextPaint"/></summary>
        public static TView LegendTextPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PolarChart { view.UI.LegendTextPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.LegendTextSize"/></summary>
        public static TView LegendTextSize<TView>(this TView view, double? value) where TView : PolarChart { view.UI.LegendTextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.PointerMoveCommand"/></summary>
        public static TView PointerMoveCommand<TView>(this TView view, ICommand? value) where TView : PolarChart { view.UI.PointerMoveCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.PointerPressedCommand"/></summary>
        public static TView PointerPressedCommand<TView>(this TView view, ICommand? value) where TView : PolarChart { view.UI.PointerPressedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.PointerReleasedCommand"/></summary>
        public static TView PointerReleasedCommand<TView>(this TView view, ICommand? value) where TView : PolarChart { view.UI.PointerReleasedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.RadiusAxes"/></summary>
        public static TView RadiusAxes<TView>(this TView view, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis> value) where TView : PolarChart { view.UI.RadiusAxes = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.Series"/></summary>
        public static TView Series<TView>(this TView view, IEnumerable<LiveCharts.ISeries> value) where TView : PolarChart { view.UI.Series = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.SyncContext"/></summary>
        public static TView SyncContext<TView>(this TView view, object value) where TView : PolarChart { view.UI.SyncContext = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.Title"/></summary>
        public static TView Title<TView>(this TView view, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PolarChart { view.UI.Title = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.Tooltip"/></summary>
        public static TView Tooltip<TView>(this TView view, LiveCharts.Kernel.Sketches.IChartTooltip<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PolarChart { view.UI.Tooltip = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.TooltipBackgroundPaint"/></summary>
        public static TView TooltipBackgroundPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PolarChart { view.UI.TooltipBackgroundPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.TooltipPosition"/></summary>
        public static TView TooltipPosition<TView>(this TView view, LiveCharts.Measure.TooltipPosition value) where TView : PolarChart { view.UI.TooltipPosition = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.TooltipTextPaint"/></summary>
        public static TView TooltipTextPaint<TView>(this TView view, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>? value) where TView : PolarChart { view.UI.TooltipTextPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.TooltipTextSize"/></summary>
        public static TView TooltipTextSize<TView>(this TView view, double? value) where TView : PolarChart { view.UI.TooltipTextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.TotalAngle"/></summary>
        public static TView TotalAngle<TView>(this TView view, double value) where TView : PolarChart { view.UI.TotalAngle = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.UpdaterThrottler"/></summary>
        public static TView UpdaterThrottler<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : PolarChart { view.UI.UpdaterThrottler = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.UpdateStartedCommand"/></summary>
        public static TView UpdateStartedCommand<TView>(this TView view, ICommand? value) where TView : PolarChart { view.UI.UpdateStartedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.VisualElements"/></summary>
        public static TView VisualElements<TView>(this TView view, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>> value) where TView : PolarChart { view.UI.VisualElements = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.PolarChart.VisualElementsPointerDownCommand"/></summary>
        public static TView VisualElementsPointerDownCommand<TView>(this TView view, ICommand? value) where TView : PolarChart { view.UI.VisualElementsPointerDownCommand = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.AngleAxes"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis>> AngleAxes<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis>>.Get(target, LiveChartsSkiaWinUI.PolarChart.AngleAxesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.AnimationsSpeed"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan> AnimationsSpeed<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan>.Get(target, LiveChartsSkiaWinUI.PolarChart.AnimationsSpeedProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.ChartPointPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> ChartPointPointerDownCommand<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsSkiaWinUI.PolarChart.ChartPointPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.DataPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> DataPointerDownCommand<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsSkiaWinUI.PolarChart.DataPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.EasingFunction"/></summary>
        public static DependencyProperty<TTarget, Func<float, float>> EasingFunction<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, Func<float, float>>.Get(target, LiveChartsSkiaWinUI.PolarChart.EasingFunctionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.FitToBounds"/></summary>
        public static DependencyProperty<TTarget, bool> FitToBounds<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.PolarChart.FitToBoundsProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.InitialRotation"/></summary>
        public static DependencyProperty<TTarget, double> InitialRotation<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.PolarChart.InitialRotationProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.InnerRadius"/></summary>
        public static DependencyProperty<TTarget, double> InnerRadius<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.PolarChart.InnerRadiusProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.LegendBackgroundPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> LegendBackgroundPaint<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.PolarChart.LegendBackgroundPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.LegendPosition"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> LegendPosition<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition>.Get(target, LiveChartsSkiaWinUI.PolarChart.LegendPositionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.LegendTextPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> LegendTextPaint<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.PolarChart.LegendTextPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.LegendTextSize"/></summary>
        public static DependencyProperty<TTarget, double?> LegendTextSize<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.PolarChart.LegendTextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.PointerMoveCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerMoveCommand<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.PolarChart.PointerMoveCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.PointerPressedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerPressedCommand<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.PolarChart.PointerPressedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.PointerReleasedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerReleasedCommand<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.PolarChart.PointerReleasedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.RadiusAxes"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis>> RadiusAxes<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis>>.Get(target, LiveChartsSkiaWinUI.PolarChart.RadiusAxesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.Series"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.ISeries>> Series<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.ISeries>>.Get(target, LiveChartsSkiaWinUI.PolarChart.SeriesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.SyncContext"/></summary>
        public static DependencyProperty<TTarget, object> SyncContext<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, object>.Get(target, LiveChartsSkiaWinUI.PolarChart.SyncContextProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.Title"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> Title<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, LiveCharts.VisualElements.VisualElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.PolarChart.TitleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.TooltipBackgroundPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> TooltipBackgroundPaint<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.PolarChart.TooltipBackgroundPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.TooltipPosition"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> TooltipPosition<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition>.Get(target, LiveChartsSkiaWinUI.PolarChart.TooltipPositionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.TooltipTextPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?> TooltipTextPaint<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, LiveCharts.Drawing.IPaint<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>?>.Get(target, LiveChartsSkiaWinUI.PolarChart.TooltipTextPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.TooltipTextSize"/></summary>
        public static DependencyProperty<TTarget, double?> TooltipTextSize<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.PolarChart.TooltipTextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.TotalAngle"/></summary>
        public static DependencyProperty<TTarget, double> TotalAngle<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.PolarChart.TotalAngleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.UpdateStartedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> UpdateStartedCommand<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.PolarChart.UpdateStartedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.VisualElementsPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> VisualElementsPointerDownCommand<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.PolarChart.VisualElementsPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.PolarChart.VisualElements"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>> VisualElements<TTarget>(this TTarget target) where TTarget : PolarChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.ChartElement<LiveChartsSkiaSharpView.Drawing.SkiaSharpDrawingContext>>>.Get(target, LiveChartsSkiaWinUI.PolarChart.VisualElementsProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // EnumPropertyValues
{
    public static partial class CartesianChartExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Bottom"/></summary>
        public static TTarget Bottom<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.LegendPosition.Bottom);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Hidden"/></summary>
        public static TTarget Hidden<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.LegendPosition.Hidden);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.LegendPosition.Left);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.LegendPosition.Right);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Top"/></summary>
        public static TTarget Top<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.LegendPosition.Top);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipFindingStrategy.Automatic"/></summary>
        public static TTarget Automatic<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipFindingStrategy> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipFindingStrategy.Automatic);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipFindingStrategy.CompareAll"/></summary>
        public static TTarget CompareAll<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipFindingStrategy> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipFindingStrategy.CompareAll);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipFindingStrategy.CompareAllTakeClosest"/></summary>
        public static TTarget CompareAllTakeClosest<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipFindingStrategy> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipFindingStrategy.CompareAllTakeClosest);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipFindingStrategy.CompareOnlyX"/></summary>
        public static TTarget CompareOnlyX<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipFindingStrategy> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipFindingStrategy.CompareOnlyX);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipFindingStrategy.CompareOnlyXTakeClosest"/></summary>
        public static TTarget CompareOnlyXTakeClosest<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipFindingStrategy> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipFindingStrategy.CompareOnlyXTakeClosest);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipFindingStrategy.CompareOnlyY"/></summary>
        public static TTarget CompareOnlyY<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipFindingStrategy> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipFindingStrategy.CompareOnlyY);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipFindingStrategy.CompareOnlyYTakeClosest"/></summary>
        public static TTarget CompareOnlyYTakeClosest<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipFindingStrategy> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipFindingStrategy.CompareOnlyYTakeClosest);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Auto"/></summary>
        public static TTarget Auto<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Auto);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Bottom"/></summary>
        public static TTarget Bottom<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Bottom);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Center"/></summary>
        public static TTarget Center<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Center);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Hidden"/></summary>
        public static TTarget Hidden<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Hidden);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Left);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Right);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Top"/></summary>
        public static TTarget Top<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Top);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.Both"/></summary>
        public static TTarget Both<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.Both);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.InvertPanningPointerTrigger"/></summary>
        public static TTarget InvertPanningPointerTrigger<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.InvertPanningPointerTrigger);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.None);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.PanX"/></summary>
        public static TTarget PanX<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.PanX);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.PanY"/></summary>
        public static TTarget PanY<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.PanY);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.X"/></summary>
        public static TTarget X<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.X);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.Y"/></summary>
        public static TTarget Y<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.Y);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.ZoomX"/></summary>
        public static TTarget ZoomX<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.ZoomX);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.ZoomY"/></summary>
        public static TTarget ZoomY<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : CartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.ZoomY);
    }

    public static partial class GeoMapExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Geo.MapProjection.Default"/></summary>
        public static TTarget Default<TTarget>(this DependencyProperty<TTarget, LiveCharts.Geo.MapProjection> property) where TTarget : GeoMap
        => property.Set(LiveCharts.Geo.MapProjection.Default);

        /// <summary>Set to <see cref="LiveCharts.Geo.MapProjection.Mercator"/></summary>
        public static TTarget Mercator<TTarget>(this DependencyProperty<TTarget, LiveCharts.Geo.MapProjection> property) where TTarget : GeoMap
        => property.Set(LiveCharts.Geo.MapProjection.Mercator);
    }

    public static partial class PieChartExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Bottom"/></summary>
        public static TTarget Bottom<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.LegendPosition.Bottom);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Hidden"/></summary>
        public static TTarget Hidden<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.LegendPosition.Hidden);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.LegendPosition.Left);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.LegendPosition.Right);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Top"/></summary>
        public static TTarget Top<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.LegendPosition.Top);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Auto"/></summary>
        public static TTarget Auto<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Auto);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Bottom"/></summary>
        public static TTarget Bottom<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Bottom);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Center"/></summary>
        public static TTarget Center<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Center);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Hidden"/></summary>
        public static TTarget Hidden<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Hidden);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Left);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Right);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Top"/></summary>
        public static TTarget Top<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PieChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Top);
    }

    public static partial class PolarChartExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Bottom"/></summary>
        public static TTarget Bottom<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.LegendPosition.Bottom);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Hidden"/></summary>
        public static TTarget Hidden<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.LegendPosition.Hidden);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.LegendPosition.Left);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.LegendPosition.Right);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Top"/></summary>
        public static TTarget Top<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.LegendPosition.Top);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Auto"/></summary>
        public static TTarget Auto<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Auto);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Bottom"/></summary>
        public static TTarget Bottom<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Bottom);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Center"/></summary>
        public static TTarget Center<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Center);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Hidden"/></summary>
        public static TTarget Hidden<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Hidden);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Left);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Right);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Top"/></summary>
        public static TTarget Top<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : PolarChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Top);
    }
}

#endif
// End of generated C# Markup API for Uno.WinUI
