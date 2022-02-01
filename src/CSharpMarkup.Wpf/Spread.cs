using System.Collections.Generic;
using System.Linq;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        /// <summary>Insert <paramref name="children"/> of type class <typeparamref name="TChild"/> in the parent layout's children at the position where <see cref="Spread{TChild}(TChild[])"/> is called</summary>
        /// <typeparam name="TChild">Must be a class; for struct types, use <see cref="SpreadS{TChild}(TChild[])"/></typeparam>
        public static TChild Spread<TChild>(IEnumerable<TChild> children) where TChild : class => Spreader<TChild>.Spread(children.ToArray());
        /// <summary>Insert <paramref name="children"/> of type class <typeparamref name="TChild"/> in the parent layout's children at the position where <see cref="Spread{TChild}(TChild[])"/> is called</summary>
        /// <typeparam name="TChild">Must be a class; for struct types, use <see cref="SpreadS{TChild}(TChild[])"/></typeparam>
        public static TChild Spread<TChild>(TChild[] children) where TChild : class => Spreader<TChild>.Spread(children);

        /// <summary>Insert <paramref name="children"/> of type struct <typeparamref name="TChild"/> in the parent layout's children at the position where <see cref="SpreadS{TChild}(TChild[])"/> is called</summary>
        /// <typeparam name="TChild">Must be a struct; for class types, use <see cref="Spread{TChild}(TChild[])"/></typeparam>
        public static TChild[] SpreadS<TChild>(IEnumerable<TChild> children) where TChild : struct => children.ToArray();
        /// <summary>Insert <paramref name="children"/> of type struct <typeparamref name="TChild"/> in the parent layout's children at the position where <see cref="SpreadS{TChild}(TChild[])"/> is called</summary>
        /// <typeparam name="TChild">Must be a struct; for class types, use <see cref="Spread{TChild}(TChild[])"/></typeparam>
        public static TChild[] SpreadS<TChild>(TChild[] children) where TChild : struct => children;
    }

    /// <typeparam name="TChild">
    /// Must be a class because we want to pass a spread into a layout with the same parameter type as a non-spread
    /// (to avoid overhead when no spreads are used); the identity of the spread is the *reference* to it's first non-null child.
    /// 
    /// For spreads of structs, use jagged arrays instead of <see cref="Spreader{TChild}"/> - <see cref="Helpers.SpreadS"/>.
    /// </typeparam>
    /// <remarks>This class is used by <see cref="Helpers.Spread"/></remarks>
    public static class Spreader<TChild> where TChild : class
    {
        static Dictionary<TChild, TChild[]> spreads = new();
        static bool hasSpreads = false;

        public static TChild? Spread(TChild[] children)
        {
            var key = children.FirstOrDefault(item => item is not null);
            if (key is not null) { spreads.Add(key, children); hasSpreads = true; }
            return key;
        }

        public static TChild[]? ExtractChildren(TChild childOrSpread)
        {
            if (!hasSpreads) return null;
            if (spreads.TryGetValue(childOrSpread, out var children)) { spreads.Remove(childOrSpread); hasSpreads = spreads.Count > 0; }
            return children;
        }
    }
}
