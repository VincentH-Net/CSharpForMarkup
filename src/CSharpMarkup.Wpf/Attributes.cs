using System;

namespace CSharpMarkup.Wpf
{
    /// <summary>
    /// Apply to a helper method that is shorthand for a (sequence of) other helpers, e.g. <code>[ShortFor("HorizontalAlignment().Left()")]</code> on a <code>Left()</code> helper.
    /// Specify multiple sequences if the helper method is shorthand for a combination of helper sequences, e.g. <code>[ShortFor("HorizontalAlignment().Center()", "VerticalAlignment().Center()")]</code> on a <code>Center()</code> helper.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class ShortForAttribute : Attribute
    {
        public ShortForAttribute(params string[] helperSequences) { HelperSequences = helperSequences; }
        public string[] HelperSequences { get; }
    }
}