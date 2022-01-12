using System;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        public static void Add(this System.Windows.Documents.InlineCollection inlines, InlineCollectionItem item)
        {
            switch (item.TypeIndex)
            {
                case 1: inlines.Add(item.T1Value); break;
                case 2: inlines.Add(item.T2Value); break;
                case 3: inlines.Add(item.T3Value); break;
            }
        }
    }

    public class InlineCollectionItem : TypesWrapper<string, System.Windows.Documents.Inline, System.Windows.UIElement>
    {
        public static implicit operator InlineCollectionItem(string    value) => new InlineCollectionItem { Value = value   , TypeIndex = 1 };
        public static implicit operator InlineCollectionItem(Inline    value) => new InlineCollectionItem { Value = value.UI, TypeIndex = 2 };
        public static implicit operator InlineCollectionItem(UIElement value) => new InlineCollectionItem { Value = value.UI, TypeIndex = 3 };
    }

    /// <summary>Allows to specify either a <typeparamref name="T1"/>, a <typeparamref name="T2"/> or a <typeparamref name="T3"/></summary>
    public abstract class TypesWrapper<T1, T2, T3>
    {
        protected object Value { get; init; }
        public int TypeIndex { get; init; } // TODO: 2022 Make TypeIndex assignment automatic

        public T1 T1Value => TypeIndex == 1 ? (T1)Value : throw new InvalidOperationException();
        public T2 T2Value => TypeIndex == 2 ? (T2)Value : throw new InvalidOperationException();
        public T3 T3Value => TypeIndex == 3 ? (T3)Value : throw new InvalidOperationException();

        protected TypesWrapper() { }
    }
}