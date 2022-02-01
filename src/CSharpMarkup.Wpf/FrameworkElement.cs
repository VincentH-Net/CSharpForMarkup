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
        public static TView Resources<TView>(this TView view, params (object key, UIDispatcherObject value)[] keyValuePairs) where TView : FrameworkElement
        {
            var resources = new Windows.ResourceDictionary();
            foreach (var keyValue in keyValuePairs)
                resources.Add(keyValue.key, keyValue.value.UI);
            view.UI.Resources = resources; return view; 
        }
    }

    public static partial class FrameworkElementExtensions
    {
        public static TTarget OnDataContextChanged<TTarget, TUI, TContext>(this TTarget target, Action<TUI, TContext> onChanged)
            where TTarget : FrameworkElement where TUI : Windows.FrameworkElement
        {
            target.UI.DataContextChanged += (s, a) => onChanged((TUI)s, (TContext)a.NewValue);
            return target;
        }
    }
}
