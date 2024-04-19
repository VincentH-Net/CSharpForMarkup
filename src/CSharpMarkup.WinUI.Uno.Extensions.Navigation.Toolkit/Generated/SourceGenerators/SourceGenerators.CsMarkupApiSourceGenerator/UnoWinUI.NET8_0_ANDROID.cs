// Start of generated C# Markup API for Uno.WinUI
#if NET8_0_ANDROID && __ANDROID__

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
using UnoExtensionsNavigationToolkit = Uno.Extensions.Navigation.Toolkit;

namespace CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit // ModalFlyout
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoExtensionsNavigationToolkit.Controls.ModalFlyout"/></summary>
        public static ModalFlyout ModalFlyout(Xaml.UIElement Content)
        {
            var ui = new UnoExtensionsNavigationToolkit.Controls.ModalFlyout();
            if (Content != null) ui.Content = Content;
            return CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit.ModalFlyout.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoExtensionsNavigationToolkit.Controls.ModalFlyout"/></summary>
        public static ModalFlyout ModalFlyout()
        {
            var ui = new UnoExtensionsNavigationToolkit.Controls.ModalFlyout();
            return CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit.ModalFlyout.StartChain(ui);
        }
    }

    public partial class ModalFlyout : Flyout, IUI<UnoExtensionsNavigationToolkit.Controls.ModalFlyout>
    {
        static ModalFlyout instance;

        internal static ModalFlyout StartChain(UnoExtensionsNavigationToolkit.Controls.ModalFlyout ui)
        {
            if (instance == null) instance = new ModalFlyout();
            instance.UI = ui;
            return instance;
        }

        UnoExtensionsNavigationToolkit.Controls.ModalFlyout ui;

        public new UnoExtensionsNavigationToolkit.Controls.ModalFlyout UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator UnoExtensionsNavigationToolkit.Controls.ModalFlyout(ModalFlyout view) => view?.UI;

        public static implicit operator ModalFlyout(UnoExtensionsNavigationToolkit.Controls.ModalFlyout ui) => ModalFlyout.StartChain(ui);

        public ModalFlyout Invoke(Action<UnoExtensionsNavigationToolkit.Controls.ModalFlyout> action) { action?.Invoke(UI); return this; }

        protected ModalFlyout() { }
    }
}


#endif
// End of generated C# Markup API for Uno.WinUI
