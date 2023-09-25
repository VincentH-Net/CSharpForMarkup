// Start of generated C# Markup API for Uno.WinUI
#if NET7_0_MACCATALYST && HAS_UNO && !WINDOWS_UWP

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Input;
using System.Runtime.Versioning;
using Microsoft;
using UI = Microsoft.UI;
using Collections = System.Collections;
using UnoToolkit = Uno.Toolkit;
using UnoToolkitUI = Uno.Toolkit.UI;
using Xaml = Microsoft.UI.Xaml;
using VirtualKey = Windows.System.VirtualKey;
using VirtualKeyModifiers = Windows.System.VirtualKeyModifiers;
using Drawing = System.Drawing;

namespace CSharpMarkup.WinUI.Uno.Toolkit // AutoLayout
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.AutoLayout"/></summary>
        public static AutoLayout AutoLayout(params Xaml.UIElement[] Children)
        {
            var ui = new UnoToolkitUI.AutoLayout();
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
            return CSharpMarkup.WinUI.Uno.Toolkit.AutoLayout.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.AutoLayout"/></summary>
        public static AutoLayout AutoLayout()
        {
            var ui = new UnoToolkitUI.AutoLayout();
            return CSharpMarkup.WinUI.Uno.Toolkit.AutoLayout.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.AutoLayout"/></summary>
        public static AutoLayout AutoLayout(nint handle)
        {
            var ui = new UnoToolkitUI.AutoLayout(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.AutoLayout.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.AutoLayout"/></summary>
        public static AutoLayout AutoLayout(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.AutoLayout(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.AutoLayout.StartChain(ui);
        }
    }

    public partial class AutoLayout : DependencyObject, IUI<UnoToolkitUI.AutoLayout>
    {
        static AutoLayout instance;

        internal static AutoLayout StartChain(UnoToolkitUI.AutoLayout ui)
        {
            if (instance == null) instance = new AutoLayout();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.AutoLayout ui;

        public new UnoToolkitUI.AutoLayout UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(AutoLayout view) => view?.UI;

        public static implicit operator UnoToolkitUI.AutoLayout(AutoLayout view) => view?.UI;

        public static implicit operator AutoLayout(UnoToolkitUI.AutoLayout ui) => AutoLayout.StartChain(ui);

        public AutoLayout Invoke(Action<UnoToolkitUI.AutoLayout> action) { action?.Invoke(UI); return this; }

        protected AutoLayout() { }
    }

    public static partial class AutoLayoutExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout.IsReverseZIndex"/></summary>
        public static TView IsReverseZIndex<TView>(this TView view, bool value) where TView : AutoLayout { view.UI.IsReverseZIndex = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout.Orientation"/></summary>
        public static TView Orientation<TView>(this TView view, Xaml.Controls.Orientation value) where TView : AutoLayout { view.UI.Orientation = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout.Spacing"/></summary>
        public static TView Spacing<TView>(this TView view, double value) where TView : AutoLayout { view.UI.Spacing = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout.Justify"/></summary>
        public static TView Justify<TView>(this TView view, UnoToolkitUI.AutoLayoutJustify value) where TView : AutoLayout { view.UI.Justify = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout.PrimaryAxisAlignment"/></summary>
        public static TView PrimaryAxisAlignment<TView>(this TView view, UnoToolkitUI.AutoLayoutAlignment value) where TView : AutoLayout { view.UI.PrimaryAxisAlignment = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.AutoLayout.IsReverseZIndex"/></summary>
        public static DependencyProperty<TTarget, bool> IsReverseZIndex<TTarget>(this TTarget target) where TTarget : AutoLayout
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.AutoLayout.IsReverseZIndexProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.AutoLayout.Orientation"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.Orientation> Orientation<TTarget>(this TTarget target) where TTarget : AutoLayout
        => DependencyProperty<TTarget, Xaml.Controls.Orientation>.Get(target, UnoToolkitUI.AutoLayout.OrientationProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.AutoLayout.Spacing"/></summary>
        public static DependencyProperty<TTarget, double> Spacing<TTarget>(this TTarget target) where TTarget : AutoLayout
        => DependencyProperty<TTarget, double>.Get(target, UnoToolkitUI.AutoLayout.SpacingProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.AutoLayout.Justify"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutJustify> Justify<TTarget>(this TTarget target) where TTarget : AutoLayout
        => DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutJustify>.Get(target, UnoToolkitUI.AutoLayout.JustifyProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.AutoLayout.PrimaryAxisAlignment"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment> PrimaryAxisAlignment<TTarget>(this TTarget target) where TTarget : AutoLayout
        => DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment>.Get(target, UnoToolkitUI.AutoLayout.PrimaryAxisAlignmentProperty);

        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout.PrimaryAlignment"/></summary>
        public static TTarget AutoLayout_PrimaryAlignment<TTarget>(this TTarget target, UnoToolkitUI.AutoLayoutPrimaryAlignment value) where TTarget : DependencyObject
        { UnoToolkitUI.AutoLayout.SetPrimaryAlignment(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.AutoLayout.PrimaryAlignment"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutPrimaryAlignment> AutoLayout_PrimaryAlignment<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutPrimaryAlignment>.Get(target, UnoToolkitUI.AutoLayout.PrimaryAlignmentProperty);

        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout.CounterAlignment"/></summary>
        public static TTarget AutoLayout_CounterAlignment<TTarget>(this TTarget target, UnoToolkitUI.AutoLayoutAlignment value) where TTarget : DependencyObject
        { UnoToolkitUI.AutoLayout.SetCounterAlignment(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.AutoLayout.CounterAlignment"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment> AutoLayout_CounterAlignment<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment>.Get(target, UnoToolkitUI.AutoLayout.CounterAlignmentProperty);

        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout.IsIndependentLayout"/></summary>
        public static TTarget AutoLayout_IsIndependentLayout<TTarget>(this TTarget target, bool value) where TTarget : DependencyObject
        { UnoToolkitUI.AutoLayout.SetIsIndependentLayout(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.AutoLayout.IsIndependentLayout"/></summary>
        public static DependencyProperty<TTarget, bool> AutoLayout_IsIndependentLayout<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.AutoLayout.IsIndependentLayoutProperty);

        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout.PrimaryLength"/></summary>
        public static TTarget AutoLayout_PrimaryLength<TTarget>(this TTarget target, double value) where TTarget : DependencyObject
        { UnoToolkitUI.AutoLayout.SetPrimaryLength(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.AutoLayout.PrimaryLength"/></summary>
        public static DependencyProperty<TTarget, double> AutoLayout_PrimaryLength<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, double>.Get(target, UnoToolkitUI.AutoLayout.PrimaryLengthProperty);

        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout.CounterLength"/></summary>
        public static TTarget AutoLayout_CounterLength<TTarget>(this TTarget target, double value) where TTarget : DependencyObject
        { UnoToolkitUI.AutoLayout.SetCounterLength(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.AutoLayout.CounterLength"/></summary>
        public static DependencyProperty<TTarget, double> AutoLayout_CounterLength<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, double>.Get(target, UnoToolkitUI.AutoLayout.CounterLengthProperty);

        /// <summary>Set <see cref="UnoToolkitUI.AutoLayout"/> attached properties</summary>
        public static TTarget AutoLayout<TTarget>(this TTarget target

            , UnoToolkitUI.AutoLayoutPrimaryAlignment? PrimaryAlignment = default

            , UnoToolkitUI.AutoLayoutAlignment? CounterAlignment = default

            , bool? IsIndependentLayout = default

            , double? PrimaryLength = default

            , double? CounterLength = default

        ) where TTarget : DependencyObject
        {
            if (PrimaryAlignment is not null) UnoToolkitUI.AutoLayout.SetPrimaryAlignment(target.UI, PrimaryAlignment.Value);

            if (CounterAlignment is not null) UnoToolkitUI.AutoLayout.SetCounterAlignment(target.UI, CounterAlignment.Value);

            if (IsIndependentLayout is not null) UnoToolkitUI.AutoLayout.SetIsIndependentLayout(target.UI, IsIndependentLayout.Value);

            if (PrimaryLength is not null) UnoToolkitUI.AutoLayout.SetPrimaryLength(target.UI, PrimaryLength.Value);

            if (CounterLength is not null) UnoToolkitUI.AutoLayout.SetCounterLength(target.UI, CounterLength.Value);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // CardContentControl
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.CardContentControl"/></summary>
        public static CardContentControl CardContentControl(UIObject Content)
        {
            var ui = new UnoToolkitUI.CardContentControl();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.CardContentControl.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.CardContentControl"/></summary>
        public static CardContentControl CardContentControl(double? Elevation = default, Windows.UI.Color? ShadowColor = default, bool? IsClickable = default, UIObject Content = default)
        {
            var ui = new UnoToolkitUI.CardContentControl();
            if (Elevation is not null) ui.Elevation = Elevation.Value;
            if (ShadowColor is not null) ui.ShadowColor = ShadowColor.Value;
            if (IsClickable is not null) ui.IsClickable = IsClickable.Value;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.CardContentControl.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.CardContentControl"/></summary>
        public static CardContentControl CardContentControl()
        {
            var ui = new UnoToolkitUI.CardContentControl();
            return CSharpMarkup.WinUI.Uno.Toolkit.CardContentControl.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.CardContentControl"/></summary>
        public static CardContentControl CardContentControl(nint handle)
        {
            var ui = new UnoToolkitUI.CardContentControl(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.CardContentControl.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.CardContentControl"/></summary>
        public static CardContentControl CardContentControl(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.CardContentControl(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.CardContentControl.StartChain(ui);
        }
    }

    public partial class CardContentControl : DependencyObject, IUI<UnoToolkitUI.CardContentControl>
    {
        static CardContentControl instance;

        internal static CardContentControl StartChain(UnoToolkitUI.CardContentControl ui)
        {
            if (instance == null) instance = new CardContentControl();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.CardContentControl ui;

        public new UnoToolkitUI.CardContentControl UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(CardContentControl view) => view?.UI;

        public static implicit operator UnoToolkitUI.CardContentControl(CardContentControl view) => view?.UI;

        public static implicit operator CardContentControl(UnoToolkitUI.CardContentControl ui) => CardContentControl.StartChain(ui);

        public CardContentControl Invoke(Action<UnoToolkitUI.CardContentControl> action) { action?.Invoke(UI); return this; }

        protected CardContentControl() { }
    }

    public static partial class CardContentControlExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.CardContentControl.Elevation"/></summary>
        public static TView Elevation<TView>(this TView view, double value) where TView : CardContentControl { view.UI.Elevation = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.CardContentControl.ShadowColor"/></summary>
        public static TView ShadowColor<TView>(this TView view, Windows.UI.Color value) where TView : CardContentControl { view.UI.ShadowColor = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.CardContentControl.IsClickable"/></summary>
        public static TView IsClickable<TView>(this TView view, bool value) where TView : CardContentControl { view.UI.IsClickable = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.CardContentControl.Elevation"/></summary>
        public static DependencyProperty<TTarget, double> Elevation<TTarget>(this TTarget target) where TTarget : CardContentControl
        => DependencyProperty<TTarget, double>.Get(target, UnoToolkitUI.CardContentControl.ElevationProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.CardContentControl.ShadowColor"/></summary>
        public static DependencyProperty<TTarget, Windows.UI.Color> ShadowColor<TTarget>(this TTarget target) where TTarget : CardContentControl
        => DependencyProperty<TTarget, Windows.UI.Color>.Get(target, UnoToolkitUI.CardContentControl.ShadowColorProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.CardContentControl.IsClickable"/></summary>
        public static DependencyProperty<TTarget, bool> IsClickable<TTarget>(this TTarget target) where TTarget : CardContentControl
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.CardContentControl.IsClickableProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // Card
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.Card"/></summary>
        public static Card Card(object HeaderContent = default, Xaml.DataTemplate HeaderContentTemplate = default, object SubHeaderContent = default, Xaml.DataTemplate SubHeaderContentTemplate = default, object AvatarContent = default, Xaml.DataTemplate AvatarContentTemplate = default, object MediaContent = default, Xaml.DataTemplate MediaContentTemplate = default, object SupportingContent = default, Xaml.DataTemplate SupportingContentTemplate = default, object IconsContent = default, Xaml.DataTemplate IconsContentTemplate = default, double? Elevation = default, Windows.UI.Color? ShadowColor = default, bool? IsClickable = default)
        {
            var ui = new UnoToolkitUI.Card();
            if (HeaderContent is not null) ui.HeaderContent = HeaderContent;
            if (HeaderContentTemplate is not null) ui.HeaderContentTemplate = HeaderContentTemplate;
            if (SubHeaderContent is not null) ui.SubHeaderContent = SubHeaderContent;
            if (SubHeaderContentTemplate is not null) ui.SubHeaderContentTemplate = SubHeaderContentTemplate;
            if (AvatarContent is not null) ui.AvatarContent = AvatarContent;
            if (AvatarContentTemplate is not null) ui.AvatarContentTemplate = AvatarContentTemplate;
            if (MediaContent is not null) ui.MediaContent = MediaContent;
            if (MediaContentTemplate is not null) ui.MediaContentTemplate = MediaContentTemplate;
            if (SupportingContent is not null) ui.SupportingContent = SupportingContent;
            if (SupportingContentTemplate is not null) ui.SupportingContentTemplate = SupportingContentTemplate;
            if (IconsContent is not null) ui.IconsContent = IconsContent;
            if (IconsContentTemplate is not null) ui.IconsContentTemplate = IconsContentTemplate;
            if (Elevation is not null) ui.Elevation = Elevation.Value;
            if (ShadowColor is not null) ui.ShadowColor = ShadowColor.Value;
            if (IsClickable is not null) ui.IsClickable = IsClickable.Value;
            return CSharpMarkup.WinUI.Uno.Toolkit.Card.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Card"/></summary>
        public static Card Card()
        {
            var ui = new UnoToolkitUI.Card();
            return CSharpMarkup.WinUI.Uno.Toolkit.Card.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Card"/></summary>
        public static Card Card(nint handle)
        {
            var ui = new UnoToolkitUI.Card(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.Card.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Card"/></summary>
        public static Card Card(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.Card(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.Card.StartChain(ui);
        }
    }

    public partial class Card : DependencyObject, IUI<UnoToolkitUI.Card>
    {
        static Card instance;

        internal static Card StartChain(UnoToolkitUI.Card ui)
        {
            if (instance == null) instance = new Card();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.Card ui;

        public new UnoToolkitUI.Card UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(Card view) => view?.UI;

        public static implicit operator UnoToolkitUI.Card(Card view) => view?.UI;

        public static implicit operator Card(UnoToolkitUI.Card ui) => Card.StartChain(ui);

        public Card Invoke(Action<UnoToolkitUI.Card> action) { action?.Invoke(UI); return this; }

        protected Card() { }
    }

    public static partial class CardExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.Card.HeaderContent"/></summary>
        public static TView HeaderContent<TView>(this TView view, object value) where TView : Card { view.UI.HeaderContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.HeaderContentTemplate"/></summary>
        public static TView HeaderContentTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : Card { view.UI.HeaderContentTemplate = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.SubHeaderContent"/></summary>
        public static TView SubHeaderContent<TView>(this TView view, object value) where TView : Card { view.UI.SubHeaderContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.SubHeaderContentTemplate"/></summary>
        public static TView SubHeaderContentTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : Card { view.UI.SubHeaderContentTemplate = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.AvatarContent"/></summary>
        public static TView AvatarContent<TView>(this TView view, object value) where TView : Card { view.UI.AvatarContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.AvatarContentTemplate"/></summary>
        public static TView AvatarContentTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : Card { view.UI.AvatarContentTemplate = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.MediaContent"/></summary>
        public static TView MediaContent<TView>(this TView view, object value) where TView : Card { view.UI.MediaContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.MediaContentTemplate"/></summary>
        public static TView MediaContentTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : Card { view.UI.MediaContentTemplate = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.SupportingContent"/></summary>
        public static TView SupportingContent<TView>(this TView view, object value) where TView : Card { view.UI.SupportingContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.SupportingContentTemplate"/></summary>
        public static TView SupportingContentTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : Card { view.UI.SupportingContentTemplate = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.IconsContent"/></summary>
        public static TView IconsContent<TView>(this TView view, object value) where TView : Card { view.UI.IconsContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.IconsContentTemplate"/></summary>
        public static TView IconsContentTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : Card { view.UI.IconsContentTemplate = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.Elevation"/></summary>
        public static TView Elevation<TView>(this TView view, double value) where TView : Card { view.UI.Elevation = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.ShadowColor"/></summary>
        public static TView ShadowColor<TView>(this TView view, Windows.UI.Color value) where TView : Card { view.UI.ShadowColor = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Card.IsClickable"/></summary>
        public static TView IsClickable<TView>(this TView view, bool value) where TView : Card { view.UI.IsClickable = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.HeaderContent"/></summary>
        public static DependencyProperty<TTarget, object> HeaderContent<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.Card.HeaderContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.HeaderContentTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> HeaderContentTemplate<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, UnoToolkitUI.Card.HeaderContentTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.SubHeaderContent"/></summary>
        public static DependencyProperty<TTarget, object> SubHeaderContent<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.Card.SubHeaderContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.SubHeaderContentTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> SubHeaderContentTemplate<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, UnoToolkitUI.Card.SubHeaderContentTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.AvatarContent"/></summary>
        public static DependencyProperty<TTarget, object> AvatarContent<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.Card.AvatarContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.AvatarContentTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> AvatarContentTemplate<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, UnoToolkitUI.Card.AvatarContentTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.MediaContent"/></summary>
        public static DependencyProperty<TTarget, object> MediaContent<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.Card.MediaContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.MediaContentTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> MediaContentTemplate<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, UnoToolkitUI.Card.MediaContentTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.SupportingContent"/></summary>
        public static DependencyProperty<TTarget, object> SupportingContent<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.Card.SupportingContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.SupportingContentTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> SupportingContentTemplate<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, UnoToolkitUI.Card.SupportingContentTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.IconsContent"/></summary>
        public static DependencyProperty<TTarget, object> IconsContent<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.Card.IconsContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.IconsContentTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> IconsContentTemplate<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, UnoToolkitUI.Card.IconsContentTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.Elevation"/></summary>
        public static DependencyProperty<TTarget, double> Elevation<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, double>.Get(target, UnoToolkitUI.Card.ElevationProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.ShadowColor"/></summary>
        public static DependencyProperty<TTarget, Windows.UI.Color> ShadowColor<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, Windows.UI.Color>.Get(target, UnoToolkitUI.Card.ShadowColorProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Card.IsClickable"/></summary>
        public static DependencyProperty<TTarget, bool> IsClickable<TTarget>(this TTarget target) where TTarget : Card
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.Card.IsClickableProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // Chip
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.Chip"/></summary>
        public static Chip Chip(UIObject Content)
        {
            var ui = new UnoToolkitUI.Chip();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.Chip.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Chip"/></summary>
        public static Chip Chip(bool? CanRemove = default, double? Elevation = default, object? Icon = default, Xaml.DataTemplate? IconTemplate = default, ICommand RemovedCommand = default, object RemovedCommandParameter = default, UIObject Content = default)
        {
            var ui = new UnoToolkitUI.Chip();
            if (CanRemove is not null) ui.CanRemove = CanRemove.Value;
            if (Elevation is not null) ui.Elevation = Elevation.Value;
            if (Icon is not null) ui.Icon = Icon;
            if (IconTemplate is not null) ui.IconTemplate = IconTemplate;
            if (RemovedCommand is not null) ui.RemovedCommand = RemovedCommand;
            if (RemovedCommandParameter is not null) ui.RemovedCommandParameter = RemovedCommandParameter;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.Chip.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Chip"/></summary>
        public static Chip Chip()
        {
            var ui = new UnoToolkitUI.Chip();
            return CSharpMarkup.WinUI.Uno.Toolkit.Chip.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Chip"/></summary>
        public static Chip Chip(nint handle)
        {
            var ui = new UnoToolkitUI.Chip(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.Chip.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Chip"/></summary>
        public static Chip Chip(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.Chip(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.Chip.StartChain(ui);
        }
    }

    public partial class Chip : DependencyObject, IUI<UnoToolkitUI.Chip>
    {
        static Chip instance;

        internal static Chip StartChain(UnoToolkitUI.Chip ui)
        {
            if (instance == null) instance = new Chip();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.Chip ui;

        public new UnoToolkitUI.Chip UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(Chip view) => view?.UI;

        public static implicit operator UnoToolkitUI.Chip(Chip view) => view?.UI;

        public static implicit operator Chip(UnoToolkitUI.Chip ui) => Chip.StartChain(ui);

        public Chip Invoke(Action<UnoToolkitUI.Chip> action) { action?.Invoke(UI); return this; }

        protected Chip() { }
    }

    public static partial class ChipExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.Chip.CanRemove"/></summary>
        public static TView CanRemove<TView>(this TView view, bool value) where TView : Chip { view.UI.CanRemove = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Chip.Elevation"/></summary>
        public static TView Elevation<TView>(this TView view, double value) where TView : Chip { view.UI.Elevation = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Chip.Icon"/></summary>
        public static TView Icon<TView>(this TView view, object? value) where TView : Chip { view.UI.Icon = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Chip.IconTemplate"/></summary>
        public static TView IconTemplate<TView>(this TView view, Xaml.DataTemplate? value) where TView : Chip { view.UI.IconTemplate = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Chip.RemovedCommand"/></summary>
        public static TView RemovedCommand<TView>(this TView view, ICommand value) where TView : Chip { view.UI.RemovedCommand = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Chip.RemovedCommandParameter"/></summary>
        public static TView RemovedCommandParameter<TView>(this TView view, object value) where TView : Chip { view.UI.RemovedCommandParameter = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Chip.CanRemove"/></summary>
        public static DependencyProperty<TTarget, bool> CanRemove<TTarget>(this TTarget target) where TTarget : Chip
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.Chip.CanRemoveProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Chip.Elevation"/></summary>
        public static DependencyProperty<TTarget, double> Elevation<TTarget>(this TTarget target) where TTarget : Chip
        => DependencyProperty<TTarget, double>.Get(target, UnoToolkitUI.Chip.ElevationProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Chip.Icon"/></summary>
        public static DependencyProperty<TTarget, object?> Icon<TTarget>(this TTarget target) where TTarget : Chip
        => DependencyProperty<TTarget, object?>.Get(target, UnoToolkitUI.Chip.IconProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Chip.IconTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate?> IconTemplate<TTarget>(this TTarget target) where TTarget : Chip
        => DependencyProperty<TTarget, Xaml.DataTemplate?>.Get(target, UnoToolkitUI.Chip.IconTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Chip.RemovedCommand"/></summary>
        public static DependencyProperty<TTarget, ICommand> RemovedCommand<TTarget>(this TTarget target) where TTarget : Chip
        => DependencyProperty<TTarget, ICommand>.Get(target, UnoToolkitUI.Chip.RemovedCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Chip.RemovedCommandParameter"/></summary>
        public static DependencyProperty<TTarget, object> RemovedCommandParameter<TTarget>(this TTarget target) where TTarget : Chip
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.Chip.RemovedCommandParameterProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // ChipGroup
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.ChipGroup"/></summary>
        public static ChipGroup ChipGroup(params UIObject[] Items)
        {
            var ui = new UnoToolkitUI.ChipGroup();
            for (int i = 0; i < Items.Length; i++)
            {
                var child = Items[i];
                if (child == null) continue;

                var subChildren = Spreader<UIObject>.ExtractChildren(child);
                if (subChildren is not null)
                    for (int j = 0; j < subChildren.Length; j++)
                        ui.Items.Add(subChildren[j].UI);
                else
                    ui.Items.Add(child.UI);
            }
            return CSharpMarkup.WinUI.Uno.Toolkit.ChipGroup.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.ChipGroup"/></summary>
        public static ChipGroup ChipGroup()
        {
            var ui = new UnoToolkitUI.ChipGroup();
            return CSharpMarkup.WinUI.Uno.Toolkit.ChipGroup.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.ChipGroup"/></summary>
        public static ChipGroup ChipGroup(nint handle)
        {
            var ui = new UnoToolkitUI.ChipGroup(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.ChipGroup.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.ChipGroup"/></summary>
        public static ChipGroup ChipGroup(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.ChipGroup(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.ChipGroup.StartChain(ui);
        }
    }

    public partial class ChipGroup : DependencyObject, IUI<UnoToolkitUI.ChipGroup>
    {
        static ChipGroup instance;

        internal static ChipGroup StartChain(UnoToolkitUI.ChipGroup ui)
        {
            if (instance == null) instance = new ChipGroup();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.ChipGroup ui;

        public new UnoToolkitUI.ChipGroup UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(ChipGroup view) => view?.UI;

        public static implicit operator UnoToolkitUI.ChipGroup(ChipGroup view) => view?.UI;

        public static implicit operator ChipGroup(UnoToolkitUI.ChipGroup ui) => ChipGroup.StartChain(ui);

        public ChipGroup Invoke(Action<UnoToolkitUI.ChipGroup> action) { action?.Invoke(UI); return this; }

        protected ChipGroup() { }
    }

    public static partial class ChipGroupExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.ChipGroup.CanRemove"/></summary>
        public static TView CanRemove<TView>(this TView view, bool value) where TView : ChipGroup { view.UI.CanRemove = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.ChipGroup.IconTemplate"/></summary>
        public static TView IconTemplate<TView>(this TView view, Xaml.DataTemplate? value) where TView : ChipGroup { view.UI.IconTemplate = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.ChipGroup.SelectedItem"/></summary>
        public static TView SelectedItem<TView>(this TView view, object? value) where TView : ChipGroup { view.UI.SelectedItem = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.ChipGroup.SelectedItems"/></summary>
        public static TView SelectedItems<TView>(this TView view, Collections.IList? value) where TView : ChipGroup { view.UI.SelectedItems = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.ChipGroup.SelectionMemberPath"/></summary>
        public static TView SelectionMemberPath<TView>(this TView view, string value) where TView : ChipGroup { view.UI.SelectionMemberPath = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.ChipGroup.SelectionMode"/></summary>
        public static TView SelectionMode<TView>(this TView view, UnoToolkitUI.ChipSelectionMode value) where TView : ChipGroup { view.UI.SelectionMode = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ChipGroup.CanRemove"/></summary>
        public static DependencyProperty<TTarget, bool> CanRemove<TTarget>(this TTarget target) where TTarget : ChipGroup
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.ChipGroup.CanRemoveProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ChipGroup.IconTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate?> IconTemplate<TTarget>(this TTarget target) where TTarget : ChipGroup
        => DependencyProperty<TTarget, Xaml.DataTemplate?>.Get(target, UnoToolkitUI.ChipGroup.IconTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ChipGroup.SelectedItem"/></summary>
        public static DependencyProperty<TTarget, object?> SelectedItem<TTarget>(this TTarget target) where TTarget : ChipGroup
        => DependencyProperty<TTarget, object?>.Get(target, UnoToolkitUI.ChipGroup.SelectedItemProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ChipGroup.SelectedItems"/></summary>
        public static DependencyProperty<TTarget, Collections.IList?> SelectedItems<TTarget>(this TTarget target) where TTarget : ChipGroup
        => DependencyProperty<TTarget, Collections.IList?>.Get(target, UnoToolkitUI.ChipGroup.SelectedItemsProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ChipGroup.SelectionMemberPath"/></summary>
        public static DependencyProperty<TTarget, string> SelectionMemberPath<TTarget>(this TTarget target) where TTarget : ChipGroup
        => DependencyProperty<TTarget, string>.Get(target, UnoToolkitUI.ChipGroup.SelectionMemberPathProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ChipGroup.SelectionMode"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.ChipSelectionMode> SelectionMode<TTarget>(this TTarget target) where TTarget : ChipGroup
        => DependencyProperty<TTarget, UnoToolkitUI.ChipSelectionMode>.Get(target, UnoToolkitUI.ChipGroup.SelectionModeProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // Divider
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.Divider"/></summary>
        public static Divider Divider(string SubHeader = default, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush? SubHeaderForeground = default)
        {
            var ui = new UnoToolkitUI.Divider();
            if (SubHeader is not null) ui.SubHeader = SubHeader;
            if (SubHeaderForeground is not null) ui.SubHeaderForeground = SubHeaderForeground.Value;
            return CSharpMarkup.WinUI.Uno.Toolkit.Divider.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Divider"/></summary>
        public static Divider Divider()
        {
            var ui = new UnoToolkitUI.Divider();
            return CSharpMarkup.WinUI.Uno.Toolkit.Divider.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Divider"/></summary>
        public static Divider Divider(nint handle)
        {
            var ui = new UnoToolkitUI.Divider(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.Divider.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Divider"/></summary>
        public static Divider Divider(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.Divider(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.Divider.StartChain(ui);
        }
    }

    public partial class Divider : DependencyObject, IUI<UnoToolkitUI.Divider>
    {
        static Divider instance;

        internal static Divider StartChain(UnoToolkitUI.Divider ui)
        {
            if (instance == null) instance = new Divider();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.Divider ui;

        public new UnoToolkitUI.Divider UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(Divider view) => view?.UI;

        public static implicit operator UnoToolkitUI.Divider(Divider view) => view?.UI;

        public static implicit operator Divider(UnoToolkitUI.Divider ui) => Divider.StartChain(ui);

        public Divider Invoke(Action<UnoToolkitUI.Divider> action) { action?.Invoke(UI); return this; }

        protected Divider() { }
    }

    public static partial class DividerExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.Divider.SubHeader"/></summary>
        public static TView SubHeader<TView>(this TView view, string value) where TView : Divider { view.UI.SubHeader = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Divider.SubHeaderForeground"/></summary>
        public static TView SubHeaderForeground<TView>(this TView view, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush value) where TView : Divider { view.UI.SubHeaderForeground = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Divider.SubHeader"/></summary>
        public static DependencyProperty<TTarget, string> SubHeader<TTarget>(this TTarget target) where TTarget : Divider
        => DependencyProperty<TTarget, string>.Get(target, UnoToolkitUI.Divider.SubHeaderProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Divider.SubHeaderForeground"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush> SubHeaderForeground<TTarget>(this TTarget target) where TTarget : Divider
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush>.Get(target, UnoToolkitUI.Divider.SubHeaderForegroundProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // DrawerControl
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.DrawerControl"/></summary>
        public static DrawerControl DrawerControl(UIObject Content)
        {
            var ui = new UnoToolkitUI.DrawerControl();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.DrawerControl.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.DrawerControl"/></summary>
        public static DrawerControl DrawerControl(object DrawerContent = default, double? DrawerDepth = default, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush? DrawerBackground = default, UnoToolkitUI.DrawerOpenDirection? OpenDirection = default, bool? IsOpen = default, bool? FitToDrawerContent = default, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush? LightDismissOverlayBackground = default, double? EdgeSwipeDetectionLength = default, bool? IsGestureEnabled = default, UIObject Content = default)
        {
            var ui = new UnoToolkitUI.DrawerControl();
            if (DrawerContent is not null) ui.DrawerContent = DrawerContent;
            if (DrawerDepth is not null) ui.DrawerDepth = DrawerDepth;
            if (DrawerBackground is not null) ui.DrawerBackground = DrawerBackground.Value;
            if (OpenDirection is not null) ui.OpenDirection = OpenDirection.Value;
            if (IsOpen is not null) ui.IsOpen = IsOpen.Value;
            if (FitToDrawerContent is not null) ui.FitToDrawerContent = FitToDrawerContent.Value;
            if (LightDismissOverlayBackground is not null) ui.LightDismissOverlayBackground = LightDismissOverlayBackground.Value;
            if (EdgeSwipeDetectionLength is not null) ui.EdgeSwipeDetectionLength = EdgeSwipeDetectionLength;
            if (IsGestureEnabled is not null) ui.IsGestureEnabled = IsGestureEnabled.Value;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.DrawerControl.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.DrawerControl"/></summary>
        public static DrawerControl DrawerControl()
        {
            var ui = new UnoToolkitUI.DrawerControl();
            return CSharpMarkup.WinUI.Uno.Toolkit.DrawerControl.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.DrawerControl"/></summary>
        public static DrawerControl DrawerControl(nint handle)
        {
            var ui = new UnoToolkitUI.DrawerControl(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.DrawerControl.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.DrawerControl"/></summary>
        public static DrawerControl DrawerControl(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.DrawerControl(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.DrawerControl.StartChain(ui);
        }
    }

    public partial class DrawerControl : DependencyObject, IUI<UnoToolkitUI.DrawerControl>
    {
        static DrawerControl instance;

        internal static DrawerControl StartChain(UnoToolkitUI.DrawerControl ui)
        {
            if (instance == null) instance = new DrawerControl();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.DrawerControl ui;

        public new UnoToolkitUI.DrawerControl UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(DrawerControl view) => view?.UI;

        public static implicit operator UnoToolkitUI.DrawerControl(DrawerControl view) => view?.UI;

        public static implicit operator DrawerControl(UnoToolkitUI.DrawerControl ui) => DrawerControl.StartChain(ui);

        public DrawerControl Invoke(Action<UnoToolkitUI.DrawerControl> action) { action?.Invoke(UI); return this; }

        protected DrawerControl() { }
    }

    public static partial class DrawerControlExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.DrawerContent"/></summary>
        public static TView DrawerContent<TView>(this TView view, object value) where TView : DrawerControl { view.UI.DrawerContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.DrawerDepth"/></summary>
        public static TView DrawerDepth<TView>(this TView view, double? value) where TView : DrawerControl { view.UI.DrawerDepth = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.DrawerBackground"/></summary>
        public static TView DrawerBackground<TView>(this TView view, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush value) where TView : DrawerControl { view.UI.DrawerBackground = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.OpenDirection"/></summary>
        public static TView OpenDirection<TView>(this TView view, UnoToolkitUI.DrawerOpenDirection value) where TView : DrawerControl { view.UI.OpenDirection = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.IsOpen"/></summary>
        public static TView IsOpen<TView>(this TView view, bool value) where TView : DrawerControl { view.UI.IsOpen = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.FitToDrawerContent"/></summary>
        public static TView FitToDrawerContent<TView>(this TView view, bool value) where TView : DrawerControl { view.UI.FitToDrawerContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.LightDismissOverlayBackground"/></summary>
        public static TView LightDismissOverlayBackground<TView>(this TView view, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush value) where TView : DrawerControl { view.UI.LightDismissOverlayBackground = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.EdgeSwipeDetectionLength"/></summary>
        public static TView EdgeSwipeDetectionLength<TView>(this TView view, double? value) where TView : DrawerControl { view.UI.EdgeSwipeDetectionLength = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.IsGestureEnabled"/></summary>
        public static TView IsGestureEnabled<TView>(this TView view, bool value) where TView : DrawerControl { view.UI.IsGestureEnabled = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControl.DrawerContent"/></summary>
        public static DependencyProperty<TTarget, object> DrawerContent<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.DrawerControl.DrawerContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControl.DrawerDepth"/></summary>
        public static DependencyProperty<TTarget, double?> DrawerDepth<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, double?>.Get(target, UnoToolkitUI.DrawerControl.DrawerDepthProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControl.DrawerBackground"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush> DrawerBackground<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush>.Get(target, UnoToolkitUI.DrawerControl.DrawerBackgroundProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControl.OpenDirection"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> OpenDirection<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection>.Get(target, UnoToolkitUI.DrawerControl.OpenDirectionProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControl.IsOpen"/></summary>
        public static DependencyProperty<TTarget, bool> IsOpen<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.DrawerControl.IsOpenProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControl.FitToDrawerContent"/></summary>
        public static DependencyProperty<TTarget, bool> FitToDrawerContent<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.DrawerControl.FitToDrawerContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControl.LightDismissOverlayBackground"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush> LightDismissOverlayBackground<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush>.Get(target, UnoToolkitUI.DrawerControl.LightDismissOverlayBackgroundProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControl.EdgeSwipeDetectionLength"/></summary>
        public static DependencyProperty<TTarget, double?> EdgeSwipeDetectionLength<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, double?>.Get(target, UnoToolkitUI.DrawerControl.EdgeSwipeDetectionLengthProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControl.IsGestureEnabled"/></summary>
        public static DependencyProperty<TTarget, bool> IsGestureEnabled<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.DrawerControl.IsGestureEnabledProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // DrawerFlyoutPresenter
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.DrawerFlyoutPresenter"/></summary>
        public static DrawerFlyoutPresenter DrawerFlyoutPresenter(UIObject Content)
        {
            var ui = new UnoToolkitUI.DrawerFlyoutPresenter();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.DrawerFlyoutPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.DrawerFlyoutPresenter"/></summary>
        public static DrawerFlyoutPresenter DrawerFlyoutPresenter(UnoToolkitUI.DrawerOpenDirection? OpenDirection = default, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush? LightDismissOverlayBackground = default, bool? IsGestureEnabled = default, UIObject Content = default)
        {
            var ui = new UnoToolkitUI.DrawerFlyoutPresenter();
            if (OpenDirection is not null) ui.OpenDirection = OpenDirection.Value;
            if (LightDismissOverlayBackground is not null) ui.LightDismissOverlayBackground = LightDismissOverlayBackground.Value;
            if (IsGestureEnabled is not null) ui.IsGestureEnabled = IsGestureEnabled.Value;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.DrawerFlyoutPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.DrawerFlyoutPresenter"/></summary>
        public static DrawerFlyoutPresenter DrawerFlyoutPresenter()
        {
            var ui = new UnoToolkitUI.DrawerFlyoutPresenter();
            return CSharpMarkup.WinUI.Uno.Toolkit.DrawerFlyoutPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.DrawerFlyoutPresenter"/></summary>
        public static DrawerFlyoutPresenter DrawerFlyoutPresenter(nint handle)
        {
            var ui = new UnoToolkitUI.DrawerFlyoutPresenter(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.DrawerFlyoutPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.DrawerFlyoutPresenter"/></summary>
        public static DrawerFlyoutPresenter DrawerFlyoutPresenter(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.DrawerFlyoutPresenter(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.DrawerFlyoutPresenter.StartChain(ui);
        }
    }

    public partial class DrawerFlyoutPresenter : DependencyObject, IUI<UnoToolkitUI.DrawerFlyoutPresenter>
    {
        static DrawerFlyoutPresenter instance;

        internal static DrawerFlyoutPresenter StartChain(UnoToolkitUI.DrawerFlyoutPresenter ui)
        {
            if (instance == null) instance = new DrawerFlyoutPresenter();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.DrawerFlyoutPresenter ui;

        public new UnoToolkitUI.DrawerFlyoutPresenter UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(DrawerFlyoutPresenter view) => view?.UI;

        public static implicit operator UnoToolkitUI.DrawerFlyoutPresenter(DrawerFlyoutPresenter view) => view?.UI;

        public static implicit operator DrawerFlyoutPresenter(UnoToolkitUI.DrawerFlyoutPresenter ui) => DrawerFlyoutPresenter.StartChain(ui);

        public DrawerFlyoutPresenter Invoke(Action<UnoToolkitUI.DrawerFlyoutPresenter> action) { action?.Invoke(UI); return this; }

        protected DrawerFlyoutPresenter() { }
    }

    public static partial class DrawerFlyoutPresenterExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter.OpenDirection"/></summary>
        public static TView OpenDirection<TView>(this TView view, UnoToolkitUI.DrawerOpenDirection value) where TView : DrawerFlyoutPresenter { view.UI.OpenDirection = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackground"/></summary>
        public static TView LightDismissOverlayBackground<TView>(this TView view, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush value) where TView : DrawerFlyoutPresenter { view.UI.LightDismissOverlayBackground = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter.IsGestureEnabled"/></summary>
        public static TView IsGestureEnabled<TView>(this TView view, bool value) where TView : DrawerFlyoutPresenter { view.UI.IsGestureEnabled = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerFlyoutPresenter.OpenDirection"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> OpenDirection<TTarget>(this TTarget target) where TTarget : DrawerFlyoutPresenter
        => DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection>.Get(target, UnoToolkitUI.DrawerFlyoutPresenter.OpenDirectionProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackground"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush> LightDismissOverlayBackground<TTarget>(this TTarget target) where TTarget : DrawerFlyoutPresenter
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush>.Get(target, UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackgroundProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerFlyoutPresenter.IsGestureEnabled"/></summary>
        public static DependencyProperty<TTarget, bool> IsGestureEnabled<TTarget>(this TTarget target) where TTarget : DrawerFlyoutPresenter
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.DrawerFlyoutPresenter.IsGestureEnabledProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter.OpenDirection"/></summary>
        public static TTarget DrawerFlyoutPresenter_OpenDirection<TTarget>(this TTarget target, UnoToolkitUI.DrawerOpenDirection value) where TTarget : DependencyObject
        { UnoToolkitUI.DrawerFlyoutPresenter.SetOpenDirection(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerFlyoutPresenter.OpenDirection"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> DrawerFlyoutPresenter_OpenDirection<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection>.Get(target, UnoToolkitUI.DrawerFlyoutPresenter.OpenDirectionProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackground"/></summary>
        public static TTarget DrawerFlyoutPresenter_LightDismissOverlayBackground<TTarget>(this TTarget target, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush value) where TTarget : DependencyObject
        { UnoToolkitUI.DrawerFlyoutPresenter.SetLightDismissOverlayBackground(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackground"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush> DrawerFlyoutPresenter_LightDismissOverlayBackground<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Brush>.Get(target, UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackgroundProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter.IsGestureEnabled"/></summary>
        public static TTarget DrawerFlyoutPresenter_IsGestureEnabled<TTarget>(this TTarget target, bool value) where TTarget : DependencyObject
        { UnoToolkitUI.DrawerFlyoutPresenter.SetIsGestureEnabled(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerFlyoutPresenter.IsGestureEnabled"/></summary>
        public static DependencyProperty<TTarget, bool> DrawerFlyoutPresenter_IsGestureEnabled<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.DrawerFlyoutPresenter.IsGestureEnabledProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter"/> attached properties</summary>
        public static TTarget DrawerFlyoutPresenter<TTarget>(this TTarget target

            , UnoToolkitUI.DrawerOpenDirection? OpenDirection = default

            , CSharpMarkup.WinUI.Uno.Toolkit.to.Brush? LightDismissOverlayBackground = default

            , bool? IsGestureEnabled = default

        ) where TTarget : DependencyObject
        {
            if (OpenDirection is not null) UnoToolkitUI.DrawerFlyoutPresenter.SetOpenDirection(target.UI, OpenDirection.Value);

            if (LightDismissOverlayBackground is not null) UnoToolkitUI.DrawerFlyoutPresenter.SetLightDismissOverlayBackground(target.UI, LightDismissOverlayBackground.Value);

            if (IsGestureEnabled is not null) UnoToolkitUI.DrawerFlyoutPresenter.SetIsGestureEnabled(target.UI, IsGestureEnabled.Value);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // ExtendedSplashScreen
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.ExtendedSplashScreen"/></summary>
        public static ExtendedSplashScreen ExtendedSplashScreen(UIObject Content)
        {
            var ui = new UnoToolkitUI.ExtendedSplashScreen();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.ExtendedSplashScreen.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.ExtendedSplashScreen"/></summary>
        public static ExtendedSplashScreen ExtendedSplashScreen(UnoToolkitUI.SplashScreenPlatform? Platforms = default, Windows.ApplicationModel.Activation.SplashScreen? SplashScreen = default, Xaml.Window? Window = default, UIObject Content = default)
        {
            var ui = new UnoToolkitUI.ExtendedSplashScreen();
            if (Platforms is not null) ui.Platforms = Platforms.Value;
            if (SplashScreen is not null) ui.SplashScreen = SplashScreen;
            if (Window is not null) ui.Window = Window;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.ExtendedSplashScreen.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.ExtendedSplashScreen"/></summary>
        public static ExtendedSplashScreen ExtendedSplashScreen()
        {
            var ui = new UnoToolkitUI.ExtendedSplashScreen();
            return CSharpMarkup.WinUI.Uno.Toolkit.ExtendedSplashScreen.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.ExtendedSplashScreen"/></summary>
        public static ExtendedSplashScreen ExtendedSplashScreen(nint handle)
        {
            var ui = new UnoToolkitUI.ExtendedSplashScreen(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.ExtendedSplashScreen.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.ExtendedSplashScreen"/></summary>
        public static ExtendedSplashScreen ExtendedSplashScreen(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.ExtendedSplashScreen(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.ExtendedSplashScreen.StartChain(ui);
        }
    }

    public partial class ExtendedSplashScreen : LoadingView, IUI<UnoToolkitUI.ExtendedSplashScreen>
    {
        static ExtendedSplashScreen instance;

        internal static ExtendedSplashScreen StartChain(UnoToolkitUI.ExtendedSplashScreen ui)
        {
            if (instance == null) instance = new ExtendedSplashScreen();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.ExtendedSplashScreen ui;

        public new UnoToolkitUI.ExtendedSplashScreen UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(ExtendedSplashScreen view) => view?.UI;

        public static implicit operator UnoToolkitUI.ExtendedSplashScreen(ExtendedSplashScreen view) => view?.UI;

        public static implicit operator ExtendedSplashScreen(UnoToolkitUI.ExtendedSplashScreen ui) => ExtendedSplashScreen.StartChain(ui);

        public ExtendedSplashScreen Invoke(Action<UnoToolkitUI.ExtendedSplashScreen> action) { action?.Invoke(UI); return this; }

        protected ExtendedSplashScreen() { }
    }

    public static partial class ExtendedSplashScreenExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.ExtendedSplashScreen.Platforms"/></summary>
        public static TView Platforms<TView>(this TView view, UnoToolkitUI.SplashScreenPlatform value) where TView : ExtendedSplashScreen { view.UI.Platforms = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.ExtendedSplashScreen.SplashScreen"/></summary>
        public static TView SplashScreen<TView>(this TView view, Windows.ApplicationModel.Activation.SplashScreen? value) where TView : ExtendedSplashScreen { view.UI.SplashScreen = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.ExtendedSplashScreen.Window"/></summary>
        public static TView Window<TView>(this TView view, Xaml.Window? value) where TView : ExtendedSplashScreen { view.UI.Window = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ExtendedSplashScreen.Platforms"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.SplashScreenPlatform> Platforms<TTarget>(this TTarget target) where TTarget : ExtendedSplashScreen
        => DependencyProperty<TTarget, UnoToolkitUI.SplashScreenPlatform>.Get(target, UnoToolkitUI.ExtendedSplashScreen.PlatformsProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // CompositeLoadableSource
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.CompositeLoadableSource"/></summary>
        public static CompositeLoadableSource CompositeLoadableSource(params UnoToolkit.ILoadable[] Sources)
        {
            var ui = new UnoToolkitUI.CompositeLoadableSource();
            for (int i = 0; i < Sources.Length; i++)
            {
                var child = Sources[i];
                if (child == null) continue;

                var subChildren = Spreader<UnoToolkit.ILoadable>.ExtractChildren(child);
                if (subChildren is not null)
                    for (int j = 0; j < subChildren.Length; j++)
                        ui.Sources.Add(subChildren[j]);
                else
                    ui.Sources.Add(child);
            }
            return CSharpMarkup.WinUI.Uno.Toolkit.CompositeLoadableSource.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.CompositeLoadableSource"/></summary>
        public static CompositeLoadableSource CompositeLoadableSource()
        {
            var ui = new UnoToolkitUI.CompositeLoadableSource();
            return CSharpMarkup.WinUI.Uno.Toolkit.CompositeLoadableSource.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.CompositeLoadableSource"/></summary>
        public static CompositeLoadableSource CompositeLoadableSource(nint handle)
        {
            var ui = new UnoToolkitUI.CompositeLoadableSource(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.CompositeLoadableSource.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.CompositeLoadableSource"/></summary>
        public static CompositeLoadableSource CompositeLoadableSource(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.CompositeLoadableSource(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.CompositeLoadableSource.StartChain(ui);
        }
    }

    public partial class CompositeLoadableSource : DependencyObject, IUI<UnoToolkitUI.CompositeLoadableSource>
    {
        static CompositeLoadableSource instance;

        internal static CompositeLoadableSource StartChain(UnoToolkitUI.CompositeLoadableSource ui)
        {
            if (instance == null) instance = new CompositeLoadableSource();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.CompositeLoadableSource ui;

        public new UnoToolkitUI.CompositeLoadableSource UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(CompositeLoadableSource view) => view?.UI;

        public static implicit operator UnoToolkitUI.CompositeLoadableSource(CompositeLoadableSource view) => view?.UI;

        public static implicit operator CompositeLoadableSource(UnoToolkitUI.CompositeLoadableSource ui) => CompositeLoadableSource.StartChain(ui);

        public CompositeLoadableSource Invoke(Action<UnoToolkitUI.CompositeLoadableSource> action) { action?.Invoke(UI); return this; }

        protected CompositeLoadableSource() { }
    }

    public static partial class CompositeLoadableSourceExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.CompositeLoadableSource.IsExecuting"/></summary>
        public static TView IsExecuting<TView>(this TView view, bool value) where TView : CompositeLoadableSource { view.UI.IsExecuting = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.CompositeLoadableSource.Sources"/></summary>
        public static DependencyProperty<TTarget, Collections.ObjectModel.ObservableCollection<UnoToolkit.ILoadable>> Sources<TTarget>(this TTarget target) where TTarget : CompositeLoadableSource
        => DependencyProperty<TTarget, Collections.ObjectModel.ObservableCollection<UnoToolkit.ILoadable>>.Get(target, UnoToolkitUI.CompositeLoadableSource.SourcesProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.CompositeLoadableSource.IsExecuting"/></summary>
        public static DependencyProperty<TTarget, bool> IsExecuting<TTarget>(this TTarget target) where TTarget : CompositeLoadableSource
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.CompositeLoadableSource.IsExecutingProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // LoadableSource
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.LoadableSource"/></summary>
        public static LoadableSource LoadableSource(UnoToolkit.ILoadable Source = default, bool? IsExecuting = default)
        {
            var ui = new UnoToolkitUI.LoadableSource();
            if (Source is not null) ui.Source = Source;
            if (IsExecuting is not null) ui.IsExecuting = IsExecuting.Value;
            return CSharpMarkup.WinUI.Uno.Toolkit.LoadableSource.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.LoadableSource"/></summary>
        public static LoadableSource LoadableSource()
        {
            var ui = new UnoToolkitUI.LoadableSource();
            return CSharpMarkup.WinUI.Uno.Toolkit.LoadableSource.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.LoadableSource"/></summary>
        public static LoadableSource LoadableSource(nint handle)
        {
            var ui = new UnoToolkitUI.LoadableSource(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.LoadableSource.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.LoadableSource"/></summary>
        public static LoadableSource LoadableSource(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.LoadableSource(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.LoadableSource.StartChain(ui);
        }
    }

    public partial class LoadableSource : DependencyObject, IUI<UnoToolkitUI.LoadableSource>
    {
        static LoadableSource instance;

        internal static LoadableSource StartChain(UnoToolkitUI.LoadableSource ui)
        {
            if (instance == null) instance = new LoadableSource();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.LoadableSource ui;

        public new UnoToolkitUI.LoadableSource UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(LoadableSource view) => view?.UI;

        public static implicit operator UnoToolkitUI.LoadableSource(LoadableSource view) => view?.UI;

        public static implicit operator LoadableSource(UnoToolkitUI.LoadableSource ui) => LoadableSource.StartChain(ui);

        public LoadableSource Invoke(Action<UnoToolkitUI.LoadableSource> action) { action?.Invoke(UI); return this; }

        protected LoadableSource() { }
    }

    public static partial class LoadableSourceExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.LoadableSource.Source"/></summary>
        public static TView Source<TView>(this TView view, UnoToolkit.ILoadable value) where TView : LoadableSource { view.UI.Source = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.LoadableSource.IsExecuting"/></summary>
        public static TView IsExecuting<TView>(this TView view, bool value) where TView : LoadableSource { view.UI.IsExecuting = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.LoadableSource.Source"/></summary>
        public static DependencyProperty<TTarget, UnoToolkit.ILoadable> Source<TTarget>(this TTarget target) where TTarget : LoadableSource
        => DependencyProperty<TTarget, UnoToolkit.ILoadable>.Get(target, UnoToolkitUI.LoadableSource.SourceProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.LoadableSource.IsExecuting"/></summary>
        public static DependencyProperty<TTarget, bool> IsExecuting<TTarget>(this TTarget target) where TTarget : LoadableSource
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.LoadableSource.IsExecutingProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // LoadingView
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.LoadingView"/></summary>
        public static LoadingView LoadingView(UIObject Content)
        {
            var ui = new UnoToolkitUI.LoadingView();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.LoadingView.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.LoadingView"/></summary>
        public static LoadingView LoadingView(bool? UseTransitions = default, UnoToolkit.ILoadable Source = default, object LoadingContent = default, Xaml.DataTemplate LoadingContentTemplate = default, Xaml.Controls.DataTemplateSelector LoadingContentTemplateSelector = default, UIObject Content = default)
        {
            var ui = new UnoToolkitUI.LoadingView();
            if (UseTransitions is not null) ui.UseTransitions = UseTransitions.Value;
            if (Source is not null) ui.Source = Source;
            if (LoadingContent is not null) ui.LoadingContent = LoadingContent;
            if (LoadingContentTemplate is not null) ui.LoadingContentTemplate = LoadingContentTemplate;
            if (LoadingContentTemplateSelector is not null) ui.LoadingContentTemplateSelector = LoadingContentTemplateSelector;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.LoadingView.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.LoadingView"/></summary>
        public static LoadingView LoadingView()
        {
            var ui = new UnoToolkitUI.LoadingView();
            return CSharpMarkup.WinUI.Uno.Toolkit.LoadingView.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.LoadingView"/></summary>
        public static LoadingView LoadingView(nint handle)
        {
            var ui = new UnoToolkitUI.LoadingView(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.LoadingView.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.LoadingView"/></summary>
        public static LoadingView LoadingView(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.LoadingView(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.LoadingView.StartChain(ui);
        }
    }

    public partial class LoadingView : DependencyObject, IUI<UnoToolkitUI.LoadingView>
    {
        static LoadingView instance;

        internal static LoadingView StartChain(UnoToolkitUI.LoadingView ui)
        {
            if (instance == null) instance = new LoadingView();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.LoadingView ui;

        public new UnoToolkitUI.LoadingView UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(LoadingView view) => view?.UI;

        public static implicit operator UnoToolkitUI.LoadingView(LoadingView view) => view?.UI;

        public static implicit operator LoadingView(UnoToolkitUI.LoadingView ui) => LoadingView.StartChain(ui);

        public LoadingView Invoke(Action<UnoToolkitUI.LoadingView> action) { action?.Invoke(UI); return this; }

        protected LoadingView() { }
    }

    public static partial class LoadingViewExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.LoadingView.UseTransitions"/></summary>
        public static TView UseTransitions<TView>(this TView view, bool value) where TView : LoadingView { view.UI.UseTransitions = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.LoadingView.Source"/></summary>
        public static TView Source<TView>(this TView view, UnoToolkit.ILoadable value) where TView : LoadingView { view.UI.Source = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.LoadingView.LoadingContent"/></summary>
        public static TView LoadingContent<TView>(this TView view, object value) where TView : LoadingView { view.UI.LoadingContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.LoadingView.LoadingContentTemplate"/></summary>
        public static TView LoadingContentTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : LoadingView { view.UI.LoadingContentTemplate = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.LoadingView.LoadingContentTemplateSelector"/></summary>
        public static TView LoadingContentTemplateSelector<TView>(this TView view, Xaml.Controls.DataTemplateSelector value) where TView : LoadingView { view.UI.LoadingContentTemplateSelector = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.LoadingView.UseTransitions"/></summary>
        public static DependencyProperty<TTarget, bool> UseTransitions<TTarget>(this TTarget target) where TTarget : LoadingView
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.LoadingView.UseTransitionsProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.LoadingView.Source"/></summary>
        public static DependencyProperty<TTarget, UnoToolkit.ILoadable> Source<TTarget>(this TTarget target) where TTarget : LoadingView
        => DependencyProperty<TTarget, UnoToolkit.ILoadable>.Get(target, UnoToolkitUI.LoadingView.SourceProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.LoadingView.LoadingContent"/></summary>
        public static DependencyProperty<TTarget, object> LoadingContent<TTarget>(this TTarget target) where TTarget : LoadingView
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.LoadingView.LoadingContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.LoadingView.LoadingContentTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> LoadingContentTemplate<TTarget>(this TTarget target) where TTarget : LoadingView
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, UnoToolkitUI.LoadingView.LoadingContentTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.LoadingView.LoadingContentTemplateSelector"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.DataTemplateSelector> LoadingContentTemplateSelector<TTarget>(this TTarget target) where TTarget : LoadingView
        => DependencyProperty<TTarget, Xaml.Controls.DataTemplateSelector>.Get(target, UnoToolkitUI.LoadingView.LoadingContentTemplateSelectorProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // NativeFramePresenter
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.NativeFramePresenter"/></summary>
        public static NativeFramePresenter NativeFramePresenter()
        {
            var ui = new UnoToolkitUI.NativeFramePresenter();
            return CSharpMarkup.WinUI.Uno.Toolkit.NativeFramePresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NativeFramePresenter"/></summary>
        public static NativeFramePresenter NativeFramePresenter(nint handle)
        {
            var ui = new UnoToolkitUI.NativeFramePresenter(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.NativeFramePresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NativeFramePresenter"/></summary>
        public static NativeFramePresenter NativeFramePresenter(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.NativeFramePresenter(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.NativeFramePresenter.StartChain(ui);
        }
    }

    public partial class NativeFramePresenter : DependencyObject, IUI<UnoToolkitUI.NativeFramePresenter>
    {
        static NativeFramePresenter instance;

        internal static NativeFramePresenter StartChain(UnoToolkitUI.NativeFramePresenter ui)
        {
            if (instance == null) instance = new NativeFramePresenter();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.NativeFramePresenter ui;

        public new UnoToolkitUI.NativeFramePresenter UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(NativeFramePresenter view) => view?.UI;

        public static implicit operator UnoToolkitUI.NativeFramePresenter(NativeFramePresenter view) => view?.UI;

        public static implicit operator NativeFramePresenter(UnoToolkitUI.NativeFramePresenter ui) => NativeFramePresenter.StartChain(ui);

        public NativeFramePresenter Invoke(Action<UnoToolkitUI.NativeFramePresenter> action) { action?.Invoke(UI); return this; }

        protected NativeFramePresenter() { }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // NativeNavigationBarPresenter
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.NativeNavigationBarPresenter"/></summary>
        public static NativeNavigationBarPresenter NativeNavigationBarPresenter(UIObject Content)
        {
            var ui = new UnoToolkitUI.NativeNavigationBarPresenter();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.NativeNavigationBarPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NativeNavigationBarPresenter"/></summary>
        public static NativeNavigationBarPresenter NativeNavigationBarPresenter()
        {
            var ui = new UnoToolkitUI.NativeNavigationBarPresenter();
            return CSharpMarkup.WinUI.Uno.Toolkit.NativeNavigationBarPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NativeNavigationBarPresenter"/></summary>
        public static NativeNavigationBarPresenter NativeNavigationBarPresenter(nint handle)
        {
            var ui = new UnoToolkitUI.NativeNavigationBarPresenter(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.NativeNavigationBarPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NativeNavigationBarPresenter"/></summary>
        public static NativeNavigationBarPresenter NativeNavigationBarPresenter(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.NativeNavigationBarPresenter(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.NativeNavigationBarPresenter.StartChain(ui);
        }
    }

    public partial class NativeNavigationBarPresenter : DependencyObject, IUI<UnoToolkitUI.NativeNavigationBarPresenter>
    {
        static NativeNavigationBarPresenter instance;

        internal static NativeNavigationBarPresenter StartChain(UnoToolkitUI.NativeNavigationBarPresenter ui)
        {
            if (instance == null) instance = new NativeNavigationBarPresenter();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.NativeNavigationBarPresenter ui;

        public new UnoToolkitUI.NativeNavigationBarPresenter UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(NativeNavigationBarPresenter view) => view?.UI;

        public static implicit operator UnoToolkitUI.NativeNavigationBarPresenter(NativeNavigationBarPresenter view) => view?.UI;

        public static implicit operator NativeNavigationBarPresenter(UnoToolkitUI.NativeNavigationBarPresenter ui) => NativeNavigationBarPresenter.StartChain(ui);

        public NativeNavigationBarPresenter Invoke(Action<UnoToolkitUI.NativeNavigationBarPresenter> action) { action?.Invoke(UI); return this; }

        protected NativeNavigationBarPresenter() { }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // NavigationBar
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBar"/></summary>
        public static NavigationBar NavigationBar(bool? IsSticky = default, bool? IsOpen = default, UnoToolkitUI.NavigationBarClosedDisplayMode? ClosedDisplayMode = default, Xaml.Controls.LightDismissOverlayMode? LightDismissOverlayMode = default, UnoToolkitUI.NavigationBarOverflowButtonVisibility? OverflowButtonVisibility = default, bool? IsDynamicOverflowEnabled = default, UnoToolkitUI.NavigationBarDefaultLabelPosition? DefaultLabelPosition = default, Xaml.Controls.AppBarButton MainCommand = default, UnoToolkitUI.MainCommandMode? MainCommandMode = default, string? Subtitle = default, Xaml.Style MainCommandStyle = default)
        {
            var ui = new UnoToolkitUI.NavigationBar();
            if (IsSticky is not null) ui.IsSticky = IsSticky.Value;
            if (IsOpen is not null) ui.IsOpen = IsOpen.Value;
            if (ClosedDisplayMode is not null) ui.ClosedDisplayMode = ClosedDisplayMode.Value;
            if (LightDismissOverlayMode is not null) ui.LightDismissOverlayMode = LightDismissOverlayMode.Value;
            if (OverflowButtonVisibility is not null) ui.OverflowButtonVisibility = OverflowButtonVisibility.Value;
            if (IsDynamicOverflowEnabled is not null) ui.IsDynamicOverflowEnabled = IsDynamicOverflowEnabled.Value;
            if (DefaultLabelPosition is not null) ui.DefaultLabelPosition = DefaultLabelPosition.Value;
            if (MainCommand is not null) ui.MainCommand = MainCommand;
            if (MainCommandMode is not null) ui.MainCommandMode = MainCommandMode.Value;
            if (Subtitle is not null) ui.Subtitle = Subtitle;
            if (MainCommandStyle is not null) ui.MainCommandStyle = MainCommandStyle;
            return CSharpMarkup.WinUI.Uno.Toolkit.NavigationBar.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBar"/></summary>
        public static NavigationBar NavigationBar()
        {
            var ui = new UnoToolkitUI.NavigationBar();
            return CSharpMarkup.WinUI.Uno.Toolkit.NavigationBar.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBar"/></summary>
        public static NavigationBar NavigationBar(nint handle)
        {
            var ui = new UnoToolkitUI.NavigationBar(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.NavigationBar.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBar"/></summary>
        public static NavigationBar NavigationBar(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.NavigationBar(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.NavigationBar.StartChain(ui);
        }
    }

    public partial class NavigationBar : DependencyObject, IUI<UnoToolkitUI.NavigationBar>
    {
        static NavigationBar instance;

        internal static NavigationBar StartChain(UnoToolkitUI.NavigationBar ui)
        {
            if (instance == null) instance = new NavigationBar();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.NavigationBar ui;

        public new UnoToolkitUI.NavigationBar UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(NavigationBar view) => view?.UI;

        public static implicit operator UnoToolkitUI.NavigationBar(NavigationBar view) => view?.UI;

        public static implicit operator NavigationBar(UnoToolkitUI.NavigationBar ui) => NavigationBar.StartChain(ui);

        public NavigationBar Invoke(Action<UnoToolkitUI.NavigationBar> action) { action?.Invoke(UI); return this; }

        protected NavigationBar() { }
    }

    public static partial class NavigationBarExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.IsSticky"/></summary>
        public static TView IsSticky<TView>(this TView view, bool value) where TView : NavigationBar { view.UI.IsSticky = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.IsOpen"/></summary>
        public static TView IsOpen<TView>(this TView view, bool value) where TView : NavigationBar { view.UI.IsOpen = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.ClosedDisplayMode"/></summary>
        public static TView ClosedDisplayMode<TView>(this TView view, UnoToolkitUI.NavigationBarClosedDisplayMode value) where TView : NavigationBar { view.UI.ClosedDisplayMode = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.LightDismissOverlayMode"/></summary>
        public static TView LightDismissOverlayMode<TView>(this TView view, Xaml.Controls.LightDismissOverlayMode value) where TView : NavigationBar { view.UI.LightDismissOverlayMode = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.OverflowButtonVisibility"/></summary>
        public static TView OverflowButtonVisibility<TView>(this TView view, UnoToolkitUI.NavigationBarOverflowButtonVisibility value) where TView : NavigationBar { view.UI.OverflowButtonVisibility = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.IsDynamicOverflowEnabled"/></summary>
        public static TView IsDynamicOverflowEnabled<TView>(this TView view, bool value) where TView : NavigationBar { view.UI.IsDynamicOverflowEnabled = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.DefaultLabelPosition"/></summary>
        public static TView DefaultLabelPosition<TView>(this TView view, UnoToolkitUI.NavigationBarDefaultLabelPosition value) where TView : NavigationBar { view.UI.DefaultLabelPosition = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.MainCommand"/></summary>
        public static TView MainCommand<TView>(this TView view, Xaml.Controls.AppBarButton value) where TView : NavigationBar { view.UI.MainCommand = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.MainCommandMode"/></summary>
        public static TView MainCommandMode<TView>(this TView view, UnoToolkitUI.MainCommandMode value) where TView : NavigationBar { view.UI.MainCommandMode = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.Subtitle"/></summary>
        public static TView Subtitle<TView>(this TView view, string? value) where TView : NavigationBar { view.UI.Subtitle = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBar.MainCommandStyle"/></summary>
        public static TView MainCommandStyle<TView>(this TView view, Xaml.Style value) where TView : NavigationBar { view.UI.MainCommandStyle = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.IsSticky"/></summary>
        public static DependencyProperty<TTarget, bool> IsSticky<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.NavigationBar.IsStickyProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.IsOpen"/></summary>
        public static DependencyProperty<TTarget, bool> IsOpen<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.NavigationBar.IsOpenProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.ClosedDisplayMode"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.NavigationBarClosedDisplayMode> ClosedDisplayMode<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, UnoToolkitUI.NavigationBarClosedDisplayMode>.Get(target, UnoToolkitUI.NavigationBar.ClosedDisplayModeProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.LightDismissOverlayMode"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.LightDismissOverlayMode> LightDismissOverlayMode<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, Xaml.Controls.LightDismissOverlayMode>.Get(target, UnoToolkitUI.NavigationBar.LightDismissOverlayModeProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.PrimaryCommands"/></summary>
        public static DependencyProperty<TTarget, Windows.Foundation.Collections.IObservableVector<Xaml.Controls.ICommandBarElement>> PrimaryCommands<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, Windows.Foundation.Collections.IObservableVector<Xaml.Controls.ICommandBarElement>>.Get(target, UnoToolkitUI.NavigationBar.PrimaryCommandsProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.SecondaryCommands"/></summary>
        public static DependencyProperty<TTarget, Windows.Foundation.Collections.IObservableVector<Xaml.Controls.ICommandBarElement>> SecondaryCommands<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, Windows.Foundation.Collections.IObservableVector<Xaml.Controls.ICommandBarElement>>.Get(target, UnoToolkitUI.NavigationBar.SecondaryCommandsProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.OverflowButtonVisibility"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.NavigationBarOverflowButtonVisibility> OverflowButtonVisibility<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, UnoToolkitUI.NavigationBarOverflowButtonVisibility>.Get(target, UnoToolkitUI.NavigationBar.OverflowButtonVisibilityProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.IsDynamicOverflowEnabled"/></summary>
        public static DependencyProperty<TTarget, bool> IsDynamicOverflowEnabled<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.NavigationBar.IsDynamicOverflowEnabledProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.DefaultLabelPosition"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.NavigationBarDefaultLabelPosition> DefaultLabelPosition<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, UnoToolkitUI.NavigationBarDefaultLabelPosition>.Get(target, UnoToolkitUI.NavigationBar.DefaultLabelPositionProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.MainCommand"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.AppBarButton> MainCommand<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, Xaml.Controls.AppBarButton>.Get(target, UnoToolkitUI.NavigationBar.MainCommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.MainCommandMode"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.MainCommandMode> MainCommandMode<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, UnoToolkitUI.MainCommandMode>.Get(target, UnoToolkitUI.NavigationBar.MainCommandModeProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.Subtitle"/></summary>
        public static DependencyProperty<TTarget, string?> Subtitle<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, string?>.Get(target, UnoToolkitUI.NavigationBar.SubtitleProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBar.MainCommandStyle"/></summary>
        public static DependencyProperty<TTarget, Xaml.Style> MainCommandStyle<TTarget>(this TTarget target) where TTarget : NavigationBar
        => DependencyProperty<TTarget, Xaml.Style>.Get(target, UnoToolkitUI.NavigationBar.MainCommandStyleProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // NavigationBarPresenter
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBarPresenter"/></summary>
        public static NavigationBarPresenter NavigationBarPresenter(object Content = default)
        {
            var ui = new UnoToolkitUI.NavigationBarPresenter();
            if (Content is not null) ui.Content = Content;
            return CSharpMarkup.WinUI.Uno.Toolkit.NavigationBarPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBarPresenter"/></summary>
        public static NavigationBarPresenter NavigationBarPresenter()
        {
            var ui = new UnoToolkitUI.NavigationBarPresenter();
            return CSharpMarkup.WinUI.Uno.Toolkit.NavigationBarPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBarPresenter"/></summary>
        public static NavigationBarPresenter NavigationBarPresenter(nint handle)
        {
            var ui = new UnoToolkitUI.NavigationBarPresenter(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.NavigationBarPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBarPresenter"/></summary>
        public static NavigationBarPresenter NavigationBarPresenter(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.NavigationBarPresenter(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.NavigationBarPresenter.StartChain(ui);
        }
    }

    public partial class NavigationBarPresenter : DependencyObject, IUI<UnoToolkitUI.NavigationBarPresenter>
    {
        static NavigationBarPresenter instance;

        internal static NavigationBarPresenter StartChain(UnoToolkitUI.NavigationBarPresenter ui)
        {
            if (instance == null) instance = new NavigationBarPresenter();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.NavigationBarPresenter ui;

        public new UnoToolkitUI.NavigationBarPresenter UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(NavigationBarPresenter view) => view?.UI;

        public static implicit operator UnoToolkitUI.NavigationBarPresenter(NavigationBarPresenter view) => view?.UI;

        public static implicit operator NavigationBarPresenter(UnoToolkitUI.NavigationBarPresenter ui) => NavigationBarPresenter.StartChain(ui);

        public NavigationBarPresenter Invoke(Action<UnoToolkitUI.NavigationBarPresenter> action) { action?.Invoke(UI); return this; }

        protected NavigationBarPresenter() { }
    }

    public static partial class NavigationBarPresenterExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.NavigationBarPresenter.Content"/></summary>
        public static TView Content<TView>(this TView view, object value) where TView : NavigationBarPresenter { view.UI.Content = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBarPresenter.Content"/></summary>
        public static DependencyProperty<TTarget, object> Content<TTarget>(this TTarget target) where TTarget : NavigationBarPresenter
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.NavigationBarPresenter.ContentProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // NavigationBarTemplateSettings
{
    public partial class NavigationBarTemplateSettings : DependencyObject, IUI<UnoToolkitUI.NavigationBarTemplateSettings>
    {
        UnoToolkitUI.NavigationBarTemplateSettings ui;

        public new UnoToolkitUI.NavigationBarTemplateSettings UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public NavigationBarTemplateSettings Invoke(Action<UnoToolkitUI.NavigationBarTemplateSettings> action) { action?.Invoke(UI); return this; }

        protected NavigationBarTemplateSettings() { }
    }

    public static partial class NavigationBarTemplateSettingsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.NavigationBarTemplateSettings.ContentHeight"/></summary>
        public static TView ContentHeight<TView>(this TView view, double value) where TView : NavigationBarTemplateSettings { view.UI.ContentHeight = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBarTemplateSettings.DataContext"/></summary>
        public static TView DataContext<TView>(this TView view, object value) where TView : NavigationBarTemplateSettings { view.UI.DataContext = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.NavigationBarTemplateSettings.TemplatedParent"/></summary>
        public static TView TemplatedParent<TView>(this TView view, Xaml.DependencyObject value) where TView : NavigationBarTemplateSettings { view.UI.TemplatedParent = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBarTemplateSettings.HiddenRootMargin"/></summary>
        public static DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Thickness> HiddenRootMargin<TTarget>(this TTarget target) where TTarget : NavigationBarTemplateSettings
        => DependencyProperty<TTarget, CSharpMarkup.WinUI.Uno.Toolkit.to.Thickness>.Get(target, UnoToolkitUI.NavigationBarTemplateSettings.HiddenRootMarginProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBarTemplateSettings.ContentHeight"/></summary>
        public static DependencyProperty<TTarget, double> ContentHeight<TTarget>(this TTarget target) where TTarget : NavigationBarTemplateSettings
        => DependencyProperty<TTarget, double>.Get(target, UnoToolkitUI.NavigationBarTemplateSettings.ContentHeightProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBarTemplateSettings.DataContext"/></summary>
        public static DependencyProperty<TTarget, object> DataContext<TTarget>(this TTarget target) where TTarget : NavigationBarTemplateSettings
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.NavigationBarTemplateSettings.DataContextProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBarTemplateSettings.TemplatedParent"/></summary>
        public static DependencyProperty<TTarget, Xaml.DependencyObject> TemplatedParent<TTarget>(this TTarget target) where TTarget : NavigationBarTemplateSettings
        => DependencyProperty<TTarget, Xaml.DependencyObject>.Get(target, UnoToolkitUI.NavigationBarTemplateSettings.TemplatedParentProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // SafeArea
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.SafeArea"/></summary>
        public static SafeArea SafeArea(UIObject Content)
        {
            var ui = new UnoToolkitUI.SafeArea();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.SafeArea.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.SafeArea"/></summary>
        public static SafeArea SafeArea()
        {
            var ui = new UnoToolkitUI.SafeArea();
            return CSharpMarkup.WinUI.Uno.Toolkit.SafeArea.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.SafeArea"/></summary>
        public static SafeArea SafeArea(nint handle)
        {
            var ui = new UnoToolkitUI.SafeArea(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.SafeArea.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.SafeArea"/></summary>
        public static SafeArea SafeArea(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.SafeArea(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.SafeArea.StartChain(ui);
        }
    }

    public partial class SafeArea : DependencyObject, IUI<UnoToolkitUI.SafeArea>
    {
        static SafeArea instance;

        internal static SafeArea StartChain(UnoToolkitUI.SafeArea ui)
        {
            if (instance == null) instance = new SafeArea();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.SafeArea ui;

        public new UnoToolkitUI.SafeArea UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(SafeArea view) => view?.UI;

        public static implicit operator UnoToolkitUI.SafeArea(SafeArea view) => view?.UI;

        public static implicit operator SafeArea(UnoToolkitUI.SafeArea ui) => SafeArea.StartChain(ui);

        public SafeArea Invoke(Action<UnoToolkitUI.SafeArea> action) { action?.Invoke(UI); return this; }

        protected SafeArea() { }
    }

    public static partial class SafeAreaExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.SafeArea.Insets"/></summary>
        public static TTarget SafeArea_Insets<TTarget>(this TTarget target, UnoToolkitUI.SafeArea.InsetMask value) where TTarget : DependencyObject
        { UnoToolkitUI.SafeArea.SetInsets(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.SafeArea.Insets"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMask> SafeArea_Insets<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMask>.Get(target, UnoToolkitUI.SafeArea.InsetsProperty);

        /// <summary>Set <see cref="UnoToolkitUI.SafeArea.Mode"/></summary>
        public static TTarget SafeArea_Mode<TTarget>(this TTarget target, UnoToolkitUI.SafeArea.InsetMode value) where TTarget : DependencyObject
        { UnoToolkitUI.SafeArea.SetMode(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.SafeArea.Mode"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMode> SafeArea_Mode<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMode>.Get(target, UnoToolkitUI.SafeArea.ModeProperty);

        /// <summary>Set <see cref="UnoToolkitUI.SafeArea"/> attached properties</summary>
        public static TTarget SafeArea<TTarget>(this TTarget target

            , UnoToolkitUI.SafeArea.InsetMask? Insets = default

            , UnoToolkitUI.SafeArea.InsetMode? Mode = default

        ) where TTarget : DependencyObject
        {
            if (Insets is not null) UnoToolkitUI.SafeArea.SetInsets(target.UI, Insets.Value);

            if (Mode is not null) UnoToolkitUI.SafeArea.SetMode(target.UI, Mode.Value);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // TabBar
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.TabBar"/></summary>
        public static TabBar TabBar(params UIObject[] Items)
        {
            var ui = new UnoToolkitUI.TabBar();
            for (int i = 0; i < Items.Length; i++)
            {
                var child = Items[i];
                if (child == null) continue;

                var subChildren = Spreader<UIObject>.ExtractChildren(child);
                if (subChildren is not null)
                    for (int j = 0; j < subChildren.Length; j++)
                        ui.Items.Add(subChildren[j].UI);
                else
                    ui.Items.Add(child.UI);
            }
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBar.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBar"/></summary>
        public static TabBar TabBar()
        {
            var ui = new UnoToolkitUI.TabBar();
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBar.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBar"/></summary>
        public static TabBar TabBar(nint handle)
        {
            var ui = new UnoToolkitUI.TabBar(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBar.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBar"/></summary>
        public static TabBar TabBar(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.TabBar(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBar.StartChain(ui);
        }
    }

    public partial class TabBar : DependencyObject, IUI<UnoToolkitUI.TabBar>
    {
        static TabBar instance;

        internal static TabBar StartChain(UnoToolkitUI.TabBar ui)
        {
            if (instance == null) instance = new TabBar();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.TabBar ui;

        public new UnoToolkitUI.TabBar UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TabBar view) => view?.UI;

        public static implicit operator UnoToolkitUI.TabBar(TabBar view) => view?.UI;

        public static implicit operator TabBar(UnoToolkitUI.TabBar ui) => TabBar.StartChain(ui);

        public TabBar Invoke(Action<UnoToolkitUI.TabBar> action) { action?.Invoke(UI); return this; }

        protected TabBar() { }
    }

    public static partial class TabBarExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.TabBar.SelectedItem"/></summary>
        public static TView SelectedItem<TView>(this TView view, object value) where TView : TabBar { view.UI.SelectedItem = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBar.SelectedIndex"/></summary>
        public static TView SelectedIndex<TView>(this TView view, int value) where TView : TabBar { view.UI.SelectedIndex = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBar.TemplateSettings"/></summary>
        public static TView TemplateSettings<TView>(this TView view, UnoToolkitUI.TabBarTemplateSettings value) where TView : TabBar { view.UI.TemplateSettings = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBar.Orientation"/></summary>
        public static TView Orientation<TView>(this TView view, Xaml.Controls.Orientation value) where TView : TabBar { view.UI.Orientation = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBar.SelectionIndicatorContent"/></summary>
        public static TView SelectionIndicatorContent<TView>(this TView view, object value) where TView : TabBar { view.UI.SelectionIndicatorContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBar.SelectionIndicatorContentTemplate"/></summary>
        public static TView SelectionIndicatorContentTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : TabBar { view.UI.SelectionIndicatorContentTemplate = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBar.SelectionIndicatorPresenterStyle"/></summary>
        public static TView SelectionIndicatorPresenterStyle<TView>(this TView view, Xaml.Style value) where TView : TabBar { view.UI.SelectionIndicatorPresenterStyle = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBar.SelectionIndicatorTransitionMode"/></summary>
        public static TView SelectionIndicatorTransitionMode<TView>(this TView view, UnoToolkitUI.IndicatorTransitionMode value) where TView : TabBar { view.UI.SelectionIndicatorTransitionMode = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBar.SelectionIndicatorPlacement"/></summary>
        public static TView SelectionIndicatorPlacement<TView>(this TView view, UnoToolkitUI.IndicatorPlacement value) where TView : TabBar { view.UI.SelectionIndicatorPlacement = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBar.SelectedItem"/></summary>
        public static DependencyProperty<TTarget, object> SelectedItem<TTarget>(this TTarget target) where TTarget : TabBar
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.TabBar.SelectedItemProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBar.SelectedIndex"/></summary>
        public static DependencyProperty<TTarget, int> SelectedIndex<TTarget>(this TTarget target) where TTarget : TabBar
        => DependencyProperty<TTarget, int>.Get(target, UnoToolkitUI.TabBar.SelectedIndexProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBar.TemplateSettings"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.TabBarTemplateSettings> TemplateSettings<TTarget>(this TTarget target) where TTarget : TabBar
        => DependencyProperty<TTarget, UnoToolkitUI.TabBarTemplateSettings>.Get(target, UnoToolkitUI.TabBar.TemplateSettingsProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBar.Orientation"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.Orientation> Orientation<TTarget>(this TTarget target) where TTarget : TabBar
        => DependencyProperty<TTarget, Xaml.Controls.Orientation>.Get(target, UnoToolkitUI.TabBar.OrientationProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBar.SelectionIndicatorContent"/></summary>
        public static DependencyProperty<TTarget, object> SelectionIndicatorContent<TTarget>(this TTarget target) where TTarget : TabBar
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.TabBar.SelectionIndicatorContentProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBar.SelectionIndicatorContentTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> SelectionIndicatorContentTemplate<TTarget>(this TTarget target) where TTarget : TabBar
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, UnoToolkitUI.TabBar.SelectionIndicatorContentTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBar.SelectionIndicatorPresenterStyle"/></summary>
        public static DependencyProperty<TTarget, Xaml.Style> SelectionIndicatorPresenterStyle<TTarget>(this TTarget target) where TTarget : TabBar
        => DependencyProperty<TTarget, Xaml.Style>.Get(target, UnoToolkitUI.TabBar.SelectionIndicatorPresenterStyleProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBar.SelectionIndicatorTransitionMode"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.IndicatorTransitionMode> SelectionIndicatorTransitionMode<TTarget>(this TTarget target) where TTarget : TabBar
        => DependencyProperty<TTarget, UnoToolkitUI.IndicatorTransitionMode>.Get(target, UnoToolkitUI.TabBar.SelectionIndicatorTransitionModeProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBar.SelectionIndicatorPlacement"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.IndicatorPlacement> SelectionIndicatorPlacement<TTarget>(this TTarget target) where TTarget : TabBar
        => DependencyProperty<TTarget, UnoToolkitUI.IndicatorPlacement>.Get(target, UnoToolkitUI.TabBar.SelectionIndicatorPlacementProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // TabBarItem
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.TabBarItem"/></summary>
        public static TabBarItem TabBarItem(UIObject Content)
        {
            var ui = new UnoToolkitUI.TabBarItem();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarItem.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarItem"/></summary>
        public static TabBarItem TabBarItem(Xaml.Controls.IconElement? Icon = default, Xaml.Visibility? BadgeVisibility = default, string? BadgeValue = default, bool? IsSelectable = default, Xaml.Controls.Primitives.FlyoutBase Flyout = default, ICommand Command = default, object CommandParameter = default, UIObject Content = default)
        {
            var ui = new UnoToolkitUI.TabBarItem();
            if (Icon is not null) ui.Icon = Icon;
            if (BadgeVisibility is not null) ui.BadgeVisibility = BadgeVisibility.Value;
            if (BadgeValue is not null) ui.BadgeValue = BadgeValue;
            if (IsSelectable is not null) ui.IsSelectable = IsSelectable.Value;
            if (Flyout is not null) ui.Flyout = Flyout;
            if (Command is not null) ui.Command = Command;
            if (CommandParameter is not null) ui.CommandParameter = CommandParameter;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarItem.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarItem"/></summary>
        public static TabBarItem TabBarItem()
        {
            var ui = new UnoToolkitUI.TabBarItem();
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarItem.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarItem"/></summary>
        public static TabBarItem TabBarItem(nint handle)
        {
            var ui = new UnoToolkitUI.TabBarItem(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarItem.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarItem"/></summary>
        public static TabBarItem TabBarItem(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.TabBarItem(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarItem.StartChain(ui);
        }
    }

    public partial class TabBarItem : DependencyObject, IUI<UnoToolkitUI.TabBarItem>
    {
        static TabBarItem instance;

        internal static TabBarItem StartChain(UnoToolkitUI.TabBarItem ui)
        {
            if (instance == null) instance = new TabBarItem();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.TabBarItem ui;

        public new UnoToolkitUI.TabBarItem UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TabBarItem view) => view?.UI;

        public static implicit operator UnoToolkitUI.TabBarItem(TabBarItem view) => view?.UI;

        public static implicit operator TabBarItem(UnoToolkitUI.TabBarItem ui) => TabBarItem.StartChain(ui);

        public TabBarItem Invoke(Action<UnoToolkitUI.TabBarItem> action) { action?.Invoke(UI); return this; }

        protected TabBarItem() { }
    }

    public static partial class TabBarItemExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.TabBarItem.Icon"/></summary>
        public static TView Icon<TView>(this TView view, Xaml.Controls.IconElement? value) where TView : TabBarItem { view.UI.Icon = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarItem.BadgeVisibility"/></summary>
        public static TView BadgeVisibility<TView>(this TView view, Xaml.Visibility value) where TView : TabBarItem { view.UI.BadgeVisibility = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarItem.BadgeValue"/></summary>
        public static TView BadgeValue<TView>(this TView view, string? value) where TView : TabBarItem { view.UI.BadgeValue = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarItem.IsSelectable"/></summary>
        public static TView IsSelectable<TView>(this TView view, bool value) where TView : TabBarItem { view.UI.IsSelectable = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarItem.Flyout"/></summary>
        public static TView Flyout<TView>(this TView view, Xaml.Controls.Primitives.FlyoutBase value) where TView : TabBarItem { view.UI.Flyout = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarItem.Command"/></summary>
        public static TView Command<TView>(this TView view, ICommand value) where TView : TabBarItem { view.UI.Command = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarItem.CommandParameter"/></summary>
        public static TView CommandParameter<TView>(this TView view, object value) where TView : TabBarItem { view.UI.CommandParameter = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarItem.IsSelectable"/></summary>
        public static DependencyProperty<TTarget, bool> IsSelectable<TTarget>(this TTarget target) where TTarget : TabBarItem
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.TabBarItem.IsSelectableProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarItem.Flyout"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.Primitives.FlyoutBase> Flyout<TTarget>(this TTarget target) where TTarget : TabBarItem
        => DependencyProperty<TTarget, Xaml.Controls.Primitives.FlyoutBase>.Get(target, UnoToolkitUI.TabBarItem.FlyoutProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarItem.Command"/></summary>
        public static DependencyProperty<TTarget, ICommand> Command<TTarget>(this TTarget target) where TTarget : TabBarItem
        => DependencyProperty<TTarget, ICommand>.Get(target, UnoToolkitUI.TabBarItem.CommandProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarItem.CommandParameter"/></summary>
        public static DependencyProperty<TTarget, object> CommandParameter<TTarget>(this TTarget target) where TTarget : TabBarItem
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.TabBarItem.CommandParameterProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarItem.Icon"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.IconElement?> Icon<TTarget>(this TTarget target) where TTarget : TabBarItem
        => DependencyProperty<TTarget, Xaml.Controls.IconElement?>.Get(target, UnoToolkitUI.TabBarItem.IconProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarItem.BadgeVisibility"/></summary>
        public static DependencyProperty<TTarget, Xaml.Visibility> BadgeVisibility<TTarget>(this TTarget target) where TTarget : TabBarItem
        => DependencyProperty<TTarget, Xaml.Visibility>.Get(target, UnoToolkitUI.TabBarItem.BadgeVisibilityProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarItem.BadgeValue"/></summary>
        public static DependencyProperty<TTarget, string?> BadgeValue<TTarget>(this TTarget target) where TTarget : TabBarItem
        => DependencyProperty<TTarget, string?>.Get(target, UnoToolkitUI.TabBarItem.BadgeValueProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // TabBarListPanel
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.TabBarListPanel"/></summary>
        public static TabBarListPanel TabBarListPanel(params Xaml.UIElement[] Children)
        {
            var ui = new UnoToolkitUI.TabBarListPanel();
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
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarListPanel.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarListPanel"/></summary>
        public static TabBarListPanel TabBarListPanel()
        {
            var ui = new UnoToolkitUI.TabBarListPanel();
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarListPanel.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarListPanel"/></summary>
        public static TabBarListPanel TabBarListPanel(nint handle)
        {
            var ui = new UnoToolkitUI.TabBarListPanel(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarListPanel.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarListPanel"/></summary>
        public static TabBarListPanel TabBarListPanel(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.TabBarListPanel(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarListPanel.StartChain(ui);
        }
    }

    public partial class TabBarListPanel : DependencyObject, IUI<UnoToolkitUI.TabBarListPanel>
    {
        static TabBarListPanel instance;

        internal static TabBarListPanel StartChain(UnoToolkitUI.TabBarListPanel ui)
        {
            if (instance == null) instance = new TabBarListPanel();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.TabBarListPanel ui;

        public new UnoToolkitUI.TabBarListPanel UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TabBarListPanel view) => view?.UI;

        public static implicit operator UnoToolkitUI.TabBarListPanel(TabBarListPanel view) => view?.UI;

        public static implicit operator TabBarListPanel(UnoToolkitUI.TabBarListPanel ui) => TabBarListPanel.StartChain(ui);

        public TabBarListPanel Invoke(Action<UnoToolkitUI.TabBarListPanel> action) { action?.Invoke(UI); return this; }

        protected TabBarListPanel() { }
    }

    public static partial class TabBarListPanelExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.TabBarListPanel.Orientation"/></summary>
        public static TView Orientation<TView>(this TView view, Xaml.Controls.Orientation value) where TView : TabBarListPanel { view.UI.Orientation = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarListPanel.Orientation"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.Orientation> Orientation<TTarget>(this TTarget target) where TTarget : TabBarListPanel
        => DependencyProperty<TTarget, Xaml.Controls.Orientation>.Get(target, UnoToolkitUI.TabBarListPanel.OrientationProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // TabBarSelectionIndicatorPresenter
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter"/></summary>
        public static TabBarSelectionIndicatorPresenter TabBarSelectionIndicatorPresenter(UIObject Content)
        {
            var ui = new UnoToolkitUI.TabBarSelectionIndicatorPresenter();
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarSelectionIndicatorPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter"/></summary>
        public static TabBarSelectionIndicatorPresenter TabBarSelectionIndicatorPresenter(UnoToolkitUI.TabBar Owner = default, UnoToolkitUI.IndicatorTransitionMode? IndicatorTransitionMode = default, UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings TemplateSettings = default, UIObject Content = default)
        {
            var ui = new UnoToolkitUI.TabBarSelectionIndicatorPresenter();
            if (Owner is not null) ui.Owner = Owner;
            if (IndicatorTransitionMode is not null) ui.IndicatorTransitionMode = IndicatorTransitionMode.Value;
            if (TemplateSettings is not null) ui.TemplateSettings = TemplateSettings;
            if (Content != null) ui.Content = Content.UI;
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarSelectionIndicatorPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter"/></summary>
        public static TabBarSelectionIndicatorPresenter TabBarSelectionIndicatorPresenter()
        {
            var ui = new UnoToolkitUI.TabBarSelectionIndicatorPresenter();
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarSelectionIndicatorPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter"/></summary>
        public static TabBarSelectionIndicatorPresenter TabBarSelectionIndicatorPresenter(nint handle)
        {
            var ui = new UnoToolkitUI.TabBarSelectionIndicatorPresenter(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarSelectionIndicatorPresenter.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter"/></summary>
        public static TabBarSelectionIndicatorPresenter TabBarSelectionIndicatorPresenter(ObjCRuntime.NativeHandle handle)
        {
            var ui = new UnoToolkitUI.TabBarSelectionIndicatorPresenter(handle);
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarSelectionIndicatorPresenter.StartChain(ui);
        }
    }

    public partial class TabBarSelectionIndicatorPresenter : DependencyObject, IUI<UnoToolkitUI.TabBarSelectionIndicatorPresenter>
    {
        static TabBarSelectionIndicatorPresenter instance;

        internal static TabBarSelectionIndicatorPresenter StartChain(UnoToolkitUI.TabBarSelectionIndicatorPresenter ui)
        {
            if (instance == null) instance = new TabBarSelectionIndicatorPresenter();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.TabBarSelectionIndicatorPresenter ui;

        public new UnoToolkitUI.TabBarSelectionIndicatorPresenter UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(TabBarSelectionIndicatorPresenter view) => view?.UI;

        public static implicit operator UnoToolkitUI.TabBarSelectionIndicatorPresenter(TabBarSelectionIndicatorPresenter view) => view?.UI;

        public static implicit operator TabBarSelectionIndicatorPresenter(UnoToolkitUI.TabBarSelectionIndicatorPresenter ui) => TabBarSelectionIndicatorPresenter.StartChain(ui);

        public TabBarSelectionIndicatorPresenter Invoke(Action<UnoToolkitUI.TabBarSelectionIndicatorPresenter> action) { action?.Invoke(UI); return this; }

        protected TabBarSelectionIndicatorPresenter() { }
    }

    public static partial class TabBarSelectionIndicatorPresenterExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter.Owner"/></summary>
        public static TView Owner<TView>(this TView view, UnoToolkitUI.TabBar value) where TView : TabBarSelectionIndicatorPresenter { view.UI.Owner = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter.IndicatorTransitionMode"/></summary>
        public static TView IndicatorTransitionMode<TView>(this TView view, UnoToolkitUI.IndicatorTransitionMode value) where TView : TabBarSelectionIndicatorPresenter { view.UI.IndicatorTransitionMode = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter.TemplateSettings"/></summary>
        public static TView TemplateSettings<TView>(this TView view, UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings value) where TView : TabBarSelectionIndicatorPresenter { view.UI.TemplateSettings = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter.Owner"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.TabBar> Owner<TTarget>(this TTarget target) where TTarget : TabBarSelectionIndicatorPresenter
        => DependencyProperty<TTarget, UnoToolkitUI.TabBar>.Get(target, UnoToolkitUI.TabBarSelectionIndicatorPresenter.OwnerProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter.IndicatorTransitionMode"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.IndicatorTransitionMode> IndicatorTransitionMode<TTarget>(this TTarget target) where TTarget : TabBarSelectionIndicatorPresenter
        => DependencyProperty<TTarget, UnoToolkitUI.IndicatorTransitionMode>.Get(target, UnoToolkitUI.TabBarSelectionIndicatorPresenter.IndicatorTransitionModeProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenter.TemplateSettings"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings> TemplateSettings<TTarget>(this TTarget target) where TTarget : TabBarSelectionIndicatorPresenter
        => DependencyProperty<TTarget, UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings>.Get(target, UnoToolkitUI.TabBarSelectionIndicatorPresenter.TemplateSettingsProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // TabBarSelectionIndicatorPresenterTemplateSettings
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings"/></summary>
        public static TabBarSelectionIndicatorPresenterTemplateSettings TabBarSelectionIndicatorPresenterTemplateSettings(Windows.Foundation.Point? IndicatorTransitionFrom = default, Windows.Foundation.Point? IndicatorTransitionTo = default, CSharpMarkup.WinUI.Uno.Toolkit.to.Size? IndicatorMaxSize = default, object DataContext = default, Xaml.DependencyObject TemplatedParent = default)
        {
            var ui = new UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings();
            if (IndicatorTransitionFrom is not null) ui.IndicatorTransitionFrom = IndicatorTransitionFrom.Value;
            if (IndicatorTransitionTo is not null) ui.IndicatorTransitionTo = IndicatorTransitionTo.Value;
            if (IndicatorMaxSize is not null) ui.IndicatorMaxSize = IndicatorMaxSize.Value;
            if (DataContext is not null) ui.DataContext = DataContext;
            if (TemplatedParent is not null) ui.TemplatedParent = TemplatedParent;
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarSelectionIndicatorPresenterTemplateSettings.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings"/></summary>
        public static TabBarSelectionIndicatorPresenterTemplateSettings TabBarSelectionIndicatorPresenterTemplateSettings()
        {
            var ui = new UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings();
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarSelectionIndicatorPresenterTemplateSettings.StartChain(ui);
        }
    }

    public partial class TabBarSelectionIndicatorPresenterTemplateSettings : DependencyObject, IUI<UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings>
    {
        static TabBarSelectionIndicatorPresenterTemplateSettings instance;

        internal static TabBarSelectionIndicatorPresenterTemplateSettings StartChain(UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings ui)
        {
            if (instance == null) instance = new TabBarSelectionIndicatorPresenterTemplateSettings();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings ui;

        public new UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings(TabBarSelectionIndicatorPresenterTemplateSettings view) => view?.UI;

        public static implicit operator TabBarSelectionIndicatorPresenterTemplateSettings(UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings ui) => TabBarSelectionIndicatorPresenterTemplateSettings.StartChain(ui);

        public TabBarSelectionIndicatorPresenterTemplateSettings Invoke(Action<UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings> action) { action?.Invoke(UI); return this; }

        protected TabBarSelectionIndicatorPresenterTemplateSettings() { }
    }

    public static partial class TabBarSelectionIndicatorPresenterTemplateSettingsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.IndicatorTransitionFrom"/></summary>
        public static TView IndicatorTransitionFrom<TView>(this TView view, Windows.Foundation.Point value) where TView : TabBarSelectionIndicatorPresenterTemplateSettings { view.UI.IndicatorTransitionFrom = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.IndicatorTransitionTo"/></summary>
        public static TView IndicatorTransitionTo<TView>(this TView view, Windows.Foundation.Point value) where TView : TabBarSelectionIndicatorPresenterTemplateSettings { view.UI.IndicatorTransitionTo = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.IndicatorMaxSize"/></summary>
        public static TView IndicatorMaxSize<TView>(this TView view, CSharpMarkup.WinUI.Uno.Toolkit.to.Size value) where TView : TabBarSelectionIndicatorPresenterTemplateSettings { view.UI.IndicatorMaxSize = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.DataContext"/></summary>
        public static TView DataContext<TView>(this TView view, object value) where TView : TabBarSelectionIndicatorPresenterTemplateSettings { view.UI.DataContext = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.TemplatedParent"/></summary>
        public static TView TemplatedParent<TView>(this TView view, Xaml.DependencyObject value) where TView : TabBarSelectionIndicatorPresenterTemplateSettings { view.UI.TemplatedParent = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.DataContext"/></summary>
        public static DependencyProperty<TTarget, object> DataContext<TTarget>(this TTarget target) where TTarget : TabBarSelectionIndicatorPresenterTemplateSettings
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.DataContextProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.TemplatedParent"/></summary>
        public static DependencyProperty<TTarget, Xaml.DependencyObject> TemplatedParent<TTarget>(this TTarget target) where TTarget : TabBarSelectionIndicatorPresenterTemplateSettings
        => DependencyProperty<TTarget, Xaml.DependencyObject>.Get(target, UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.TemplatedParentProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // TabBarTemplateSettings
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.TabBarTemplateSettings"/></summary>
        public static TabBarTemplateSettings TabBarTemplateSettings(CSharpMarkup.WinUI.Uno.Toolkit.to.Size? SelectionIndicatorMaxSize = default, object DataContext = default, Xaml.DependencyObject TemplatedParent = default)
        {
            var ui = new UnoToolkitUI.TabBarTemplateSettings();
            if (SelectionIndicatorMaxSize is not null) ui.SelectionIndicatorMaxSize = SelectionIndicatorMaxSize.Value;
            if (DataContext is not null) ui.DataContext = DataContext;
            if (TemplatedParent is not null) ui.TemplatedParent = TemplatedParent;
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarTemplateSettings.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.TabBarTemplateSettings"/></summary>
        public static TabBarTemplateSettings TabBarTemplateSettings()
        {
            var ui = new UnoToolkitUI.TabBarTemplateSettings();
            return CSharpMarkup.WinUI.Uno.Toolkit.TabBarTemplateSettings.StartChain(ui);
        }
    }

    public partial class TabBarTemplateSettings : DependencyObject, IUI<UnoToolkitUI.TabBarTemplateSettings>
    {
        static TabBarTemplateSettings instance;

        internal static TabBarTemplateSettings StartChain(UnoToolkitUI.TabBarTemplateSettings ui)
        {
            if (instance == null) instance = new TabBarTemplateSettings();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.TabBarTemplateSettings ui;

        public new UnoToolkitUI.TabBarTemplateSettings UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator UnoToolkitUI.TabBarTemplateSettings(TabBarTemplateSettings view) => view?.UI;

        public static implicit operator TabBarTemplateSettings(UnoToolkitUI.TabBarTemplateSettings ui) => TabBarTemplateSettings.StartChain(ui);

        public TabBarTemplateSettings Invoke(Action<UnoToolkitUI.TabBarTemplateSettings> action) { action?.Invoke(UI); return this; }

        protected TabBarTemplateSettings() { }
    }

    public static partial class TabBarTemplateSettingsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.TabBarTemplateSettings.SelectionIndicatorMaxSize"/></summary>
        public static TView SelectionIndicatorMaxSize<TView>(this TView view, CSharpMarkup.WinUI.Uno.Toolkit.to.Size value) where TView : TabBarTemplateSettings { view.UI.SelectionIndicatorMaxSize = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarTemplateSettings.DataContext"/></summary>
        public static TView DataContext<TView>(this TView view, object value) where TView : TabBarTemplateSettings { view.UI.DataContext = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarTemplateSettings.TemplatedParent"/></summary>
        public static TView TemplatedParent<TView>(this TView view, Xaml.DependencyObject value) where TView : TabBarTemplateSettings { view.UI.TemplatedParent = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarTemplateSettings.DataContext"/></summary>
        public static DependencyProperty<TTarget, object> DataContext<TTarget>(this TTarget target) where TTarget : TabBarTemplateSettings
        => DependencyProperty<TTarget, object>.Get(target, UnoToolkitUI.TabBarTemplateSettings.DataContextProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarTemplateSettings.TemplatedParent"/></summary>
        public static DependencyProperty<TTarget, Xaml.DependencyObject> TemplatedParent<TTarget>(this TTarget target) where TTarget : TabBarTemplateSettings
        => DependencyProperty<TTarget, Xaml.DependencyObject>.Get(target, UnoToolkitUI.TabBarTemplateSettings.TemplatedParentProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // ToolkitResources
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.ToolkitResources"/></summary>
        public static ToolkitResources ToolkitResources()
        {
            var ui = new UnoToolkitUI.ToolkitResources();
            return CSharpMarkup.WinUI.Uno.Toolkit.ToolkitResources.StartChain(ui);
        }
    }

    public partial class ToolkitResources : DependencyObject, IUI<UnoToolkitUI.ToolkitResources>
    {
        static ToolkitResources instance;

        internal static ToolkitResources StartChain(UnoToolkitUI.ToolkitResources ui)
        {
            if (instance == null) instance = new ToolkitResources();
            instance.UI = ui;
            return instance;
        }

        UnoToolkitUI.ToolkitResources ui;

        public new UnoToolkitUI.ToolkitResources UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator UnoToolkitUI.ToolkitResources(ToolkitResources view) => view?.UI;

        public static implicit operator ToolkitResources(UnoToolkitUI.ToolkitResources ui) => ToolkitResources.StartChain(ui);

        public ToolkitResources Invoke(Action<UnoToolkitUI.ToolkitResources> action) { action?.Invoke(UI); return this; }

        protected ToolkitResources() { }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit.to // Type convertors
{
    readonly public partial struct Brush
    {
        readonly Xaml.Media.Brush value;

        public Brush(Xaml.Media.Brush value) => this.value = value;

        public static implicit operator Xaml.Media.Brush(Brush value) => value.value;
        public static implicit operator Brush(Xaml.Media.Brush value) => new(value);
    }

    partial struct Brush
    {
        static Xaml.Media.BrushConverter fromStringconverter;
        static Xaml.Media.BrushConverter FromStringConverter => fromStringconverter ??= new();

        public static implicit operator Brush(string value) => (Xaml.Media.Brush)Brush.FromStringConverter.ConvertFromInvariantString(value);
    }

    readonly public partial struct Thickness
    {
        readonly Xaml.Thickness value;

        public Thickness(Xaml.Thickness value) => this.value = value;

        public static implicit operator Xaml.Thickness(Thickness value) => value.value;
        public static implicit operator Thickness(Xaml.Thickness value) => new(value);
    }

    partial struct Thickness
    {
        static Xaml.ThicknessConverter fromStringconverter;
        static Xaml.ThicknessConverter FromStringConverter => fromStringconverter ??= new();

        public static implicit operator Thickness(string value) => (Xaml.Thickness)Thickness.FromStringConverter.ConvertFromInvariantString(value);
    }

    readonly public partial struct Size
    {
        readonly Windows.Foundation.Size value;

        public Size(Windows.Foundation.Size value) => this.value = value;

        public static implicit operator Windows.Foundation.Size(Size value) => value.value;
        public static implicit operator Size(Windows.Foundation.Size value) => new(value);
    }

    partial struct Size
    {
        static Windows.Foundation.SizeConverter fromStringconverter;
        static Windows.Foundation.SizeConverter FromStringConverter => fromStringconverter ??= new();

        public static implicit operator Size(string value) => (Windows.Foundation.Size)Size.FromStringConverter.ConvertFromInvariantString(value);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // EnumPropertyValues
{
    public static partial class AutoLayoutExtensions
    {
        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutAlignment.Start"/></summary>
        public static TTarget Start<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment> property) where TTarget : AutoLayout
        => property.Set(UnoToolkitUI.AutoLayoutAlignment.Start);

        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutAlignment.Center"/></summary>
        public static TTarget Center<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment> property) where TTarget : AutoLayout
        => property.Set(UnoToolkitUI.AutoLayoutAlignment.Center);

        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutAlignment.End"/></summary>
        public static TTarget End<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment> property) where TTarget : AutoLayout
        => property.Set(UnoToolkitUI.AutoLayoutAlignment.End);

        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutAlignment.Stretch"/></summary>
        public static TTarget Stretch<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment> property) where TTarget : AutoLayout
        => property.Set(UnoToolkitUI.AutoLayoutAlignment.Stretch);

        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutJustify.Stack"/></summary>
        public static TTarget Stack<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutJustify> property) where TTarget : AutoLayout
        => property.Set(UnoToolkitUI.AutoLayoutJustify.Stack);

        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutJustify.SpaceBetween"/></summary>
        public static TTarget SpaceBetween<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutJustify> property) where TTarget : AutoLayout
        => property.Set(UnoToolkitUI.AutoLayoutJustify.SpaceBetween);

        /// <summary>Set to <see cref="Xaml.Controls.Orientation.Vertical"/></summary>
        public static TTarget Vertical<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.Orientation> property) where TTarget : AutoLayout
        => property.Set(Xaml.Controls.Orientation.Vertical);

        /// <summary>Set to <see cref="Xaml.Controls.Orientation.Horizontal"/></summary>
        public static TTarget Horizontal<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.Orientation> property) where TTarget : AutoLayout
        => property.Set(Xaml.Controls.Orientation.Horizontal);
    }

    public static partial class ChipGroupExtensions
    {
        /// <summary>Set to <see cref="UnoToolkitUI.ChipSelectionMode.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.ChipSelectionMode> property) where TTarget : ChipGroup
        => property.Set(UnoToolkitUI.ChipSelectionMode.None);

        /// <summary>Set to <see cref="UnoToolkitUI.ChipSelectionMode.SingleOrNone"/></summary>
        public static TTarget SingleOrNone<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.ChipSelectionMode> property) where TTarget : ChipGroup
        => property.Set(UnoToolkitUI.ChipSelectionMode.SingleOrNone);

        /// <summary>Set to <see cref="UnoToolkitUI.ChipSelectionMode.Single"/></summary>
        public static TTarget Single<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.ChipSelectionMode> property) where TTarget : ChipGroup
        => property.Set(UnoToolkitUI.ChipSelectionMode.Single);

        /// <summary>Set to <see cref="UnoToolkitUI.ChipSelectionMode.Multiple"/></summary>
        public static TTarget Multiple<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.ChipSelectionMode> property) where TTarget : ChipGroup
        => property.Set(UnoToolkitUI.ChipSelectionMode.Multiple);
    }

    public static partial class DependencyObjectExtensions
    {
        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutAlignment.Start"/></summary>
        public static TTarget Start<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.AutoLayoutAlignment.Start);

        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutAlignment.Center"/></summary>
        public static TTarget Center<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.AutoLayoutAlignment.Center);

        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutAlignment.End"/></summary>
        public static TTarget End<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.AutoLayoutAlignment.End);

        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutAlignment.Stretch"/></summary>
        public static TTarget Stretch<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutAlignment> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.AutoLayoutAlignment.Stretch);

        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutPrimaryAlignment.Auto"/></summary>
        public static TTarget Auto<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutPrimaryAlignment> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.AutoLayoutPrimaryAlignment.Auto);

        /// <summary>Set to <see cref="UnoToolkitUI.AutoLayoutPrimaryAlignment.Stretch"/></summary>
        public static TTarget Stretch<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.AutoLayoutPrimaryAlignment> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.AutoLayoutPrimaryAlignment.Stretch);

        /// <summary>Set to <see cref="UnoToolkitUI.SafeArea.InsetMask.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMask> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.SafeArea.InsetMask.None);

        /// <summary>Set to <see cref="UnoToolkitUI.SafeArea.InsetMask.Top"/></summary>
        public static TTarget Top<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMask> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.SafeArea.InsetMask.Top);

        /// <summary>Set to <see cref="UnoToolkitUI.SafeArea.InsetMask.Bottom"/></summary>
        public static TTarget Bottom<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMask> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.SafeArea.InsetMask.Bottom);

        /// <summary>Set to <see cref="UnoToolkitUI.SafeArea.InsetMask.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMask> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.SafeArea.InsetMask.Left);

        /// <summary>Set to <see cref="UnoToolkitUI.SafeArea.InsetMask.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMask> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.SafeArea.InsetMask.Right);

        /// <summary>Set to <see cref="UnoToolkitUI.SafeArea.InsetMask.SoftInput"/></summary>
        public static TTarget SoftInput<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMask> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.SafeArea.InsetMask.SoftInput);

        /// <summary>Set to <see cref="UnoToolkitUI.SafeArea.InsetMask.VisibleBounds"/></summary>
        public static TTarget VisibleBounds<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMask> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.SafeArea.InsetMask.VisibleBounds);

        /// <summary>Set to <see cref="UnoToolkitUI.SafeArea.InsetMask.All"/></summary>
        public static TTarget All<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMask> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.SafeArea.InsetMask.All);

        /// <summary>Set to <see cref="UnoToolkitUI.SafeArea.InsetMode.Padding"/></summary>
        public static TTarget Padding<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMode> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.SafeArea.InsetMode.Padding);

        /// <summary>Set to <see cref="UnoToolkitUI.SafeArea.InsetMode.Margin"/></summary>
        public static TTarget Margin<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SafeArea.InsetMode> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.SafeArea.InsetMode.Margin);

        /// <summary>Set to <see cref="UnoToolkitUI.DrawerOpenDirection.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.DrawerOpenDirection.Right);

        /// <summary>Set to <see cref="UnoToolkitUI.DrawerOpenDirection.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.DrawerOpenDirection.Left);

        /// <summary>Set to <see cref="UnoToolkitUI.DrawerOpenDirection.Down"/></summary>
        public static TTarget Down<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.DrawerOpenDirection.Down);

        /// <summary>Set to <see cref="UnoToolkitUI.DrawerOpenDirection.Up"/></summary>
        public static TTarget Up<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> property) where TTarget : DependencyObject
        => property.Set(UnoToolkitUI.DrawerOpenDirection.Up);
    }

    public static partial class DrawerControlExtensions
    {
        /// <summary>Set to <see cref="UnoToolkitUI.DrawerOpenDirection.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> property) where TTarget : DrawerControl
        => property.Set(UnoToolkitUI.DrawerOpenDirection.Right);

        /// <summary>Set to <see cref="UnoToolkitUI.DrawerOpenDirection.Left"/></summary>
        public static TTarget Left<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> property) where TTarget : DrawerControl
        => property.Set(UnoToolkitUI.DrawerOpenDirection.Left);

        /// <summary>Set to <see cref="UnoToolkitUI.DrawerOpenDirection.Down"/></summary>
        public static TTarget Down<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> property) where TTarget : DrawerControl
        => property.Set(UnoToolkitUI.DrawerOpenDirection.Down);

        /// <summary>Set to <see cref="UnoToolkitUI.DrawerOpenDirection.Up"/></summary>
        public static TTarget Up<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> property) where TTarget : DrawerControl
        => property.Set(UnoToolkitUI.DrawerOpenDirection.Up);
    }

    public static partial class ExtendedSplashScreenExtensions
    {
        /// <summary>Set to <see cref="UnoToolkitUI.SplashScreenPlatform.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SplashScreenPlatform> property) where TTarget : ExtendedSplashScreen
        => property.Set(UnoToolkitUI.SplashScreenPlatform.None);

        /// <summary>Set to <see cref="UnoToolkitUI.SplashScreenPlatform.Android"/></summary>
        public static TTarget Android<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SplashScreenPlatform> property) where TTarget : ExtendedSplashScreen
        => property.Set(UnoToolkitUI.SplashScreenPlatform.Android);

        /// <summary>Set to <see cref="UnoToolkitUI.SplashScreenPlatform.iOS"/></summary>
        public static TTarget iOS<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SplashScreenPlatform> property) where TTarget : ExtendedSplashScreen
        => property.Set(UnoToolkitUI.SplashScreenPlatform.iOS);

        /// <summary>Set to <see cref="UnoToolkitUI.SplashScreenPlatform.Windows"/></summary>
        public static TTarget Windows<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SplashScreenPlatform> property) where TTarget : ExtendedSplashScreen
        => property.Set(UnoToolkitUI.SplashScreenPlatform.Windows);

        /// <summary>Set to <see cref="UnoToolkitUI.SplashScreenPlatform.WebAssembly"/></summary>
        public static TTarget WebAssembly<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SplashScreenPlatform> property) where TTarget : ExtendedSplashScreen
        => property.Set(UnoToolkitUI.SplashScreenPlatform.WebAssembly);

        /// <summary>Set to <see cref="UnoToolkitUI.SplashScreenPlatform.Skia"/></summary>
        public static TTarget Skia<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SplashScreenPlatform> property) where TTarget : ExtendedSplashScreen
        => property.Set(UnoToolkitUI.SplashScreenPlatform.Skia);

        /// <summary>Set to <see cref="UnoToolkitUI.SplashScreenPlatform.All"/></summary>
        public static TTarget All<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.SplashScreenPlatform> property) where TTarget : ExtendedSplashScreen
        => property.Set(UnoToolkitUI.SplashScreenPlatform.All);
    }

    public static partial class NavigationBarExtensions
    {
        /// <summary>Set to <see cref="UnoToolkitUI.MainCommandMode.Back"/></summary>
        public static TTarget Back<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.MainCommandMode> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.MainCommandMode.Back);

        /// <summary>Set to <see cref="UnoToolkitUI.MainCommandMode.Action"/></summary>
        public static TTarget Action<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.MainCommandMode> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.MainCommandMode.Action);

        /// <summary>Set to <see cref="UnoToolkitUI.NavigationBarDefaultLabelPosition.Bottom"/></summary>
        public static TTarget Bottom<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.NavigationBarDefaultLabelPosition> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.NavigationBarDefaultLabelPosition.Bottom);

        /// <summary>Set to <see cref="UnoToolkitUI.NavigationBarDefaultLabelPosition.Right"/></summary>
        public static TTarget Right<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.NavigationBarDefaultLabelPosition> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.NavigationBarDefaultLabelPosition.Right);

        /// <summary>Set to <see cref="UnoToolkitUI.NavigationBarDefaultLabelPosition.Collapsed"/></summary>
        public static TTarget Collapsed<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.NavigationBarDefaultLabelPosition> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.NavigationBarDefaultLabelPosition.Collapsed);

        /// <summary>Set to <see cref="UnoToolkitUI.NavigationBarOverflowButtonVisibility.Auto"/></summary>
        public static TTarget Auto<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.NavigationBarOverflowButtonVisibility> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.NavigationBarOverflowButtonVisibility.Auto);

        /// <summary>Set to <see cref="UnoToolkitUI.NavigationBarOverflowButtonVisibility.Visible"/></summary>
        public static TTarget Visible<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.NavigationBarOverflowButtonVisibility> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.NavigationBarOverflowButtonVisibility.Visible);

        /// <summary>Set to <see cref="UnoToolkitUI.NavigationBarOverflowButtonVisibility.Collapsed"/></summary>
        public static TTarget Collapsed<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.NavigationBarOverflowButtonVisibility> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.NavigationBarOverflowButtonVisibility.Collapsed);

        /// <summary>Set to <see cref="Xaml.Controls.LightDismissOverlayMode.Auto"/></summary>
        public static TTarget Auto<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.LightDismissOverlayMode> property) where TTarget : NavigationBar
        => property.Set(Xaml.Controls.LightDismissOverlayMode.Auto);

        /// <summary>Set to <see cref="Xaml.Controls.LightDismissOverlayMode.On"/></summary>
        public static TTarget On<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.LightDismissOverlayMode> property) where TTarget : NavigationBar
        => property.Set(Xaml.Controls.LightDismissOverlayMode.On);

        /// <summary>Set to <see cref="Xaml.Controls.LightDismissOverlayMode.Off"/></summary>
        public static TTarget Off<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.LightDismissOverlayMode> property) where TTarget : NavigationBar
        => property.Set(Xaml.Controls.LightDismissOverlayMode.Off);

        /// <summary>Set to <see cref="UnoToolkitUI.NavigationBarClosedDisplayMode.Compact"/></summary>
        public static TTarget Compact<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.NavigationBarClosedDisplayMode> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.NavigationBarClosedDisplayMode.Compact);

        /// <summary>Set to <see cref="UnoToolkitUI.NavigationBarClosedDisplayMode.Minimal"/></summary>
        public static TTarget Minimal<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.NavigationBarClosedDisplayMode> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.NavigationBarClosedDisplayMode.Minimal);

        /// <summary>Set to <see cref="UnoToolkitUI.NavigationBarClosedDisplayMode.Hidden"/></summary>
        public static TTarget Hidden<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.NavigationBarClosedDisplayMode> property) where TTarget : NavigationBar
        => property.Set(UnoToolkitUI.NavigationBarClosedDisplayMode.Hidden);
    }

    public static partial class TabBarExtensions
    {
        /// <summary>Set to <see cref="Xaml.Controls.Orientation.Vertical"/></summary>
        public static TTarget Vertical<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.Orientation> property) where TTarget : TabBar
        => property.Set(Xaml.Controls.Orientation.Vertical);

        /// <summary>Set to <see cref="Xaml.Controls.Orientation.Horizontal"/></summary>
        public static TTarget Horizontal<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.Orientation> property) where TTarget : TabBar
        => property.Set(Xaml.Controls.Orientation.Horizontal);

        /// <summary>Set to <see cref="UnoToolkitUI.IndicatorPlacement.Above"/></summary>
        public static TTarget Above<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.IndicatorPlacement> property) where TTarget : TabBar
        => property.Set(UnoToolkitUI.IndicatorPlacement.Above);

        /// <summary>Set to <see cref="UnoToolkitUI.IndicatorPlacement.Below"/></summary>
        public static TTarget Below<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.IndicatorPlacement> property) where TTarget : TabBar
        => property.Set(UnoToolkitUI.IndicatorPlacement.Below);

        /// <summary>Set to <see cref="UnoToolkitUI.IndicatorTransitionMode.Snap"/></summary>
        public static TTarget Snap<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.IndicatorTransitionMode> property) where TTarget : TabBar
        => property.Set(UnoToolkitUI.IndicatorTransitionMode.Snap);

        /// <summary>Set to <see cref="UnoToolkitUI.IndicatorTransitionMode.Slide"/></summary>
        public static TTarget Slide<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.IndicatorTransitionMode> property) where TTarget : TabBar
        => property.Set(UnoToolkitUI.IndicatorTransitionMode.Slide);
    }

    public static partial class TabBarItemExtensions
    {
        /// <summary>Set to <see cref="Xaml.Visibility.Visible"/></summary>
        public static TTarget Visible<TTarget>(this DependencyProperty<TTarget, Xaml.Visibility> property) where TTarget : TabBarItem
        => property.Set(Xaml.Visibility.Visible);

        /// <summary>Set to <see cref="Xaml.Visibility.Collapsed"/></summary>
        public static TTarget Collapsed<TTarget>(this DependencyProperty<TTarget, Xaml.Visibility> property) where TTarget : TabBarItem
        => property.Set(Xaml.Visibility.Collapsed);
    }

    public static partial class TabBarListPanelExtensions
    {
        /// <summary>Set to <see cref="Xaml.Controls.Orientation.Vertical"/></summary>
        public static TTarget Vertical<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.Orientation> property) where TTarget : TabBarListPanel
        => property.Set(Xaml.Controls.Orientation.Vertical);

        /// <summary>Set to <see cref="Xaml.Controls.Orientation.Horizontal"/></summary>
        public static TTarget Horizontal<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.Orientation> property) where TTarget : TabBarListPanel
        => property.Set(Xaml.Controls.Orientation.Horizontal);
    }

    public static partial class TabBarSelectionIndicatorPresenterExtensions
    {
        /// <summary>Set to <see cref="UnoToolkitUI.IndicatorTransitionMode.Snap"/></summary>
        public static TTarget Snap<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.IndicatorTransitionMode> property) where TTarget : TabBarSelectionIndicatorPresenter
        => property.Set(UnoToolkitUI.IndicatorTransitionMode.Snap);

        /// <summary>Set to <see cref="UnoToolkitUI.IndicatorTransitionMode.Slide"/></summary>
        public static TTarget Slide<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.IndicatorTransitionMode> property) where TTarget : TabBarSelectionIndicatorPresenter
        => property.Set(UnoToolkitUI.IndicatorTransitionMode.Slide);
    }
}

#endif
// End of generated C# Markup API for Uno.WinUI
