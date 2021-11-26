using System;
using System.Collections.Generic;
using System.Security;
#if WINDOWS
using Microsoft.UI.Markup.Delegators;
#endif
using Xaml = Microsoft.UI.Xaml;
using Controls = Microsoft.UI.Xaml.Controls;

namespace Microsoft.UI.Markup
{
    public static partial class Helpers
    {
        public static DataTemplate DataTemplate(Func<UIElement> build) => DataTemplate<Xaml.Controls.Grid>(build);

        public static DataTemplate DataTemplate(Action<Xaml.DependencyObject> build) => DataTemplate<Xaml.Controls.Grid>(build);

        public static DataTemplate DataTemplate<TRootUI>(Func<UIElement> build) where TRootUI : Xaml.Controls.Panel
        {
#if WINDOWS
            string id = BuildChild.CreateIdFor(build);
            string idp = $"BuildChild.IdProperty = {BuildChild.IdProperty}"; // TODO: attempt fix remove
            string xaml =
                $@"<DataTemplate
					xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
					xmlns:x= ""http://schemas.microsoft.com/winfx/2006/xaml""
					xmlns:root=""using:{typeof(TRootUI).Namespace}""
                    xmlns:delegators=""using:{typeof(BuildChild).Namespace}"">
				  <root:{typeof(TRootUI).Name} delegators:BuildChild.Id=""{SecurityElement.Escape(id)}"" />
				</DataTemplate>";
            var ui = Xaml.Markup.XamlReader.Load(xaml) as Xaml.DataTemplate;
#else
            var ui = new Xaml.DataTemplate(() =>
            {
                var root = new Xaml.Controls.Grid();
                var child = build();
                root.Children.Add(child.UI);
                return root;
            });
#endif
            return Markup.DataTemplate.StartChain(ui);
        }

        public static DataTemplate DataTemplate<TRootUI>(Action<Xaml.DependencyObject> build) where TRootUI : Xaml.UIElement, new()
        {
#if WINDOWS
            // TODO: check what is the appropriate symbol for WinUI 3 Desktop #if NETFX_CORE
            // Note that we cannot pass markup objects to the build action here, because we get the ui type instance.
            string id = ConfigureRoot.CreateIdFor(build);
            string idp = $"BuildChild.IdProperty = {BuildChild.IdProperty}"; // TODO: attempt fix remove
            string xaml =
                $@"<DataTemplate
					xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
					xmlns:x= ""http://schemas.microsoft.com/winfx/2006/xaml""
					xmlns:root=""using:{typeof(TRootUI).Namespace}""
                    xmlns:delegators=""using:{typeof(ConfigureRoot).Namespace}"">
				  <root:{typeof(TRootUI).Name} delegators:ConfigureRoot.Id=""{SecurityElement.Escape(id)}"" />
				</DataTemplate>";

            var ui = Xaml.Markup.XamlReader.Load(xaml) as Xaml.DataTemplate;
#else
            var ui = new Xaml.DataTemplate(() =>
            {
                var root = new TRootUI();
                build(root);
                return root;
            });
#endif
            return Markup.DataTemplate.StartChain(ui);
        }
    }
}