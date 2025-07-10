// Start of generated C# Markup API for Uno.WinUI
#if NET8_0 && __IOS__ && !__MACCATALYST__

using System;
using System.Collections.Generic;
using CSharpMarkup.WinUI.GeneratedCodeUtilities;
using Xaml = Microsoft.UI.Xaml;
using MuiCore = Mapsui;
using Mui = Mapsui.UI.WinUI;

namespace CSharpMarkup.WinUI.Mapsui // MapControl
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Mui.MapControl"/></summary>
        public static MapControl MapControl(params Xaml.UIElement[] Children)
        {
            var ui = new Mui.MapControl();
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
            return CSharpMarkup.WinUI.Mapsui.MapControl.StartChain(ui);
        }

        /// <summary>Create a <see cref="Mui.MapControl"/></summary>
        public static MapControl MapControl()
        {
            var ui = new Mui.MapControl();
            return CSharpMarkup.WinUI.Mapsui.MapControl.StartChain(ui);
        }
    }

    public partial class MapControl : Grid, IUI<Mui.MapControl>
    {
        static MapControl instance;

        internal static MapControl StartChain(Mui.MapControl ui)
        {
            if (instance == null) instance = new MapControl();
            instance.UI = ui;
            return instance;
        }

        Mui.MapControl ui;

        public new Mui.MapControl UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(MapControl view) => view?.UI;

        public static implicit operator Mui.MapControl(MapControl view) => view?.UI;

        public static implicit operator MapControl(Mui.MapControl ui) => MapControl.StartChain(ui);

        public MapControl Invoke(Action<Mui.MapControl> action) { action?.Invoke(UI); return this; }

        protected MapControl() { }
    }

    public static partial class MapControlExtensions
    {
        /// <summary>Set <see cref="Mui.MapControl.Map"/></summary>
        public static TView Map<TView>(this TView view, MuiCore.Map value) where TView : MapControl { view.UI.Map = value; return view; }

        /// <summary>Set <see cref="Mui.MapControl.MaxTapGestureMovement"/></summary>
        public static TView MaxTapGestureMovement<TView>(this TView view, int value) where TView : MapControl { view.UI.MaxTapGestureMovement = value; return view; }

        /// <summary>Set <see cref="Mui.MapControl.UseFling"/></summary>
        public static TView UseFling<TView>(this TView view, bool value) where TView : MapControl { view.UI.UseFling = value; return view; }
    }
}


#endif
// End of generated C# Markup API for Uno.WinUI
