#if WINUI
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Microsoft.UI.Xaml.Data;
using Xaml = Microsoft.UI.Xaml;

namespace CSharpMarkup.WinUI
{
    interface IStartChain<TUI, TMarkup> where TUI : Xaml.DependencyObject where TMarkup : DependencyObject
    {
        // TODO: switch to C# 8 and move static chain implementation from codegen to here, then make ConfigureRoot Action take TMarkup parameter
    }
}

namespace CSharpMarkup.WinUI.Delegators
{
    [Bindable]
    public class BuildChild
    {
        internal static Dictionary<string, Func<CSharpMarkup.WinUI.UIElement>> Delegates { get; private set; } = null;

        static string Id(Delegate build) => $"{build.Method.DeclaringType.FullName}.{build.Method.Name}";

        public static string CreateIdFor(Func<CSharpMarkup.WinUI.UIElement> build)
        {
            AssertStateless(build);

            if (Delegates == null) Delegates = new Dictionary<string, Func<CSharpMarkup.WinUI.UIElement>>();

            string id = Id(build);
            Delegates[id] = build;
            return id;
        }

        public static Xaml.DependencyProperty IdProperty = Xaml.DependencyProperty.RegisterAttached("Id", typeof(string), typeof(BuildChild), new Xaml.PropertyMetadata(null, OnIdChanged));

        public static string GetId(Xaml.Controls.Panel panel) => (string)panel.GetValue(IdProperty);

        public static void SetId(Xaml.Controls.Panel panel, string id) => panel.SetValue(IdProperty, id);

        [Conditional("DEBUG")]
        internal static void AssertStateless(Delegate build)
        {
            if (build.Target != null)
            {
                string fields = string.Join(',', build.Method.DeclaringType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Select(f => f.Name));
                string properties = string.Join(',', build.Method.DeclaringType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).Select(p => p.Name));
                string state = string.Join(',', fields, properties);
                if (state != ",")
                    throw new ArgumentException($"State in template methods is not supported: {state}. Either avoid state in the lambda expression or use a static method, e.g. DataTemplate(AStaticMethod)", nameof(build));
            }
        }

        // A propertyChangedCallback catches all manners in which the property value can be changed, including via SetValue or binding
        static void OnIdChanged(Xaml.DependencyObject target, Xaml.DependencyPropertyChangedEventArgs e) => Build((Xaml.Controls.Panel)target, id: (string)e.NewValue);

