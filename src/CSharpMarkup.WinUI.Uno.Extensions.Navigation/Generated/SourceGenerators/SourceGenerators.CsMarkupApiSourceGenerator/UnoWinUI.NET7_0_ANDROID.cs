// Start of generated C# Markup API for Uno.WinUI
#if NET7_0_ANDROID && HAS_UNO && !WINDOWS_UWP

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
using UnoExtensionsNavigation = Uno.Extensions.Navigation;

namespace CSharpMarkup.WinUI.Uno.Extensions.Navigation // FrameNavigatorExtensions
{
    public static partial class FrameNavigatorExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoExtensionsNavigation.Navigators.FrameNavigatorExtensions.NavigatorInstance"/></summary>
        public static TTarget FrameNavigatorExtensions_NavigatorInstance<TTarget>(this TTarget target, UnoExtensionsNavigation.INavigator value) where TTarget : FrameworkElement
        { UnoExtensionsNavigation.Navigators.FrameNavigatorExtensions.SetNavigatorInstance(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsNavigation.Navigators.FrameNavigatorExtensions.NavigatorInstance"/></summary>
        public static DependencyProperty<TTarget, UnoExtensionsNavigation.INavigator> FrameNavigatorExtensions_NavigatorInstance<TTarget>(this TTarget target) where TTarget : FrameworkElement
        => DependencyProperty<TTarget, UnoExtensionsNavigation.INavigator>.Get(target, UnoExtensionsNavigation.Navigators.FrameNavigatorExtensions.NavigatorInstanceProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Extensions.Navigation // Navigation
{
    public static partial class NavigationExtensions
    {
        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Navigation.Request"/></summary>
        public static TTarget Navigation_Request<TTarget>(this TTarget target, string value) where TTarget : FrameworkElement
        { UnoExtensionsNavigation.UI.Navigation.SetRequest(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsNavigation.UI.Navigation.Request"/></summary>
        public static DependencyProperty<TTarget, string> Navigation_Request<TTarget>(this TTarget target) where TTarget : FrameworkElement
        => DependencyProperty<TTarget, string>.Get(target, UnoExtensionsNavigation.UI.Navigation.RequestProperty);

        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Navigation.Data"/></summary>
        public static TTarget Navigation_Data<TTarget>(this TTarget target, object? value) where TTarget : FrameworkElement
        { UnoExtensionsNavigation.UI.Navigation.SetData(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsNavigation.UI.Navigation.Data"/></summary>
        public static DependencyProperty<TTarget, object?> Navigation_Data<TTarget>(this TTarget target) where TTarget : FrameworkElement
        => DependencyProperty<TTarget, object?>.Get(target, UnoExtensionsNavigation.UI.Navigation.DataProperty);

        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Navigation"/> attached properties</summary>
        public static TTarget Navigation<TTarget>(this TTarget target

            , string Request = default

            , object? Data = default

        ) where TTarget : FrameworkElement
        {
            if (Request is not null) UnoExtensionsNavigation.UI.Navigation.SetRequest(target.UI, Request);

            if (Data is not null) UnoExtensionsNavigation.UI.Navigation.SetData(target.UI, Data);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Extensions.Navigation // Region
{
    public static partial class RegionExtensions
    {
        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Region.Instance"/></summary>
        public static TTarget Region_Instance<TTarget>(this TTarget target, UnoExtensionsNavigation.Regions.IRegion? value) where TTarget : DependencyObject
        { UnoExtensionsNavigation.UI.Region.SetInstance(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsNavigation.UI.Region.Instance"/></summary>
        public static DependencyProperty<TTarget, UnoExtensionsNavigation.Regions.IRegion?> Region_Instance<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, UnoExtensionsNavigation.Regions.IRegion?>.Get(target, UnoExtensionsNavigation.UI.Region.InstanceProperty);

        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Region.Attached"/></summary>
        public static TTarget Region_Attached<TTarget>(this TTarget target, bool value) where TTarget : DependencyObject
        { UnoExtensionsNavigation.UI.Region.SetAttached(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsNavigation.UI.Region.Attached"/></summary>
        public static DependencyProperty<TTarget, bool> Region_Attached<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, bool>.Get(target, UnoExtensionsNavigation.UI.Region.AttachedProperty);

        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Region.Parent"/></summary>
        public static TTarget Region_Parent<TTarget>(this TTarget target, Xaml.FrameworkElement value) where TTarget : DependencyObject
        { UnoExtensionsNavigation.UI.Region.SetParent(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsNavigation.UI.Region.Parent"/></summary>
        public static DependencyProperty<TTarget, Xaml.FrameworkElement> Region_Parent<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, Xaml.FrameworkElement>.Get(target, UnoExtensionsNavigation.UI.Region.ParentProperty);

        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Region.ServiceProvider"/></summary>
        public static TTarget Region_ServiceProvider<TTarget>(this TTarget target, IServiceProvider value) where TTarget : DependencyObject
        { UnoExtensionsNavigation.UI.Region.SetServiceProvider(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsNavigation.UI.Region.ServiceProvider"/></summary>
        public static DependencyProperty<TTarget, IServiceProvider> Region_ServiceProvider<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, IServiceProvider>.Get(target, UnoExtensionsNavigation.UI.Region.ServiceProviderProperty);

        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Region"/> attached properties</summary>
        public static TTarget Region<TTarget>(this TTarget target

            , UnoExtensionsNavigation.Regions.IRegion? Instance = default

            , bool? Attached = default

            , Xaml.FrameworkElement Parent = default

            , IServiceProvider ServiceProvider = default

        ) where TTarget : DependencyObject
        {
            if (Instance is not null) UnoExtensionsNavigation.UI.Region.SetInstance(target.UI, Instance);

            if (Attached is not null) UnoExtensionsNavigation.UI.Region.SetAttached(target.UI, Attached.Value);

            if (Parent is not null) UnoExtensionsNavigation.UI.Region.SetParent(target.UI, Parent);

            if (ServiceProvider is not null) UnoExtensionsNavigation.UI.Region.SetServiceProvider(target.UI, ServiceProvider);

            return target;
        }

        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Region.Name"/></summary>
        public static TTarget Region_Name<TTarget>(this TTarget target, string? value) where TTarget : FrameworkElement
        { UnoExtensionsNavigation.UI.Region.SetName(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsNavigation.UI.Region.Name"/></summary>
        public static DependencyProperty<TTarget, string?> Region_Name<TTarget>(this TTarget target) where TTarget : FrameworkElement
        => DependencyProperty<TTarget, string?>.Get(target, UnoExtensionsNavigation.UI.Region.NameProperty);

        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Region.Navigator"/></summary>
        public static TTarget Region_Navigator<TTarget>(this TTarget target, string value) where TTarget : FrameworkElement
        { UnoExtensionsNavigation.UI.Region.SetNavigator(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsNavigation.UI.Region.Navigator"/></summary>
        public static DependencyProperty<TTarget, string> Region_Navigator<TTarget>(this TTarget target) where TTarget : FrameworkElement
        => DependencyProperty<TTarget, string>.Get(target, UnoExtensionsNavigation.UI.Region.NavigatorProperty);

        /// <summary>Set <see cref="UnoExtensionsNavigation.UI.Region"/> attached properties</summary>
        public static TTarget Region<TTarget>(this TTarget target

            , string? Name = default

            , string Navigator = default

        ) where TTarget : FrameworkElement
        {
            if (Name is not null) UnoExtensionsNavigation.UI.Region.SetName(target.UI, Name);

            if (Navigator is not null) UnoExtensionsNavigation.UI.Region.SetNavigator(target.UI, Navigator);

            return target;
        }
    }
}

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
        public static FrameView FrameView(nint javaReference, Android.Runtime.JniHandleOwnership transfer)
        {
            var ui = new UnoExtensionsNavigation.UI.Controls.FrameView(javaReference, transfer);
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
