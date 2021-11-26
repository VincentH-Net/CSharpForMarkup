using System;

namespace Microsoft.UI.Markup
{
    public static partial class Helpers
    {
        public static ListView ListView(Func<UIElement> itemTemplate) => ListView().ItemTemplate(DataTemplate(itemTemplate));

        public static ListView ListView(Func<UIElement> headerTemplate, Func<UIElement> itemTemplate, Func<UIElement> footerTemplate = null)
        {
            var listView = ListView();
            if (headerTemplate != null) listView.HeaderTemplate(DataTemplate(headerTemplate));
            if (itemTemplate != null) listView.ItemTemplate(DataTemplate(itemTemplate));
            if (footerTemplate != null) listView.FooterTemplate(DataTemplate(footerTemplate));
            return listView;
        }

    }
}