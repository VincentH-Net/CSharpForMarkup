using System;
using System.Runtime.Versioning;
using Xaml = Microsoft.UI.Xaml;

namespace CSharpMarkup.WinUI
{
    public static partial class Helpers
    {
        ///<summary>Short for:<code>.HorizontalAlignment().Left()</code></summary>
        [ShortFor("HorizontalAlignment().Left()")]
        public static TFrameworkElement Left<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.HorizontalAlignment = Xaml.HorizontalAlignment.Left; return frameworkElement; }

        ///<summary>Short for:<code>.HorizontalAlignment().Center()</code></summary>
        [ShortFor("HorizontalAlignment().Center()")]
        public static TFrameworkElement HCenter<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.HorizontalAlignment = Xaml.HorizontalAlignment.Center; return frameworkElement; }

        ///<summary>Short for:<code>.HorizontalAlignment().Right()</code></summary>
        [ShortFor("HorizontalAlignment().Right()")]
        public static TFrameworkElement Right<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.HorizontalAlignment = Xaml.HorizontalAlignment.Right; return frameworkElement; }

        ///<summary>Short for:<code>.VerticalAlignment().Top()</code></summary>
        [ShortFor("VerticalAlignment().Top()")]
        public static TFrameworkElement Top<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.VerticalAlignment = Xaml.VerticalAlignment.Top; return frameworkElement; }

        ///<summary>Short for:<code>.VerticalAlignment().Center()</code></summary>
        [ShortFor("VerticalAlignment().Center()")]
        public static TFrameworkElement VCenter<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.VerticalAlignment = Xaml.VerticalAlignment.Center; return frameworkElement; }

        ///<summary>Short for:<code>.VerticalAlignment().Bottom()</code></summary>
        [ShortFor("VerticalAlignment().Bottom()")]
        public static TFrameworkElement Bottom<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.VerticalAlignment = Xaml.VerticalAlignment.Bottom; return frameworkElement; }

        ///<summary>Short for:<code>HorizontalAlignment().Center() .VerticalAlignment().Center()</code></summary>
        [ShortFor("HorizontalAlignment().Center() .VerticalAlignment().Center()")]
        public static TFrameworkElement Center<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.HorizontalAlignment = Xaml.HorizontalAlignment.Center; frameworkElement.UI.VerticalAlignment = Xaml.VerticalAlignment.Center; return frameworkElement; }

        ///<summary>Short for:<code>HorizontalAlignment().Center() .VerticalAlignment().Center()</code></summary>
        [ShortFor("HorizontalAlignment().Stretch() .VerticalAlignment().Stretch()")]
        public static TFrameworkElement Stretch<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.HorizontalAlignment = Xaml.HorizontalAlignment.Stretch; frameworkElement.UI.VerticalAlignment = Xaml.VerticalAlignment.Stretch; return frameworkElement; }

        ///<summary>Short for:<code>Width(size).Height(size)</code></summary>
        [ShortFor("Width(size).Height(size)")]
        public static TFrameworkElement Size<TFrameworkElement>(this TFrameworkElement frameworkElement, double size) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.Width = size; frameworkElement.UI.Height = size; return frameworkElement; }

        /// <summary>Assign key - <see cref="DependencyObject"/> pairs to <see cref="Xaml.FrameworkElement.Resources"/></summary>
        public static TView Resources<TView>(this TView view, params (object key, UIObject value)[] keyValuePairs) where TView : FrameworkElement
        {
            var resources = new Xaml.ResourceDictionary();
            foreach ((var key, var value) in keyValuePairs) resources.Add(key, value.UI);
            view.UI.Resources = resources; return view;
        }

#if HAS_UNO // WinUI does not allow setting the Name of the VisualStateGroup from C# - while Uno and WPF do allow that
        /// <summary>Create a <see cref="Xaml.VisualStateGroup"/></summary>
        public static VisualStateGroup VisualStateGroup(string name, Xaml.VisualState[] states = null, Xaml.VisualTransition[] transitions = null)
        {
            var ui = new Xaml.VisualStateGroup {  Name = name };
            if (states != null) foreach (var state in states) ui.States.Add(state);
            if (transitions != null) foreach (var transition in transitions) ui.Transitions.Add(transition);
            return CSharpMarkup.WinUI.VisualStateGroup.StartChain(ui);
        }

        /// <summary>Create a <see cref="Xaml.VisualStateGroup"/></summary>
        public static VisualStateGroup VisualStateGroup(string name, params Xaml.VisualState[] states) => VisualStateGroup(name, states, null);

        public static Xaml.VisualState[] VisualStates(params Xaml.VisualState[] states) => states;

        public static Xaml.VisualTransition[] VisualTransitions(params Xaml.VisualTransition[] transitions) => transitions;
#endif

#if __ANDROID__
        public static FrameworkElement Native(Android.Views.View view) => FrameworkElementFromNative.StartChain(Microsoft.UI.Xaml.Media.VisualTreeHelper.AdaptNative(view));
#endif
    }

#if __ANDROID__
    internal class FrameworkElementFromNative : FrameworkElement
    {
        static FrameworkElementFromNative instance;

        internal static FrameworkElementFromNative StartChain(Xaml.FrameworkElement ui)
        {
            if (instance == null) instance = new FrameworkElementFromNative();
            instance.UI = ui;
            return instance;
        }
    }
#endif

    public static partial class FrameworkElementExtensions
    {
        public static TTarget OnDataContextChanged<TTarget, TUI, TContext>(this TTarget target, Action<TUI, TContext> onChanged)
            where TTarget : FrameworkElement where TUI : Microsoft.UI.Xaml.FrameworkElement
        {
            target.UI.DataContextChanged += (s, a) => onChanged((TUI)s, (TContext)a.NewValue);
            return target;
        }

#if HAS_UNO // WinUI does not allow setting the Name of the VisualStateGroup from C# - while Uno and WPF do allow that
        public static TTarget VisualStateGroups<TTarget>(this TTarget target, params Xaml.VisualStateGroup[] groups)
            where TTarget : FrameworkElement
        {
            var groupList = Xaml.VisualStateManager.GetVisualStateGroups(target?.UI);
            groupList.Clear();
            foreach (var group in groups) groupList.Add(group);
            return target;
        }
#else
        [UnsupportedOSPlatform("Windows", VisualStateManagerExtensions.UnsupportedErrorMessage)]
        public static TTarget VisualStateGroups<TTarget>(this TTarget target, params Xaml.VisualStateGroup[] groups)
            where TTarget : FrameworkElement
        => throw new NotImplementedException();
#endif
    }
}
