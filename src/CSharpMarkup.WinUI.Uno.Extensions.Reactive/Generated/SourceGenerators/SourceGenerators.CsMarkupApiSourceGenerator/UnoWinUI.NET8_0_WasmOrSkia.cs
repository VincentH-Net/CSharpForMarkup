// Start of generated C# Markup API for Uno.WinUI
#if NET8_0 && __WASM_OR_SKIA__ && !DESKTOP && !BROWSERWASM

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
using UnoExtensionsReactive = Uno.Extensions.Reactive;

namespace CSharpMarkup.WinUI.Uno.Extensions.Reactive // ButtonExtensions
{
    public static partial class ButtonExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoExtensionsReactive.UI.ButtonExtensions.IsExecutionTrackingEnabled"/></summary>
        public static TTarget ButtonExtensions_IsExecutionTrackingEnabled<TTarget>(this TTarget target, bool value) where TTarget : ButtonBase
        { UnoExtensionsReactive.UI.ButtonExtensions.SetIsExecutionTrackingEnabled(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.ButtonExtensions.IsExecutionTrackingEnabled"/></summary>
        public static DependencyProperty<TTarget, bool> ButtonExtensions_IsExecutionTrackingEnabled<TTarget>(this TTarget target) where TTarget : ButtonBase
        => DependencyProperty<TTarget, bool>.Get(target, UnoExtensionsReactive.UI.ButtonExtensions.IsExecutionTrackingEnabledProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Extensions.Reactive // FeedView
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoExtensionsReactive.UI.FeedView"/></summary>
        public static FeedView FeedView(Xaml.DataTemplate? ValueTemplate)
        {
            var ui = new UnoExtensionsReactive.UI.FeedView();
            if (ValueTemplate != null) ui.ValueTemplate = ValueTemplate;
            return CSharpMarkup.WinUI.Uno.Extensions.Reactive.FeedView.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoExtensionsReactive.UI.FeedView"/></summary>
        public static FeedView FeedView(Xaml.DataTemplate ErrorTemplate = default, object? None = default, Xaml.DataTemplate? NoneTemplate = default, Xaml.DataTemplate ProgressTemplate = default, UnoExtensionsReactive.UI.FeedViewRefreshState? RefreshingState = default, object? Source = default, object? Undefined = default, Xaml.DataTemplate? UndefinedTemplate = default, UnoExtensionsReactive.UI.FeedViewVisualStateSelector? VisualStateSelector = default, Xaml.DataTemplate? ValueTemplate = default)
        {
            var ui = new UnoExtensionsReactive.UI.FeedView();
            if (ErrorTemplate is not null) ui.ErrorTemplate = ErrorTemplate;
            if (None is not null) ui.None = None;
            if (NoneTemplate is not null) ui.NoneTemplate = NoneTemplate;
            if (ProgressTemplate is not null) ui.ProgressTemplate = ProgressTemplate;
            if (RefreshingState is not null) ui.RefreshingState = RefreshingState.Value;
            if (Source is not null) ui.Source = Source;
            if (Undefined is not null) ui.Undefined = Undefined;
            if (UndefinedTemplate is not null) ui.UndefinedTemplate = UndefinedTemplate;
            if (VisualStateSelector is not null) ui.VisualStateSelector = VisualStateSelector;
            if (ValueTemplate != null) ui.ValueTemplate = ValueTemplate;
            return CSharpMarkup.WinUI.Uno.Extensions.Reactive.FeedView.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoExtensionsReactive.UI.FeedView"/></summary>
        public static FeedView FeedView()
        {
            var ui = new UnoExtensionsReactive.UI.FeedView();
            return CSharpMarkup.WinUI.Uno.Extensions.Reactive.FeedView.StartChain(ui);
        }
    }

    public partial class FeedView : Control, IUI<UnoExtensionsReactive.UI.FeedView>
    {
        static FeedView instance;

        internal static FeedView StartChain(UnoExtensionsReactive.UI.FeedView ui)
        {
            if (instance == null) instance = new FeedView();
            instance.UI = ui;
            return instance;
        }

        UnoExtensionsReactive.UI.FeedView ui;

        public new UnoExtensionsReactive.UI.FeedView UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Xaml.UIElement(FeedView view) => view?.UI;

        public static implicit operator UnoExtensionsReactive.UI.FeedView(FeedView view) => view?.UI;

        public static implicit operator FeedView(UnoExtensionsReactive.UI.FeedView ui) => FeedView.StartChain(ui);

        public FeedView Invoke(Action<UnoExtensionsReactive.UI.FeedView> action) { action?.Invoke(UI); return this; }

        protected FeedView() { }
    }

    public static partial class FeedViewExtensions
    {
        /// <summary>Set <see cref="UnoExtensionsReactive.UI.FeedView.ErrorTemplate"/></summary>
        public static TView ErrorTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : FeedView { view.UI.ErrorTemplate = value; return view; }

        /// <summary>Set <see cref="UnoExtensionsReactive.UI.FeedView.None"/></summary>
        public static TView None<TView>(this TView view, object? value) where TView : FeedView { view.UI.None = value; return view; }

        /// <summary>Set <see cref="UnoExtensionsReactive.UI.FeedView.NoneTemplate"/></summary>
        public static TView NoneTemplate<TView>(this TView view, Xaml.DataTemplate? value) where TView : FeedView { view.UI.NoneTemplate = value; return view; }

        /// <summary>Set <see cref="UnoExtensionsReactive.UI.FeedView.ProgressTemplate"/></summary>
        public static TView ProgressTemplate<TView>(this TView view, Xaml.DataTemplate value) where TView : FeedView { view.UI.ProgressTemplate = value; return view; }

        /// <summary>Set <see cref="UnoExtensionsReactive.UI.FeedView.RefreshingState"/></summary>
        public static TView RefreshingState<TView>(this TView view, UnoExtensionsReactive.UI.FeedViewRefreshState value) where TView : FeedView { view.UI.RefreshingState = value; return view; }

        /// <summary>Set <see cref="UnoExtensionsReactive.UI.FeedView.Source"/></summary>
        public static TView Source<TView>(this TView view, object? value) where TView : FeedView { view.UI.Source = value; return view; }

        /// <summary>Set <see cref="UnoExtensionsReactive.UI.FeedView.Undefined"/></summary>
        public static TView Undefined<TView>(this TView view, object? value) where TView : FeedView { view.UI.Undefined = value; return view; }

        /// <summary>Set <see cref="UnoExtensionsReactive.UI.FeedView.UndefinedTemplate"/></summary>
        public static TView UndefinedTemplate<TView>(this TView view, Xaml.DataTemplate? value) where TView : FeedView { view.UI.UndefinedTemplate = value; return view; }

        /// <summary>Set <see cref="UnoExtensionsReactive.UI.FeedView.VisualStateSelector"/></summary>
        public static TView VisualStateSelector<TView>(this TView view, UnoExtensionsReactive.UI.FeedViewVisualStateSelector? value) where TView : FeedView { view.UI.VisualStateSelector = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.ErrorTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> ErrorTemplate<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, UnoExtensionsReactive.UI.FeedView.ErrorTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.None"/></summary>
        public static DependencyProperty<TTarget, object?> None<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, object?>.Get(target, UnoExtensionsReactive.UI.FeedView.NoneProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.NoneTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate?> NoneTemplate<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, Xaml.DataTemplate?>.Get(target, UnoExtensionsReactive.UI.FeedView.NoneTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.ProgressTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate> ProgressTemplate<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, Xaml.DataTemplate>.Get(target, UnoExtensionsReactive.UI.FeedView.ProgressTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.RefreshingState"/></summary>
        public static DependencyProperty<TTarget, UnoExtensionsReactive.UI.FeedViewRefreshState> RefreshingState<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, UnoExtensionsReactive.UI.FeedViewRefreshState>.Get(target, UnoExtensionsReactive.UI.FeedView.RefreshingStateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.Source"/></summary>
        public static DependencyProperty<TTarget, object?> Source<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, object?>.Get(target, UnoExtensionsReactive.UI.FeedView.SourceProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.State"/></summary>
        public static DependencyProperty<TTarget, UnoExtensionsReactive.UI.FeedViewState> State<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, UnoExtensionsReactive.UI.FeedViewState>.Get(target, UnoExtensionsReactive.UI.FeedView.StateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.Undefined"/></summary>
        public static DependencyProperty<TTarget, object?> Undefined<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, object?>.Get(target, UnoExtensionsReactive.UI.FeedView.UndefinedProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.UndefinedTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate?> UndefinedTemplate<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, Xaml.DataTemplate?>.Get(target, UnoExtensionsReactive.UI.FeedView.UndefinedTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.ValueTemplate"/></summary>
        public static DependencyProperty<TTarget, Xaml.DataTemplate?> ValueTemplate<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, Xaml.DataTemplate?>.Get(target, UnoExtensionsReactive.UI.FeedView.ValueTemplateProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.FeedView.VisualStateSelector"/></summary>
        public static DependencyProperty<TTarget, UnoExtensionsReactive.UI.FeedViewVisualStateSelector?> VisualStateSelector<TTarget>(this TTarget target) where TTarget : FeedView
        => DependencyProperty<TTarget, UnoExtensionsReactive.UI.FeedViewVisualStateSelector?>.Get(target, UnoExtensionsReactive.UI.FeedView.VisualStateSelectorProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Extensions.Reactive // RefreshContainerExtensions
{
    public static partial class RefreshContainerExtensionsExtensions
    {
        /// <summary>Set <see cref="UnoExtensionsReactive.UI.RefreshContainerExtensions.CommandParameter"/></summary>
        public static TTarget RefreshContainerExtensions_CommandParameter<TTarget>(this TTarget target, object? value) where TTarget : RefreshContainer
        { UnoExtensionsReactive.UI.RefreshContainerExtensions.SetCommandParameter(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.RefreshContainerExtensions.CommandParameter"/></summary>
        public static DependencyProperty<TTarget, object?> RefreshContainerExtensions_CommandParameter<TTarget>(this TTarget target) where TTarget : RefreshContainer
        => DependencyProperty<TTarget, object?>.Get(target, UnoExtensionsReactive.UI.RefreshContainerExtensions.CommandParameterProperty);

        /// <summary>Set <see cref="UnoExtensionsReactive.UI.RefreshContainerExtensions.Command"/></summary>
        public static TTarget RefreshContainerExtensions_Command<TTarget>(this TTarget target, ICommand? value) where TTarget : RefreshContainer
        { UnoExtensionsReactive.UI.RefreshContainerExtensions.SetCommand(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.RefreshContainerExtensions.Command"/></summary>
        public static DependencyProperty<TTarget, ICommand?> RefreshContainerExtensions_Command<TTarget>(this TTarget target) where TTarget : RefreshContainer
        => DependencyProperty<TTarget, ICommand?>.Get(target, UnoExtensionsReactive.UI.RefreshContainerExtensions.CommandProperty);

        /// <summary>Set <see cref="UnoExtensionsReactive.UI.RefreshContainerExtensions"/> attached properties</summary>
        public static TTarget RefreshContainerExtensions<TTarget>(this TTarget target

            , object? CommandParameter = default

            , ICommand? Command = default

        ) where TTarget : RefreshContainer
        {
            if (CommandParameter is not null) UnoExtensionsReactive.UI.RefreshContainerExtensions.SetCommandParameter(target.UI, CommandParameter);

            if (Command is not null) UnoExtensionsReactive.UI.RefreshContainerExtensions.SetCommand(target.UI, Command);

            return target;
        }
    }
}

namespace CSharpMarkup.WinUI.Uno.Extensions.Reactive // SmoothVisualStateManager
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="UnoExtensionsReactive.UI.SmoothVisualStateManager"/></summary>
        public static SmoothVisualStateManager SmoothVisualStateManager(params UnoExtensionsReactive.UI.SmoothVisualStateRule[] Rules)
        {
            var ui = new UnoExtensionsReactive.UI.SmoothVisualStateManager();
            for (int i = 0; i < Rules.Length; i++)
            {
                var child = Rules[i];
                if (child == null) continue;

                var subChildren = Spreader<UnoExtensionsReactive.UI.SmoothVisualStateRule>.ExtractChildren(child);
                if (subChildren is not null)
                    for (int j = 0; j < subChildren.Length; j++)
                        ui.Rules.Add(subChildren[j]);
                else
                    ui.Rules.Add(child);
            }
            return CSharpMarkup.WinUI.Uno.Extensions.Reactive.SmoothVisualStateManager.StartChain(ui);
        }

        /// <summary>Create a <see cref="UnoExtensionsReactive.UI.SmoothVisualStateManager"/></summary>
        public static SmoothVisualStateManager SmoothVisualStateManager()
        {
            var ui = new UnoExtensionsReactive.UI.SmoothVisualStateManager();
            return CSharpMarkup.WinUI.Uno.Extensions.Reactive.SmoothVisualStateManager.StartChain(ui);
        }
    }

    public partial class SmoothVisualStateManager : VisualStateManager, IUI<UnoExtensionsReactive.UI.SmoothVisualStateManager>
    {
        static SmoothVisualStateManager instance;

        internal static SmoothVisualStateManager StartChain(UnoExtensionsReactive.UI.SmoothVisualStateManager ui)
        {
            if (instance == null) instance = new SmoothVisualStateManager();
            instance.UI = ui;
            return instance;
        }

        UnoExtensionsReactive.UI.SmoothVisualStateManager ui;

        public new UnoExtensionsReactive.UI.SmoothVisualStateManager UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator UnoExtensionsReactive.UI.SmoothVisualStateManager(SmoothVisualStateManager view) => view?.UI;

        public static implicit operator SmoothVisualStateManager(UnoExtensionsReactive.UI.SmoothVisualStateManager ui) => SmoothVisualStateManager.StartChain(ui);

        public SmoothVisualStateManager Invoke(Action<UnoExtensionsReactive.UI.SmoothVisualStateManager> action) { action?.Invoke(UI); return this; }

        protected SmoothVisualStateManager() { }
    }

    public static partial class SmoothVisualStateManagerExtensions
    {
        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.UI.SmoothVisualStateManager.Rules"/></summary>
        public static DependencyProperty<TTarget, UnoExtensionsReactive.UI.SmoothVisualStateRuleCollection> Rules<TTarget>(this TTarget target) where TTarget : SmoothVisualStateManager
        => DependencyProperty<TTarget, UnoExtensionsReactive.UI.SmoothVisualStateRuleCollection>.Get(target, UnoExtensionsReactive.UI.SmoothVisualStateManager.RulesProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Extensions.Reactive // ViewDebugger
{
    public partial class ViewDebugger : DependencyObject, IUI<UnoExtensionsReactive.ViewDebugger>
    {
        UnoExtensionsReactive.ViewDebugger ui;

        public new UnoExtensionsReactive.ViewDebugger UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public ViewDebugger Invoke(Action<UnoExtensionsReactive.ViewDebugger> action) { action?.Invoke(UI); return this; }

        protected ViewDebugger() { }
    }

    public static partial class ViewDebuggerExtensions
    {
        /// <summary>Set <see cref="UnoExtensionsReactive.ViewDebugger.DataContext"/></summary>
        public static TView DataContext<TView>(this TView view, object value) where TView : ViewDebugger { view.UI.DataContext = value; return view; }

        /// <summary>Set <see cref="UnoExtensionsReactive.ViewDebugger.TemplatedParent"/></summary>
        public static TView TemplatedParent<TView>(this TView view, Xaml.DependencyObject value) where TView : ViewDebugger { view.UI.TemplatedParent = value; return view; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.ViewDebugger.DataContext"/></summary>
        public static DependencyProperty<TTarget, object> DataContext<TTarget>(this TTarget target) where TTarget : ViewDebugger
        => DependencyProperty<TTarget, object>.Get(target, UnoExtensionsReactive.ViewDebugger.DataContextProperty);

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.ViewDebugger.TemplatedParent"/></summary>
        public static DependencyProperty<TTarget, Xaml.DependencyObject> TemplatedParent<TTarget>(this TTarget target) where TTarget : ViewDebugger
        => DependencyProperty<TTarget, Xaml.DependencyObject>.Get(target, UnoExtensionsReactive.ViewDebugger.TemplatedParentProperty);

        /// <summary>Set <see cref="UnoExtensionsReactive.ViewDebugger.AvailableVisualStates"/></summary>
        public static TTarget ViewDebugger_AvailableVisualStates<TTarget>(this TTarget target, string? value) where TTarget : Control
        { UnoExtensionsReactive.ViewDebugger.SetAvailableVisualStates(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.ViewDebugger.AvailableVisualStates"/></summary>
        public static DependencyProperty<TTarget, string?> ViewDebugger_AvailableVisualStates<TTarget>(this TTarget target) where TTarget : Control
        => DependencyProperty<TTarget, string?>.Get(target, UnoExtensionsReactive.ViewDebugger.AvailableVisualStatesProperty);

        /// <summary>Set <see cref="UnoExtensionsReactive.ViewDebugger.VisualStates"/></summary>
        public static TTarget ViewDebugger_VisualStates<TTarget>(this TTarget target, string? value) where TTarget : Control
        { UnoExtensionsReactive.ViewDebugger.SetVisualStates(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.ViewDebugger.VisualStates"/></summary>
        public static DependencyProperty<TTarget, string?> ViewDebugger_VisualStates<TTarget>(this TTarget target) where TTarget : Control
        => DependencyProperty<TTarget, string?>.Get(target, UnoExtensionsReactive.ViewDebugger.VisualStatesProperty);

        /// <summary>Set <see cref="UnoExtensionsReactive.ViewDebugger"/> attached properties</summary>
        public static TTarget ViewDebugger<TTarget>(this TTarget target

            , string? AvailableVisualStates = default

            , string? VisualStates = default

            , bool? IsEnabled = default

        ) where TTarget : Control
        {
            if (AvailableVisualStates is not null) UnoExtensionsReactive.ViewDebugger.SetAvailableVisualStates(target.UI, AvailableVisualStates);

            if (VisualStates is not null) UnoExtensionsReactive.ViewDebugger.SetVisualStates(target.UI, VisualStates);

            if (IsEnabled is not null) UnoExtensionsReactive.ViewDebugger.SetIsEnabled(target.UI, IsEnabled.Value);

            return target;
        }

        /// <summary>Set <see cref="UnoExtensionsReactive.ViewDebugger.IsEnabled"/></summary>
        public static TTarget ViewDebugger_IsEnabled<TTarget>(this TTarget target, bool value) where TTarget : UIElement
        { UnoExtensionsReactive.ViewDebugger.SetIsEnabled(target.UI, value); return target; }

        /// <summary>Bind (or set enum value of) <see cref="UnoExtensionsReactive.ViewDebugger.IsEnabled"/></summary>
        public static DependencyProperty<TTarget, bool> ViewDebugger_IsEnabled<TTarget>(this TTarget target) where TTarget : UIElement
        => DependencyProperty<TTarget, bool>.Get(target, UnoExtensionsReactive.ViewDebugger.IsEnabledProperty);
    }
}

namespace CSharpMarkup.WinUI.Uno.Extensions.Reactive // EnumPropertyValues
{
    public static partial class FeedViewExtensions
    {
        /// <summary>Set to <see cref="UnoExtensionsReactive.UI.FeedViewRefreshState.Default"/></summary>
        public static TTarget Default<TTarget>(this DependencyProperty<TTarget, UnoExtensionsReactive.UI.FeedViewRefreshState> property) where TTarget : FeedView
        => property.Set(UnoExtensionsReactive.UI.FeedViewRefreshState.Default);

        /// <summary>Set to <see cref="UnoExtensionsReactive.UI.FeedViewRefreshState.Loading"/></summary>
        public static TTarget Loading<TTarget>(this DependencyProperty<TTarget, UnoExtensionsReactive.UI.FeedViewRefreshState> property) where TTarget : FeedView
        => property.Set(UnoExtensionsReactive.UI.FeedViewRefreshState.Loading);

        /// <summary>Set to <see cref="UnoExtensionsReactive.UI.FeedViewRefreshState.None"/></summary>
        public static TTarget None<TTarget>(this DependencyProperty<TTarget, UnoExtensionsReactive.UI.FeedViewRefreshState> property) where TTarget : FeedView
        => property.Set(UnoExtensionsReactive.UI.FeedViewRefreshState.None);
    }
}

#endif
// End of generated C# Markup API for Uno.WinUI
