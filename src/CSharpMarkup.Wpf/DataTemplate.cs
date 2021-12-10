using System;
using System.Collections.Generic;
using System.Security;
using CSharpMarkup.Wpf.Delegators;
using Windows = System.Windows;
using Controls = System.Windows.Controls;
using System.IO;
using System.Xml;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        public static DataTemplate DataTemplate(Func<UIElement> build) => DataTemplate<Windows.Controls.Grid>(build);

        public static DataTemplate DataTemplate(Action<Windows.DependencyObject> build) => DataTemplate<Windows.Controls.Grid>(build);

        public static DataTemplate DataTemplate<TRootUI>(Func<UIElement> build) where TRootUI : Windows.Controls.Panel
        {
            string id = BuildChild.CreateIdFor(build);
            string idp = $"BuildChild.IdProperty = {BuildChild.IdProperty}"; // TODO: attempt fix remove
            string xaml =
                $@"<DataTemplate
					xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
					xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""
                    xmlns:root=""clr-namespace:{typeof(TRootUI).Namespace};assembly={typeof(TRootUI).Assembly.FullName}""
                    xmlns:delegators=""clr-namespace:{typeof(BuildChild).Namespace};assembly={typeof(BuildChild).Assembly.FullName}"">
                    <root:{typeof(TRootUI).Name} delegators:BuildChild.Id=""{SecurityElement.Escape(id)}"" />
				</DataTemplate>";

            var ui = Windows.Markup.XamlReader.Load(XmlReader.Create(new StringReader(xaml))) as Windows.DataTemplate;
            return CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }

        public static DataTemplate DataTemplate<TRootUI>(Action<Windows.DependencyObject> build) where TRootUI : Windows.UIElement, new()
        {
            // Note that we cannot pass markup objects to the build action here, because we get the ui type instance.
            string id = ConfigureRoot.CreateIdFor(build);
            string idp = $"BuildChild.IdProperty = {BuildChild.IdProperty}"; // TODO: attempt fix remove
            string xaml =
                $@"<DataTemplate
					xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
					xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""
                    xmlns:root=""clr-namespace:{typeof(TRootUI).Namespace};assembly={typeof(TRootUI).Assembly.FullName}""
                    xmlns:delegators=""clr-namespace:{typeof(ConfigureRoot).Namespace};assembly={typeof(ConfigureRoot).Assembly.FullName}"">
				  <root:{typeof(TRootUI).Name} delegators:ConfigureRoot.Id=""{SecurityElement.Escape(id)}"" />
				</DataTemplate>";

            var ui = Windows.Markup.XamlReader.Load(XmlReader.Create(new StringReader(xaml))) as Windows.DataTemplate;
            return CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }
    }
}

// Below is from generated code when DispatcherObject is used as the view base type
// Only manual change is IUI to IUI_Dispatcher
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

