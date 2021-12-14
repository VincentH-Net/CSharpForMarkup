using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Windows = System.Windows;

namespace CSharpMarkup.Wpf
{
    interface IStartChain<TUI, TMarkup> where TUI : Windows.DependencyObject where TMarkup : DependencyObject
    {
        // TODO: switch to C# 8 and move static chain implementation from codegen to here, then make ConfigureRoot Action take TMarkup parameter
    }
}

namespace CSharpMarkup.Wpf.Delegators
{
    public static class BuildChild
    {
        static Dictionary<string, Func<CSharpMarkup.Wpf.UIElement>> delegates = null;

        static string Id(Delegate build) => $"{build.Method.DeclaringType.FullName}.{build.Method.Name}";

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

        public static string CreateIdFor(Func<CSharpMarkup.Wpf.UIElement> build)
        {
            AssertStateless(build);

            if (delegates == null) delegates = new Dictionary<string, Func<CSharpMarkup.Wpf.UIElement>>();

            string id = Id(build);
            delegates[id] = build;
            return id;
        }

        public static readonly Windows.DependencyProperty IdProperty = Windows.DependencyProperty.RegisterAttached(
            "Id", typeof(string), typeof(BuildChild), 
            new Windows.FrameworkPropertyMetadata(propertyChangedCallback: OnIdChanged)
        );

        public static string GetId(Windows.Controls.Panel panel) => (string)panel.GetValue(IdProperty);

        public static void SetId(Windows.Controls.Panel panel, string id) => panel.SetValue(IdProperty, id);

        // A propertyChangedCallback is necessary because GetId and SetId are not called by WPF XamlReader 
        static void OnIdChanged(Windows.DependencyObject target, Windows.DependencyPropertyChangedEventArgs e)
        {
            if (target is Windows.Controls.Panel panel && e.NewValue is string id)
            {
                panel.Children.Clear();
                if (!string.IsNullOrEmpty(id)) panel.Children.Add(delegates[id]().UI);
            }
        }
    }

    public static class ConfigureRoot
    {
        static Dictionary<string, Action<Windows.DependencyObject>> delegates = null;

        static string Id(Delegate build) => $"{build.Method.DeclaringType.FullName}.{build.Method.Name}";

        public static string CreateIdFor(Action<Windows.DependencyObject> build)
        {
            BuildChild.AssertStateless(build);

            if (delegates == null) delegates = new Dictionary<string, Action<Windows.DependencyObject>>();

            string delegateId = Id(build);
            delegates[delegateId] = build;
            return delegateId;
        }

        public static readonly Windows.DependencyProperty IdProperty = Windows.DependencyProperty.RegisterAttached(
            "Id", typeof(string), typeof(ConfigureRoot), 
            new Windows.PropertyMetadata(propertyChangedCallback: OnIdChanged)
        );

        public static string GetId(Windows.DependencyObject target) => (string)target.GetValue(IdProperty);

        public static void SetId(Windows.DependencyObject target, string id) => target.SetValue(IdProperty, id);

        // A propertyChangedCallback is necessary because GetId and SetId are not called by WPF XamlReader 
        static void OnIdChanged(Windows.DependencyObject target, Windows.DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is string id && !string.IsNullOrEmpty(id)) delegates[id](target);
        }
    }
}
