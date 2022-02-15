using System;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        public static ListView ListView(Func<UIElement> itemTemplate) => ListView().ItemTemplate(DataTemplate(itemTemplate));
    }
}