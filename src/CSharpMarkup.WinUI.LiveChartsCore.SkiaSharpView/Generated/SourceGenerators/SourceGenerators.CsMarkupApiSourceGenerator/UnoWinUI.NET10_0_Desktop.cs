// Start of generated C# Markup API for Uno.WinUI
#if NET10_0 && DESKTOP

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
        public static CartesianChart CartesianChart()
        {
            var ui = new LiveChartsSkiaWinUI.CartesianChart();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.CartesianChart.StartChain(ui);
        }
    }

    public partial class CartesianChart : SourceGenCartesianChart, IUI<LiveChartsSkiaWinUI.CartesianChart>
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
        public static GeoMap GeoMap()
        {
            var ui = new LiveChartsSkiaWinUI.GeoMap();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.GeoMap.StartChain(ui);
        }
    }

    public partial class GeoMap : SourceGenMapChart, IUI<LiveChartsSkiaWinUI.GeoMap>
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
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // MotionCanvas
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.MotionCanvas"/></summary>
        public static MotionCanvas MotionCanvas(params Xaml.UIElement[] Children)
        {
            var ui = new LiveChartsSkiaWinUI.MotionCanvas();
            for (int i = 0; i < Children.Length; i++)
            {
                var child = Children[i];
                if (child == null) continue;

                var subChildren = Spreader<Xaml.UIElement>.ExtractChildren(child);
                if (subChildren is not null)
                    for (int j = 0; j < subChildren.Length; j++)
                        ui.Children.Add(subChildren[j]);
                else
                    ui.Children.Add(child);
            }
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.MotionCanvas.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.MotionCanvas"/></summary>
        public static MotionCanvas MotionCanvas()
        {
            var ui = new LiveChartsSkiaWinUI.MotionCanvas();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.MotionCanvas.StartChain(ui);
        }
    }

    public partial class MotionCanvas : Canvas, IUI<LiveChartsSkiaWinUI.MotionCanvas>
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
        public static PieChart PieChart()
        {
            var ui = new LiveChartsSkiaWinUI.PieChart();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PieChart.StartChain(ui);
        }
    }

    public partial class PieChart : SourceGenPieChart, IUI<LiveChartsSkiaWinUI.PieChart>
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
        public static PolarChart PolarChart()
        {
            var ui = new LiveChartsSkiaWinUI.PolarChart();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.PolarChart.StartChain(ui);
        }
    }

    public partial class PolarChart : SourceGenPolarChart, IUI<LiveChartsSkiaWinUI.PolarChart>
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
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlAngularGaugeSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlAngularGaugeSeries"/></summary>
        public static XamlAngularGaugeSeries XamlAngularGaugeSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlAngularGaugeSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlAngularGaugeSeries.StartChain(ui);
        }
    }

    public partial class XamlAngularGaugeSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlAngularGaugeSeries>
    {
        static XamlAngularGaugeSeries instance;

        internal static XamlAngularGaugeSeries StartChain(LiveChartsSkiaWinUI.XamlAngularGaugeSeries ui)
        {
            if (instance == null) instance = new XamlAngularGaugeSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlAngularGaugeSeries ui;

        public new LiveChartsSkiaWinUI.XamlAngularGaugeSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlAngularGaugeSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlAngularGaugeSeries(XamlAngularGaugeSeries view) => view?.UI;

        public static implicit operator XamlAngularGaugeSeries(LiveChartsSkiaWinUI.XamlAngularGaugeSeries ui) => XamlAngularGaugeSeries.StartChain(ui);

        public XamlAngularGaugeSeries Invoke(Action<LiveChartsSkiaWinUI.XamlAngularGaugeSeries> action) { action?.Invoke(UI); return this; }

        protected XamlAngularGaugeSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlAngularTicks
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlAngularTicks"/></summary>
        public static XamlAngularTicks XamlAngularTicks(bool? IsVisible = default, Func<double, string> Labeler = default, double? LabelsOuterOffset = default, LiveCharts.Painting.Paint? LabelsPaint = default, double? LabelsSize = default, LiveCharts.Measure.MeasureUnit? LocationUnit = default, double? OuterOffset = default, ICommand? PointerDownCommand = default, ICommand? PropertyChangedCommand = default, double? Rotation = default, int? ScalesXAt = default, int? ScalesYAt = default, LiveCharts.Painting.Paint? Stroke = default, object? Tag = default, double? TicksLength = default, LiveCharts.Drawing.LvcPoint? Translate = default, double? X = default, double? Y = default)
        {
            var ui = new LiveChartsSkiaWinUI.XamlAngularTicks();
            if (IsVisible is not null) ui.IsVisible = IsVisible.Value;
            if (Labeler is not null) ui.Labeler = Labeler;
            if (LabelsOuterOffset is not null) ui.LabelsOuterOffset = LabelsOuterOffset.Value;
            if (LabelsPaint is not null) ui.LabelsPaint = LabelsPaint;
            if (LabelsSize is not null) ui.LabelsSize = LabelsSize.Value;
            if (LocationUnit is not null) ui.LocationUnit = LocationUnit.Value;
            if (OuterOffset is not null) ui.OuterOffset = OuterOffset.Value;
            if (PointerDownCommand is not null) ui.PointerDownCommand = PointerDownCommand;
            if (PropertyChangedCommand is not null) ui.PropertyChangedCommand = PropertyChangedCommand;
            if (Rotation is not null) ui.Rotation = Rotation.Value;
            if (ScalesXAt is not null) ui.ScalesXAt = ScalesXAt.Value;
            if (ScalesYAt is not null) ui.ScalesYAt = ScalesYAt.Value;
            if (Stroke is not null) ui.Stroke = Stroke;
            if (Tag is not null) ui.Tag = Tag;
            if (TicksLength is not null) ui.TicksLength = TicksLength.Value;
            if (Translate is not null) ui.Translate = Translate.Value;
            if (X is not null) ui.X = X.Value;
            if (Y is not null) ui.Y = Y.Value;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlAngularTicks.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlAngularTicks"/></summary>
        public static XamlAngularTicks XamlAngularTicks()
        {
            var ui = new LiveChartsSkiaWinUI.XamlAngularTicks();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlAngularTicks.StartChain(ui);
        }
    }

    public partial class XamlAngularTicks : FrameworkElement, IUI<LiveChartsSkiaWinUI.XamlAngularTicks>
    {
        static XamlAngularTicks instance;

        internal static XamlAngularTicks StartChain(LiveChartsSkiaWinUI.XamlAngularTicks ui)
        {
            if (instance == null) instance = new XamlAngularTicks();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlAngularTicks ui;

        public new LiveChartsSkiaWinUI.XamlAngularTicks UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlAngularTicks view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlAngularTicks(XamlAngularTicks view) => view?.UI;

        public static implicit operator XamlAngularTicks(LiveChartsSkiaWinUI.XamlAngularTicks ui) => XamlAngularTicks.StartChain(ui);

        public XamlAngularTicks Invoke(Action<LiveChartsSkiaWinUI.XamlAngularTicks> action) { action?.Invoke(UI); return this; }

        protected XamlAngularTicks() { }
    }

    public static partial class XamlAngularTicksExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.IsVisible"/></summary>
        public static TView IsVisible<TView>(this TView view, bool value) where TView : XamlAngularTicks { view.UI.IsVisible = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Labeler"/></summary>
        public static TView Labeler<TView>(this TView view, Func<double, string> value) where TView : XamlAngularTicks { view.UI.Labeler = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.LabelsOuterOffset"/></summary>
        public static TView LabelsOuterOffset<TView>(this TView view, double value) where TView : XamlAngularTicks { view.UI.LabelsOuterOffset = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.LabelsPaint"/></summary>
        public static TView LabelsPaint<TView>(this TView view, LiveCharts.Painting.Paint? value) where TView : XamlAngularTicks { view.UI.LabelsPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.LabelsSize"/></summary>
        public static TView LabelsSize<TView>(this TView view, double value) where TView : XamlAngularTicks { view.UI.LabelsSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.LocationUnit"/></summary>
        public static TView LocationUnit<TView>(this TView view, LiveCharts.Measure.MeasureUnit value) where TView : XamlAngularTicks { view.UI.LocationUnit = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.OuterOffset"/></summary>
        public static TView OuterOffset<TView>(this TView view, double value) where TView : XamlAngularTicks { view.UI.OuterOffset = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.PointerDownCommand"/></summary>
        public static TView PointerDownCommand<TView>(this TView view, ICommand? value) where TView : XamlAngularTicks { view.UI.PointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.PropertyChangedCommand"/></summary>
        public static TView PropertyChangedCommand<TView>(this TView view, ICommand? value) where TView : XamlAngularTicks { view.UI.PropertyChangedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Rotation"/></summary>
        public static TView Rotation<TView>(this TView view, double value) where TView : XamlAngularTicks { view.UI.Rotation = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.ScalesXAt"/></summary>
        public static TView ScalesXAt<TView>(this TView view, int value) where TView : XamlAngularTicks { view.UI.ScalesXAt = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.ScalesYAt"/></summary>
        public static TView ScalesYAt<TView>(this TView view, int value) where TView : XamlAngularTicks { view.UI.ScalesYAt = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Stroke"/></summary>
        public static TView Stroke<TView>(this TView view, LiveCharts.Painting.Paint? value) where TView : XamlAngularTicks { view.UI.Stroke = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Tag"/></summary>
        public static TView Tag<TView>(this TView view, object? value) where TView : XamlAngularTicks { view.UI.Tag = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.TicksLength"/></summary>
        public static TView TicksLength<TView>(this TView view, double value) where TView : XamlAngularTicks { view.UI.TicksLength = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Translate"/></summary>
        public static TView Translate<TView>(this TView view, LiveCharts.Drawing.LvcPoint value) where TView : XamlAngularTicks { view.UI.Translate = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.X"/></summary>
        public static TView X<TView>(this TView view, double value) where TView : XamlAngularTicks { view.UI.X = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Y"/></summary>
        public static TView Y<TView>(this TView view, double value) where TView : XamlAngularTicks { view.UI.Y = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.IsVisible"/></summary>
        public static DependencyProperty<TTarget, bool> IsVisible<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.IsVisibleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Labeler"/></summary>
        public static DependencyProperty<TTarget, Func<double, string>> Labeler<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, Func<double, string>>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.LabelerProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.LabelsOuterOffset"/></summary>
        public static DependencyProperty<TTarget, double> LabelsOuterOffset<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.LabelsOuterOffsetProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.LabelsPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint?> LabelsPaint<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint?>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.LabelsPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.LabelsSize"/></summary>
        public static DependencyProperty<TTarget, double> LabelsSize<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.LabelsSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.LocationUnit"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.MeasureUnit> LocationUnit<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, LiveCharts.Measure.MeasureUnit>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.LocationUnitProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.OuterOffset"/></summary>
        public static DependencyProperty<TTarget, double> OuterOffset<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.OuterOffsetProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.PointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerDownCommand<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.PointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.PropertyChangedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PropertyChangedCommand<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.PropertyChangedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Rotation"/></summary>
        public static DependencyProperty<TTarget, double> Rotation<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.RotationProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.ScalesXAt"/></summary>
        public static DependencyProperty<TTarget, int> ScalesXAt<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, int>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.ScalesXAtProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.ScalesYAt"/></summary>
        public static DependencyProperty<TTarget, int> ScalesYAt<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, int>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.ScalesYAtProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Stroke"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint?> Stroke<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint?>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.StrokeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Tag"/></summary>
        public static DependencyProperty<TTarget, object?> Tag<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, object?>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.TagProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.TicksLength"/></summary>
        public static DependencyProperty<TTarget, double> TicksLength<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.TicksLengthProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Translate"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint> Translate<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.TranslateProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.X"/></summary>
        public static DependencyProperty<TTarget, double> X<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.XProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlAngularTicks.Y"/></summary>
        public static DependencyProperty<TTarget, double> Y<TTarget>(this TTarget target) where TTarget : XamlAngularTicks
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlAngularTicks.YProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlAxis
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlAxis"/></summary>
        public static XamlAxis XamlAxis()
        {
            var ui = new LiveChartsSkiaWinUI.XamlAxis();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlAxis.StartChain(ui);
        }
    }

    public partial class XamlAxis : FrameworkElement, IUI<LiveChartsSkiaWinUI.XamlAxis>
    {
        static XamlAxis instance;

        internal static XamlAxis StartChain(LiveChartsSkiaWinUI.XamlAxis ui)
        {
            if (instance == null) instance = new XamlAxis();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlAxis ui;

        public new LiveChartsSkiaWinUI.XamlAxis UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlAxis view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlAxis(XamlAxis view) => view?.UI;

        public static implicit operator XamlAxis(LiveChartsSkiaWinUI.XamlAxis ui) => XamlAxis.StartChain(ui);

        public XamlAxis Invoke(Action<LiveChartsSkiaWinUI.XamlAxis> action) { action?.Invoke(UI); return this; }

        protected XamlAxis() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlBoxSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlBoxSeries"/></summary>
        public static XamlBoxSeries XamlBoxSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlBoxSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlBoxSeries.StartChain(ui);
        }
    }

    public partial class XamlBoxSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlBoxSeries>
    {
        static XamlBoxSeries instance;

        internal static XamlBoxSeries StartChain(LiveChartsSkiaWinUI.XamlBoxSeries ui)
        {
            if (instance == null) instance = new XamlBoxSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlBoxSeries ui;

        public new LiveChartsSkiaWinUI.XamlBoxSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlBoxSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlBoxSeries(XamlBoxSeries view) => view?.UI;

        public static implicit operator XamlBoxSeries(LiveChartsSkiaWinUI.XamlBoxSeries ui) => XamlBoxSeries.StartChain(ui);

        public XamlBoxSeries Invoke(Action<LiveChartsSkiaWinUI.XamlBoxSeries> action) { action?.Invoke(UI); return this; }

        protected XamlBoxSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlCandlesticksSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlCandlesticksSeries"/></summary>
        public static XamlCandlesticksSeries XamlCandlesticksSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlCandlesticksSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlCandlesticksSeries.StartChain(ui);
        }
    }

    public partial class XamlCandlesticksSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlCandlesticksSeries>
    {
        static XamlCandlesticksSeries instance;

        internal static XamlCandlesticksSeries StartChain(LiveChartsSkiaWinUI.XamlCandlesticksSeries ui)
        {
            if (instance == null) instance = new XamlCandlesticksSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlCandlesticksSeries ui;

        public new LiveChartsSkiaWinUI.XamlCandlesticksSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlCandlesticksSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlCandlesticksSeries(XamlCandlesticksSeries view) => view?.UI;

        public static implicit operator XamlCandlesticksSeries(LiveChartsSkiaWinUI.XamlCandlesticksSeries ui) => XamlCandlesticksSeries.StartChain(ui);

        public XamlCandlesticksSeries Invoke(Action<LiveChartsSkiaWinUI.XamlCandlesticksSeries> action) { action?.Invoke(UI); return this; }

        protected XamlCandlesticksSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlColumnSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlColumnSeries"/></summary>
        public static XamlColumnSeries XamlColumnSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlColumnSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlColumnSeries.StartChain(ui);
        }
    }

    public partial class XamlColumnSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlColumnSeries>
    {
        static XamlColumnSeries instance;

        internal static XamlColumnSeries StartChain(LiveChartsSkiaWinUI.XamlColumnSeries ui)
        {
            if (instance == null) instance = new XamlColumnSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlColumnSeries ui;

        public new LiveChartsSkiaWinUI.XamlColumnSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlColumnSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlColumnSeries(XamlColumnSeries view) => view?.UI;

        public static implicit operator XamlColumnSeries(LiveChartsSkiaWinUI.XamlColumnSeries ui) => XamlColumnSeries.StartChain(ui);

        public XamlColumnSeries Invoke(Action<LiveChartsSkiaWinUI.XamlColumnSeries> action) { action?.Invoke(UI); return this; }

        protected XamlColumnSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlDateTimeAxis
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlDateTimeAxis"/></summary>
        public static XamlDateTimeAxis XamlDateTimeAxis(Func<DateTime, string> DateFormatter = default, CSharpMarkup.WinUI.to.TimeSpan? Interval = default)
        {
            var ui = new LiveChartsSkiaWinUI.XamlDateTimeAxis();
            if (DateFormatter is not null) ui.DateFormatter = DateFormatter;
            if (Interval is not null) ui.Interval = Interval.Value;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlDateTimeAxis.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlDateTimeAxis"/></summary>
        public static XamlDateTimeAxis XamlDateTimeAxis()
        {
            var ui = new LiveChartsSkiaWinUI.XamlDateTimeAxis();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlDateTimeAxis.StartChain(ui);
        }
    }

    public partial class XamlDateTimeAxis : FrameworkElement, IUI<LiveChartsSkiaWinUI.XamlDateTimeAxis>
    {
        static XamlDateTimeAxis instance;

        internal static XamlDateTimeAxis StartChain(LiveChartsSkiaWinUI.XamlDateTimeAxis ui)
        {
            if (instance == null) instance = new XamlDateTimeAxis();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlDateTimeAxis ui;

        public new LiveChartsSkiaWinUI.XamlDateTimeAxis UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlDateTimeAxis view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlDateTimeAxis(XamlDateTimeAxis view) => view?.UI;

        public static implicit operator XamlDateTimeAxis(LiveChartsSkiaWinUI.XamlDateTimeAxis ui) => XamlDateTimeAxis.StartChain(ui);

        public XamlDateTimeAxis Invoke(Action<LiveChartsSkiaWinUI.XamlDateTimeAxis> action) { action?.Invoke(UI); return this; }

        protected XamlDateTimeAxis() { }
    }

    public static partial class XamlDateTimeAxisExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDateTimeAxis.DateFormatter"/></summary>
        public static TView DateFormatter<TView>(this TView view, Func<DateTime, string> value) where TView : XamlDateTimeAxis { view.UI.DateFormatter = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDateTimeAxis.Interval"/></summary>
        public static TView Interval<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : XamlDateTimeAxis { view.UI.Interval = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDateTimeAxis.DateFormatter"/></summary>
        public static DependencyProperty<TTarget, Func<DateTime, string>> DateFormatter<TTarget>(this TTarget target) where TTarget : XamlDateTimeAxis
        => DependencyProperty<TTarget, Func<DateTime, string>>.Get(target, LiveChartsSkiaWinUI.XamlDateTimeAxis.DateFormatterProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDateTimeAxis.Interval"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan> Interval<TTarget>(this TTarget target) where TTarget : XamlDateTimeAxis
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan>.Get(target, LiveChartsSkiaWinUI.XamlDateTimeAxis.IntervalProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlDrawnLabelVisual
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual"/></summary>
        public static XamlDrawnLabelVisual XamlDrawnLabelVisual(CSharpMarkup.WinUI.to.TimeSpan? AnimationSpeed = default, LiveCharts.Drawing.LvcColor? Background = default, LiveCharts.Drawing.LvcRectangle? ClippingBounds = default, LiveCharts.Drawing.LvcDropShadow? DropShadow = default, Func<float, float>? Easing = default, bool? HasTransform = default, LiveCharts.Drawing.Align? HorizontalAlign = default, bool? IsValid = default, bool? IsVisible = default, float? MaxWidth = default, float? Opacity = default, LiveCharts.Drawing.Padding Padding = default, LiveCharts.Painting.Paint? Paint = default, ICommand? PointerDownCommand = default, ICommand? PropertyChangedCommand = default, bool? RemoveOnCompleted = default, float? RotateTransform = default, LiveCharts.Drawing.LvcPoint? ScaleTransform = default, LiveCharts.Drawing.LvcPoint? SkewTransform = default, object? Tag = default, string Text = default, float? TextSize = default, LiveCharts.Drawing.LvcPoint? TransformOrigin = default, LiveCharts.Drawing.LvcPoint? TranslateTransform = default, LiveCharts.Drawing.Align? VerticalAlign = default, float? X = default, float? Y = default)
        {
            var ui = new LiveChartsSkiaWinUI.XamlDrawnLabelVisual();
            if (AnimationSpeed is not null) ui.AnimationSpeed = AnimationSpeed.Value;
            if (Background is not null) ui.Background = Background.Value;
            if (ClippingBounds is not null) ui.ClippingBounds = ClippingBounds.Value;
            if (DropShadow is not null) ui.DropShadow = DropShadow;
            if (Easing is not null) ui.Easing = Easing;
            if (HasTransform is not null) ui.HasTransform = HasTransform.Value;
            if (HorizontalAlign is not null) ui.HorizontalAlign = HorizontalAlign.Value;
            if (IsValid is not null) ui.IsValid = IsValid.Value;
            if (IsVisible is not null) ui.IsVisible = IsVisible.Value;
            if (MaxWidth is not null) ui.MaxWidth = MaxWidth.Value;
            if (Opacity is not null) ui.Opacity = Opacity.Value;
            if (Padding is not null) ui.Padding = Padding;
            if (Paint is not null) ui.Paint = Paint;
            if (PointerDownCommand is not null) ui.PointerDownCommand = PointerDownCommand;
            if (PropertyChangedCommand is not null) ui.PropertyChangedCommand = PropertyChangedCommand;
            if (RemoveOnCompleted is not null) ui.RemoveOnCompleted = RemoveOnCompleted.Value;
            if (RotateTransform is not null) ui.RotateTransform = RotateTransform.Value;
            if (ScaleTransform is not null) ui.ScaleTransform = ScaleTransform.Value;
            if (SkewTransform is not null) ui.SkewTransform = SkewTransform.Value;
            if (Tag is not null) ui.Tag = Tag;
            if (Text is not null) ui.Text = Text;
            if (TextSize is not null) ui.TextSize = TextSize.Value;
            if (TransformOrigin is not null) ui.TransformOrigin = TransformOrigin.Value;
            if (TranslateTransform is not null) ui.TranslateTransform = TranslateTransform.Value;
            if (VerticalAlign is not null) ui.VerticalAlign = VerticalAlign.Value;
            if (X is not null) ui.X = X.Value;
            if (Y is not null) ui.Y = Y.Value;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlDrawnLabelVisual.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual"/></summary>
        public static XamlDrawnLabelVisual XamlDrawnLabelVisual()
        {
            var ui = new LiveChartsSkiaWinUI.XamlDrawnLabelVisual();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlDrawnLabelVisual.StartChain(ui);
        }
    }

    public partial class XamlDrawnLabelVisual : FrameworkElement, IUI<LiveChartsSkiaWinUI.XamlDrawnLabelVisual>
    {
        static XamlDrawnLabelVisual instance;

        internal static XamlDrawnLabelVisual StartChain(LiveChartsSkiaWinUI.XamlDrawnLabelVisual ui)
        {
            if (instance == null) instance = new XamlDrawnLabelVisual();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlDrawnLabelVisual ui;

        public new LiveChartsSkiaWinUI.XamlDrawnLabelVisual UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlDrawnLabelVisual view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlDrawnLabelVisual(XamlDrawnLabelVisual view) => view?.UI;

        public static implicit operator XamlDrawnLabelVisual(LiveChartsSkiaWinUI.XamlDrawnLabelVisual ui) => XamlDrawnLabelVisual.StartChain(ui);

        public XamlDrawnLabelVisual Invoke(Action<LiveChartsSkiaWinUI.XamlDrawnLabelVisual> action) { action?.Invoke(UI); return this; }

        protected XamlDrawnLabelVisual() { }
    }

    public static partial class XamlDrawnLabelVisualExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.AnimationSpeed"/></summary>
        public static TView AnimationSpeed<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : XamlDrawnLabelVisual { view.UI.AnimationSpeed = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Background"/></summary>
        public static TView Background<TView>(this TView view, LiveCharts.Drawing.LvcColor value) where TView : XamlDrawnLabelVisual { view.UI.Background = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.ClippingBounds"/></summary>
        public static TView ClippingBounds<TView>(this TView view, LiveCharts.Drawing.LvcRectangle value) where TView : XamlDrawnLabelVisual { view.UI.ClippingBounds = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.DropShadow"/></summary>
        public static TView DropShadow<TView>(this TView view, LiveCharts.Drawing.LvcDropShadow? value) where TView : XamlDrawnLabelVisual { view.UI.DropShadow = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Easing"/></summary>
        public static TView Easing<TView>(this TView view, Func<float, float>? value) where TView : XamlDrawnLabelVisual { view.UI.Easing = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.HasTransform"/></summary>
        public static TView HasTransform<TView>(this TView view, bool value) where TView : XamlDrawnLabelVisual { view.UI.HasTransform = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.HorizontalAlign"/></summary>
        public static TView HorizontalAlign<TView>(this TView view, LiveCharts.Drawing.Align value) where TView : XamlDrawnLabelVisual { view.UI.HorizontalAlign = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.IsValid"/></summary>
        public static TView IsValid<TView>(this TView view, bool value) where TView : XamlDrawnLabelVisual { view.UI.IsValid = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.IsVisible"/></summary>
        public static TView IsVisible<TView>(this TView view, bool value) where TView : XamlDrawnLabelVisual { view.UI.IsVisible = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.MaxWidth"/></summary>
        public static TView MaxWidth<TView>(this TView view, float value) where TView : XamlDrawnLabelVisual { view.UI.MaxWidth = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Opacity"/></summary>
        public static TView Opacity<TView>(this TView view, float value) where TView : XamlDrawnLabelVisual { view.UI.Opacity = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Padding"/></summary>
        public static TView Padding<TView>(this TView view, LiveCharts.Drawing.Padding value) where TView : XamlDrawnLabelVisual { view.UI.Padding = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Paint"/></summary>
        public static TView Paint<TView>(this TView view, LiveCharts.Painting.Paint? value) where TView : XamlDrawnLabelVisual { view.UI.Paint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.PointerDownCommand"/></summary>
        public static TView PointerDownCommand<TView>(this TView view, ICommand? value) where TView : XamlDrawnLabelVisual { view.UI.PointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.PropertyChangedCommand"/></summary>
        public static TView PropertyChangedCommand<TView>(this TView view, ICommand? value) where TView : XamlDrawnLabelVisual { view.UI.PropertyChangedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.RemoveOnCompleted"/></summary>
        public static TView RemoveOnCompleted<TView>(this TView view, bool value) where TView : XamlDrawnLabelVisual { view.UI.RemoveOnCompleted = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.RotateTransform"/></summary>
        public static TView RotateTransform<TView>(this TView view, float value) where TView : XamlDrawnLabelVisual { view.UI.RotateTransform = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.ScaleTransform"/></summary>
        public static TView ScaleTransform<TView>(this TView view, LiveCharts.Drawing.LvcPoint value) where TView : XamlDrawnLabelVisual { view.UI.ScaleTransform = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.SkewTransform"/></summary>
        public static TView SkewTransform<TView>(this TView view, LiveCharts.Drawing.LvcPoint value) where TView : XamlDrawnLabelVisual { view.UI.SkewTransform = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Tag"/></summary>
        public static TView Tag<TView>(this TView view, object? value) where TView : XamlDrawnLabelVisual { view.UI.Tag = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Text"/></summary>
        public static TView Text<TView>(this TView view, string value) where TView : XamlDrawnLabelVisual { view.UI.Text = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TextSize"/></summary>
        public static TView TextSize<TView>(this TView view, float value) where TView : XamlDrawnLabelVisual { view.UI.TextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TransformOrigin"/></summary>
        public static TView TransformOrigin<TView>(this TView view, LiveCharts.Drawing.LvcPoint value) where TView : XamlDrawnLabelVisual { view.UI.TransformOrigin = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TranslateTransform"/></summary>
        public static TView TranslateTransform<TView>(this TView view, LiveCharts.Drawing.LvcPoint value) where TView : XamlDrawnLabelVisual { view.UI.TranslateTransform = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.VerticalAlign"/></summary>
        public static TView VerticalAlign<TView>(this TView view, LiveCharts.Drawing.Align value) where TView : XamlDrawnLabelVisual { view.UI.VerticalAlign = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.X"/></summary>
        public static TView X<TView>(this TView view, float value) where TView : XamlDrawnLabelVisual { view.UI.X = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Y"/></summary>
        public static TView Y<TView>(this TView view, float value) where TView : XamlDrawnLabelVisual { view.UI.Y = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.AnimationSpeed"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan> AnimationSpeed<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.AnimationSpeedProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Background"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.LvcColor> Background<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Drawing.LvcColor>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.BackgroundProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.ClippingBounds"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.LvcRectangle> ClippingBounds<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Drawing.LvcRectangle>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.ClippingBoundsProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.DropShadow"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.LvcDropShadow?> DropShadow<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Drawing.LvcDropShadow?>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.DropShadowProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Easing"/></summary>
        public static DependencyProperty<TTarget, Func<float, float>?> Easing<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, Func<float, float>?>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.EasingProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.HasTransform"/></summary>
        public static DependencyProperty<TTarget, bool> HasTransform<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.HasTransformProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.HorizontalAlign"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.Align> HorizontalAlign<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Drawing.Align>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.HorizontalAlignProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.IsValid"/></summary>
        public static DependencyProperty<TTarget, bool> IsValid<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.IsValidProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.IsVisible"/></summary>
        public static DependencyProperty<TTarget, bool> IsVisible<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.IsVisibleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.MaxWidth"/></summary>
        public static DependencyProperty<TTarget, float> MaxWidth<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, float>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.MaxWidthProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Opacity"/></summary>
        public static DependencyProperty<TTarget, float> Opacity<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, float>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.OpacityProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Padding"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.Padding> Padding<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Drawing.Padding>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.PaddingProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Paint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint?> Paint<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint?>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.PaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.PointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerDownCommand<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.PointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.PropertyChangedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PropertyChangedCommand<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.PropertyChangedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.RemoveOnCompleted"/></summary>
        public static DependencyProperty<TTarget, bool> RemoveOnCompleted<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.RemoveOnCompletedProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.RotateTransform"/></summary>
        public static DependencyProperty<TTarget, float> RotateTransform<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, float>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.RotateTransformProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.ScaleTransform"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint> ScaleTransform<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.ScaleTransformProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.SkewTransform"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint> SkewTransform<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.SkewTransformProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Tag"/></summary>
        public static DependencyProperty<TTarget, object?> Tag<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, object?>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TagProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Text"/></summary>
        public static DependencyProperty<TTarget, string> Text<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, string>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TextProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TextSize"/></summary>
        public static DependencyProperty<TTarget, float> TextSize<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, float>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TransformOrigin"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint> TransformOrigin<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TransformOriginProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TranslateTransform"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint> TranslateTransform<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.TranslateTransformProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.VerticalAlign"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.Align> VerticalAlign<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, LiveCharts.Drawing.Align>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.VerticalAlignProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.X"/></summary>
        public static DependencyProperty<TTarget, float> X<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, float>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.XProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlDrawnLabelVisual.Y"/></summary>
        public static DependencyProperty<TTarget, float> Y<TTarget>(this TTarget target) where TTarget : XamlDrawnLabelVisual
        => DependencyProperty<TTarget, float>.Get(target, LiveChartsSkiaWinUI.XamlDrawnLabelVisual.YProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlGaugeBackgroundSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlGaugeBackgroundSeries"/></summary>
        public static XamlGaugeBackgroundSeries XamlGaugeBackgroundSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlGaugeBackgroundSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlGaugeBackgroundSeries.StartChain(ui);
        }
    }

    public partial class XamlGaugeBackgroundSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlGaugeBackgroundSeries>
    {
        static XamlGaugeBackgroundSeries instance;

        internal static XamlGaugeBackgroundSeries StartChain(LiveChartsSkiaWinUI.XamlGaugeBackgroundSeries ui)
        {
            if (instance == null) instance = new XamlGaugeBackgroundSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlGaugeBackgroundSeries ui;

        public new LiveChartsSkiaWinUI.XamlGaugeBackgroundSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlGaugeBackgroundSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlGaugeBackgroundSeries(XamlGaugeBackgroundSeries view) => view?.UI;

        public static implicit operator XamlGaugeBackgroundSeries(LiveChartsSkiaWinUI.XamlGaugeBackgroundSeries ui) => XamlGaugeBackgroundSeries.StartChain(ui);

        public XamlGaugeBackgroundSeries Invoke(Action<LiveChartsSkiaWinUI.XamlGaugeBackgroundSeries> action) { action?.Invoke(UI); return this; }

        protected XamlGaugeBackgroundSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlGaugeSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlGaugeSeries"/></summary>
        public static XamlGaugeSeries XamlGaugeSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlGaugeSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlGaugeSeries.StartChain(ui);
        }
    }

    public partial class XamlGaugeSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlGaugeSeries>
    {
        static XamlGaugeSeries instance;

        internal static XamlGaugeSeries StartChain(LiveChartsSkiaWinUI.XamlGaugeSeries ui)
        {
            if (instance == null) instance = new XamlGaugeSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlGaugeSeries ui;

        public new LiveChartsSkiaWinUI.XamlGaugeSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlGaugeSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlGaugeSeries(XamlGaugeSeries view) => view?.UI;

        public static implicit operator XamlGaugeSeries(LiveChartsSkiaWinUI.XamlGaugeSeries ui) => XamlGaugeSeries.StartChain(ui);

        public XamlGaugeSeries Invoke(Action<LiveChartsSkiaWinUI.XamlGaugeSeries> action) { action?.Invoke(UI); return this; }

        protected XamlGaugeSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlHeatSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlHeatSeries"/></summary>
        public static XamlHeatSeries XamlHeatSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlHeatSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlHeatSeries.StartChain(ui);
        }
    }

    public partial class XamlHeatSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlHeatSeries>
    {
        static XamlHeatSeries instance;

        internal static XamlHeatSeries StartChain(LiveChartsSkiaWinUI.XamlHeatSeries ui)
        {
            if (instance == null) instance = new XamlHeatSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlHeatSeries ui;

        public new LiveChartsSkiaWinUI.XamlHeatSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlHeatSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlHeatSeries(XamlHeatSeries view) => view?.UI;

        public static implicit operator XamlHeatSeries(LiveChartsSkiaWinUI.XamlHeatSeries ui) => XamlHeatSeries.StartChain(ui);

        public XamlHeatSeries Invoke(Action<LiveChartsSkiaWinUI.XamlHeatSeries> action) { action?.Invoke(UI); return this; }

        protected XamlHeatSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlLineSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlLineSeries"/></summary>
        public static XamlLineSeries XamlLineSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlLineSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlLineSeries.StartChain(ui);
        }
    }

    public partial class XamlLineSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlLineSeries>
    {
        static XamlLineSeries instance;

        internal static XamlLineSeries StartChain(LiveChartsSkiaWinUI.XamlLineSeries ui)
        {
            if (instance == null) instance = new XamlLineSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlLineSeries ui;

        public new LiveChartsSkiaWinUI.XamlLineSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlLineSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlLineSeries(XamlLineSeries view) => view?.UI;

        public static implicit operator XamlLineSeries(LiveChartsSkiaWinUI.XamlLineSeries ui) => XamlLineSeries.StartChain(ui);

        public XamlLineSeries Invoke(Action<LiveChartsSkiaWinUI.XamlLineSeries> action) { action?.Invoke(UI); return this; }

        protected XamlLineSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlLogarithmicAxis
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlLogarithmicAxis"/></summary>
        public static XamlLogarithmicAxis XamlLogarithmicAxis(double? LogBase = default)
        {
            var ui = new LiveChartsSkiaWinUI.XamlLogarithmicAxis();
            if (LogBase is not null) ui.LogBase = LogBase.Value;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlLogarithmicAxis.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlLogarithmicAxis"/></summary>
        public static XamlLogarithmicAxis XamlLogarithmicAxis()
        {
            var ui = new LiveChartsSkiaWinUI.XamlLogarithmicAxis();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlLogarithmicAxis.StartChain(ui);
        }
    }

    public partial class XamlLogarithmicAxis : FrameworkElement, IUI<LiveChartsSkiaWinUI.XamlLogarithmicAxis>
    {
        static XamlLogarithmicAxis instance;

        internal static XamlLogarithmicAxis StartChain(LiveChartsSkiaWinUI.XamlLogarithmicAxis ui)
        {
            if (instance == null) instance = new XamlLogarithmicAxis();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlLogarithmicAxis ui;

        public new LiveChartsSkiaWinUI.XamlLogarithmicAxis UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlLogarithmicAxis view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlLogarithmicAxis(XamlLogarithmicAxis view) => view?.UI;

        public static implicit operator XamlLogarithmicAxis(LiveChartsSkiaWinUI.XamlLogarithmicAxis ui) => XamlLogarithmicAxis.StartChain(ui);

        public XamlLogarithmicAxis Invoke(Action<LiveChartsSkiaWinUI.XamlLogarithmicAxis> action) { action?.Invoke(UI); return this; }

        protected XamlLogarithmicAxis() { }
    }

    public static partial class XamlLogarithmicAxisExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlLogarithmicAxis.LogBase"/></summary>
        public static TView LogBase<TView>(this TView view, double value) where TView : XamlLogarithmicAxis { view.UI.LogBase = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlLogarithmicAxis.LogBase"/></summary>
        public static DependencyProperty<TTarget, double> LogBase<TTarget>(this TTarget target) where TTarget : XamlLogarithmicAxis
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlLogarithmicAxis.LogBaseProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlNeedle
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlNeedle"/></summary>
        public static XamlNeedle XamlNeedle(LiveCharts.Painting.Paint? Fill = default, bool? IsVisible = default, LiveCharts.Measure.MeasureUnit? LocationUnit = default, ICommand? PointerDownCommand = default, ICommand? PropertyChangedCommand = default, double? Rotation = default, int? ScalesXAt = default, int? ScalesYAt = default, object? Tag = default, LiveCharts.Drawing.LvcPoint? Translate = default, double? Value = default, double? Width = default, double? X = default, double? Y = default)
        {
            var ui = new LiveChartsSkiaWinUI.XamlNeedle();
            if (Fill is not null) ui.Fill = Fill;
            if (IsVisible is not null) ui.IsVisible = IsVisible.Value;
            if (LocationUnit is not null) ui.LocationUnit = LocationUnit.Value;
            if (PointerDownCommand is not null) ui.PointerDownCommand = PointerDownCommand;
            if (PropertyChangedCommand is not null) ui.PropertyChangedCommand = PropertyChangedCommand;
            if (Rotation is not null) ui.Rotation = Rotation.Value;
            if (ScalesXAt is not null) ui.ScalesXAt = ScalesXAt.Value;
            if (ScalesYAt is not null) ui.ScalesYAt = ScalesYAt.Value;
            if (Tag is not null) ui.Tag = Tag;
            if (Translate is not null) ui.Translate = Translate.Value;
            if (Value is not null) ui.Value = Value.Value;
            if (Width is not null) ui.Width = Width.Value;
            if (X is not null) ui.X = X.Value;
            if (Y is not null) ui.Y = Y.Value;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlNeedle.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlNeedle"/></summary>
        public static XamlNeedle XamlNeedle()
        {
            var ui = new LiveChartsSkiaWinUI.XamlNeedle();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlNeedle.StartChain(ui);
        }
    }

    public partial class XamlNeedle : FrameworkElement, IUI<LiveChartsSkiaWinUI.XamlNeedle>
    {
        static XamlNeedle instance;

        internal static XamlNeedle StartChain(LiveChartsSkiaWinUI.XamlNeedle ui)
        {
            if (instance == null) instance = new XamlNeedle();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlNeedle ui;

        public new LiveChartsSkiaWinUI.XamlNeedle UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlNeedle view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlNeedle(XamlNeedle view) => view?.UI;

        public static implicit operator XamlNeedle(LiveChartsSkiaWinUI.XamlNeedle ui) => XamlNeedle.StartChain(ui);

        public XamlNeedle Invoke(Action<LiveChartsSkiaWinUI.XamlNeedle> action) { action?.Invoke(UI); return this; }

        protected XamlNeedle() { }
    }

    public static partial class XamlNeedleExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.Fill"/></summary>
        public static TView Fill<TView>(this TView view, LiveCharts.Painting.Paint? value) where TView : XamlNeedle { view.UI.Fill = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.IsVisible"/></summary>
        public static TView IsVisible<TView>(this TView view, bool value) where TView : XamlNeedle { view.UI.IsVisible = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.LocationUnit"/></summary>
        public static TView LocationUnit<TView>(this TView view, LiveCharts.Measure.MeasureUnit value) where TView : XamlNeedle { view.UI.LocationUnit = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.PointerDownCommand"/></summary>
        public static TView PointerDownCommand<TView>(this TView view, ICommand? value) where TView : XamlNeedle { view.UI.PointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.PropertyChangedCommand"/></summary>
        public static TView PropertyChangedCommand<TView>(this TView view, ICommand? value) where TView : XamlNeedle { view.UI.PropertyChangedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.Rotation"/></summary>
        public static TView Rotation<TView>(this TView view, double value) where TView : XamlNeedle { view.UI.Rotation = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.ScalesXAt"/></summary>
        public static TView ScalesXAt<TView>(this TView view, int value) where TView : XamlNeedle { view.UI.ScalesXAt = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.ScalesYAt"/></summary>
        public static TView ScalesYAt<TView>(this TView view, int value) where TView : XamlNeedle { view.UI.ScalesYAt = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.Tag"/></summary>
        public static TView Tag<TView>(this TView view, object? value) where TView : XamlNeedle { view.UI.Tag = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.Translate"/></summary>
        public static TView Translate<TView>(this TView view, LiveCharts.Drawing.LvcPoint value) where TView : XamlNeedle { view.UI.Translate = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.Value"/></summary>
        public static TView Value<TView>(this TView view, double value) where TView : XamlNeedle { view.UI.Value = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.Width"/></summary>
        public static TView Width<TView>(this TView view, double value) where TView : XamlNeedle { view.UI.Width = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.X"/></summary>
        public static TView X<TView>(this TView view, double value) where TView : XamlNeedle { view.UI.X = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlNeedle.Y"/></summary>
        public static TView Y<TView>(this TView view, double value) where TView : XamlNeedle { view.UI.Y = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.Fill"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint?> Fill<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint?>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.FillProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.IsVisible"/></summary>
        public static DependencyProperty<TTarget, bool> IsVisible<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.IsVisibleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.LocationUnit"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.MeasureUnit> LocationUnit<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, LiveCharts.Measure.MeasureUnit>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.LocationUnitProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.PointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PointerDownCommand<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.PointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.PropertyChangedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PropertyChangedCommand<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.PropertyChangedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.Rotation"/></summary>
        public static DependencyProperty<TTarget, double> Rotation<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.RotationProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.ScalesXAt"/></summary>
        public static DependencyProperty<TTarget, int> ScalesXAt<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, int>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.ScalesXAtProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.ScalesYAt"/></summary>
        public static DependencyProperty<TTarget, int> ScalesYAt<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, int>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.ScalesYAtProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.Tag"/></summary>
        public static DependencyProperty<TTarget, object?> Tag<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, object?>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.TagProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.Translate"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint> Translate<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, LiveCharts.Drawing.LvcPoint>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.TranslateProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.Value"/></summary>
        public static DependencyProperty<TTarget, double> Value<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.ValueProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.Width"/></summary>
        public static DependencyProperty<TTarget, double> Width<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.WidthProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.X"/></summary>
        public static DependencyProperty<TTarget, double> X<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.XProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlNeedle.Y"/></summary>
        public static DependencyProperty<TTarget, double> Y<TTarget>(this TTarget target) where TTarget : XamlNeedle
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlNeedle.YProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlPieSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlPieSeries"/></summary>
        public static XamlPieSeries XamlPieSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlPieSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlPieSeries.StartChain(ui);
        }
    }

    public partial class XamlPieSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlPieSeries>
    {
        static XamlPieSeries instance;

        internal static XamlPieSeries StartChain(LiveChartsSkiaWinUI.XamlPieSeries ui)
        {
            if (instance == null) instance = new XamlPieSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlPieSeries ui;

        public new LiveChartsSkiaWinUI.XamlPieSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlPieSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlPieSeries(XamlPieSeries view) => view?.UI;

        public static implicit operator XamlPieSeries(LiveChartsSkiaWinUI.XamlPieSeries ui) => XamlPieSeries.StartChain(ui);

        public XamlPieSeries Invoke(Action<LiveChartsSkiaWinUI.XamlPieSeries> action) { action?.Invoke(UI); return this; }

        protected XamlPieSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlPolarAxis
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlPolarAxis"/></summary>
        public static XamlPolarAxis XamlPolarAxis(CSharpMarkup.WinUI.to.TimeSpan? AnimationsSpeed = default, IEnumerable<double>? CustomSeparators = default, Func<float, float>? EasingFunction = default, bool? ForceStepToMin = default, ICommand? InitializedCommand = default, bool? IsInverted = default, bool? IsVisible = default, Func<double, string> Labeler = default, IList<string>? Labels = default, double? LabelsAngle = default, LiveCharts.Drawing.LvcColor? LabelsBackground = default, LiveCharts.Drawing.Align? LabelsHorizontalAlignment = default, LiveCharts.Drawing.Padding LabelsPadding = default, LiveCharts.Painting.Paint? LabelsPaint = default, double? LabelsRotation = default, LiveCharts.Drawing.Align? LabelsVerticalAlignment = default, double? MaxLimit = default, double? MinLimit = default, double? MinStep = default, LiveCharts.Drawing.Padding NamePadding = default, LiveCharts.Painting.Paint? NamePaint = default, double? NameTextSize = default, string? PolarAxisName = default, ICommand? PropertyChangedCommand = default, LiveCharts.Painting.Paint? SeparatorsPaint = default, bool? ShowSeparatorLines = default, object? Tag = default, double? TextSize = default, double? UnitWidth = default)
        {
            var ui = new LiveChartsSkiaWinUI.XamlPolarAxis();
            if (AnimationsSpeed is not null) ui.AnimationsSpeed = AnimationsSpeed.Value;
            if (CustomSeparators is not null) ui.CustomSeparators = CustomSeparators;
            if (EasingFunction is not null) ui.EasingFunction = EasingFunction;
            if (ForceStepToMin is not null) ui.ForceStepToMin = ForceStepToMin.Value;
            if (InitializedCommand is not null) ui.InitializedCommand = InitializedCommand;
            if (IsInverted is not null) ui.IsInverted = IsInverted.Value;
            if (IsVisible is not null) ui.IsVisible = IsVisible.Value;
            if (Labeler is not null) ui.Labeler = Labeler;
            if (Labels is not null) ui.Labels = Labels;
            if (LabelsAngle is not null) ui.LabelsAngle = LabelsAngle.Value;
            if (LabelsBackground is not null) ui.LabelsBackground = LabelsBackground.Value;
            if (LabelsHorizontalAlignment is not null) ui.LabelsHorizontalAlignment = LabelsHorizontalAlignment.Value;
            if (LabelsPadding is not null) ui.LabelsPadding = LabelsPadding;
            if (LabelsPaint is not null) ui.LabelsPaint = LabelsPaint;
            if (LabelsRotation is not null) ui.LabelsRotation = LabelsRotation.Value;
            if (LabelsVerticalAlignment is not null) ui.LabelsVerticalAlignment = LabelsVerticalAlignment.Value;
            if (MaxLimit is not null) ui.MaxLimit = MaxLimit.Value;
            if (MinLimit is not null) ui.MinLimit = MinLimit.Value;
            if (MinStep is not null) ui.MinStep = MinStep.Value;
            if (NamePadding is not null) ui.NamePadding = NamePadding;
            if (NamePaint is not null) ui.NamePaint = NamePaint;
            if (NameTextSize is not null) ui.NameTextSize = NameTextSize.Value;
            if (PolarAxisName is not null) ui.PolarAxisName = PolarAxisName;
            if (PropertyChangedCommand is not null) ui.PropertyChangedCommand = PropertyChangedCommand;
            if (SeparatorsPaint is not null) ui.SeparatorsPaint = SeparatorsPaint;
            if (ShowSeparatorLines is not null) ui.ShowSeparatorLines = ShowSeparatorLines.Value;
            if (Tag is not null) ui.Tag = Tag;
            if (TextSize is not null) ui.TextSize = TextSize.Value;
            if (UnitWidth is not null) ui.UnitWidth = UnitWidth.Value;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlPolarAxis.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlPolarAxis"/></summary>
        public static XamlPolarAxis XamlPolarAxis()
        {
            var ui = new LiveChartsSkiaWinUI.XamlPolarAxis();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlPolarAxis.StartChain(ui);
        }
    }

    public partial class XamlPolarAxis : FrameworkElement, IUI<LiveChartsSkiaWinUI.XamlPolarAxis>
    {
        static XamlPolarAxis instance;

        internal static XamlPolarAxis StartChain(LiveChartsSkiaWinUI.XamlPolarAxis ui)
        {
            if (instance == null) instance = new XamlPolarAxis();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlPolarAxis ui;

        public new LiveChartsSkiaWinUI.XamlPolarAxis UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlPolarAxis view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlPolarAxis(XamlPolarAxis view) => view?.UI;

        public static implicit operator XamlPolarAxis(LiveChartsSkiaWinUI.XamlPolarAxis ui) => XamlPolarAxis.StartChain(ui);

        public XamlPolarAxis Invoke(Action<LiveChartsSkiaWinUI.XamlPolarAxis> action) { action?.Invoke(UI); return this; }

        protected XamlPolarAxis() { }
    }

    public static partial class XamlPolarAxisExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.AnimationsSpeed"/></summary>
        public static TView AnimationsSpeed<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : XamlPolarAxis { view.UI.AnimationsSpeed = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.CustomSeparators"/></summary>
        public static TView CustomSeparators<TView>(this TView view, IEnumerable<double>? value) where TView : XamlPolarAxis { view.UI.CustomSeparators = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.EasingFunction"/></summary>
        public static TView EasingFunction<TView>(this TView view, Func<float, float>? value) where TView : XamlPolarAxis { view.UI.EasingFunction = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.ForceStepToMin"/></summary>
        public static TView ForceStepToMin<TView>(this TView view, bool value) where TView : XamlPolarAxis { view.UI.ForceStepToMin = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.InitializedCommand"/></summary>
        public static TView InitializedCommand<TView>(this TView view, ICommand? value) where TView : XamlPolarAxis { view.UI.InitializedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.IsInverted"/></summary>
        public static TView IsInverted<TView>(this TView view, bool value) where TView : XamlPolarAxis { view.UI.IsInverted = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.IsVisible"/></summary>
        public static TView IsVisible<TView>(this TView view, bool value) where TView : XamlPolarAxis { view.UI.IsVisible = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.Labeler"/></summary>
        public static TView Labeler<TView>(this TView view, Func<double, string> value) where TView : XamlPolarAxis { view.UI.Labeler = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.Labels"/></summary>
        public static TView Labels<TView>(this TView view, IList<string>? value) where TView : XamlPolarAxis { view.UI.Labels = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsAngle"/></summary>
        public static TView LabelsAngle<TView>(this TView view, double value) where TView : XamlPolarAxis { view.UI.LabelsAngle = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsBackground"/></summary>
        public static TView LabelsBackground<TView>(this TView view, LiveCharts.Drawing.LvcColor value) where TView : XamlPolarAxis { view.UI.LabelsBackground = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsHorizontalAlignment"/></summary>
        public static TView LabelsHorizontalAlignment<TView>(this TView view, LiveCharts.Drawing.Align value) where TView : XamlPolarAxis { view.UI.LabelsHorizontalAlignment = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsPadding"/></summary>
        public static TView LabelsPadding<TView>(this TView view, LiveCharts.Drawing.Padding value) where TView : XamlPolarAxis { view.UI.LabelsPadding = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsPaint"/></summary>
        public static TView LabelsPaint<TView>(this TView view, LiveCharts.Painting.Paint? value) where TView : XamlPolarAxis { view.UI.LabelsPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsRotation"/></summary>
        public static TView LabelsRotation<TView>(this TView view, double value) where TView : XamlPolarAxis { view.UI.LabelsRotation = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsVerticalAlignment"/></summary>
        public static TView LabelsVerticalAlignment<TView>(this TView view, LiveCharts.Drawing.Align value) where TView : XamlPolarAxis { view.UI.LabelsVerticalAlignment = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.MaxLimit"/></summary>
        public static TView MaxLimit<TView>(this TView view, double? value) where TView : XamlPolarAxis { view.UI.MaxLimit = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.MinLimit"/></summary>
        public static TView MinLimit<TView>(this TView view, double? value) where TView : XamlPolarAxis { view.UI.MinLimit = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.MinStep"/></summary>
        public static TView MinStep<TView>(this TView view, double value) where TView : XamlPolarAxis { view.UI.MinStep = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.NamePadding"/></summary>
        public static TView NamePadding<TView>(this TView view, LiveCharts.Drawing.Padding value) where TView : XamlPolarAxis { view.UI.NamePadding = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.NamePaint"/></summary>
        public static TView NamePaint<TView>(this TView view, LiveCharts.Painting.Paint? value) where TView : XamlPolarAxis { view.UI.NamePaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.NameTextSize"/></summary>
        public static TView NameTextSize<TView>(this TView view, double value) where TView : XamlPolarAxis { view.UI.NameTextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.PolarAxisName"/></summary>
        public static TView PolarAxisName<TView>(this TView view, string? value) where TView : XamlPolarAxis { view.UI.PolarAxisName = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.PropertyChangedCommand"/></summary>
        public static TView PropertyChangedCommand<TView>(this TView view, ICommand? value) where TView : XamlPolarAxis { view.UI.PropertyChangedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.SeparatorsPaint"/></summary>
        public static TView SeparatorsPaint<TView>(this TView view, LiveCharts.Painting.Paint? value) where TView : XamlPolarAxis { view.UI.SeparatorsPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.ShowSeparatorLines"/></summary>
        public static TView ShowSeparatorLines<TView>(this TView view, bool value) where TView : XamlPolarAxis { view.UI.ShowSeparatorLines = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.Tag"/></summary>
        public static TView Tag<TView>(this TView view, object? value) where TView : XamlPolarAxis { view.UI.Tag = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.TextSize"/></summary>
        public static TView TextSize<TView>(this TView view, double value) where TView : XamlPolarAxis { view.UI.TextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.UnitWidth"/></summary>
        public static TView UnitWidth<TView>(this TView view, double value) where TView : XamlPolarAxis { view.UI.UnitWidth = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.AnimationsSpeed"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan> AnimationsSpeed<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.AnimationsSpeedProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.CustomSeparators"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<double>?> CustomSeparators<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, IEnumerable<double>?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.CustomSeparatorsProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.EasingFunction"/></summary>
        public static DependencyProperty<TTarget, Func<float, float>?> EasingFunction<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, Func<float, float>?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.EasingFunctionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.ForceStepToMin"/></summary>
        public static DependencyProperty<TTarget, bool> ForceStepToMin<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.ForceStepToMinProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.InitializedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> InitializedCommand<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.InitializedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.IsInverted"/></summary>
        public static DependencyProperty<TTarget, bool> IsInverted<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.IsInvertedProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.IsVisible"/></summary>
        public static DependencyProperty<TTarget, bool> IsVisible<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.IsVisibleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.Labeler"/></summary>
        public static DependencyProperty<TTarget, Func<double, string>> Labeler<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, Func<double, string>>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.LabelerProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsAngle"/></summary>
        public static DependencyProperty<TTarget, double> LabelsAngle<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.LabelsAngleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsBackground"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.LvcColor> LabelsBackground<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, LiveCharts.Drawing.LvcColor>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.LabelsBackgroundProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsHorizontalAlignment"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.Align> LabelsHorizontalAlignment<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, LiveCharts.Drawing.Align>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.LabelsHorizontalAlignmentProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsPadding"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.Padding> LabelsPadding<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, LiveCharts.Drawing.Padding>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.LabelsPaddingProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint?> LabelsPaint<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.LabelsPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.Labels"/></summary>
        public static DependencyProperty<TTarget, IList<string>?> Labels<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, IList<string>?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.LabelsProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsRotation"/></summary>
        public static DependencyProperty<TTarget, double> LabelsRotation<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.LabelsRotationProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.LabelsVerticalAlignment"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.Align> LabelsVerticalAlignment<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, LiveCharts.Drawing.Align>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.LabelsVerticalAlignmentProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.MaxLimit"/></summary>
        public static DependencyProperty<TTarget, double?> MaxLimit<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.MaxLimitProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.MinLimit"/></summary>
        public static DependencyProperty<TTarget, double?> MinLimit<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.MinLimitProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.MinStep"/></summary>
        public static DependencyProperty<TTarget, double> MinStep<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.MinStepProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.NamePadding"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Drawing.Padding> NamePadding<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, LiveCharts.Drawing.Padding>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.NamePaddingProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.NamePaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint?> NamePaint<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.NamePaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.NameTextSize"/></summary>
        public static DependencyProperty<TTarget, double> NameTextSize<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.NameTextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.PolarAxisName"/></summary>
        public static DependencyProperty<TTarget, string?> PolarAxisName<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, string?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.PolarAxisNameProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.PropertyChangedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PropertyChangedCommand<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.PropertyChangedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.SeparatorsPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint?> SeparatorsPaint<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.SeparatorsPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.ShowSeparatorLines"/></summary>
        public static DependencyProperty<TTarget, bool> ShowSeparatorLines<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.ShowSeparatorLinesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.Tag"/></summary>
        public static DependencyProperty<TTarget, object?> Tag<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, object?>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.TagProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.TextSize"/></summary>
        public static DependencyProperty<TTarget, double> TextSize<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.TextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlPolarAxis.UnitWidth"/></summary>
        public static DependencyProperty<TTarget, double> UnitWidth<TTarget>(this TTarget target) where TTarget : XamlPolarAxis
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlPolarAxis.UnitWidthProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlPolarLineSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlPolarLineSeries"/></summary>
        public static XamlPolarLineSeries XamlPolarLineSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlPolarLineSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlPolarLineSeries.StartChain(ui);
        }
    }

    public partial class XamlPolarLineSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlPolarLineSeries>
    {
        static XamlPolarLineSeries instance;

        internal static XamlPolarLineSeries StartChain(LiveChartsSkiaWinUI.XamlPolarLineSeries ui)
        {
            if (instance == null) instance = new XamlPolarLineSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlPolarLineSeries ui;

        public new LiveChartsSkiaWinUI.XamlPolarLineSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlPolarLineSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlPolarLineSeries(XamlPolarLineSeries view) => view?.UI;

        public static implicit operator XamlPolarLineSeries(LiveChartsSkiaWinUI.XamlPolarLineSeries ui) => XamlPolarLineSeries.StartChain(ui);

        public XamlPolarLineSeries Invoke(Action<LiveChartsSkiaWinUI.XamlPolarLineSeries> action) { action?.Invoke(UI); return this; }

        protected XamlPolarLineSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlRectangularSection
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlRectangularSection"/></summary>
        public static XamlRectangularSection XamlRectangularSection(LiveCharts.Painting.Paint? Fill = default, bool? IsVisible = default, string Label = default, LiveCharts.Painting.Paint? LabelPaint = default, double? LabelSize = default, ICommand? PropertyChangedCommand = default, int? ScalesXAt = default, int? ScalesYAt = default, LiveCharts.Painting.Paint? Stroke = default, object? Tag = default, double? Xi = default, double? Xj = default, double? Yi = default, double? Yj = default, int? ZIndex = default)
        {
            var ui = new LiveChartsSkiaWinUI.XamlRectangularSection();
            if (Fill is not null) ui.Fill = Fill;
            if (IsVisible is not null) ui.IsVisible = IsVisible.Value;
            if (Label is not null) ui.Label = Label;
            if (LabelPaint is not null) ui.LabelPaint = LabelPaint;
            if (LabelSize is not null) ui.LabelSize = LabelSize.Value;
            if (PropertyChangedCommand is not null) ui.PropertyChangedCommand = PropertyChangedCommand;
            if (ScalesXAt is not null) ui.ScalesXAt = ScalesXAt.Value;
            if (ScalesYAt is not null) ui.ScalesYAt = ScalesYAt.Value;
            if (Stroke is not null) ui.Stroke = Stroke;
            if (Tag is not null) ui.Tag = Tag;
            if (Xi is not null) ui.Xi = Xi.Value;
            if (Xj is not null) ui.Xj = Xj.Value;
            if (Yi is not null) ui.Yi = Yi.Value;
            if (Yj is not null) ui.Yj = Yj.Value;
            if (ZIndex is not null) ui.ZIndex = ZIndex.Value;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlRectangularSection.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlRectangularSection"/></summary>
        public static XamlRectangularSection XamlRectangularSection()
        {
            var ui = new LiveChartsSkiaWinUI.XamlRectangularSection();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlRectangularSection.StartChain(ui);
        }
    }

    public partial class XamlRectangularSection : FrameworkElement, IUI<LiveChartsSkiaWinUI.XamlRectangularSection>
    {
        static XamlRectangularSection instance;

        internal static XamlRectangularSection StartChain(LiveChartsSkiaWinUI.XamlRectangularSection ui)
        {
            if (instance == null) instance = new XamlRectangularSection();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlRectangularSection ui;

        public new LiveChartsSkiaWinUI.XamlRectangularSection UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlRectangularSection view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlRectangularSection(XamlRectangularSection view) => view?.UI;

        public static implicit operator XamlRectangularSection(LiveChartsSkiaWinUI.XamlRectangularSection ui) => XamlRectangularSection.StartChain(ui);

        public XamlRectangularSection Invoke(Action<LiveChartsSkiaWinUI.XamlRectangularSection> action) { action?.Invoke(UI); return this; }

        protected XamlRectangularSection() { }
    }

    public static partial class XamlRectangularSectionExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Fill"/></summary>
        public static TView Fill<TView>(this TView view, LiveCharts.Painting.Paint? value) where TView : XamlRectangularSection { view.UI.Fill = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.IsVisible"/></summary>
        public static TView IsVisible<TView>(this TView view, bool value) where TView : XamlRectangularSection { view.UI.IsVisible = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Label"/></summary>
        public static TView Label<TView>(this TView view, string value) where TView : XamlRectangularSection { view.UI.Label = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.LabelPaint"/></summary>
        public static TView LabelPaint<TView>(this TView view, LiveCharts.Painting.Paint? value) where TView : XamlRectangularSection { view.UI.LabelPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.LabelSize"/></summary>
        public static TView LabelSize<TView>(this TView view, double value) where TView : XamlRectangularSection { view.UI.LabelSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.PropertyChangedCommand"/></summary>
        public static TView PropertyChangedCommand<TView>(this TView view, ICommand? value) where TView : XamlRectangularSection { view.UI.PropertyChangedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.ScalesXAt"/></summary>
        public static TView ScalesXAt<TView>(this TView view, int value) where TView : XamlRectangularSection { view.UI.ScalesXAt = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.ScalesYAt"/></summary>
        public static TView ScalesYAt<TView>(this TView view, int value) where TView : XamlRectangularSection { view.UI.ScalesYAt = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Stroke"/></summary>
        public static TView Stroke<TView>(this TView view, LiveCharts.Painting.Paint? value) where TView : XamlRectangularSection { view.UI.Stroke = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Tag"/></summary>
        public static TView Tag<TView>(this TView view, object? value) where TView : XamlRectangularSection { view.UI.Tag = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Xi"/></summary>
        public static TView Xi<TView>(this TView view, double? value) where TView : XamlRectangularSection { view.UI.Xi = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Xj"/></summary>
        public static TView Xj<TView>(this TView view, double? value) where TView : XamlRectangularSection { view.UI.Xj = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Yi"/></summary>
        public static TView Yi<TView>(this TView view, double? value) where TView : XamlRectangularSection { view.UI.Yi = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Yj"/></summary>
        public static TView Yj<TView>(this TView view, double? value) where TView : XamlRectangularSection { view.UI.Yj = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.ZIndex"/></summary>
        public static TView ZIndex<TView>(this TView view, int? value) where TView : XamlRectangularSection { view.UI.ZIndex = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Fill"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint?> Fill<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint?>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.FillProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.IsVisible"/></summary>
        public static DependencyProperty<TTarget, bool> IsVisible<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.IsVisibleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.LabelPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint?> LabelPaint<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint?>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.LabelPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Label"/></summary>
        public static DependencyProperty<TTarget, string> Label<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, string>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.LabelProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.LabelSize"/></summary>
        public static DependencyProperty<TTarget, double> LabelSize<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.LabelSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.PropertyChangedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand?> PropertyChangedCommand<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, ICommand?>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.PropertyChangedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.ScalesXAt"/></summary>
        public static DependencyProperty<TTarget, int> ScalesXAt<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, int>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.ScalesXAtProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.ScalesYAt"/></summary>
        public static DependencyProperty<TTarget, int> ScalesYAt<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, int>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.ScalesYAtProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Stroke"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint?> Stroke<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint?>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.StrokeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Tag"/></summary>
        public static DependencyProperty<TTarget, object?> Tag<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, object?>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.TagProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Xi"/></summary>
        public static DependencyProperty<TTarget, double?> Xi<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.XiProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Xj"/></summary>
        public static DependencyProperty<TTarget, double?> Xj<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.XjProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Yi"/></summary>
        public static DependencyProperty<TTarget, double?> Yi<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.YiProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.Yj"/></summary>
        public static DependencyProperty<TTarget, double?> Yj<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, double?>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.YjProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlRectangularSection.ZIndex"/></summary>
        public static DependencyProperty<TTarget, int?> ZIndex<TTarget>(this TTarget target) where TTarget : XamlRectangularSection
        => DependencyProperty<TTarget, int?>.Get(target, LiveChartsSkiaWinUI.XamlRectangularSection.ZIndexProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlRowSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlRowSeries"/></summary>
        public static XamlRowSeries XamlRowSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlRowSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlRowSeries.StartChain(ui);
        }
    }

    public partial class XamlRowSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlRowSeries>
    {
        static XamlRowSeries instance;

        internal static XamlRowSeries StartChain(LiveChartsSkiaWinUI.XamlRowSeries ui)
        {
            if (instance == null) instance = new XamlRowSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlRowSeries ui;

        public new LiveChartsSkiaWinUI.XamlRowSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlRowSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlRowSeries(XamlRowSeries view) => view?.UI;

        public static implicit operator XamlRowSeries(LiveChartsSkiaWinUI.XamlRowSeries ui) => XamlRowSeries.StartChain(ui);

        public XamlRowSeries Invoke(Action<LiveChartsSkiaWinUI.XamlRowSeries> action) { action?.Invoke(UI); return this; }

        protected XamlRowSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlScatterSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlScatterSeries"/></summary>
        public static XamlScatterSeries XamlScatterSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlScatterSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlScatterSeries.StartChain(ui);
        }
    }

    public partial class XamlScatterSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlScatterSeries>
    {
        static XamlScatterSeries instance;

        internal static XamlScatterSeries StartChain(LiveChartsSkiaWinUI.XamlScatterSeries ui)
        {
            if (instance == null) instance = new XamlScatterSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlScatterSeries ui;

        public new LiveChartsSkiaWinUI.XamlScatterSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlScatterSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlScatterSeries(XamlScatterSeries view) => view?.UI;

        public static implicit operator XamlScatterSeries(LiveChartsSkiaWinUI.XamlScatterSeries ui) => XamlScatterSeries.StartChain(ui);

        public XamlScatterSeries Invoke(Action<LiveChartsSkiaWinUI.XamlScatterSeries> action) { action?.Invoke(UI); return this; }

        protected XamlScatterSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlSeries
{
    public partial class XamlSeries : FrameworkElement, IUI<LiveChartsSkiaWinUI.XamlSeries>
    {
        LiveChartsSkiaWinUI.XamlSeries ui;

        public new LiveChartsSkiaWinUI.XamlSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public XamlSeries Invoke(Action<LiveChartsSkiaWinUI.XamlSeries> action) { action?.Invoke(UI); return this; }

        protected XamlSeries() { }
    }

    public static partial class XamlSeriesExtensions
    {
        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlSeries.AdditionalVisualStates"/></summary>
        public static DependencyProperty<TTarget, Collections.ObjectModel.ObservableCollection<LiveChartsSkiaWinUI.ChartPointState>> AdditionalVisualStates<TTarget>(this TTarget target) where TTarget : XamlSeries
        => DependencyProperty<TTarget, Collections.ObjectModel.ObservableCollection<LiveChartsSkiaWinUI.ChartPointState>>.Get(target, LiveChartsSkiaWinUI.XamlSeries.AdditionalVisualStatesProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlStackedAreaSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlStackedAreaSeries"/></summary>
        public static XamlStackedAreaSeries XamlStackedAreaSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlStackedAreaSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlStackedAreaSeries.StartChain(ui);
        }
    }

    public partial class XamlStackedAreaSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlStackedAreaSeries>
    {
        static XamlStackedAreaSeries instance;

        internal static XamlStackedAreaSeries StartChain(LiveChartsSkiaWinUI.XamlStackedAreaSeries ui)
        {
            if (instance == null) instance = new XamlStackedAreaSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlStackedAreaSeries ui;

        public new LiveChartsSkiaWinUI.XamlStackedAreaSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlStackedAreaSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlStackedAreaSeries(XamlStackedAreaSeries view) => view?.UI;

        public static implicit operator XamlStackedAreaSeries(LiveChartsSkiaWinUI.XamlStackedAreaSeries ui) => XamlStackedAreaSeries.StartChain(ui);

        public XamlStackedAreaSeries Invoke(Action<LiveChartsSkiaWinUI.XamlStackedAreaSeries> action) { action?.Invoke(UI); return this; }

        protected XamlStackedAreaSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlStackedColumnSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlStackedColumnSeries"/></summary>
        public static XamlStackedColumnSeries XamlStackedColumnSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlStackedColumnSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlStackedColumnSeries.StartChain(ui);
        }
    }

    public partial class XamlStackedColumnSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlStackedColumnSeries>
    {
        static XamlStackedColumnSeries instance;

        internal static XamlStackedColumnSeries StartChain(LiveChartsSkiaWinUI.XamlStackedColumnSeries ui)
        {
            if (instance == null) instance = new XamlStackedColumnSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlStackedColumnSeries ui;

        public new LiveChartsSkiaWinUI.XamlStackedColumnSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlStackedColumnSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlStackedColumnSeries(XamlStackedColumnSeries view) => view?.UI;

        public static implicit operator XamlStackedColumnSeries(LiveChartsSkiaWinUI.XamlStackedColumnSeries ui) => XamlStackedColumnSeries.StartChain(ui);

        public XamlStackedColumnSeries Invoke(Action<LiveChartsSkiaWinUI.XamlStackedColumnSeries> action) { action?.Invoke(UI); return this; }

        protected XamlStackedColumnSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlStackedRowSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlStackedRowSeries"/></summary>
        public static XamlStackedRowSeries XamlStackedRowSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlStackedRowSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlStackedRowSeries.StartChain(ui);
        }
    }

    public partial class XamlStackedRowSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlStackedRowSeries>
    {
        static XamlStackedRowSeries instance;

        internal static XamlStackedRowSeries StartChain(LiveChartsSkiaWinUI.XamlStackedRowSeries ui)
        {
            if (instance == null) instance = new XamlStackedRowSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlStackedRowSeries ui;

        public new LiveChartsSkiaWinUI.XamlStackedRowSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlStackedRowSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlStackedRowSeries(XamlStackedRowSeries view) => view?.UI;

        public static implicit operator XamlStackedRowSeries(LiveChartsSkiaWinUI.XamlStackedRowSeries ui) => XamlStackedRowSeries.StartChain(ui);

        public XamlStackedRowSeries Invoke(Action<LiveChartsSkiaWinUI.XamlStackedRowSeries> action) { action?.Invoke(UI); return this; }

        protected XamlStackedRowSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlStackedStepAreaSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlStackedStepAreaSeries"/></summary>
        public static XamlStackedStepAreaSeries XamlStackedStepAreaSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlStackedStepAreaSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlStackedStepAreaSeries.StartChain(ui);
        }
    }

    public partial class XamlStackedStepAreaSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlStackedStepAreaSeries>
    {
        static XamlStackedStepAreaSeries instance;

        internal static XamlStackedStepAreaSeries StartChain(LiveChartsSkiaWinUI.XamlStackedStepAreaSeries ui)
        {
            if (instance == null) instance = new XamlStackedStepAreaSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlStackedStepAreaSeries ui;

        public new LiveChartsSkiaWinUI.XamlStackedStepAreaSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlStackedStepAreaSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlStackedStepAreaSeries(XamlStackedStepAreaSeries view) => view?.UI;

        public static implicit operator XamlStackedStepAreaSeries(LiveChartsSkiaWinUI.XamlStackedStepAreaSeries ui) => XamlStackedStepAreaSeries.StartChain(ui);

        public XamlStackedStepAreaSeries Invoke(Action<LiveChartsSkiaWinUI.XamlStackedStepAreaSeries> action) { action?.Invoke(UI); return this; }

        protected XamlStackedStepAreaSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlStepLineSeries
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlStepLineSeries"/></summary>
        public static XamlStepLineSeries XamlStepLineSeries()
        {
            var ui = new LiveChartsSkiaWinUI.XamlStepLineSeries();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlStepLineSeries.StartChain(ui);
        }
    }

    public partial class XamlStepLineSeries : XamlSeries, IUI<LiveChartsSkiaWinUI.XamlStepLineSeries>
    {
        static XamlStepLineSeries instance;

        internal static XamlStepLineSeries StartChain(LiveChartsSkiaWinUI.XamlStepLineSeries ui)
        {
            if (instance == null) instance = new XamlStepLineSeries();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlStepLineSeries ui;

        public new LiveChartsSkiaWinUI.XamlStepLineSeries UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlStepLineSeries view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlStepLineSeries(XamlStepLineSeries view) => view?.UI;

        public static implicit operator XamlStepLineSeries(LiveChartsSkiaWinUI.XamlStepLineSeries ui) => XamlStepLineSeries.StartChain(ui);

        public XamlStepLineSeries Invoke(Action<LiveChartsSkiaWinUI.XamlStepLineSeries> action) { action?.Invoke(UI); return this; }

        protected XamlStepLineSeries() { }
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // XamlTimeSpanAxis
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlTimeSpanAxis"/></summary>
        public static XamlTimeSpanAxis XamlTimeSpanAxis(CSharpMarkup.WinUI.to.TimeSpan? Interval = default, Func<TimeSpan, string> TimeFormatter = default)
        {
            var ui = new LiveChartsSkiaWinUI.XamlTimeSpanAxis();
            if (Interval is not null) ui.Interval = Interval.Value;
            if (TimeFormatter is not null) ui.TimeFormatter = TimeFormatter;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlTimeSpanAxis.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsSkiaWinUI.XamlTimeSpanAxis"/></summary>
        public static XamlTimeSpanAxis XamlTimeSpanAxis()
        {
            var ui = new LiveChartsSkiaWinUI.XamlTimeSpanAxis();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.XamlTimeSpanAxis.StartChain(ui);
        }
    }

    public partial class XamlTimeSpanAxis : FrameworkElement, IUI<LiveChartsSkiaWinUI.XamlTimeSpanAxis>
    {
        static XamlTimeSpanAxis instance;

        internal static XamlTimeSpanAxis StartChain(LiveChartsSkiaWinUI.XamlTimeSpanAxis ui)
        {
            if (instance == null) instance = new XamlTimeSpanAxis();
            instance.UI = ui;
            return instance;
        }

        LiveChartsSkiaWinUI.XamlTimeSpanAxis ui;

        public new LiveChartsSkiaWinUI.XamlTimeSpanAxis UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(XamlTimeSpanAxis view) => view?.UI;

        public static implicit operator LiveChartsSkiaWinUI.XamlTimeSpanAxis(XamlTimeSpanAxis view) => view?.UI;

        public static implicit operator XamlTimeSpanAxis(LiveChartsSkiaWinUI.XamlTimeSpanAxis ui) => XamlTimeSpanAxis.StartChain(ui);

        public XamlTimeSpanAxis Invoke(Action<LiveChartsSkiaWinUI.XamlTimeSpanAxis> action) { action?.Invoke(UI); return this; }

        protected XamlTimeSpanAxis() { }
    }

    public static partial class XamlTimeSpanAxisExtensions
    {
        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlTimeSpanAxis.Interval"/></summary>
        public static TView Interval<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : XamlTimeSpanAxis { view.UI.Interval = value; return view; }

        /// <summary>Set <see cref="LiveChartsSkiaWinUI.XamlTimeSpanAxis.TimeFormatter"/></summary>
        public static TView TimeFormatter<TView>(this TView view, Func<TimeSpan, string> value) where TView : XamlTimeSpanAxis { view.UI.TimeFormatter = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlTimeSpanAxis.Interval"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan> Interval<TTarget>(this TTarget target) where TTarget : XamlTimeSpanAxis
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan>.Get(target, LiveChartsSkiaWinUI.XamlTimeSpanAxis.IntervalProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsSkiaWinUI.XamlTimeSpanAxis.TimeFormatter"/></summary>
        public static DependencyProperty<TTarget, Func<TimeSpan, string>> TimeFormatter<TTarget>(this TTarget target) where TTarget : XamlTimeSpanAxis
        => DependencyProperty<TTarget, Func<TimeSpan, string>>.Get(target, LiveChartsSkiaWinUI.XamlTimeSpanAxis.TimeFormatterProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // SourceGenCartesianChart
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart"/></summary>
        public static SourceGenCartesianChart SourceGenCartesianChart(UIObject Content)
        {
            var ui = new LiveChartsGeneratedCode.SourceGenCartesianChart();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.SourceGenCartesianChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart"/></summary>
        public static SourceGenCartesianChart SourceGenCartesianChart(LiveCharts.Kernel.IChartElement DrawMarginFrame = default, LiveCharts.Measure.FindingStrategy? FindingStrategy = default, bool? MatchAxesScreenDataRatio = default, IEnumerable<LiveCharts.Kernel.IChartElement> Sections = default, LiveCharts.Measure.TooltipFindingStrategy? TooltipFindingStrategy = default, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis> XAxes = default, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis> YAxes = default, double? ZoomingSpeed = default, LiveCharts.Measure.ZoomAndPanMode? ZoomMode = default, UIObject Content = default)
        {
            var ui = new LiveChartsGeneratedCode.SourceGenCartesianChart();
            if (DrawMarginFrame is not null) ui.DrawMarginFrame = DrawMarginFrame;
            if (FindingStrategy is not null) ui.FindingStrategy = FindingStrategy.Value;
            if (MatchAxesScreenDataRatio is not null) ui.MatchAxesScreenDataRatio = MatchAxesScreenDataRatio.Value;
            if (Sections is not null) ui.Sections = Sections;
            if (TooltipFindingStrategy is not null) ui.TooltipFindingStrategy = TooltipFindingStrategy.Value;
            if (XAxes is not null) ui.XAxes = XAxes;
            if (YAxes is not null) ui.YAxes = YAxes;
            if (ZoomingSpeed is not null) ui.ZoomingSpeed = ZoomingSpeed.Value;
            if (ZoomMode is not null) ui.ZoomMode = ZoomMode.Value;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.SourceGenCartesianChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart"/></summary>
        public static SourceGenCartesianChart SourceGenCartesianChart()
        {
            var ui = new LiveChartsGeneratedCode.SourceGenCartesianChart();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.SourceGenCartesianChart.StartChain(ui);
        }
    }

    public partial class SourceGenCartesianChart : SourceGenChart, IUI<LiveChartsGeneratedCode.SourceGenCartesianChart>
    {
        static SourceGenCartesianChart instance;

        internal static SourceGenCartesianChart StartChain(LiveChartsGeneratedCode.SourceGenCartesianChart ui)
        {
            if (instance == null) instance = new SourceGenCartesianChart();
            instance.UI = ui;
            return instance;
        }

        LiveChartsGeneratedCode.SourceGenCartesianChart ui;

        public new LiveChartsGeneratedCode.SourceGenCartesianChart UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(SourceGenCartesianChart view) => view?.UI;

        public static implicit operator LiveChartsGeneratedCode.SourceGenCartesianChart(SourceGenCartesianChart view) => view?.UI;

        public static implicit operator SourceGenCartesianChart(LiveChartsGeneratedCode.SourceGenCartesianChart ui) => SourceGenCartesianChart.StartChain(ui);

        public SourceGenCartesianChart Invoke(Action<LiveChartsGeneratedCode.SourceGenCartesianChart> action) { action?.Invoke(UI); return this; }

        protected SourceGenCartesianChart() { }
    }

    public static partial class SourceGenCartesianChartExtensions
    {
        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.DrawMarginFrame"/></summary>
        public static TView DrawMarginFrame<TView>(this TView view, LiveCharts.Kernel.IChartElement value) where TView : SourceGenCartesianChart { view.UI.DrawMarginFrame = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.FindingStrategy"/></summary>
        public static TView FindingStrategy<TView>(this TView view, LiveCharts.Measure.FindingStrategy value) where TView : SourceGenCartesianChart { view.UI.FindingStrategy = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.MatchAxesScreenDataRatio"/></summary>
        public static TView MatchAxesScreenDataRatio<TView>(this TView view, bool value) where TView : SourceGenCartesianChart { view.UI.MatchAxesScreenDataRatio = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.Sections"/></summary>
        public static TView Sections<TView>(this TView view, IEnumerable<LiveCharts.Kernel.IChartElement> value) where TView : SourceGenCartesianChart { view.UI.Sections = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.TooltipFindingStrategy"/></summary>
        public static TView TooltipFindingStrategy<TView>(this TView view, LiveCharts.Measure.TooltipFindingStrategy value) where TView : SourceGenCartesianChart { view.UI.TooltipFindingStrategy = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.XAxes"/></summary>
        public static TView XAxes<TView>(this TView view, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis> value) where TView : SourceGenCartesianChart { view.UI.XAxes = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.YAxes"/></summary>
        public static TView YAxes<TView>(this TView view, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis> value) where TView : SourceGenCartesianChart { view.UI.YAxes = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.ZoomingSpeed"/></summary>
        public static TView ZoomingSpeed<TView>(this TView view, double value) where TView : SourceGenCartesianChart { view.UI.ZoomingSpeed = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.ZoomMode"/></summary>
        public static TView ZoomMode<TView>(this TView view, LiveCharts.Measure.ZoomAndPanMode value) where TView : SourceGenCartesianChart { view.UI.ZoomMode = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.DrawMarginFrame"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Kernel.IChartElement> DrawMarginFrame<TTarget>(this TTarget target) where TTarget : SourceGenCartesianChart
        => DependencyProperty<TTarget, LiveCharts.Kernel.IChartElement>.Get(target, LiveChartsGeneratedCode.SourceGenCartesianChart.DrawMarginFrameProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.FindingStrategy"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy> FindingStrategy<TTarget>(this TTarget target) where TTarget : SourceGenCartesianChart
        => DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy>.Get(target, LiveChartsGeneratedCode.SourceGenCartesianChart.FindingStrategyProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.Sections"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.IChartElement>> Sections<TTarget>(this TTarget target) where TTarget : SourceGenCartesianChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.IChartElement>>.Get(target, LiveChartsGeneratedCode.SourceGenCartesianChart.SectionsProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.XAxes"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis>> XAxes<TTarget>(this TTarget target) where TTarget : SourceGenCartesianChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis>>.Get(target, LiveChartsGeneratedCode.SourceGenCartesianChart.XAxesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.YAxes"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis>> YAxes<TTarget>(this TTarget target) where TTarget : SourceGenCartesianChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.ICartesianAxis>>.Get(target, LiveChartsGeneratedCode.SourceGenCartesianChart.YAxesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.ZoomingSpeed"/></summary>
        public static DependencyProperty<TTarget, double> ZoomingSpeed<TTarget>(this TTarget target) where TTarget : SourceGenCartesianChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsGeneratedCode.SourceGenCartesianChart.ZoomingSpeedProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenCartesianChart.ZoomMode"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> ZoomMode<TTarget>(this TTarget target) where TTarget : SourceGenCartesianChart
        => DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode>.Get(target, LiveChartsGeneratedCode.SourceGenCartesianChart.ZoomModeProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // SourceGenChart
{
    public partial class SourceGenChart : UserControl, IUI<LiveChartsGeneratedCode.SourceGenChart>
    {
        LiveChartsGeneratedCode.SourceGenChart ui;

        public new LiveChartsGeneratedCode.SourceGenChart UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public SourceGenChart Invoke(Action<LiveChartsGeneratedCode.SourceGenChart> action) { action?.Invoke(UI); return this; }

        protected SourceGenChart() { }
    }

    public static partial class SourceGenChartExtensions
    {
        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.AnimationsSpeed"/></summary>
        public static TView AnimationsSpeed<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : SourceGenChart { view.UI.AnimationsSpeed = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.AutoUpdateEnabled"/></summary>
        public static TView AutoUpdateEnabled<TView>(this TView view, bool value) where TView : SourceGenChart { view.UI.AutoUpdateEnabled = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.ChartPointPointerDownCommand"/></summary>
        public static TView ChartPointPointerDownCommand<TView>(this TView view, ICommand value) where TView : SourceGenChart { view.UI.ChartPointPointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.ChartTheme"/></summary>
        public static TView ChartTheme<TView>(this TView view, LiveCharts.Themes.Theme? value) where TView : SourceGenChart { view.UI.ChartTheme = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.DataPointerDownCommand"/></summary>
        public static TView DataPointerDownCommand<TView>(this TView view, ICommand value) where TView : SourceGenChart { view.UI.DataPointerDownCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.DrawMargin"/></summary>
        public static TView DrawMargin<TView>(this TView view, LiveCharts.Measure.Margin value) where TView : SourceGenChart { view.UI.DrawMargin = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.EasingFunction"/></summary>
        public static TView EasingFunction<TView>(this TView view, Func<float, float> value) where TView : SourceGenChart { view.UI.EasingFunction = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.HoveredPointsChangedCommand"/></summary>
        public static TView HoveredPointsChangedCommand<TView>(this TView view, ICommand value) where TView : SourceGenChart { view.UI.HoveredPointsChangedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.Legend"/></summary>
        public static TView Legend<TView>(this TView view, LiveCharts.Kernel.Sketches.IChartLegend? value) where TView : SourceGenChart { view.UI.Legend = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.LegendBackgroundPaint"/></summary>
        public static TView LegendBackgroundPaint<TView>(this TView view, LiveCharts.Painting.Paint value) where TView : SourceGenChart { view.UI.LegendBackgroundPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.LegendPosition"/></summary>
        public static TView LegendPosition<TView>(this TView view, LiveCharts.Measure.LegendPosition value) where TView : SourceGenChart { view.UI.LegendPosition = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.LegendTextPaint"/></summary>
        public static TView LegendTextPaint<TView>(this TView view, LiveCharts.Painting.Paint value) where TView : SourceGenChart { view.UI.LegendTextPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.LegendTextSize"/></summary>
        public static TView LegendTextSize<TView>(this TView view, double value) where TView : SourceGenChart { view.UI.LegendTextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.PointerMoveCommand"/></summary>
        public static TView PointerMoveCommand<TView>(this TView view, ICommand value) where TView : SourceGenChart { view.UI.PointerMoveCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.PointerPressedCommand"/></summary>
        public static TView PointerPressedCommand<TView>(this TView view, ICommand value) where TView : SourceGenChart { view.UI.PointerPressedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.PointerReleasedCommand"/></summary>
        public static TView PointerReleasedCommand<TView>(this TView view, ICommand value) where TView : SourceGenChart { view.UI.PointerReleasedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.Series"/></summary>
        public static TView Series<TView>(this TView view, IEnumerable<LiveCharts.ISeries> value) where TView : SourceGenChart { view.UI.Series = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.SeriesSource"/></summary>
        public static TView SeriesSource<TView>(this TView view, IEnumerable<object> value) where TView : SourceGenChart { view.UI.SeriesSource = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.SeriesTemplate"/></summary>
        public static TView SeriesTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : SourceGenChart { view.UI.SeriesTemplate = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.SyncContext"/></summary>
        public static TView SyncContext<TView>(this TView view, object value) where TView : SourceGenChart { view.UI.SyncContext = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.Title"/></summary>
        public static TView Title<TView>(this TView view, LiveCharts.Kernel.IChartElement value) where TView : SourceGenChart { view.UI.Title = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.Tooltip"/></summary>
        public static TView Tooltip<TView>(this TView view, LiveCharts.Kernel.Sketches.IChartTooltip? value) where TView : SourceGenChart { view.UI.Tooltip = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.TooltipBackgroundPaint"/></summary>
        public static TView TooltipBackgroundPaint<TView>(this TView view, LiveCharts.Painting.Paint value) where TView : SourceGenChart { view.UI.TooltipBackgroundPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.TooltipPosition"/></summary>
        public static TView TooltipPosition<TView>(this TView view, LiveCharts.Measure.TooltipPosition value) where TView : SourceGenChart { view.UI.TooltipPosition = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.TooltipTextPaint"/></summary>
        public static TView TooltipTextPaint<TView>(this TView view, LiveCharts.Painting.Paint value) where TView : SourceGenChart { view.UI.TooltipTextPaint = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.TooltipTextSize"/></summary>
        public static TView TooltipTextSize<TView>(this TView view, double value) where TView : SourceGenChart { view.UI.TooltipTextSize = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.UpdaterThrottler"/></summary>
        public static TView UpdaterThrottler<TView>(this TView view, CSharpMarkup.WinUI.to.TimeSpan value) where TView : SourceGenChart { view.UI.UpdaterThrottler = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.UpdateStartedCommand"/></summary>
        public static TView UpdateStartedCommand<TView>(this TView view, ICommand value) where TView : SourceGenChart { view.UI.UpdateStartedCommand = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.VisualElements"/></summary>
        public static TView VisualElements<TView>(this TView view, IEnumerable<LiveCharts.Kernel.IChartElement> value) where TView : SourceGenChart { view.UI.VisualElements = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenChart.VisualElementsPointerDownCommand"/></summary>
        public static TView VisualElementsPointerDownCommand<TView>(this TView view, ICommand value) where TView : SourceGenChart { view.UI.VisualElementsPointerDownCommand = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.AnimationsSpeed"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan> AnimationsSpeed<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.to.TimeSpan>.Get(target, LiveChartsGeneratedCode.SourceGenChart.AnimationsSpeedProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.ChartPointPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> ChartPointPointerDownCommand<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsGeneratedCode.SourceGenChart.ChartPointPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.DataPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> DataPointerDownCommand<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsGeneratedCode.SourceGenChart.DataPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.DrawMargin"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.Margin> DrawMargin<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, LiveCharts.Measure.Margin>.Get(target, LiveChartsGeneratedCode.SourceGenChart.DrawMarginProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.EasingFunction"/></summary>
        public static DependencyProperty<TTarget, Func<float, float>> EasingFunction<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, Func<float, float>>.Get(target, LiveChartsGeneratedCode.SourceGenChart.EasingFunctionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.HoveredPointsChangedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> HoveredPointsChangedCommand<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsGeneratedCode.SourceGenChart.HoveredPointsChangedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.LegendBackgroundPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint> LegendBackgroundPaint<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint>.Get(target, LiveChartsGeneratedCode.SourceGenChart.LegendBackgroundPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.LegendPosition"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> LegendPosition<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition>.Get(target, LiveChartsGeneratedCode.SourceGenChart.LegendPositionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.LegendTextPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint> LegendTextPaint<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint>.Get(target, LiveChartsGeneratedCode.SourceGenChart.LegendTextPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.LegendTextSize"/></summary>
        public static DependencyProperty<TTarget, double> LegendTextSize<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsGeneratedCode.SourceGenChart.LegendTextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.PointerMoveCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> PointerMoveCommand<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsGeneratedCode.SourceGenChart.PointerMoveCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.PointerPressedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> PointerPressedCommand<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsGeneratedCode.SourceGenChart.PointerPressedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.PointerReleasedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> PointerReleasedCommand<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsGeneratedCode.SourceGenChart.PointerReleasedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.Series"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.ISeries>> Series<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.ISeries>>.Get(target, LiveChartsGeneratedCode.SourceGenChart.SeriesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.SeriesSource"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<object>> SeriesSource<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, IEnumerable<object>>.Get(target, LiveChartsGeneratedCode.SourceGenChart.SeriesSourceProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.SeriesTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> SeriesTemplate<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, LiveChartsGeneratedCode.SourceGenChart.SeriesTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.SyncContext"/></summary>
        public static DependencyProperty<TTarget, object> SyncContext<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, object>.Get(target, LiveChartsGeneratedCode.SourceGenChart.SyncContextProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.Title"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Kernel.IChartElement> Title<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, LiveCharts.Kernel.IChartElement>.Get(target, LiveChartsGeneratedCode.SourceGenChart.TitleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.TooltipBackgroundPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint> TooltipBackgroundPaint<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint>.Get(target, LiveChartsGeneratedCode.SourceGenChart.TooltipBackgroundPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.TooltipPosition"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> TooltipPosition<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition>.Get(target, LiveChartsGeneratedCode.SourceGenChart.TooltipPositionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.TooltipTextPaint"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint> TooltipTextPaint<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint>.Get(target, LiveChartsGeneratedCode.SourceGenChart.TooltipTextPaintProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.TooltipTextSize"/></summary>
        public static DependencyProperty<TTarget, double> TooltipTextSize<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsGeneratedCode.SourceGenChart.TooltipTextSizeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.UpdateStartedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> UpdateStartedCommand<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsGeneratedCode.SourceGenChart.UpdateStartedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.VisualElementsPointerDownCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> VisualElementsPointerDownCommand<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, ICommand>.Get(target, LiveChartsGeneratedCode.SourceGenChart.VisualElementsPointerDownCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenChart.VisualElements"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.IChartElement>> VisualElements<TTarget>(this TTarget target) where TTarget : SourceGenChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.IChartElement>>.Get(target, LiveChartsGeneratedCode.SourceGenChart.VisualElementsProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // SourceGenMapChart
{
    public partial class SourceGenMapChart : UserControl, IUI<LiveChartsGeneratedCode.SourceGenMapChart>
    {
        LiveChartsGeneratedCode.SourceGenMapChart ui;

        public new LiveChartsGeneratedCode.SourceGenMapChart UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public SourceGenMapChart Invoke(Action<LiveChartsGeneratedCode.SourceGenMapChart> action) { action?.Invoke(UI); return this; }

        protected SourceGenMapChart() { }
    }

    public static partial class SourceGenMapChartExtensions
    {
        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenMapChart.ActiveMap"/></summary>
        public static TView ActiveMap<TView>(this TView view, LiveCharts.Geo.DrawnMap value) where TView : SourceGenMapChart { view.UI.ActiveMap = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenMapChart.AutoUpdateEnabled"/></summary>
        public static TView AutoUpdateEnabled<TView>(this TView view, bool value) where TView : SourceGenMapChart { view.UI.AutoUpdateEnabled = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenMapChart.Fill"/></summary>
        public static TView Fill<TView>(this TView view, LiveCharts.Painting.Paint value) where TView : SourceGenMapChart { view.UI.Fill = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenMapChart.MapProjection"/></summary>
        public static TView MapProjection<TView>(this TView view, LiveCharts.Geo.MapProjection value) where TView : SourceGenMapChart { view.UI.MapProjection = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenMapChart.Series"/></summary>
        public static TView Series<TView>(this TView view, IEnumerable<LiveCharts.Geo.IGeoSeries> value) where TView : SourceGenMapChart { view.UI.Series = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenMapChart.Stroke"/></summary>
        public static TView Stroke<TView>(this TView view, LiveCharts.Painting.Paint value) where TView : SourceGenMapChart { view.UI.Stroke = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenMapChart.SyncContext"/></summary>
        public static TView SyncContext<TView>(this TView view, object value) where TView : SourceGenMapChart { view.UI.SyncContext = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenMapChart.ActiveMap"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Geo.DrawnMap> ActiveMap<TTarget>(this TTarget target) where TTarget : SourceGenMapChart
        => DependencyProperty<TTarget, LiveCharts.Geo.DrawnMap>.Get(target, LiveChartsGeneratedCode.SourceGenMapChart.ActiveMapProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenMapChart.Fill"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint> Fill<TTarget>(this TTarget target) where TTarget : SourceGenMapChart
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint>.Get(target, LiveChartsGeneratedCode.SourceGenMapChart.FillProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenMapChart.MapProjection"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Geo.MapProjection> MapProjection<TTarget>(this TTarget target) where TTarget : SourceGenMapChart
        => DependencyProperty<TTarget, LiveCharts.Geo.MapProjection>.Get(target, LiveChartsGeneratedCode.SourceGenMapChart.MapProjectionProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenMapChart.Series"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Geo.IGeoSeries>> Series<TTarget>(this TTarget target) where TTarget : SourceGenMapChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Geo.IGeoSeries>>.Get(target, LiveChartsGeneratedCode.SourceGenMapChart.SeriesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenMapChart.Stroke"/></summary>
        public static DependencyProperty<TTarget, LiveCharts.Painting.Paint> Stroke<TTarget>(this TTarget target) where TTarget : SourceGenMapChart
        => DependencyProperty<TTarget, LiveCharts.Painting.Paint>.Get(target, LiveChartsGeneratedCode.SourceGenMapChart.StrokeProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenMapChart.SyncContext"/></summary>
        public static DependencyProperty<TTarget, object> SyncContext<TTarget>(this TTarget target) where TTarget : SourceGenMapChart
        => DependencyProperty<TTarget, object>.Get(target, LiveChartsGeneratedCode.SourceGenMapChart.SyncContextProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // SourceGenPieChart
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsGeneratedCode.SourceGenPieChart"/></summary>
        public static SourceGenPieChart SourceGenPieChart(UIObject Content)
        {
            var ui = new LiveChartsGeneratedCode.SourceGenPieChart();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.SourceGenPieChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsGeneratedCode.SourceGenPieChart"/></summary>
        public static SourceGenPieChart SourceGenPieChart(double? InitialRotation = default, bool? IsClockwise = default, double? MaxAngle = default, double? MaxValue = default, double? MinValue = default, UIObject Content = default)
        {
            var ui = new LiveChartsGeneratedCode.SourceGenPieChart();
            if (InitialRotation is not null) ui.InitialRotation = InitialRotation.Value;
            if (IsClockwise is not null) ui.IsClockwise = IsClockwise.Value;
            if (MaxAngle is not null) ui.MaxAngle = MaxAngle.Value;
            if (MaxValue is not null) ui.MaxValue = MaxValue.Value;
            if (MinValue is not null) ui.MinValue = MinValue.Value;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.SourceGenPieChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsGeneratedCode.SourceGenPieChart"/></summary>
        public static SourceGenPieChart SourceGenPieChart()
        {
            var ui = new LiveChartsGeneratedCode.SourceGenPieChart();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.SourceGenPieChart.StartChain(ui);
        }
    }

    public partial class SourceGenPieChart : SourceGenChart, IUI<LiveChartsGeneratedCode.SourceGenPieChart>
    {
        static SourceGenPieChart instance;

        internal static SourceGenPieChart StartChain(LiveChartsGeneratedCode.SourceGenPieChart ui)
        {
            if (instance == null) instance = new SourceGenPieChart();
            instance.UI = ui;
            return instance;
        }

        LiveChartsGeneratedCode.SourceGenPieChart ui;

        public new LiveChartsGeneratedCode.SourceGenPieChart UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(SourceGenPieChart view) => view?.UI;

        public static implicit operator LiveChartsGeneratedCode.SourceGenPieChart(SourceGenPieChart view) => view?.UI;

        public static implicit operator SourceGenPieChart(LiveChartsGeneratedCode.SourceGenPieChart ui) => SourceGenPieChart.StartChain(ui);

        public SourceGenPieChart Invoke(Action<LiveChartsGeneratedCode.SourceGenPieChart> action) { action?.Invoke(UI); return this; }

        protected SourceGenPieChart() { }
    }

    public static partial class SourceGenPieChartExtensions
    {
        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPieChart.InitialRotation"/></summary>
        public static TView InitialRotation<TView>(this TView view, double value) where TView : SourceGenPieChart { view.UI.InitialRotation = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPieChart.IsClockwise"/></summary>
        public static TView IsClockwise<TView>(this TView view, bool value) where TView : SourceGenPieChart { view.UI.IsClockwise = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPieChart.MaxAngle"/></summary>
        public static TView MaxAngle<TView>(this TView view, double value) where TView : SourceGenPieChart { view.UI.MaxAngle = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPieChart.MaxValue"/></summary>
        public static TView MaxValue<TView>(this TView view, double value) where TView : SourceGenPieChart { view.UI.MaxValue = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPieChart.MinValue"/></summary>
        public static TView MinValue<TView>(this TView view, double value) where TView : SourceGenPieChart { view.UI.MinValue = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPieChart.InitialRotation"/></summary>
        public static DependencyProperty<TTarget, double> InitialRotation<TTarget>(this TTarget target) where TTarget : SourceGenPieChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsGeneratedCode.SourceGenPieChart.InitialRotationProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPieChart.IsClockwise"/></summary>
        public static DependencyProperty<TTarget, bool> IsClockwise<TTarget>(this TTarget target) where TTarget : SourceGenPieChart
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsGeneratedCode.SourceGenPieChart.IsClockwiseProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPieChart.MaxAngle"/></summary>
        public static DependencyProperty<TTarget, double> MaxAngle<TTarget>(this TTarget target) where TTarget : SourceGenPieChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsGeneratedCode.SourceGenPieChart.MaxAngleProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPieChart.MaxValue"/></summary>
        public static DependencyProperty<TTarget, double> MaxValue<TTarget>(this TTarget target) where TTarget : SourceGenPieChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsGeneratedCode.SourceGenPieChart.MaxValueProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPieChart.MinValue"/></summary>
        public static DependencyProperty<TTarget, double> MinValue<TTarget>(this TTarget target) where TTarget : SourceGenPieChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsGeneratedCode.SourceGenPieChart.MinValueProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // SourceGenPolarChart
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="LiveChartsGeneratedCode.SourceGenPolarChart"/></summary>
        public static SourceGenPolarChart SourceGenPolarChart(UIObject Content)
        {
            var ui = new LiveChartsGeneratedCode.SourceGenPolarChart();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.SourceGenPolarChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsGeneratedCode.SourceGenPolarChart"/></summary>
        public static SourceGenPolarChart SourceGenPolarChart(IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis> AngleAxes = default, bool? FitToBounds = default, double? InitialRotation = default, double? InnerRadius = default, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis> RadiusAxes = default, double? TotalAngle = default, UIObject Content = default)
        {
            var ui = new LiveChartsGeneratedCode.SourceGenPolarChart();
            if (AngleAxes is not null) ui.AngleAxes = AngleAxes;
            if (FitToBounds is not null) ui.FitToBounds = FitToBounds.Value;
            if (InitialRotation is not null) ui.InitialRotation = InitialRotation.Value;
            if (InnerRadius is not null) ui.InnerRadius = InnerRadius.Value;
            if (RadiusAxes is not null) ui.RadiusAxes = RadiusAxes;
            if (TotalAngle is not null) ui.TotalAngle = TotalAngle.Value;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.SourceGenPolarChart.StartChain(ui);
        }

        /// <summary>Create a <see cref="LiveChartsGeneratedCode.SourceGenPolarChart"/></summary>
        public static SourceGenPolarChart SourceGenPolarChart()
        {
            var ui = new LiveChartsGeneratedCode.SourceGenPolarChart();
            return CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.SourceGenPolarChart.StartChain(ui);
        }
    }

    public partial class SourceGenPolarChart : SourceGenChart, IUI<LiveChartsGeneratedCode.SourceGenPolarChart>
    {
        static SourceGenPolarChart instance;

        internal static SourceGenPolarChart StartChain(LiveChartsGeneratedCode.SourceGenPolarChart ui)
        {
            if (instance == null) instance = new SourceGenPolarChart();
            instance.UI = ui;
            return instance;
        }

        LiveChartsGeneratedCode.SourceGenPolarChart ui;

        public new LiveChartsGeneratedCode.SourceGenPolarChart UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(SourceGenPolarChart view) => view?.UI;

        public static implicit operator LiveChartsGeneratedCode.SourceGenPolarChart(SourceGenPolarChart view) => view?.UI;

        public static implicit operator SourceGenPolarChart(LiveChartsGeneratedCode.SourceGenPolarChart ui) => SourceGenPolarChart.StartChain(ui);

        public SourceGenPolarChart Invoke(Action<LiveChartsGeneratedCode.SourceGenPolarChart> action) { action?.Invoke(UI); return this; }

        protected SourceGenPolarChart() { }
    }

    public static partial class SourceGenPolarChartExtensions
    {
        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.AngleAxes"/></summary>
        public static TView AngleAxes<TView>(this TView view, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis> value) where TView : SourceGenPolarChart { view.UI.AngleAxes = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.FitToBounds"/></summary>
        public static TView FitToBounds<TView>(this TView view, bool value) where TView : SourceGenPolarChart { view.UI.FitToBounds = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.InitialRotation"/></summary>
        public static TView InitialRotation<TView>(this TView view, double value) where TView : SourceGenPolarChart { view.UI.InitialRotation = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.InnerRadius"/></summary>
        public static TView InnerRadius<TView>(this TView view, double value) where TView : SourceGenPolarChart { view.UI.InnerRadius = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.RadiusAxes"/></summary>
        public static TView RadiusAxes<TView>(this TView view, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis> value) where TView : SourceGenPolarChart { view.UI.RadiusAxes = value; return view; }

        /// <summary>Set <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.TotalAngle"/></summary>
        public static TView TotalAngle<TView>(this TView view, double value) where TView : SourceGenPolarChart { view.UI.TotalAngle = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.AngleAxes"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis>> AngleAxes<TTarget>(this TTarget target) where TTarget : SourceGenPolarChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis>>.Get(target, LiveChartsGeneratedCode.SourceGenPolarChart.AngleAxesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.FitToBounds"/></summary>
        public static DependencyProperty<TTarget, bool> FitToBounds<TTarget>(this TTarget target) where TTarget : SourceGenPolarChart
        => DependencyProperty<TTarget, bool>.Get(target, LiveChartsGeneratedCode.SourceGenPolarChart.FitToBoundsProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.InitialRotation"/></summary>
        public static DependencyProperty<TTarget, double> InitialRotation<TTarget>(this TTarget target) where TTarget : SourceGenPolarChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsGeneratedCode.SourceGenPolarChart.InitialRotationProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.InnerRadius"/></summary>
        public static DependencyProperty<TTarget, double> InnerRadius<TTarget>(this TTarget target) where TTarget : SourceGenPolarChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsGeneratedCode.SourceGenPolarChart.InnerRadiusProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.RadiusAxes"/></summary>
        public static DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis>> RadiusAxes<TTarget>(this TTarget target) where TTarget : SourceGenPolarChart
        => DependencyProperty<TTarget, IEnumerable<LiveCharts.Kernel.Sketches.IPolarAxis>>.Get(target, LiveChartsGeneratedCode.SourceGenPolarChart.RadiusAxesProperty);

        /// <summary>Bind (or set enum value of) <see cref="LiveChartsGeneratedCode.SourceGenPolarChart.TotalAngle"/></summary>
        public static DependencyProperty<TTarget, double> TotalAngle<TTarget>(this TTarget target) where TTarget : SourceGenPolarChart
        => DependencyProperty<TTarget, double>.Get(target, LiveChartsGeneratedCode.SourceGenPolarChart.TotalAngleProperty);
    }
}

namespace CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView // EnumPropertyValues
{
    public static partial class SourceGenCartesianChartExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Measure.FindingStrategy.Automatic"/></summary>
        public static TTarget Automatic<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.FindingStrategy.Automatic);

        /// <summary>Set to <see cref="LiveCharts.Measure.FindingStrategy.CompareAll"/></summary>
        public static TTarget CompareAll<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.FindingStrategy.CompareAll);

        /// <summary>Set to <see cref="LiveCharts.Measure.FindingStrategy.CompareAllTakeClosest"/></summary>
        public static TTarget CompareAllTakeClosest<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.FindingStrategy.CompareAllTakeClosest);

        /// <summary>Set to <see cref="LiveCharts.Measure.FindingStrategy.CompareOnlyX"/></summary>
        public static TTarget CompareOnlyX<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.FindingStrategy.CompareOnlyX);

        /// <summary>Set to <see cref="LiveCharts.Measure.FindingStrategy.CompareOnlyXTakeClosest"/></summary>
        public static TTarget CompareOnlyXTakeClosest<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.FindingStrategy.CompareOnlyXTakeClosest);

        /// <summary>Set to <see cref="LiveCharts.Measure.FindingStrategy.CompareOnlyY"/></summary>
        public static TTarget CompareOnlyY<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.FindingStrategy.CompareOnlyY);

        /// <summary>Set to <see cref="LiveCharts.Measure.FindingStrategy.CompareOnlyYTakeClosest"/></summary>
        public static TTarget CompareOnlyYTakeClosest<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.FindingStrategy.CompareOnlyYTakeClosest);

        /// <summary>Set to <see cref="LiveCharts.Measure.FindingStrategy.ExactMatch"/></summary>
        public static TTarget ExactMatch<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.FindingStrategy.ExactMatch);

        /// <summary>Set to <see cref="LiveCharts.Measure.FindingStrategy.ExactMatchTakeClosest"/></summary>
        public static TTarget ExactMatchTakeClosest<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.FindingStrategy> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.FindingStrategy.ExactMatchTakeClosest);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.Both"/></summary>
        public static TTarget Both<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.Both);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.InvertPanningPointerTrigger"/></summary>
        public static TTarget InvertPanningPointerTrigger<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.InvertPanningPointerTrigger);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.NoFit"/></summary>
        public static TTarget NoFit<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.NoFit);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.None);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.NoZoomBySection"/></summary>
        public static TTarget NoZoomBySection<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.NoZoomBySection);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.X"/></summary>
        public static TTarget X<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.X);

        /// <summary>Set to <see cref="LiveCharts.Measure.ZoomAndPanMode.Y"/></summary>
        public static TTarget Y<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.ZoomAndPanMode> property) where TTarget : SourceGenCartesianChart
        => property.Set(LiveCharts.Measure.ZoomAndPanMode.Y);
    }

    public static partial class SourceGenChartExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Bottom"/></summary>
        public static TTarget Bottom<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.LegendPosition.Bottom);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Hidden"/></summary>
        public static TTarget Hidden<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.LegendPosition.Hidden);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.LegendPosition.Left);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.LegendPosition.Right);

        /// <summary>Set to <see cref="LiveCharts.Measure.LegendPosition.Top"/></summary>
        public static TTarget Top<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.LegendPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.LegendPosition.Top);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Auto"/></summary>
        public static TTarget Auto<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Auto);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Bottom"/></summary>
        public static TTarget Bottom<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Bottom);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Center"/></summary>
        public static TTarget Center<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Center);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Hidden"/></summary>
        public static TTarget Hidden<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Hidden);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Left);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Right);

        /// <summary>Set to <see cref="LiveCharts.Measure.TooltipPosition.Top"/></summary>
        public static TTarget Top<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.TooltipPosition> property) where TTarget : SourceGenChart
        => property.Set(LiveCharts.Measure.TooltipPosition.Top);
    }

    public static partial class SourceGenMapChartExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Geo.MapProjection.Default"/></summary>
        public static TTarget Default<TTarget>(this DependencyProperty<TTarget, LiveCharts.Geo.MapProjection> property) where TTarget : SourceGenMapChart
        => property.Set(LiveCharts.Geo.MapProjection.Default);

        /// <summary>Set to <see cref="LiveCharts.Geo.MapProjection.Mercator"/></summary>
        public static TTarget Mercator<TTarget>(this DependencyProperty<TTarget, LiveCharts.Geo.MapProjection> property) where TTarget : SourceGenMapChart
        => property.Set(LiveCharts.Geo.MapProjection.Mercator);
    }

    public static partial class XamlAngularTicksExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Measure.MeasureUnit.ChartValues"/></summary>
        public static TTarget ChartValues<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.MeasureUnit> property) where TTarget : XamlAngularTicks
        => property.Set(LiveCharts.Measure.MeasureUnit.ChartValues);

        /// <summary>Set to <see cref="LiveCharts.Measure.MeasureUnit.Pixels"/></summary>
        public static TTarget Pixels<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.MeasureUnit> property) where TTarget : XamlAngularTicks
        => property.Set(LiveCharts.Measure.MeasureUnit.Pixels);
    }

    public static partial class XamlDrawnLabelVisualExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Drawing.Align.End"/></summary>
        public static TTarget End<TTarget>(this DependencyProperty<TTarget, LiveCharts.Drawing.Align> property) where TTarget : XamlDrawnLabelVisual
        => property.Set(LiveCharts.Drawing.Align.End);

        /// <summary>Set to <see cref="LiveCharts.Drawing.Align.Middle"/></summary>
        public static TTarget Middle<TTarget>(this DependencyProperty<TTarget, LiveCharts.Drawing.Align> property) where TTarget : XamlDrawnLabelVisual
        => property.Set(LiveCharts.Drawing.Align.Middle);

        /// <summary>Set to <see cref="LiveCharts.Drawing.Align.Start"/></summary>
        public static TTarget Start<TTarget>(this DependencyProperty<TTarget, LiveCharts.Drawing.Align> property) where TTarget : XamlDrawnLabelVisual
        => property.Set(LiveCharts.Drawing.Align.Start);
    }

    public static partial class XamlNeedleExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Measure.MeasureUnit.ChartValues"/></summary>
        public static TTarget ChartValues<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.MeasureUnit> property) where TTarget : XamlNeedle
        => property.Set(LiveCharts.Measure.MeasureUnit.ChartValues);

        /// <summary>Set to <see cref="LiveCharts.Measure.MeasureUnit.Pixels"/></summary>
        public static TTarget Pixels<TTarget>(this DependencyProperty<TTarget, LiveCharts.Measure.MeasureUnit> property) where TTarget : XamlNeedle
        => property.Set(LiveCharts.Measure.MeasureUnit.Pixels);
    }

    public static partial class XamlPolarAxisExtensions
    {
        /// <summary>Set to <see cref="LiveCharts.Drawing.Align.End"/></summary>
        public static TTarget End<TTarget>(this DependencyProperty<TTarget, LiveCharts.Drawing.Align> property) where TTarget : XamlPolarAxis
        => property.Set(LiveCharts.Drawing.Align.End);

        /// <summary>Set to <see cref="LiveCharts.Drawing.Align.Middle"/></summary>
        public static TTarget Middle<TTarget>(this DependencyProperty<TTarget, LiveCharts.Drawing.Align> property) where TTarget : XamlPolarAxis
        => property.Set(LiveCharts.Drawing.Align.Middle);

        /// <summary>Set to <see cref="LiveCharts.Drawing.Align.Start"/></summary>
        public static TTarget Start<TTarget>(this DependencyProperty<TTarget, LiveCharts.Drawing.Align> property) where TTarget : XamlPolarAxis
        => property.Set(LiveCharts.Drawing.Align.Start);
    }
}

#endif
// End of generated C# Markup API for Uno.WinUI
