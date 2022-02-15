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

        public static DataTemplate DataTemplate<TRootUI>(Func<UIElement> build) where TRootUI : Controls.Panel
        {
            string id = BuildChild.CreateIdFor(build);
            string xaml =
                $@"<DataTemplate
					xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
					xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""
                    xmlns:root=""clr-namespace:{typeof(TRootUI).Namespace};assembly={typeof(TRootUI).Assembly.FullName}""
                    xmlns:delegators=""clr-namespace:{typeof(BuildChild).Namespace};assembly={typeof(BuildChild).Assembly.FullName}"">
                    <root:{typeof(TRootUI).Name} delegators:BuildChild.Id=""{SecurityElement.Escape(id)}"" />
				</DataTemplate>";

            var ui = (Windows.DataTemplate)Windows.Markup.XamlReader.Load(XmlReader.Create(new StringReader(xaml)));
            return CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }

        public static DataTemplate DataTemplate<TRootUI>(Action<Windows.DependencyObject> build) where TRootUI : Windows.UIElement, new()
        {
            // Note that we cannot pass markup objects to the build action here, because we get the ui type instance.
            string id = ConfigureRoot.CreateIdFor(build);
            string xaml =
                $@"<DataTemplate
					xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
					xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml""
                    xmlns:root=""clr-namespace:{typeof(TRootUI).Namespace};assembly={typeof(TRootUI).Assembly.FullName}""
                    xmlns:delegators=""clr-namespace:{typeof(ConfigureRoot).Namespace};assembly={typeof(ConfigureRoot).Assembly.FullName}"">
				  <root:{typeof(TRootUI).Name} delegators:ConfigureRoot.Id=""{SecurityElement.Escape(id)}"" />
				</DataTemplate>";

            var ui = (Windows.DataTemplate)Windows.Markup.XamlReader.Load(XmlReader.Create(new StringReader(xaml)));
            return CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }
    }
}