        static void Build(Xaml.Controls.Panel panel, string id = null)
        {
            if (id is null) return;
            panel.Children.Clear();
            panel.Children.Add(Delegates[id]().UI);
        }
    }

    [Bindable]
    public class BuildChildInControlTemplate
    {
        public static Xaml.DependencyProperty IdProperty = Xaml.DependencyProperty.RegisterAttached("Id", typeof(string), typeof(BuildChildInControlTemplate), new Xaml.PropertyMetadata(null, OnIdChanged));

        public static string GetId(Xaml.Controls.Panel panel) => (string)panel.GetValue(IdProperty);

        public static void SetId(Xaml.Controls.Panel panel, string id) => panel.SetValue(IdProperty, id);

        public static Xaml.DependencyProperty TemplatedParentProperty = Xaml.DependencyProperty.RegisterAttached("TemplatedParent", typeof(Xaml.UIElement), typeof(BuildChildInControlTemplate), new Xaml.PropertyMetadata(null, OnTemplatedParentChanged));

        public static Xaml.UIElement GetTemplatedParent(Xaml.Controls.Panel panel) => (Xaml.UIElement)panel.GetValue(TemplatedParentProperty);

        public static void SetTemplatedParent(Xaml.Controls.Panel panel, Xaml.UIElement parent) => panel.SetValue(TemplatedParentProperty, parent);

        static void OnIdChanged(Xaml.DependencyObject target, Xaml.DependencyPropertyChangedEventArgs e) => Build((Xaml.Controls.Panel)target, id: (string)e.NewValue);

        static void OnTemplatedParentChanged(Xaml.DependencyObject target, Xaml.DependencyPropertyChangedEventArgs e) => Build((Xaml.Controls.Panel)target, templatedParent: (Xaml.UIElement)e.NewValue);

        static void Build(Xaml.Controls.Panel panel, string id = null, Xaml.UIElement templatedParent = null)
        {
            id ??= GetId(panel);
            templatedParent ??= GetTemplatedParent(panel);
            if (id is null || templatedParent is null) return;

            panel.Children.Clear();
            DependencyObjectExtensions.TemplatedParent = templatedParent;
            try { panel.Children.Add(BuildChild.Delegates[id]().UI); } // Any template bindings are created here, using the TemplatedParent for source
            finally { DependencyObjectExtensions.TemplatedParent = null; }
        }
    }

    public static class ConfigureRoot
    {
        internal static Dictionary<string, Action<Xaml.DependencyObject>> Delegates { get; private set; } = null;

        static string Id(Delegate build) => $"{build.Method.DeclaringType.FullName}.{build.Method.Name}";

        public static string CreateIdFor(Action<Xaml.DependencyObject> build)
        {
            BuildChild.AssertStateless(build);

            if (Delegates == null) Delegates = new Dictionary<string, Action<Xaml.DependencyObject>>();

            string delegateId = Id(build);
            Delegates[delegateId] = build;
            return delegateId;
        }

        public static readonly Xaml.DependencyProperty IdProperty = Xaml.DependencyProperty.RegisterAttached("Id", typeof(string), typeof(ConfigureRoot), new Xaml.PropertyMetadata(null));

        public static string GetId(Xaml.DependencyObject target) => (string)target.GetValue(IdProperty);

        public static void SetId(Xaml.DependencyObject target, string id)
        {
            target.SetValue(IdProperty, id);
            if (!string.IsNullOrEmpty(id)) Delegates[id](target);
        }
    }

    public static class ConfigureRootInControlTemplate
    {
        public static Xaml.DependencyProperty IdProperty = Xaml.DependencyProperty.RegisterAttached("Id", typeof(string), typeof(ConfigureRootInControlTemplate), new Xaml.PropertyMetadata(null, OnIdChanged));

        public static string GetId(Xaml.DependencyObject target) => (string)target.GetValue(IdProperty);

        public static void SetId(Xaml.DependencyObject target, string id) => target.SetValue(IdProperty, id);

        public static Xaml.DependencyProperty TemplatedParentProperty = Xaml.DependencyProperty.RegisterAttached("TemplatedParent", typeof(Xaml.UIElement), typeof(ConfigureRootInControlTemplate), new Xaml.PropertyMetadata(null, OnTemplatedParentChanged));

        public static Xaml.UIElement GetTemplatedParent(Xaml.DependencyObject target) => (Xaml.UIElement)target.GetValue(TemplatedParentProperty);

        public static void SetTemplatedParent(Xaml.DependencyObject target, Xaml.UIElement parent) => target.SetValue(TemplatedParentProperty, parent);

        static void OnIdChanged(Xaml.DependencyObject target, Xaml.DependencyPropertyChangedEventArgs e) => Build(target, id: (string)e.NewValue);

        static void OnTemplatedParentChanged(Xaml.DependencyObject target, Xaml.DependencyPropertyChangedEventArgs e) => Build(target, templatedParent: (Xaml.UIElement)e.NewValue);

        static void Build(Xaml.DependencyObject target, string id = null, Xaml.UIElement templatedParent = null)
        {
            id ??= GetId(target);
            templatedParent ??= GetTemplatedParent(target);
            if (id is null || templatedParent is null) return;

            DependencyObjectExtensions.TemplatedParent = templatedParent;
            try { ConfigureRoot.Delegates[id](target); } // Any template bindings are created here, using the TemplatedParent for source
            finally { DependencyObjectExtensions.TemplatedParent = null; }
        }
    }
}
#endif
