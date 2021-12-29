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
        static Dictionary<string, Func<CSharpMarkup.WinUI.UIElement>> delegates = null;

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

        public static string CreateIdFor(Func<CSharpMarkup.WinUI.UIElement> build)
        {
            AssertStateless(build);

            if (delegates == null) delegates = new Dictionary<string, Func<CSharpMarkup.WinUI.UIElement>>();

            string id = Id(build);
            delegates[id] = build;
            return id;
        }

        public static Xaml.DependencyProperty IdProperty = Xaml.DependencyProperty.RegisterAttached("Id", typeof(string), typeof(BuildChild), new Xaml.PropertyMetadata(null));

        public static string GetId(Microsoft.UI.Xaml.Controls.Panel panel) => (string)panel.GetValue(IdProperty);

        public static void SetId(Microsoft.UI.Xaml.Controls.Panel panel, string id)
        {
            panel.SetValue(IdProperty, id);
            panel.Children.Clear();
            if (!string.IsNullOrEmpty(id)) panel.Children.Add(delegates[id]().UI);
        }
    }

    public static class ConfigureRoot
    {
        static Dictionary<string, Action<Microsoft.UI.Xaml.DependencyObject>> delegates = null;

        static string Id(Delegate build) => $"{build.Method.DeclaringType.FullName}.{build.Method.Name}";

        public static string CreateIdFor(Action<Microsoft.UI.Xaml.DependencyObject> build)
        {
            BuildChild.AssertStateless(build);

            if (delegates == null) delegates = new Dictionary<string, Action<Microsoft.UI.Xaml.DependencyObject>>();

            string delegateId = Id(build);
            delegates[delegateId] = build;
            return delegateId;
        }

        public static readonly Xaml.DependencyProperty IdProperty = Xaml.DependencyProperty.RegisterAttached("Id", typeof(string), typeof(ConfigureRoot), new Xaml.PropertyMetadata(null));

        public static string GetId(Microsoft.UI.Xaml.DependencyObject target) => (string)target.GetValue(IdProperty);

        public static void SetId(Microsoft.UI.Xaml.DependencyObject target, string id)
        {
            target.SetValue(IdProperty, id);
            if (!string.IsNullOrEmpty(id)) delegates[id](target);
        }
    }
}
#endif
