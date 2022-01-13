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

    /// <summary>Allows to specify either a <see cref="string"/>, a <see cref="System.Windows.Documents.Inline"/> or a <see cref="System.Windows.UIElement"/></summary>
    public class InlineCollectionItem : OneOf<string, System.Windows.Documents.Inline, System.Windows.UIElement>
    {
        public static implicit operator InlineCollectionItem(string    value) => new InlineCollectionItem(value);
        public static implicit operator InlineCollectionItem(Inline    value) => new InlineCollectionItem(value.UI);
        public static implicit operator InlineCollectionItem(UIElement value) => new InlineCollectionItem(value.UI);

        InlineCollectionItem(string value) : base(value) { }
        InlineCollectionItem(System.Windows.Documents.Inline value) : base(value) { }
        InlineCollectionItem(System.Windows.UIElement value) : base(value) { }
    }

    /// <summary>Allows to specify either a <typeparamref name="T1"/>, a <typeparamref name="T2"/> or a <typeparamref name="T3"/></summary>
    public class OneOf<T1, T2, T3>
    {
        readonly object value;

        public int TypeIndex { get; }

        public T1 T1Value => TypeIndex == 1 ? (T1)value : throw new InvalidOperationException();
        public T2 T2Value => TypeIndex == 2 ? (T2)value : throw new InvalidOperationException();
        public T3 T3Value => TypeIndex == 3 ? (T3)value : throw new InvalidOperationException();

        public OneOf(T1 value) { this.value = value; TypeIndex = 1; }
        public OneOf(T2 value) { this.value = value; TypeIndex = 2; }
        public OneOf(T3 value) { this.value = value; TypeIndex = 3; }
    }
}