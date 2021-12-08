using System.Collections.Generic;
using System.Linq;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        public static UIElementRange Spread(IEnumerable<System.Windows.UIElement> children) => new UIElementRange { Elements = children?.ToList() };

        public static void SpreadChildren(System.Windows.Controls.UIElementCollection children)
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

        public static InlineRange Spread(IEnumerable<System.Windows.Documents.Inline> inlines) => new InlineRange { Inlines = inlines?.ToList() };

        public static void SpreadInlines(System.Windows.Documents.InlineCollection inlines)
        {
            // TODO: Optimize - only traverse if Spread was called after last SpreadInlines call

            foreach (var inline in inlines)
            {
                if (inline is InlineRange range)
                {
                    for (int j = 0; j < range.Inlines.Count; j++)
                        inlines.InsertBefore(range, range.Inlines[j]);

                    inlines.Remove(range);
                }
            }
        }
    }

    public partial class UIElementRange : System.Windows.FrameworkElement // TODO: Document why partial keyword is needed here to prevent compile error on Android target. Maybe some UNO codegen?
    {
        public List<System.Windows.UIElement> Elements { get; set; }
    }

    public class InlineRange : System.Windows.Documents.Inline
    {
        public List<System.Windows.Documents.Inline> Inlines { get; set; }
    }
}
