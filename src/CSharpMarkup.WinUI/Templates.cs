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

        public static ControlTemplate ControlTemplate(Func<UIElement> build) => ControlTemplate(null, build);

        public static ControlTemplate ControlTemplate(Type targetType, Func<UIElement> build)
        {
            var ui = (Xaml.Controls.ControlTemplate)CreateControlTemplate(nameof(Xaml.Controls.ControlTemplate), typeof(Controls.Grid), false, BuildChild.CreateIdFor(build), targetType);
            return CSharpMarkup.WinUI.ControlTemplate.StartChain(ui);
        }

        public static ControlTemplate ControlTemplate(Action<Xaml.DependencyObject> build) => ControlTemplate(null, build);

        public static ControlTemplate ControlTemplate(Type targetType, Action<Xaml.DependencyObject> build)
        {
            var ui = (Xaml.Controls.ControlTemplate)CreateControlTemplate(nameof(Xaml.Controls.ControlTemplate), typeof(Controls.Grid), true, ConfigureRoot.CreateIdFor(build), targetType);
            return CSharpMarkup.WinUI.ControlTemplate.StartChain(ui);
        }

        static object CreateControlTemplate(string templateTypeName, Type rootUIType, bool isConfigureRootDelegator, string delegatorId, Type targetType = null)
        {
            string bindTemplatedParent = @"{Binding RelativeSource={RelativeSource TemplatedParent}}";
            string delegatorTypeName = isConfigureRootDelegator ? nameof(ConfigureRootInControlTemplate) : nameof(BuildChildInControlTemplate);
            string xaml =
                $@"<{templateTypeName}{(targetType is null ? "" : $" TargetType=\"{targetType.Name}\"")}
					xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
					xmlns:x= ""http://schemas.microsoft.com/winfx/2006/xaml""
					xmlns:root=""using:{rootUIType.Namespace}""
                    xmlns:delegators=""using:{typeof(BuildChild).Namespace}"">
                    <root:{rootUIType.Name} delegators:{delegatorTypeName}.Id=""{SecurityElement.Escape(delegatorId)}"" delegators:{delegatorTypeName}.TemplatedParent=""{bindTemplatedParent}"" />
				</{templateTypeName}>";

            return Xaml.Markup.XamlReader.Load(xaml);
        }
#else
        public static ControlTemplate ControlTemplate(Func<UIElement> build) => ControlTemplate<Controls.Grid>(null, build);

        public static ControlTemplate ControlTemplate(Type targetType, Func<UIElement> build) => ControlTemplate<Controls.Grid>(targetType, build);

        public static ControlTemplate ControlTemplate(Action<Xaml.DependencyObject> build) => ControlTemplate<Controls.Grid>(null, build);

        public static ControlTemplate ControlTemplate(Type targetType, Action<Xaml.DependencyObject> build) => ControlTemplate<Controls.Grid>(targetType, build);

        public static ControlTemplate ControlTemplate<TRootUI>(Func<UIElement> build) where TRootUI : Controls.Panel, new() => ControlTemplate<TRootUI>(null, build);

        public static ControlTemplate ControlTemplate<TRootUI>(Type targetType, Func<UIElement> build) where TRootUI : Controls.Panel, new()
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

        public static ControlTemplate ControlTemplate<TRootUI>(Action<Xaml.DependencyObject> build) where TRootUI : Xaml.UIElement, new() => ControlTemplate<TRootUI>(null, build);

        public static ControlTemplate ControlTemplate<TRootUI>(Type targetType, Action<Xaml.DependencyObject> build) where TRootUI : Xaml.UIElement, new()
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
#endif
    }
}