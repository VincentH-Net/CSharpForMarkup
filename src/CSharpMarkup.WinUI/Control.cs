using Xaml = Microsoft.UI.Xaml;

namespace CSharpMarkup.WinUI
{
    public static partial class Helpers
    {
        ///<summary>Short for:<code>.HorizontalContentAlignment().Left()</code></summary>
        [ShortFor("HorizontalContentAlignment().Left()")]
        public static TControl LeftContent<TControl>(this TControl control) where TControl : Control
        { control.UI.HorizontalContentAlignment = Xaml.HorizontalAlignment.Left; return control; }

        ///<summary>Short for:<code>.HorizontalContentAlignment().Center()</code></summary>
        [ShortFor("HorizontalContentAlignment().Center()")]
        public static TControl HCenterContent<TControl>(this TControl control) where TControl : Control
        { control.UI.HorizontalContentAlignment = Xaml.HorizontalAlignment.Center; return control; }

        ///<summary>Short for:<code>.HorizontalContentAlignment().Right()</code></summary>
        [ShortFor("HorizontalContentAlignment().Right()")]
        public static TControl RightContent<TControl>(this TControl control) where TControl : Control
        { control.UI.HorizontalContentAlignment = Xaml.HorizontalAlignment.Right; return control; }

        ///<summary>Short for:<code>.VerticalContentAlignment().Top()</code></summary>
        [ShortFor("VerticalContentAlignment().Top()")]
        public static TControl TopContent<TControl>(this TControl control) where TControl : Control
        { control.UI.VerticalContentAlignment = Xaml.VerticalAlignment.Top; return control; }

        ///<summary>Short for:<code>.VerticalContentAlignment().Center()</code></summary>
        [ShortFor("VerticalContentAlignment().Center()")]
        public static TControl VCenterContent<TControl>(this TControl control) where TControl : Control
        { control.UI.VerticalContentAlignment = Xaml.VerticalAlignment.Center; return control; }

        ///<summary>Short for:<code>.VerticalContentAlignment().Bottom()</code></summary>
        [ShortFor("VerticalContentAlignment().Bottom()")]
        public static TControl BottomContent<TControl>(this TControl control) where TControl : Control
        { control.UI.VerticalContentAlignment = Xaml.VerticalAlignment.Bottom; return control; }

        ///<summary>Short for:<code>HorizontalContentAlignment().Center() .VerticalContentAlignment().Center()</code></summary>
        [ShortFor("HorizontalContentAlignment().Center() .VerticalContentAlignment().Center()")]
        public static TControl CenterContent<TControl>(this TControl control) where TControl : Control
        { control.UI.HorizontalContentAlignment = Xaml.HorizontalAlignment.Center; control.UI.VerticalContentAlignment = Xaml.VerticalAlignment.Center; return control; }

        ///<summary>Short for:<code>HorizontalContentAlignment().Center() .VerticalContentAlignment().Center()</code></summary>
        [ShortFor("HorizontalContentAlignment().Stretch() .VerticalContentAlignment().Stretch()")]
        public static TControl StretchContent<TControl>(this TControl control) where TControl : Control
        { control.UI.HorizontalContentAlignment = Xaml.HorizontalAlignment.Stretch; control.UI.VerticalContentAlignment = Xaml.VerticalAlignment.Stretch; return control; }
    }
}