using System;

namespace CSharpMarkup.WinUI;

public static partial class Helpers
{
    public static ItemsRepeater ItemsRepeater(Func<UIElement> itemTemplate) => ItemsRepeater().ItemTemplate(DataTemplate(itemTemplate).UI);
}