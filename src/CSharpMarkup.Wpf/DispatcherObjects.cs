using System;
using Windows = System.Windows;

namespace CSharpMarkup.Wpf
{
    public interface IUI_Dispatcher<TUI> where TUI : Windows.Threading.DispatcherObject
    {
        TUI UI { get; }
    }

    public partial class DispatcherObject : IUI_Dispatcher<Windows.Threading.DispatcherObject>
    {
        public Windows.Threading.DispatcherObject UI { get; protected set; }

        protected DispatcherObject() { }
    }
}

/*  All property types in WPF 6.0.0 namespaces that we generate code for, that are DispatcherObject but not DependencyObject:
    System.Windows.Media.Imaging.BitmapPalette
    System.Windows.Style
    System.Windows.DataTemplate
    System.Windows.Controls.ControlTemplate
    System.Windows.Controls.ItemsPanelTemplate

    Below is from generated code when DispatcherObject is used as the view base type
    Only manual change is IUI to IUI_Dispatcher */

namespace CSharpMarkup.Wpf // DataTemplate
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.DataTemplate"/></summary>
        public static DataTemplate DataTemplate(O<object> DataType = default)
        {
            var ui = new Windows.DataTemplate();
            if (DataType.HasValue) ui.DataType = DataType.Value;
            return global::CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.DataTemplate"/></summary>
        public static DataTemplate DataTemplate()
        {
            var ui = new Windows.DataTemplate();
            return global::CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.DataTemplate"/></summary>
        public static DataTemplate DataTemplate(object dataType)
        {
            var ui = new Windows.DataTemplate(dataType);
            return global::CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }
    }

    public partial class DataTemplate : FrameworkTemplate, IUI_Dispatcher<System.Windows.DataTemplate>
    {
        static DataTemplate instance;

        internal static DataTemplate StartChain(Windows.DataTemplate ui)
        {
            if (instance == null) instance = new DataTemplate();
            instance.UI = ui;
            return instance;
        }

        Windows.DataTemplate ui;

        public new Windows.DataTemplate UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.DataTemplate(DataTemplate view) => view?.UI;

        public static implicit operator DataTemplate(Windows.DataTemplate ui) => DataTemplate.StartChain(ui);

        protected DataTemplate() { }
    }

    public static partial class DataTemplateExtensions
    {
        /// <summary>Set <see cref="Windows.DataTemplate.DataType"/></summary>
        public static TView DataType<TView>(this TView view, object value) where TView : DataTemplate { view.UI.DataType = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // FrameworkTemplate
{
    public partial class FrameworkTemplate : DispatcherObject, IUI_Dispatcher<System.Windows.FrameworkTemplate>
    {
        Windows.FrameworkTemplate ui;

        public new Windows.FrameworkTemplate UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected FrameworkTemplate() { }
    }

    public static partial class FrameworkTemplateExtensions
    {
        /// <summary>Set <see cref="Windows.FrameworkTemplate.Resources"/></summary>
        public static TView Resources<TView>(this TView view, Windows.ResourceDictionary value) where TView : FrameworkTemplate { view.UI.Resources = value; return view; }

        /// <summary>Set <see cref="Windows.FrameworkTemplate.Template"/></summary>
        public static TView Template<TView>(this TView view, Windows.TemplateContent value) where TView : FrameworkTemplate { view.UI.Template = value; return view; }

        /// <summary>Set <see cref="Windows.FrameworkTemplate.VisualTree"/></summary>
        public static TView VisualTree<TView>(this TView view, Windows.FrameworkElementFactory value) where TView : FrameworkTemplate { view.UI.VisualTree = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // Style
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style(O<Windows.Style> BasedOn = default, O<Windows.ResourceDictionary> Resources = default, O<Type> TargetType = default)
        {
            var ui = new Windows.Style();
            if (BasedOn.HasValue) ui.BasedOn = BasedOn.Value;
            if (Resources.HasValue) ui.Resources = Resources.Value;
            if (TargetType.HasValue) ui.TargetType = TargetType.Value;
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style()
        {
            var ui = new Windows.Style();
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style(Type targetType)
        {
            var ui = new Windows.Style(targetType);
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style(Type targetType, Windows.Style basedOn)
        {
            var ui = new Windows.Style(targetType, basedOn);
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }
    }

    public partial class Style : DispatcherObject, IUI_Dispatcher<System.Windows.Style>
    {
        static Style instance;

        internal static Style StartChain(Windows.Style ui)
        {
            if (instance == null) instance = new Style();
            instance.UI = ui;
            return instance;
        }

        Windows.Style ui;

        public new Windows.Style UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Style(Style view) => view?.UI;

        public static implicit operator Style(Windows.Style ui) => Style.StartChain(ui);

        protected Style() { }
    }

    public static partial class StyleExtensions
    {
        /// <summary>Set <see cref="Windows.Style.BasedOn"/></summary>
        public static TView BasedOn<TView>(this TView view, Windows.Style value) where TView : Style { view.UI.BasedOn = value; return view; }

        /// <summary>Set <see cref="Windows.Style.Resources"/></summary>
        public static TView Resources<TView>(this TView view, Windows.ResourceDictionary value) where TView : Style { view.UI.Resources = value; return view; }

        /// <summary>Set <see cref="Windows.Style.TargetType"/></summary>
        public static TView TargetType<TView>(this TView view, Type value) where TView : Style { view.UI.TargetType = value; return view; }
    }
}