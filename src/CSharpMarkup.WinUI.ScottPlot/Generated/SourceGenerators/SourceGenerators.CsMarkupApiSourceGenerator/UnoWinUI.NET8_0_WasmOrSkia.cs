// Start of generated C# Markup API for Uno.WinUI
#if NET8_0 && __WASM_OR_SKIA__ && !DESKTOP && !BROWSERWASM

using System;
using System.Collections.Generic;
using CSharpMarkup.WinUI.GeneratedCodeUtilities;
using Xaml = Microsoft.UI.Xaml;
using Sp = ScottPlot;
using SpUI = ScottPlot.WinUI;

namespace CSharpMarkup.WinUI.ScottPlot // WinUIPlot
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="SpUI.WinUIPlot"/></summary>
        public static WinUIPlot WinUIPlot(UIObject Content)
        {
            var ui = new SpUI.WinUIPlot();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.ScottPlot.WinUIPlot.StartChain(ui);
        }

        /// <summary>Create a <see cref="SpUI.WinUIPlot"/></summary>
        public static WinUIPlot WinUIPlot(Xaml.Window? AppWindow = default, float? DisplayScale = default, Sp.IPlotMenu? Menu = default, Sp.IMultiplot Multiplot = default, UIObject Content = default)
        {
            var ui = new SpUI.WinUIPlot();
            if (AppWindow is not null) ui.AppWindow = AppWindow;
            if (DisplayScale is not null) ui.DisplayScale = DisplayScale.Value;
            if (Menu is not null) ui.Menu = Menu;
            if (Multiplot is not null) ui.Multiplot = Multiplot;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.ScottPlot.WinUIPlot.StartChain(ui);
        }

        /// <summary>Create a <see cref="SpUI.WinUIPlot"/></summary>
        public static WinUIPlot WinUIPlot()
        {
            var ui = new SpUI.WinUIPlot();
            return CSharpMarkup.WinUI.ScottPlot.WinUIPlot.StartChain(ui);
        }
    }

    public partial class WinUIPlot : UserControl, IUI<SpUI.WinUIPlot>
    {
        static WinUIPlot instance;

        internal static WinUIPlot StartChain(SpUI.WinUIPlot ui)
        {
            if (instance == null) instance = new WinUIPlot();
            instance.UI = ui;
            return instance;
        }

        SpUI.WinUIPlot ui;

        public new SpUI.WinUIPlot UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(WinUIPlot view) => view?.UI;

        public static implicit operator SpUI.WinUIPlot(WinUIPlot view) => view?.UI;

        public static implicit operator WinUIPlot(SpUI.WinUIPlot ui) => WinUIPlot.StartChain(ui);

        public WinUIPlot Invoke(Action<SpUI.WinUIPlot> action) { action?.Invoke(UI); return this; }

        protected WinUIPlot() { }
    }

    public static partial class WinUIPlotExtensions
    {
        /// <summary>Set <see cref="SpUI.WinUIPlot.AppWindow"/></summary>
        public static TView AppWindow<TView>(this TView view, Xaml.Window? value) where TView : WinUIPlot { view.UI.AppWindow = value; return view; }

        /// <summary>Set <see cref="SpUI.WinUIPlot.DisplayScale"/></summary>
        public static TView DisplayScale<TView>(this TView view, float value) where TView : WinUIPlot { view.UI.DisplayScale = value; return view; }

        /// <summary>Set <see cref="SpUI.WinUIPlot.Menu"/></summary>
        public static TView Menu<TView>(this TView view, Sp.IPlotMenu? value) where TView : WinUIPlot { view.UI.Menu = value; return view; }

        /// <summary>Set <see cref="SpUI.WinUIPlot.Multiplot"/></summary>
        public static TView Multiplot<TView>(this TView view, Sp.IMultiplot value) where TView : WinUIPlot { view.UI.Multiplot = value; return view; }
    }
}


#endif
// End of generated C# Markup API for Uno.WinUI
