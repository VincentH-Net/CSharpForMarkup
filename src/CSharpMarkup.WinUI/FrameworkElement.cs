using System;
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

        ///<summary>Short for:<code>Width(size).Height(size)</code></summary>
        [ShortFor("Width(size).Height(size)")]
        public static TFrameworkElement Size<TFrameworkElement>(this TFrameworkElement frameworkElement, double size) where TFrameworkElement : FrameworkElement
        { frameworkElement.UI.Width = size; frameworkElement.UI.Height = size; return frameworkElement; }
    }

    public static partial class FrameworkElementExtensions
    {
        public static TTarget OnDataContextChanged<TTarget, TUI, TContext>(this TTarget target, Action<TUI, TContext> onChanged)
            where TTarget : FrameworkElement where TUI : Microsoft.UI.Xaml.FrameworkElement
        {
            target.UI.DataContextChanged += (s, a) => onChanged((TUI)s, (TContext)a.NewValue);
            return target;
        }
    }
}
