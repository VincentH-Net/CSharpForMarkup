using System;
using System.Collections.Generic;
using System.Security;
#if WINUI
using CSharpMarkup.WinUI.Delegators;
#endif
using Xaml = Microsoft.UI.Xaml;
using Controls = Microsoft.UI.Xaml.Controls;

namespace CSharpMarkup.WinUI
{
    public static partial class Helpers
    {
        public static DataTemplate DataTemplate(Func<UIElement> build) => DataTemplate<Xaml.Controls.Grid>(build);

        public static DataTemplate DataTemplate(Action<Xaml.DependencyObject> build) => DataTemplate<Xaml.Controls.Grid>(build);

        public static DataTemplate DataTemplate<TRootUI>(Func<UIElement> build) where TRootUI : Xaml.Controls.Panel, new()
        {
#if WINUI
            var ui = (Xaml.DataTemplate)CreateTemplate(nameof(Xaml.DataTemplate), typeof(TRootUI), false, BuildChild.CreateIdFor(build));
#else
            var ui = new Xaml.DataTemplate(() =>
            {
                var root = new TRootUI();
                var child = build();
                root.Children.Add(child.UI);
                return root;
            });
#endif
            return CSharpMarkup.WinUI.DataTemplate.StartChain(ui);
        }

        public static DataTemplate DataTemplate<TRootUI>(Action<Xaml.DependencyObject> build) where TRootUI : Xaml.UIElement, new()
        {
#if WINUI
            // Note that we cannot pass markup objects to the build action here, because we get the ui type instance.
            var ui = (Xaml.DataTemplate)CreateTemplate(nameof(Xaml.DataTemplate), typeof(TRootUI), true, ConfigureRoot.CreateIdFor(build));
#else
            var ui = new Xaml.DataTemplate(() =>
            {
                var root = new TRootUI();
                build(root);
                return root;
            });
#endif
            return CSharpMarkup.WinUI.DataTemplate.StartChain(ui);
        }

        public static ItemsPanelTemplate ItemsPanelTemplate(Func<UIElement> build) => ItemsPanelTemplate<Xaml.Controls.Grid>(build);

        public static ItemsPanelTemplate ItemsPanelTemplate(Action<Xaml.DependencyObject> build) => ItemsPanelTemplate<Xaml.Controls.Grid>(build);

        public static ItemsPanelTemplate ItemsPanelTemplate<TRootUI>(Func<UIElement> build) where TRootUI : Xaml.Controls.Panel, new()
        {
#if WINUI
            var ui = (Xaml.Controls.ItemsPanelTemplate)CreateTemplate(nameof(Xaml.Controls.ItemsPanelTemplate), typeof(TRootUI), false, BuildChild.CreateIdFor(build));
#else
            var ui = new Xaml.Controls.ItemsPanelTemplate(() =>
            {
                var root = new TRootUI();
                var child = build();
                root.Children.Add(child.UI);
                return root;
            });
#endif
            return CSharpMarkup.WinUI.ItemsPanelTemplate.StartChain(ui);
        }

        public static ItemsPanelTemplate ItemsPanelTemplate<TRootUI>(Action<Xaml.DependencyObject> build) where TRootUI : Xaml.UIElement, new()
        {
#if WINUI
            // Note that we cannot pass markup objects to the build action here, because we get the ui type instance.
            var ui = (Xaml.Controls.ItemsPanelTemplate)CreateTemplate(nameof(Xaml.Controls.ItemsPanelTemplate), typeof(TRootUI), true, ConfigureRoot.CreateIdFor(build));
#else
            var ui = new Xaml.Controls.ItemsPanelTemplate(() =>
            {
                var root = new TRootUI();
                build(root);
                return root;
            });
#endif
            return CSharpMarkup.WinUI.ItemsPanelTemplate.StartChain(ui);
        }

#if WINUI
        static object CreateTemplate(string templateTypeName, Type rootUIType, bool isConfigureRootDelegator, string delegatorId, Type targetType = null)
        {
            string xaml =
                $@"<{templateTypeName}{(targetType is null ? "" : $" TargetType=\"{targetType.Name}\"")}
					xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
					xmlns:x= ""http://schemas.microsoft.com/winfx/2006/xaml""
					xmlns:root=""using:{rootUIType.Namespace}""
                    xmlns:delegators=""using:{typeof(BuildChild).Namespace}"">
                    <root:{rootUIType.Name} delegators:{(isConfigureRootDelegator ? "ConfigureRoot" : "BuildChild")}.Id=""{SecurityElement.Escape(delegatorId)}"" />
				</{templateTypeName}>";

            return Xaml.Markup.XamlReader.Load(xaml);
        }
#else
        public static ControlTemplate ControlTemplate(Func<UIElement> build, Type targetType = null) => ControlTemplate<Controls.Grid>(build, targetType);

        public static ControlTemplate ControlTemplate(Action<Xaml.DependencyObject> build, Type targetType = null) => ControlTemplate<Controls.Grid>(build, targetType);

        public static ControlTemplate ControlTemplate<TRootUI>(Func<UIElement> build, Type targetType = null) where TRootUI : Controls.Panel, new()
        {
            var ui = new Xaml.Controls.ControlTemplate(() =>
            {
                var root = new Xaml.Controls.Grid();
                buildingControlTemplate = true;
                try { var child = build(); root.Children.Add(child.UI); } finally { buildingControlTemplate = false; }
                return root;
            });
            return CSharpMarkup.WinUI.ControlTemplate.StartChain(ui);
        }

        public static ControlTemplate ControlTemplate<TRootUI>(Action<Xaml.DependencyObject> build, Type targetType = null) where TRootUI : Xaml.UIElement, new()
        {
            var ui = new Xaml.Controls.ControlTemplate(() =>
            {
                var root = new TRootUI();
                buildingControlTemplate = true;
                try { build(root); } finally { buildingControlTemplate = false; }
                return root;
            });
            return CSharpMarkup.WinUI.ControlTemplate.StartChain(ui);
        }

        static bool buildingControlTemplate = false;

        /// <summary>Create a <see cref="Xaml.Controls.ContentPresenter"/></summary>
        /// <remarks>Remark: ContentPresenter().Bind() binds to <see cref="Xaml.Controls.ContentPresenter.ContentProperty"/></remarks>
        public static ContentPresenter ContentPresenter()
        {
            var ui = new Xaml.Controls.ContentPresenter();
            var markup = CSharpMarkup.WinUI.ContentPresenter.StartChain(ui);

            // In UNO the implicit binding to Content* properties that should happen when the ContentPresenter is in a ControlTemplate
            // (see https://docs.microsoft.com/en-us/windows/winui/api/microsoft.ui.xaml.controls.contentpresenter?view=winui-3.0#remarks)
            // does not happen; see UNO issues https://github.com/unoplatform/uno/issues/857 and https://github.com/unoplatform/uno/issues/6452
            // Below is a workaround to do this implicit binding if the ContentPresenter is in a ControlTemplate.
            if (buildingControlTemplate)
                markup.Content().BindTemplate("Content")
                      .ContentTemplate().BindTemplate("ContentTemplate")
                      .ContentTemplateSelector().BindTemplate("ContentTemplateSelector");

            return markup;
        }
#endif
    }
}