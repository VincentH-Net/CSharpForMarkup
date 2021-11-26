using System.Collections.Generic;
using System.Linq;

namespace Microsoft.UI.Markup
{
    public static partial class Helpers
    {
        public static UIElementRange Spread(IEnumerable<Microsoft.UI.Xaml.UIElement> children) => new UIElementRange { Elements = children?.ToList() };

        public static void SpreadChildren(Microsoft.UI.Xaml.Controls.UIElementCollection children)
        {
            // TODO: Optimize - only traverse if Spread was called after last SpreadChildren call
            for (int i = children.Count; --i >= 0;)
            {
                if (children[i] is UIElementRange range)
                {
                    children.RemoveAt(i);

                    for (int j = 0; j < range.Elements.Count; j++)
                        children.Insert(i + j, range.Elements[j]);
                }
            }
        }

        public static InlineRange Spread(IEnumerable<Microsoft.UI.Xaml.Documents.Inline> inlines) => new InlineRange { Inlines = inlines?.ToList() };

        public static void SpreadInlines(Microsoft.UI.Xaml.Documents.InlineCollection inlines)
        {
            // TODO: Optimize - only traverse if Spread was called after last SpreadInlines call
            for (int i = inlines.Count; --i >= 0;)
            {
                if (inlines[i] is InlineRange range)
                {
                    inlines.RemoveAt(i);

                    for (int j = 0; j < range.Inlines.Count; j++)
                        inlines.Insert(i + j, range.Inlines[j]);
                }
            }
        }
    }

    public partial class UIElementRange : Microsoft.UI.Xaml.FrameworkElement // TODO: Document why partial keyword is needed here to prevent compile error on Android target. Maybe some UNO codegen?
    {
        public List<Microsoft.UI.Xaml.UIElement> Elements { get; set; }
    }

    public class InlineRange : Microsoft.UI.Xaml.Documents.Inline
    {
        public List<Microsoft.UI.Xaml.Documents.Inline> Inlines { get; set; }
    }
}
