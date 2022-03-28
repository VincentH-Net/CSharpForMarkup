using CSharpMarkup.Wpf.Delegators;
using System;
using System.IO;
using System.Security;
using System.Xml;
using Controls = System.Windows.Controls;
using Windows = System.Windows;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        public static DataTemplate DataTemplate(Func<UIElement> build) => DataTemplate<Controls.Grid>(build);

        public static DataTemplate DataTemplate(Action<Windows.DependencyObject> build) => DataTemplate<Controls.Grid>(build);

        public static DataTemplate DataTemplate<TRootUI>(Func<UIElement> build) where TRootUI : Controls.Panel, new()
        {
            var ui = (Windows.DataTemplate)CreateTemplate(nameof(Windows.DataTemplate), typeof(TRootUI), false, BuildChild.CreateIdFor(build));
            return CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }

        public static DataTemplate DataTemplate<TRootUI>(Action<Windows.DependencyObject> build) where TRootUI : Windows.DependencyObject, new()
        {
            // Note that we cannot pass markup objects to the build action here, because we get the ui type instance.
            var ui = (Windows.DataTemplate)CreateTemplate(nameof(Windows.DataTemplate), typeof(TRootUI), true, ConfigureRoot.CreateIdFor(build));
            return CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }

        public static ItemsPanelTemplate ItemsPanelTemplate(Func<UIElement> build, Type targetType = null) => ItemsPanelTemplate<Controls.Grid>(build, targetType);

        public static ItemsPanelTemplate ItemsPanelTemplate(Action<Windows.DependencyObject> build, Type targetType = null) => ItemsPanelTemplate<Controls.Grid>(build, targetType);

        public static ItemsPanelTemplate ItemsPanelTemplate<TRootUI>(Func<UIElement> build, Type targetType = null) where TRootUI : Controls.Panel, new()
        {
            var ui = (Windows.Controls.ItemsPanelTemplate)CreateTemplate(nameof(Windows.Controls.ItemsPanelTemplate), build().UI, targetType);
            return CSharpMarkup.Wpf.ItemsPanelTemplate.StartChain(ui);
        }

        public static ItemsPanelTemplate ItemsPanelTemplate<TRootUI>(Action<Windows.DependencyObject> build, Type targetType = null) where TRootUI : Windows.DependencyObject, new()
        {
            var root = new TRootUI();
            build(root);
            var ui = (Windows.Controls.ItemsPanelTemplate)CreateTemplate(nameof(Windows.Controls.ItemsPanelTemplate), root, targetType);
            return CSharpMarkup.Wpf.ItemsPanelTemplate.StartChain(ui);
        }

        public static ControlTemplate ControlTemplate(Func<UIElement> build, Type targetType = null) => ControlTemplate<Controls.Grid>(build, targetType);

        public static ControlTemplate ControlTemplate(Action<Windows.DependencyObject> build, Type targetType = null) => ControlTemplate<Controls.Grid>(build, targetType);

        public static ControlTemplate ControlTemplate<TRootUI>(Func<UIElement> build, Type targetType = null) where TRootUI : Controls.Panel, new()
        {
            var ui = (Windows.Controls.ControlTemplate)CreateTemplate(nameof(Windows.Controls.ControlTemplate), build().UI, targetType);
            return CSharpMarkup.Wpf.ControlTemplate.StartChain(ui);
        }

        public static ControlTemplate ControlTemplate<TRootUI>(Action<Windows.DependencyObject> build, Type targetType = null) where TRootUI : Windows.DependencyObject, new()
        {
            var root = new TRootUI();
            build(root);
            var ui = (Windows.Controls.ControlTemplate)CreateTemplate(nameof(Windows.Controls.ControlTemplate), root, targetType);
            return CSharpMarkup.Wpf.ControlTemplate.StartChain(ui);
        }

        // This method overload uses delegators as attached properties; prefer to use the CreateTemplate overload that uses XamlWriter + XamlReader
        // because that only creates the template content once while this overload creates the template content for each template application.
        // However, keep this overload because there may be limitations (possibly platform specific) to XamlWriter + XamlReader, in which case we can use this as an alternative.
        static object CreateTemplate(string templateTypeName, Type rootUIType, bool isConfigureRootDelegator, string delegatorId, Type targetType = null)
        {
            string xaml =
                $@"<{templateTypeName}{(targetType is null ? "" : $" TargetType=\"{targetType.Name}\"")}
					xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
					xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""
                    xmlns:root=""clr-namespace:{rootUIType.Namespace};assembly={rootUIType.Assembly.FullName}""
                    xmlns:delegators=""clr-namespace:{typeof(BuildChild).Namespace};assembly={typeof(BuildChild).Assembly.FullName}"">
                    <root:{rootUIType.Name} delegators:{(isConfigureRootDelegator ? "ConfigureRoot" : "BuildChild")}.Id=""{SecurityElement.Escape(delegatorId)}"" />
				</{templateTypeName}>";

             return Windows.Markup.XamlReader.Load(XmlReader.Create(new StringReader(xaml)));
        }

        static object CreateTemplate(string templateTypeName, object content, Type targetType = null)
        {
            var contentXamlStringBuilder = new System.Text.StringBuilder();
            var dsm = new Windows.Markup.XamlDesignerSerializationManager(XmlWriter.Create(contentXamlStringBuilder, new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true, NamespaceHandling = NamespaceHandling.OmitDuplicates }));
            dsm.XamlWriterMode = Windows.Markup.XamlWriterMode.Expression; // Save bindings as expressions - uses the registered ExpressionConverter for Bindings. Source: https://www.codeproject.com/Articles/27158/XamlWriter-and-Bindings-Serialization
            BindingConverter.EnsureRegistered();

            Windows.Markup.XamlWriter.Save(content, dsm);
            var contentXaml = contentXamlStringBuilder.ToString();

            string xaml =
                $@"<{templateTypeName}{(targetType is null ? "" : $" TargetType=\"{targetType.Name}\"")}
					xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
					xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" >
                    {contentXaml}
				</{templateTypeName}>";

            return Windows.Markup.XamlReader.Load(XmlReader.Create(new StringReader(xaml)));
        }
    }

    class BindingConverter : Windows.ExpressionConverter
    {
        static bool isRegistered = false;

        internal static void EnsureRegistered()
        {
            if (isRegistered) return;
            System.ComponentModel.TypeDescriptor.AddAttributes(typeof(System.Windows.Data.BindingExpression), new Attribute[] { new System.ComponentModel.TypeConverterAttribute(typeof(BindingConverter)) });
            isRegistered = true;
        }

        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, Type destinationType)
            => destinationType == typeof(System.Windows.Markup.MarkupExtension);

        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
            => ((System.Windows.Data.BindingExpression)value).ParentBinding;
    }
}