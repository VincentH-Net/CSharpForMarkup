// Start of generated C# Markup API for Microsoft.WindowsAppSDK
#if NET7_0_WINDOWS10_0_18362_0 && WINUI

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Input;
using System.Runtime.Versioning;
using Microsoft;
using CSharpMarkup.WinUI.GeneratedCodeUtilities;
using UI = Microsoft.UI;
using Collections = System.Collections;
using UnoToolkit = Uno.Toolkit;
using UnoToolkitUI = Uno.Toolkit.UI;
using Xaml = Microsoft.UI.Xaml;
using VirtualKey = Windows.System.VirtualKey;
using VirtualKeyModifiers = Windows.System.VirtualKeyModifiers;
using Drawing = System.Drawing;

namespace CSharpMarkup.WinUI.Uno.Toolkit // CommandExtensions
{
    public static partial class CommandExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.CommandExtensions.Command"/></summary>
        public static TTarget CommandExtensions_Command<TTarget>(this TTarget target, ICommand value) where TTarget : DependencyObject
        { UnoToolkitUI.CommandExtensions.SetCommand(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.CommandExtensions.Command"/></summary>
        public static DependencyProperty<TTarget, ICommand> CommandExtensions_Command<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, ICommand>.Get(target, UnoToolkitUI.CommandExtensions.CommandProperty);

        /// <summary>Set <see cref="UnoToolkitUI.CommandExtensions.CommandParameter"/></summary>
        public static TTarget CommandExtensions_CommandParameter<TTarget>(this TTarget target, object? value) where TTarget : DependencyObject
        { UnoToolkitUI.CommandExtensions.SetCommandParameter(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.CommandExtensions.CommandParameter"/></summary>
        public static DependencyProperty<TTarget, object?> CommandExtensions_CommandParameter<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, object?>.Get(target, UnoToolkitUI.CommandExtensions.CommandParameterProperty);

        /// <summary>Set <see cref="UnoToolkitUI.CommandExtensions"/> attached properties</summary>
        public static TTarget CommandExtensions<TTarget>(this TTarget target

            , ICommand Command = default

            , object? CommandParameter = default

        ) where TTarget : DependencyObject
        {
            if (Command is not null) UnoToolkitUI.CommandExtensions.SetCommand(target.UI, Command);

            if (CommandParameter is not null) UnoToolkitUI.CommandExtensions.SetCommandParameter(target.UI, CommandParameter);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // DrawerControlBehavior
{
    public static partial class DrawerControlBehaviorExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.DrawerControlBehavior.DrawerBackground"/></summary>
        public static TTarget DrawerControlBehavior_DrawerBackground<TTarget>(this TTarget target, Xaml.Media.Brush value) where TTarget : DrawerControl
        { UnoToolkitUI.DrawerControlBehavior.SetDrawerBackground(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControlBehavior.DrawerBackground"/></summary>
        public static DependencyProperty<TTarget, Xaml.Media.Brush> DrawerControlBehavior_DrawerBackground<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, Xaml.Media.Brush>.Get(target, UnoToolkitUI.DrawerControlBehavior.DrawerBackgroundProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControlBehavior.FitToDrawerContent"/></summary>
        public static TTarget DrawerControlBehavior_FitToDrawerContent<TTarget>(this TTarget target, bool value) where TTarget : DrawerControl
        { UnoToolkitUI.DrawerControlBehavior.SetFitToDrawerContent(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControlBehavior.FitToDrawerContent"/></summary>
        public static DependencyProperty<TTarget, bool> DrawerControlBehavior_FitToDrawerContent<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.DrawerControlBehavior.FitToDrawerContentProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControlBehavior"/> attached properties</summary>
        public static TTarget DrawerControlBehavior<TTarget>(this TTarget target

            , Xaml.Media.Brush DrawerBackground = default

            , bool? FitToDrawerContent = default

            , UnoToolkitUI.DrawerOpenDirection? OpenDirection = default

            , Xaml.Media.Brush LightDismissOverlayBackground = default

            , double? EdgeSwipeDetectionLength = default

            , bool? IsGestureEnabled = default

        ) where TTarget : DrawerControl
        {
            if (DrawerBackground is not null) UnoToolkitUI.DrawerControlBehavior.SetDrawerBackground(target.UI, DrawerBackground);

            if (FitToDrawerContent is not null) UnoToolkitUI.DrawerControlBehavior.SetFitToDrawerContent(target.UI, FitToDrawerContent.Value);

            if (OpenDirection is not null) UnoToolkitUI.DrawerControlBehavior.SetOpenDirection(target.UI, OpenDirection.Value);

            if (LightDismissOverlayBackground is not null) UnoToolkitUI.DrawerControlBehavior.SetLightDismissOverlayBackground(target.UI, LightDismissOverlayBackground);

            if (EdgeSwipeDetectionLength is not null) UnoToolkitUI.DrawerControlBehavior.SetEdgeSwipeDetectionLength(target.UI, EdgeSwipeDetectionLength);

            if (IsGestureEnabled is not null) UnoToolkitUI.DrawerControlBehavior.SetIsGestureEnabled(target.UI, IsGestureEnabled.Value);

            return target;
        }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControlBehavior.OpenDirection"/></summary>
        public static TTarget DrawerControlBehavior_OpenDirection<TTarget>(this TTarget target, UnoToolkitUI.DrawerOpenDirection value) where TTarget : DependencyObject
        { UnoToolkitUI.DrawerControlBehavior.SetOpenDirection(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControlBehavior.OpenDirection"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> DrawerControlBehavior_OpenDirection<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection>.Get(target, UnoToolkitUI.DrawerControlBehavior.OpenDirectionProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControlBehavior.LightDismissOverlayBackground"/></summary>
        public static TTarget DrawerControlBehavior_LightDismissOverlayBackground<TTarget>(this TTarget target, Xaml.Media.Brush value) where TTarget : DependencyObject
        { UnoToolkitUI.DrawerControlBehavior.SetLightDismissOverlayBackground(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControlBehavior.LightDismissOverlayBackground"/></summary>
        public static DependencyProperty<TTarget, Xaml.Media.Brush> DrawerControlBehavior_LightDismissOverlayBackground<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, Xaml.Media.Brush>.Get(target, UnoToolkitUI.DrawerControlBehavior.LightDismissOverlayBackgroundProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControlBehavior.EdgeSwipeDetectionLength"/></summary>
        public static TTarget DrawerControlBehavior_EdgeSwipeDetectionLength<TTarget>(this TTarget target, double? value) where TTarget : DependencyObject
        { UnoToolkitUI.DrawerControlBehavior.SetEdgeSwipeDetectionLength(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControlBehavior.EdgeSwipeDetectionLength"/></summary>
        public static DependencyProperty<TTarget, double?> DrawerControlBehavior_EdgeSwipeDetectionLength<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, double?>.Get(target, UnoToolkitUI.DrawerControlBehavior.EdgeSwipeDetectionLengthProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControlBehavior.IsGestureEnabled"/></summary>
        public static TTarget DrawerControlBehavior_IsGestureEnabled<TTarget>(this TTarget target, bool value) where TTarget : DependencyObject
        { UnoToolkitUI.DrawerControlBehavior.SetIsGestureEnabled(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerControlBehavior.IsGestureEnabled"/></summary>
        public static DependencyProperty<TTarget, bool> DrawerControlBehavior_IsGestureEnabled<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.DrawerControlBehavior.IsGestureEnabledProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControlBehavior"/> attached properties</summary>
        public static TTarget DrawerControlBehavior<TTarget>(this TTarget target

            , UnoToolkitUI.DrawerOpenDirection? OpenDirection = default

            , Xaml.Media.Brush LightDismissOverlayBackground = default

            , double? EdgeSwipeDetectionLength = default

            , bool? IsGestureEnabled = default

        ) where TTarget : DependencyObject
        {
            if (OpenDirection is not null) UnoToolkitUI.DrawerControlBehavior.SetOpenDirection(target.UI, OpenDirection.Value);

            if (LightDismissOverlayBackground is not null) UnoToolkitUI.DrawerControlBehavior.SetLightDismissOverlayBackground(target.UI, LightDismissOverlayBackground);

            if (EdgeSwipeDetectionLength is not null) UnoToolkitUI.DrawerControlBehavior.SetEdgeSwipeDetectionLength(target.UI, EdgeSwipeDetectionLength);

            if (IsGestureEnabled is not null) UnoToolkitUI.DrawerControlBehavior.SetIsGestureEnabled(target.UI, IsGestureEnabled.Value);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // FlipViewExtensions
{
    public static partial class FlipViewExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.FlipViewExtensions.Next"/></summary>
        public static TTarget FlipViewExtensions_Next<TTarget>(this TTarget target, Xaml.Controls.FlipView value) where TTarget : Button
        { UnoToolkitUI.FlipViewExtensions.SetNext(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.FlipViewExtensions.Next"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.FlipView> FlipViewExtensions_Next<TTarget>(this TTarget target) where TTarget : Button
        => DependencyProperty<TTarget, Xaml.Controls.FlipView>.Get(target, UnoToolkitUI.FlipViewExtensions.NextProperty);

        /// <summary>Set <see cref="UnoToolkitUI.FlipViewExtensions.Previous"/></summary>
        public static TTarget FlipViewExtensions_Previous<TTarget>(this TTarget target, Xaml.Controls.FlipView value) where TTarget : Button
        { UnoToolkitUI.FlipViewExtensions.SetPrevious(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.FlipViewExtensions.Previous"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.FlipView> FlipViewExtensions_Previous<TTarget>(this TTarget target) where TTarget : Button
        => DependencyProperty<TTarget, Xaml.Controls.FlipView>.Get(target, UnoToolkitUI.FlipViewExtensions.PreviousProperty);

        /// <summary>Set <see cref="UnoToolkitUI.FlipViewExtensions"/> attached properties</summary>
        public static TTarget FlipViewExtensions<TTarget>(this TTarget target

            , Xaml.Controls.FlipView Next = default

            , Xaml.Controls.FlipView Previous = default

        ) where TTarget : Button
        {
            if (Next is not null) UnoToolkitUI.FlipViewExtensions.SetNext(target.UI, Next);

            if (Previous is not null) UnoToolkitUI.FlipViewExtensions.SetPrevious(target.UI, Previous);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // InputExtensions
{
    public static partial class InputExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.InputExtensions.AutoDismiss"/></summary>
        public static TTarget InputExtensions_AutoDismiss<TTarget>(this TTarget target, bool value) where TTarget : DependencyObject
        { UnoToolkitUI.InputExtensions.SetAutoDismiss(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.InputExtensions.AutoDismiss"/></summary>
        public static DependencyProperty<TTarget, bool> InputExtensions_AutoDismiss<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.InputExtensions.AutoDismissProperty);

        /// <summary>Set <see cref="UnoToolkitUI.InputExtensions.AutoFocusNext"/></summary>
        public static TTarget InputExtensions_AutoFocusNext<TTarget>(this TTarget target, bool value) where TTarget : DependencyObject
        { UnoToolkitUI.InputExtensions.SetAutoFocusNext(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.InputExtensions.AutoFocusNext"/></summary>
        public static DependencyProperty<TTarget, bool> InputExtensions_AutoFocusNext<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.InputExtensions.AutoFocusNextProperty);

        /// <summary>Set <see cref="UnoToolkitUI.InputExtensions.AutoFocusNextElement"/></summary>
        public static TTarget InputExtensions_AutoFocusNextElement<TTarget>(this TTarget target, Xaml.Controls.Control value) where TTarget : DependencyObject
        { UnoToolkitUI.InputExtensions.SetAutoFocusNextElement(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.InputExtensions.AutoFocusNextElement"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.Control> InputExtensions_AutoFocusNextElement<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, Xaml.Controls.Control>.Get(target, UnoToolkitUI.InputExtensions.AutoFocusNextElementProperty);

        /// <summary>Set <see cref="UnoToolkitUI.InputExtensions"/> attached properties</summary>
        public static TTarget InputExtensions<TTarget>(this TTarget target

            , bool? AutoDismiss = default

            , bool? AutoFocusNext = default

            , Xaml.Controls.Control AutoFocusNextElement = default

        ) where TTarget : DependencyObject
        {
            if (AutoDismiss is not null) UnoToolkitUI.InputExtensions.SetAutoDismiss(target.UI, AutoDismiss.Value);

            if (AutoFocusNext is not null) UnoToolkitUI.InputExtensions.SetAutoFocusNext(target.UI, AutoFocusNext.Value);

            if (AutoFocusNextElement is not null) UnoToolkitUI.InputExtensions.SetAutoFocusNextElement(target.UI, AutoFocusNextElement);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // ItemsRepeaterExtensions
{
    public static partial class ItemsRepeaterExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.ItemsRepeaterExtensions.SelectedItem"/></summary>
        public static TTarget ItemsRepeaterExtensions_SelectedItem<TTarget>(this TTarget target, object? value) where TTarget : ItemsRepeater
        { UnoToolkitUI.ItemsRepeaterExtensions.SetSelectedItem(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ItemsRepeaterExtensions.SelectedItem"/></summary>
        public static DependencyProperty<TTarget, object?> ItemsRepeaterExtensions_SelectedItem<TTarget>(this TTarget target) where TTarget : ItemsRepeater
        => DependencyProperty<TTarget, object?>.Get(target, UnoToolkitUI.ItemsRepeaterExtensions.SelectedItemProperty);

        /// <summary>Set <see cref="UnoToolkitUI.ItemsRepeaterExtensions.SelectedItems"/></summary>
        public static TTarget ItemsRepeaterExtensions_SelectedItems<TTarget>(this TTarget target, IList<object> value) where TTarget : ItemsRepeater
        { UnoToolkitUI.ItemsRepeaterExtensions.SetSelectedItems(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ItemsRepeaterExtensions.SelectedItems"/></summary>
        public static DependencyProperty<TTarget, IList<object>> ItemsRepeaterExtensions_SelectedItems<TTarget>(this TTarget target) where TTarget : ItemsRepeater
        => DependencyProperty<TTarget, IList<object>>.Get(target, UnoToolkitUI.ItemsRepeaterExtensions.SelectedItemsProperty);

        /// <summary>Set <see cref="UnoToolkitUI.ItemsRepeaterExtensions.SelectedIndex"/></summary>
        public static TTarget ItemsRepeaterExtensions_SelectedIndex<TTarget>(this TTarget target, int value) where TTarget : ItemsRepeater
        { UnoToolkitUI.ItemsRepeaterExtensions.SetSelectedIndex(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ItemsRepeaterExtensions.SelectedIndex"/></summary>
        public static DependencyProperty<TTarget, int> ItemsRepeaterExtensions_SelectedIndex<TTarget>(this TTarget target) where TTarget : ItemsRepeater
        => DependencyProperty<TTarget, int>.Get(target, UnoToolkitUI.ItemsRepeaterExtensions.SelectedIndexProperty);

        /// <summary>Set <see cref="UnoToolkitUI.ItemsRepeaterExtensions.SelectedIndexes"/></summary>
        public static TTarget ItemsRepeaterExtensions_SelectedIndexes<TTarget>(this TTarget target, IList<int> value) where TTarget : ItemsRepeater
        { UnoToolkitUI.ItemsRepeaterExtensions.SetSelectedIndexes(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ItemsRepeaterExtensions.SelectedIndexes"/></summary>
        public static DependencyProperty<TTarget, IList<int>> ItemsRepeaterExtensions_SelectedIndexes<TTarget>(this TTarget target) where TTarget : ItemsRepeater
        => DependencyProperty<TTarget, IList<int>>.Get(target, UnoToolkitUI.ItemsRepeaterExtensions.SelectedIndexesProperty);

        /// <summary>Set <see cref="UnoToolkitUI.ItemsRepeaterExtensions.SelectionMode"/></summary>
        public static TTarget ItemsRepeaterExtensions_SelectionMode<TTarget>(this TTarget target, UnoToolkitUI.ItemsSelectionMode value) where TTarget : ItemsRepeater
        { UnoToolkitUI.ItemsRepeaterExtensions.SetSelectionMode(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.ItemsRepeaterExtensions.SelectionMode"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.ItemsSelectionMode> ItemsRepeaterExtensions_SelectionMode<TTarget>(this TTarget target) where TTarget : ItemsRepeater
        => DependencyProperty<TTarget, UnoToolkitUI.ItemsSelectionMode>.Get(target, UnoToolkitUI.ItemsRepeaterExtensions.SelectionModeProperty);

        /// <summary>Set <see cref="UnoToolkitUI.ItemsRepeaterExtensions"/> attached properties</summary>
        public static TTarget ItemsRepeaterExtensions<TTarget>(this TTarget target

            , object? SelectedItem = default

            , IList<object> SelectedItems = default

            , int? SelectedIndex = default

            , IList<int> SelectedIndexes = default

            , UnoToolkitUI.ItemsSelectionMode? SelectionMode = default

        ) where TTarget : ItemsRepeater
        {
            if (SelectedItem is not null) UnoToolkitUI.ItemsRepeaterExtensions.SetSelectedItem(target.UI, SelectedItem);

            if (SelectedItems is not null) UnoToolkitUI.ItemsRepeaterExtensions.SetSelectedItems(target.UI, SelectedItems);

            if (SelectedIndex is not null) UnoToolkitUI.ItemsRepeaterExtensions.SetSelectedIndex(target.UI, SelectedIndex.Value);

            if (SelectedIndexes is not null) UnoToolkitUI.ItemsRepeaterExtensions.SetSelectedIndexes(target.UI, SelectedIndexes);

            if (SelectionMode is not null) UnoToolkitUI.ItemsRepeaterExtensions.SetSelectionMode(target.UI, SelectionMode.Value);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // SelectorExtensions
{
    public static partial class SelectorExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.SelectorExtensions.PipsPager"/></summary>
        public static TTarget SelectorExtensions_PipsPager<TTarget>(this TTarget target, Xaml.Controls.PipsPager value) where TTarget : Selector
        { UnoToolkitUI.SelectorExtensions.SetPipsPager(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.SelectorExtensions.PipsPager"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.PipsPager> SelectorExtensions_PipsPager<TTarget>(this TTarget target) where TTarget : Selector
        => DependencyProperty<TTarget, Xaml.Controls.PipsPager>.Get(target, UnoToolkitUI.SelectorExtensions.PipsPagerProperty);

        /// <summary>Set <see cref="UnoToolkitUI.SelectorExtensions"/> attached properties</summary>
        public static TTarget SelectorExtensions<TTarget>(this TTarget target

            , Xaml.Controls.PipsPager PipsPager = default

            , double? SelectionOffset = default

        ) where TTarget : Selector
        {
            if (PipsPager is not null) UnoToolkitUI.SelectorExtensions.SetPipsPager(target.UI, PipsPager);

            if (SelectionOffset is not null) UnoToolkitUI.SelectorExtensions.SetSelectionOffset(target.UI, SelectionOffset.Value);

            return target;
        }

        /// <summary>Set <see cref="UnoToolkitUI.SelectorExtensions.SelectionOffset"/></summary>
        public static TTarget SelectorExtensions_SelectionOffset<TTarget>(this TTarget target, double value) where TTarget : DependencyObject
        { UnoToolkitUI.SelectorExtensions.SetSelectionOffset(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.SelectorExtensions.SelectionOffset"/></summary>
        public static DependencyProperty<TTarget, double> SelectorExtensions_SelectionOffset<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, double>.Get(target, UnoToolkitUI.SelectorExtensions.SelectionOffsetProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // StatusBar
{
    public static partial class StatusBarExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.StatusBar.Foreground"/></summary>
        public static TTarget StatusBar_Foreground<TTarget>(this TTarget target, UnoToolkitUI.StatusBarForegroundTheme value) where TTarget : Page
        { UnoToolkitUI.StatusBar.SetForeground(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.StatusBar.Foreground"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.StatusBarForegroundTheme> StatusBar_Foreground<TTarget>(this TTarget target) where TTarget : Page
        => DependencyProperty<TTarget, UnoToolkitUI.StatusBarForegroundTheme>.Get(target, UnoToolkitUI.StatusBar.ForegroundProperty);

        /// <summary>Set <see cref="UnoToolkitUI.StatusBar.Background"/></summary>
        public static TTarget StatusBar_Background<TTarget>(this TTarget target, Xaml.Media.Brush value) where TTarget : Page
        { UnoToolkitUI.StatusBar.SetBackground(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.StatusBar.Background"/></summary>
        public static DependencyProperty<TTarget, Xaml.Media.Brush> StatusBar_Background<TTarget>(this TTarget target) where TTarget : Page
        => DependencyProperty<TTarget, Xaml.Media.Brush>.Get(target, UnoToolkitUI.StatusBar.BackgroundProperty);

        /// <summary>Set <see cref="UnoToolkitUI.StatusBar"/> attached properties</summary>
        public static TTarget StatusBar<TTarget>(this TTarget target

            , UnoToolkitUI.StatusBarForegroundTheme? Foreground = default

            , Xaml.Media.Brush Background = default

        ) where TTarget : Page
        {
            if (Foreground is not null) UnoToolkitUI.StatusBar.SetForeground(target.UI, Foreground.Value);

            if (Background is not null) UnoToolkitUI.StatusBar.SetBackground(target.UI, Background);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // TabBarItemExtensions
{
    public static partial class TabBarItemExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.TabBarItemExtensions.OnClickBehaviors"/></summary>
        public static TTarget TabBarItemExtensions_OnClickBehaviors<TTarget>(this TTarget target, UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors value) where TTarget : TabBarItem
        { UnoToolkitUI.TabBarItemExtensions.SetOnClickBehaviors(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarItemExtensions.OnClickBehaviors"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors> TabBarItemExtensions_OnClickBehaviors<TTarget>(this TTarget target) where TTarget : TabBarItem
        => DependencyProperty<TTarget, UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors>.Get(target, UnoToolkitUI.TabBarItemExtensions.OnClickBehaviorsProperty);

        /// <summary>Set <see cref="UnoToolkitUI.TabBarItemExtensions.OnClickBehaviorsTarget"/></summary>
        public static TTarget TabBarItemExtensions_OnClickBehaviorsTarget<TTarget>(this TTarget target, Xaml.UIElement value) where TTarget : TabBarItem
        { UnoToolkitUI.TabBarItemExtensions.SetOnClickBehaviorsTarget(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarItemExtensions.OnClickBehaviorsTarget"/></summary>
        public static DependencyProperty<TTarget, Xaml.UIElement> TabBarItemExtensions_OnClickBehaviorsTarget<TTarget>(this TTarget target) where TTarget : TabBarItem
        => DependencyProperty<TTarget, Xaml.UIElement>.Get(target, UnoToolkitUI.TabBarItemExtensions.OnClickBehaviorsTargetProperty);

        /// <summary>Set <see cref="UnoToolkitUI.TabBarItemExtensions"/> attached properties</summary>
        public static TTarget TabBarItemExtensions<TTarget>(this TTarget target

            , UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors? OnClickBehaviors = default

            , Xaml.UIElement OnClickBehaviorsTarget = default

        ) where TTarget : TabBarItem
        {
            if (OnClickBehaviors is not null) UnoToolkitUI.TabBarItemExtensions.SetOnClickBehaviors(target.UI, OnClickBehaviors.Value);

            if (OnClickBehaviorsTarget is not null) UnoToolkitUI.TabBarItemExtensions.SetOnClickBehaviorsTarget(target.UI, OnClickBehaviorsTarget);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // TabBarSelectorBehavior
{
    public static partial class TabBarSelectorBehaviorExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectorBehavior.Selector"/></summary>
        public static TTarget TabBarSelectorBehavior_Selector<TTarget>(this TTarget target, Xaml.Controls.Primitives.Selector? value) where TTarget : DependencyObject
        { UnoToolkitUI.TabBarSelectorBehavior.SetSelector(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.TabBarSelectorBehavior.Selector"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.Primitives.Selector?> TabBarSelectorBehavior_Selector<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, Xaml.Controls.Primitives.Selector?>.Get(target, UnoToolkitUI.TabBarSelectorBehavior.SelectorProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // VisualStateManagerExtensions
{
    public static partial class VisualStateManagerExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.VisualStateManagerExtensions.States"/></summary>
        public static TTarget VisualStateManagerExtensions_States<TTarget>(this TTarget target, string value) where TTarget : Control
        { UnoToolkitUI.VisualStateManagerExtensions.SetStates(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.VisualStateManagerExtensions.States"/></summary>
        public static DependencyProperty<TTarget, string> VisualStateManagerExtensions_States<TTarget>(this TTarget target) where TTarget : Control
        => DependencyProperty<TTarget, string>.Get(target, UnoToolkitUI.VisualStateManagerExtensions.StatesProperty);
    }
}

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
    }

    public partial class AutoLayout : RelativePanel, IUI<UnoToolkitUI.AutoLayout>
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
    }

    public partial class CardContentControl : ContentControl, IUI<UnoToolkitUI.CardContentControl>
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
    }

    public partial class Card : Control, IUI<UnoToolkitUI.Card>
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
    }

    public partial class Chip : ToggleButton, IUI<UnoToolkitUI.Chip>
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
    }

    public partial class ChipGroup : ItemsControl, IUI<UnoToolkitUI.ChipGroup>
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
        public static Divider Divider(string SubHeader = default, Xaml.Media.Brush SubHeaderForeground = default)
        {
            var ui = new UnoToolkitUI.Divider();
            if (SubHeader is not null) ui.SubHeader = SubHeader;
            if (SubHeaderForeground is not null) ui.SubHeaderForeground = SubHeaderForeground;
            return CSharpMarkup.WinUI.Uno.Toolkit.Divider.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.Divider"/></summary>
        public static Divider Divider()
        {
            var ui = new UnoToolkitUI.Divider();
            return CSharpMarkup.WinUI.Uno.Toolkit.Divider.StartChain(ui);
        }
    }

    public partial class Divider : Control, IUI<UnoToolkitUI.Divider>
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
        public static TView SubHeaderForeground<TView>(this TView view, Xaml.Media.Brush value) where TView : Divider { view.UI.SubHeaderForeground = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Divider.SubHeaderForeground"/></summary>
        public static TView SubHeaderForeground<TView>(this TView view, Windows.UI.Color value) where TView : Divider { view.UI.SubHeaderForeground = new Xaml.Media.SolidColorBrush(value); return view; }

        /// <summary>Set <see cref="UnoToolkitUI.Divider.SubHeaderForeground"/></summary>
        public static TView SubHeaderForeground<TView>(this TView view, string color) where TView : Divider { view.UI.SubHeaderForeground = new Xaml.Media.SolidColorBrush(color.ToColor()); return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Divider.SubHeader"/></summary>
        public static DependencyProperty<TTarget, string> SubHeader<TTarget>(this TTarget target) where TTarget : Divider
        => DependencyProperty<TTarget, string>.Get(target, UnoToolkitUI.Divider.SubHeaderProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.Divider.SubHeaderForeground"/></summary>
        public static DependencyProperty<TTarget, Xaml.Media.Brush> SubHeaderForeground<TTarget>(this TTarget target) where TTarget : Divider
        => DependencyProperty<TTarget, Xaml.Media.Brush>.Get(target, UnoToolkitUI.Divider.SubHeaderForegroundProperty);
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
        public static DrawerControl DrawerControl(object DrawerContent = default, double? DrawerDepth = default, Xaml.Media.Brush DrawerBackground = default, UnoToolkitUI.DrawerOpenDirection? OpenDirection = default, bool? IsOpen = default, bool? FitToDrawerContent = default, Xaml.Media.Brush LightDismissOverlayBackground = default, double? EdgeSwipeDetectionLength = default, bool? IsGestureEnabled = default, UIObject Content = default)
        {
            var ui = new UnoToolkitUI.DrawerControl();
            if (DrawerContent is not null) ui.DrawerContent = DrawerContent;
            if (DrawerDepth is not null) ui.DrawerDepth = DrawerDepth;
            if (DrawerBackground is not null) ui.DrawerBackground = DrawerBackground;
            if (OpenDirection is not null) ui.OpenDirection = OpenDirection.Value;
            if (IsOpen is not null) ui.IsOpen = IsOpen.Value;
            if (FitToDrawerContent is not null) ui.FitToDrawerContent = FitToDrawerContent.Value;
            if (LightDismissOverlayBackground is not null) ui.LightDismissOverlayBackground = LightDismissOverlayBackground;
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
    }

    public partial class DrawerControl : ContentControl, IUI<UnoToolkitUI.DrawerControl>
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
        public static TView DrawerBackground<TView>(this TView view, Xaml.Media.Brush value) where TView : DrawerControl { view.UI.DrawerBackground = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.DrawerBackground"/></summary>
        public static TView DrawerBackground<TView>(this TView view, Windows.UI.Color value) where TView : DrawerControl { view.UI.DrawerBackground = new Xaml.Media.SolidColorBrush(value); return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.DrawerBackground"/></summary>
        public static TView DrawerBackground<TView>(this TView view, string color) where TView : DrawerControl { view.UI.DrawerBackground = new Xaml.Media.SolidColorBrush(color.ToColor()); return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.OpenDirection"/></summary>
        public static TView OpenDirection<TView>(this TView view, UnoToolkitUI.DrawerOpenDirection value) where TView : DrawerControl { view.UI.OpenDirection = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.IsOpen"/></summary>
        public static TView IsOpen<TView>(this TView view, bool value) where TView : DrawerControl { view.UI.IsOpen = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.FitToDrawerContent"/></summary>
        public static TView FitToDrawerContent<TView>(this TView view, bool value) where TView : DrawerControl { view.UI.FitToDrawerContent = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.LightDismissOverlayBackground"/></summary>
        public static TView LightDismissOverlayBackground<TView>(this TView view, Xaml.Media.Brush value) where TView : DrawerControl { view.UI.LightDismissOverlayBackground = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.LightDismissOverlayBackground"/></summary>
        public static TView LightDismissOverlayBackground<TView>(this TView view, Windows.UI.Color value) where TView : DrawerControl { view.UI.LightDismissOverlayBackground = new Xaml.Media.SolidColorBrush(value); return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerControl.LightDismissOverlayBackground"/></summary>
        public static TView LightDismissOverlayBackground<TView>(this TView view, string color) where TView : DrawerControl { view.UI.LightDismissOverlayBackground = new Xaml.Media.SolidColorBrush(color.ToColor()); return view; }

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
        public static DependencyProperty<TTarget, Xaml.Media.Brush> DrawerBackground<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, Xaml.Media.Brush>.Get(target, UnoToolkitUI.DrawerControl.DrawerBackgroundProperty);

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
        public static DependencyProperty<TTarget, Xaml.Media.Brush> LightDismissOverlayBackground<TTarget>(this TTarget target) where TTarget : DrawerControl
        => DependencyProperty<TTarget, Xaml.Media.Brush>.Get(target, UnoToolkitUI.DrawerControl.LightDismissOverlayBackgroundProperty);

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
        public static DrawerFlyoutPresenter DrawerFlyoutPresenter(UnoToolkitUI.DrawerOpenDirection? OpenDirection = default, Xaml.Media.Brush LightDismissOverlayBackground = default, bool? IsGestureEnabled = default, UIObject Content = default)
        {
            var ui = new UnoToolkitUI.DrawerFlyoutPresenter();
            if (OpenDirection is not null) ui.OpenDirection = OpenDirection.Value;
            if (LightDismissOverlayBackground is not null) ui.LightDismissOverlayBackground = LightDismissOverlayBackground;
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
    }

    public partial class DrawerFlyoutPresenter : ContentControl, IUI<UnoToolkitUI.DrawerFlyoutPresenter>
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
        public static TView LightDismissOverlayBackground<TView>(this TView view, Xaml.Media.Brush value) where TView : DrawerFlyoutPresenter { view.UI.LightDismissOverlayBackground = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackground"/></summary>
        public static TView LightDismissOverlayBackground<TView>(this TView view, Windows.UI.Color value) where TView : DrawerFlyoutPresenter { view.UI.LightDismissOverlayBackground = new Xaml.Media.SolidColorBrush(value); return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackground"/></summary>
        public static TView LightDismissOverlayBackground<TView>(this TView view, string color) where TView : DrawerFlyoutPresenter { view.UI.LightDismissOverlayBackground = new Xaml.Media.SolidColorBrush(color.ToColor()); return view; }

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter.IsGestureEnabled"/></summary>
        public static TView IsGestureEnabled<TView>(this TView view, bool value) where TView : DrawerFlyoutPresenter { view.UI.IsGestureEnabled = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerFlyoutPresenter.OpenDirection"/></summary>
        public static DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection> OpenDirection<TTarget>(this TTarget target) where TTarget : DrawerFlyoutPresenter
        => DependencyProperty<TTarget, UnoToolkitUI.DrawerOpenDirection>.Get(target, UnoToolkitUI.DrawerFlyoutPresenter.OpenDirectionProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackground"/></summary>
        public static DependencyProperty<TTarget, Xaml.Media.Brush> LightDismissOverlayBackground<TTarget>(this TTarget target) where TTarget : DrawerFlyoutPresenter
        => DependencyProperty<TTarget, Xaml.Media.Brush>.Get(target, UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackgroundProperty);

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
        public static TTarget DrawerFlyoutPresenter_LightDismissOverlayBackground<TTarget>(this TTarget target, Xaml.Media.Brush value) where TTarget : DependencyObject
        { UnoToolkitUI.DrawerFlyoutPresenter.SetLightDismissOverlayBackground(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackground"/></summary>
        public static DependencyProperty<TTarget, Xaml.Media.Brush> DrawerFlyoutPresenter_LightDismissOverlayBackground<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, Xaml.Media.Brush>.Get(target, UnoToolkitUI.DrawerFlyoutPresenter.LightDismissOverlayBackgroundProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter.IsGestureEnabled"/></summary>
        public static TTarget DrawerFlyoutPresenter_IsGestureEnabled<TTarget>(this TTarget target, bool value) where TTarget : DependencyObject
        { UnoToolkitUI.DrawerFlyoutPresenter.SetIsGestureEnabled(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.DrawerFlyoutPresenter.IsGestureEnabled"/></summary>
        public static DependencyProperty<TTarget, bool> DrawerFlyoutPresenter_IsGestureEnabled<TTarget>(this TTarget target) where TTarget : DependencyObject
        => DependencyProperty<TTarget, bool>.Get(target, UnoToolkitUI.DrawerFlyoutPresenter.IsGestureEnabledProperty);

        /// <summary>Set <see cref="UnoToolkitUI.DrawerFlyoutPresenter"/> attached properties</summary>
        public static TTarget DrawerFlyoutPresenter<TTarget>(this TTarget target

            , UnoToolkitUI.DrawerOpenDirection? OpenDirection = default

            , Xaml.Media.Brush LightDismissOverlayBackground = default

            , bool? IsGestureEnabled = default

        ) where TTarget : DependencyObject
        {
            if (OpenDirection is not null) UnoToolkitUI.DrawerFlyoutPresenter.SetOpenDirection(target.UI, OpenDirection.Value);

            if (LightDismissOverlayBackground is not null) UnoToolkitUI.DrawerFlyoutPresenter.SetLightDismissOverlayBackground(target.UI, LightDismissOverlayBackground);

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
    }

    public partial class CompositeLoadableSource : FrameworkElement, IUI<UnoToolkitUI.CompositeLoadableSource>
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
    }

    public partial class LoadableSource : FrameworkElement, IUI<UnoToolkitUI.LoadableSource>
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
    }

    public partial class LoadingView : ContentControl, IUI<UnoToolkitUI.LoadingView>
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

namespace CSharpMarkup.WinUI.Uno.Toolkit // CommandBarExtensions
{
    public static partial class CommandBarExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoToolkitUI.CommandBarExtensions.MainCommand"/></summary>
        public static TTarget CommandBarExtensions_MainCommand<TTarget>(this TTarget target, Xaml.Controls.AppBarButton? value) where TTarget : DependencyObject?
        { UnoToolkitUI.CommandBarExtensions.SetMainCommand(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.CommandBarExtensions.MainCommand"/></summary>
        public static DependencyProperty<TTarget, Xaml.Controls.AppBarButton?> CommandBarExtensions_MainCommand<TTarget>(this TTarget target) where TTarget : DependencyObject?
        => DependencyProperty<TTarget, Xaml.Controls.AppBarButton?>.Get(target, UnoToolkitUI.CommandBarExtensions.MainCommandProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // NavigationBar
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBar"/></summary>
        public static NavigationBar NavigationBar(params CSharpMarkup.WinUI.CommandBarElement[] PrimaryCommands)
        {
            var ui = new UnoToolkitUI.NavigationBar();
            for (int i = 0; i < PrimaryCommands.Length; i++)
            {
                var child = PrimaryCommands[i];
                if (child == null) continue;

                var subChildren = Spreader<CSharpMarkup.WinUI.CommandBarElement>.ExtractChildren(child);
                if (subChildren is not null)
                    for (int j = 0; j < subChildren.Length; j++)
                        ui.PrimaryCommands.Add(subChildren[j].UI);
                else
                    ui.PrimaryCommands.Add(child.UI);
            }
            return CSharpMarkup.WinUI.Uno.Toolkit.NavigationBar.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoToolkitUI.NavigationBar"/></summary>
        public static NavigationBar NavigationBar()
        {
            var ui = new UnoToolkitUI.NavigationBar();
            return CSharpMarkup.WinUI.Uno.Toolkit.NavigationBar.StartChain(ui);
        }
    }

    public partial class NavigationBar : ContentControl, IUI<UnoToolkitUI.NavigationBar>
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
    }

    public partial class NavigationBarPresenter : Control, IUI<UnoToolkitUI.NavigationBarPresenter>
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

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBarTemplateSettings.HiddenRootMargin"/></summary>
        public static DependencyProperty<TTarget, Xaml.Thickness> HiddenRootMargin<TTarget>(this TTarget target) where TTarget : NavigationBarTemplateSettings
        => DependencyProperty<TTarget, Xaml.Thickness>.Get(target, UnoToolkitUI.NavigationBarTemplateSettings.HiddenRootMarginProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoToolkitUI.NavigationBarTemplateSettings.ContentHeight"/></summary>
        public static DependencyProperty<TTarget, double> ContentHeight<TTarget>(this TTarget target) where TTarget : NavigationBarTemplateSettings
        => DependencyProperty<TTarget, double>.Get(target, UnoToolkitUI.NavigationBarTemplateSettings.ContentHeightProperty);
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
    }

    public partial class SafeArea : ContentControl, IUI<UnoToolkitUI.SafeArea>
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
    }

    public partial class TabBar : ItemsControl, IUI<UnoToolkitUI.TabBar>
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
    }

    public partial class TabBarItem : SelectorItem, IUI<UnoToolkitUI.TabBarItem>
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
    }

    public partial class TabBarListPanel : Panel, IUI<UnoToolkitUI.TabBarListPanel>
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
    }

    public partial class TabBarSelectionIndicatorPresenter : ContentControl, IUI<UnoToolkitUI.TabBarSelectionIndicatorPresenter>
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
        public static TabBarSelectionIndicatorPresenterTemplateSettings TabBarSelectionIndicatorPresenterTemplateSettings(CSharpMarkup.WinUI.to.Point? IndicatorTransitionFrom = default, CSharpMarkup.WinUI.to.Point? IndicatorTransitionTo = default, CSharpMarkup.WinUI.to.Size? IndicatorMaxSize = default)
        {
            var ui = new UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings();
            if (IndicatorTransitionFrom is not null) ui.IndicatorTransitionFrom = IndicatorTransitionFrom.Value;
            if (IndicatorTransitionTo is not null) ui.IndicatorTransitionTo = IndicatorTransitionTo.Value;
            if (IndicatorMaxSize is not null) ui.IndicatorMaxSize = IndicatorMaxSize.Value;
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
        public static TView IndicatorTransitionFrom<TView>(this TView view, CSharpMarkup.WinUI.to.Point value) where TView : TabBarSelectionIndicatorPresenterTemplateSettings { view.UI.IndicatorTransitionFrom = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.IndicatorTransitionTo"/></summary>
        public static TView IndicatorTransitionTo<TView>(this TView view, CSharpMarkup.WinUI.to.Point value) where TView : TabBarSelectionIndicatorPresenterTemplateSettings { view.UI.IndicatorTransitionTo = value; return view; }

        /// <summary>Set <see cref="UnoToolkitUI.TabBarSelectionIndicatorPresenterTemplateSettings.IndicatorMaxSize"/></summary>
        public static TView IndicatorMaxSize<TView>(this TView view, CSharpMarkup.WinUI.to.Size value) where TView : TabBarSelectionIndicatorPresenterTemplateSettings { view.UI.IndicatorMaxSize = value; return view; }
    }
}

namespace CSharpMarkup.WinUI.Uno.Toolkit // TabBarTemplateSettings
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoToolkitUI.TabBarTemplateSettings"/></summary>
        public static TabBarTemplateSettings TabBarTemplateSettings(CSharpMarkup.WinUI.to.Size? SelectionIndicatorMaxSize = default)
        {
            var ui = new UnoToolkitUI.TabBarTemplateSettings();
            if (SelectionIndicatorMaxSize is not null) ui.SelectionIndicatorMaxSize = SelectionIndicatorMaxSize.Value;
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
        public static TView SelectionIndicatorMaxSize<TView>(this TView view, CSharpMarkup.WinUI.to.Size value) where TView : TabBarTemplateSettings { view.UI.SelectionIndicatorMaxSize = value; return view; }
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

    public partial class ToolkitResources : ResourceDictionary, IUI<UnoToolkitUI.ToolkitResources>
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

namespace CSharpMarkup.WinUI.Uno.Toolkit // EnumPropertyValues
{
    public static partial class AutoLayoutExtensions
    {
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

    public static partial class ItemsRepeaterExtensions
    {
        /// <summary>Set to <see cref="UnoToolkitUI.ItemsSelectionMode.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.ItemsSelectionMode> property) where TTarget : ItemsRepeater
        => property.Set(UnoToolkitUI.ItemsSelectionMode.None);

        /// <summary>Set to <see cref="UnoToolkitUI.ItemsSelectionMode.SingleOrNone"/></summary>
        public static TTarget SingleOrNone<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.ItemsSelectionMode> property) where TTarget : ItemsRepeater
        => property.Set(UnoToolkitUI.ItemsSelectionMode.SingleOrNone);

        /// <summary>Set to <see cref="UnoToolkitUI.ItemsSelectionMode.Single"/></summary>
        public static TTarget Single<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.ItemsSelectionMode> property) where TTarget : ItemsRepeater
        => property.Set(UnoToolkitUI.ItemsSelectionMode.Single);

        /// <summary>Set to <see cref="UnoToolkitUI.ItemsSelectionMode.Multiple"/></summary>
        public static TTarget Multiple<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.ItemsSelectionMode> property) where TTarget : ItemsRepeater
        => property.Set(UnoToolkitUI.ItemsSelectionMode.Multiple);
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

    public static partial class PageExtensions
    {
        /// <summary>Set to <see cref="UnoToolkitUI.StatusBarForegroundTheme.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.StatusBarForegroundTheme> property) where TTarget : Page
        => property.Set(UnoToolkitUI.StatusBarForegroundTheme.None);

        /// <summary>Set to <see cref="UnoToolkitUI.StatusBarForegroundTheme.Light"/></summary>
        public static TTarget Light<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.StatusBarForegroundTheme> property) where TTarget : Page
        => property.Set(UnoToolkitUI.StatusBarForegroundTheme.Light);

        /// <summary>Set to <see cref="UnoToolkitUI.StatusBarForegroundTheme.Dark"/></summary>
        public static TTarget Dark<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.StatusBarForegroundTheme> property) where TTarget : Page
        => property.Set(UnoToolkitUI.StatusBarForegroundTheme.Dark);

        /// <summary>Set to <see cref="UnoToolkitUI.StatusBarForegroundTheme.Auto"/></summary>
        public static TTarget Auto<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.StatusBarForegroundTheme> property) where TTarget : Page
        => property.Set(UnoToolkitUI.StatusBarForegroundTheme.Auto);

        /// <summary>Set to <see cref="UnoToolkitUI.StatusBarForegroundTheme.AutoInverse"/></summary>
        public static TTarget AutoInverse<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.StatusBarForegroundTheme> property) where TTarget : Page
        => property.Set(UnoToolkitUI.StatusBarForegroundTheme.AutoInverse);
    }

    public static partial class TabBarExtensions
    {
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

        /// <summary>Set to <see cref="Xaml.Controls.Orientation.Vertical"/></summary>
        public static TTarget Vertical<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.Orientation> property) where TTarget : TabBar
        => property.Set(Xaml.Controls.Orientation.Vertical);

        /// <summary>Set to <see cref="Xaml.Controls.Orientation.Horizontal"/></summary>
        public static TTarget Horizontal<TTarget>(this DependencyProperty<TTarget, Xaml.Controls.Orientation> property) where TTarget : TabBar
        => property.Set(Xaml.Controls.Orientation.Horizontal);
    }

    public static partial class TabBarItemExtensions
    {
        /// <summary>Set to <see cref="UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors> property) where TTarget : TabBarItem
        => property.Set(UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors.None);

        /// <summary>Set to <see cref="UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors.BackNavigation"/></summary>
        public static TTarget BackNavigation<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors> property) where TTarget : TabBarItem
        => property.Set(UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors.BackNavigation);

        /// <summary>Set to <see cref="UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors.ScrollToTop"/></summary>
        public static TTarget ScrollToTop<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors> property) where TTarget : TabBarItem
        => property.Set(UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors.ScrollToTop);

        /// <summary>Set to <see cref="UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors.Auto"/></summary>
        public static TTarget Auto<TTarget>(this DependencyProperty<TTarget, UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors> property) where TTarget : TabBarItem
        => property.Set(UnoToolkitUI.TabBarItemExtensions.TBIOnClickBehaviors.Auto);

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
// End of generated C# Markup API for Microsoft.WindowsAppSDK
