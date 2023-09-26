// Start of generated C# Markup API for Uno.WinUI
#if NET7_0_MACOS && HAS_UNO && !WINDOWS_UWP

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Input;
using System.Runtime.Versioning;
using Microsoft;
using UI = Microsoft.UI;
using Collections = System.Collections;
using Xaml = Microsoft.UI.Xaml;
using VirtualKey = Windows.System.VirtualKey;
using VirtualKeyModifiers = Windows.System.VirtualKeyModifiers;
using Drawing = System.Drawing;
using UnoExtensionsNavigation = Uno.Extensions.Navigation;

namespace CSharpMarkup.WinUI.Uno.Extensions.Navigation // FrameView
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoExtensionsNavigation.UI.Controls.FrameView"/></summary>
        public static FrameView FrameView(UIObject Content)
        {
            var ui = new UnoExtensionsNavigation.UI.Controls.FrameView();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Extensions.Navigation.FrameView.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoExtensionsNavigation.UI.Controls.FrameView"/></summary>
        public static FrameView FrameView()
        {
            var ui = new UnoExtensionsNavigation.UI.Controls.FrameView();
            return CSharpMarkup.WinUI.Uno.Extensions.Navigation.FrameView.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoExtensionsNavigation.UI.Controls.FrameView"/></summary>
        public static FrameView FrameView(nint handle)
        {
            var ui = new UnoExtensionsNavigation.UI.Controls.FrameView(handle);
            return CSharpMarkup.WinUI.Uno.Extensions.Navigation.FrameView.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoExtensionsNavigation.UI.Controls.FrameView"/></summary>
        public static FrameView FrameView(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoExtensionsNavigation.UI.Controls.FrameView(handle);
            return CSharpMarkup.WinUI.Uno.Extensions.Navigation.FrameView.StartChain(ui);
        }
    }

    public partial class FrameView : UserControl, IUI<UnoExtensionsNavigation.UI.Controls.FrameView>
    {
        static FrameView instance;

        internal static FrameView StartChain(UnoExtensionsNavigation.UI.Controls.FrameView ui)
        {
            if (instance == null) instance = new FrameView();
            instance.UI = ui;
            return instance;
        }

        UnoExtensionsNavigation.UI.Controls.FrameView ui;

        public new UnoExtensionsNavigation.UI.Controls.FrameView UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(FrameView view) => view?.UI;

        public static implicit operator UnoExtensionsNavigation.UI.Controls.FrameView(FrameView view) => view?.UI;

        public static implicit operator FrameView(UnoExtensionsNavigation.UI.Controls.FrameView ui) => FrameView.StartChain(ui);

        public FrameView Invoke(Action<UnoExtensionsNavigation.UI.Controls.FrameView> action) { action?.Invoke(UI); return this; }

        protected FrameView() { }
    }
}

namespace CSharpMarkup.WinUI.Uno.Extensions.Navigation // NavigationFlyout
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoExtensionsNavigation.UI.Controls.NavigationFlyout"/></summary>
        public static NavigationFlyout NavigationFlyout(Xaml.UIElement Content)
        {
            var ui = new UnoExtensionsNavigation.UI.Controls.NavigationFlyout();
            if (Content != null) ui.Content = Content;
            return CSharpMarkup.WinUI.Uno.Extensions.Navigation.NavigationFlyout.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoExtensionsNavigation.UI.Controls.NavigationFlyout"/></summary>
        public static NavigationFlyout NavigationFlyout()
        {
            var ui = new UnoExtensionsNavigation.UI.Controls.NavigationFlyout();
            return CSharpMarkup.WinUI.Uno.Extensions.Navigation.NavigationFlyout.StartChain(ui);
        }
    }

    public partial class NavigationFlyout : Flyout, IUI<UnoExtensionsNavigation.UI.Controls.NavigationFlyout>
    {
        static NavigationFlyout instance;

        internal static NavigationFlyout StartChain(UnoExtensionsNavigation.UI.Controls.NavigationFlyout ui)
        {
            if (instance == null) instance = new NavigationFlyout();
            instance.UI = ui;
            return instance;
        }

        UnoExtensionsNavigation.UI.Controls.NavigationFlyout ui;

        public new UnoExtensionsNavigation.UI.Controls.NavigationFlyout UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator UnoExtensionsNavigation.UI.Controls.NavigationFlyout(NavigationFlyout view) => view?.UI;

        public static implicit operator NavigationFlyout(UnoExtensionsNavigation.UI.Controls.NavigationFlyout ui) => NavigationFlyout.StartChain(ui);

        public NavigationFlyout Invoke(Action<UnoExtensionsNavigation.UI.Controls.NavigationFlyout> action) { action?.Invoke(UI); return this; }

        protected NavigationFlyout() { }
    }
}


#endif
// End of generated C# Markup API for Uno.WinUI
