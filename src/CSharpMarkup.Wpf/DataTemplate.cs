using System;
using System.Collections.Generic;
using System.Security;
using Windows = System.Windows;
using Controls = System.Windows.Controls;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        public static DataTemplate DataTemplate(Func<UIElement> build) => DataTemplate<Windows.Controls.Grid>(build);

        public static DataTemplate DataTemplate(Action<Windows.DependencyObject> build) => DataTemplate<Windows.Controls.Grid>(build);

        public static DataTemplate DataTemplate<TRootUI>(Func<UIElement> build) where TRootUI : Windows.Controls.Panel
        {
            var ui = new Windows.DataTemplate(() =>
            {
                var root = new Windows.Controls.Grid();
                var child = build();
                root.Children.Add(child.UI);
                return root;
            });
            return Markup.DataTemplate.StartChain(ui);
        }

        public static DataTemplate DataTemplate<TRootUI>(Action<Windows.DependencyObject> build) where TRootUI : Windows.UIElement, new()
        {
            var ui = new Windows.DataTemplate(() =>
            {
                var root = new TRootUI();
                build(root);
                return root;
            });
            return Markup.DataTemplate.StartChain(ui);
        }
    }
}