using System;
using Windows = System.Windows;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        ///<summary>Short for:<code>.HorizontalAlignment().Left()</code></summary>
        [ShortFor("HorizontalAlignment().Left()")]
        public static TFrameworkElement Left<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.HorizontalAlignment = Windows.HorizontalAlignment.Left; return frameworkElement; }

        ///<summary>Short for:<code>.HorizontalAlignment().Center()</code></summary>
        [ShortFor("HorizontalAlignment().Center()")]
        public static TFrameworkElement HCenter<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.HorizontalAlignment = Windows.HorizontalAlignment.Center; return frameworkElement; }

        ///<summary>Short for:<code>.HorizontalAlignment().Right()</code></summary>
        [ShortFor("HorizontalAlignment().Right()")]
        public static TFrameworkElement Right<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.HorizontalAlignment = Windows.HorizontalAlignment.Right; return frameworkElement; }

        ///<summary>Short for:<code>.VerticalAlignment().Top()</code></summary>
        [ShortFor("VerticalAlignment().Top()")]
        public static TFrameworkElement Top<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.VerticalAlignment = Windows.VerticalAlignment.Top; return frameworkElement; }

        ///<summary>Short for:<code>.VerticalAlignment().Center()</code></summary>
        [ShortFor("VerticalAlignment().Center()")]
        public static TFrameworkElement VCenter<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.VerticalAlignment = Windows.VerticalAlignment.Center; return frameworkElement; }

        ///<summary>Short for:<code>.VerticalAlignment().Bottom()</code></summary>
        [ShortFor("VerticalAlignment().Bottom()")]
        public static TFrameworkElement Bottom<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.VerticalAlignment = Windows.VerticalAlignment.Bottom; return frameworkElement; }

        ///<summary>Short for:<code>HorizontalAlignment().Center() .VerticalAlignment().Center()</code></summary>
        [ShortFor("HorizontalAlignment().Center() .VerticalAlignment().Center()")]
        public static TFrameworkElement Center<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.HorizontalAlignment = Windows.HorizontalAlignment.Center; frameworkElement.UI.VerticalAlignment = Windows.VerticalAlignment.Center; return frameworkElement; }

        ///<summary>Short for:<code>Width(size).Height(size)</code></summary>
        [ShortFor("Width(size).Height(size)")]
        public static TFrameworkElement Size<TFrameworkElement>(this TFrameworkElement frameworkElement, double size) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.Width = size; frameworkElement.UI.Height = size; return frameworkElement; }

        /// <summary>Assign key - <see cref="DispatcherObject"/> pairs to <see cref="Windows.FrameworkElement.Resources"/></summary>
        public static TView Resources<TView>(this TView view, params (object key, UIObject value)[] keyValuePairs) where TView : FrameworkElement
        {
            var resources = new Windows.ResourceDictionary();
            foreach ((var key, var value) in keyValuePairs) resources.Add(key, value.UI);
            view.UI.Resources = resources; return view; 
        }

        /// <summary>Create a <see cref="Windows.VisualStateGroup"/></summary>
        public static VisualStateGroup VisualStateGroup(string name, Windows.VisualState[] states = null, Windows.VisualTransition[] transitions = null)
        {
            var ui = new Windows.VisualStateGroup { Name = name };
            if (states != null) foreach (var state in states) ui.States.Add(state);
            if (transitions != null) foreach (var transition in transitions) ui.Transitions.Add(transition);
            return CSharpMarkup.Wpf.VisualStateGroup.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.VisualStateGroup"/></summary>
        public static VisualStateGroup VisualStateGroup(string name, params Windows.VisualState[] states) => VisualStateGroup(name, states, null);

        public static Windows.VisualState[] VisualStates(params Windows.VisualState[] states) => states;

        public static Windows.VisualTransition[] VisualTransitions(params Windows.VisualTransition[] transitions) => transitions;
    }

    public static partial class FrameworkElementExtensions
    {
        public static TTarget OnDataContextChanged<TTarget, TUI, TContext>(this TTarget target, Action<TUI, TContext> onChanged)
            where TTarget : FrameworkElement where TUI : Windows.FrameworkElement
        {
            target.UI.DataContextChanged += (s, a) => onChanged((TUI)s, (TContext)a.NewValue);
            return target;
        }

        public static TTarget VisualStateGroups<TTarget>(this TTarget target, params Windows.VisualStateGroup[] groups)
            where TTarget : FrameworkElement
        {
            var groupList = Windows.VisualStateManager.GetVisualStateGroups(target);
            groupList.Clear();
            foreach (var group in groups) groupList.Add(group);
            return target;
        }
    }
}
