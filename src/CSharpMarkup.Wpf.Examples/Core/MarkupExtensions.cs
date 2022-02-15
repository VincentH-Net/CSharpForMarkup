using CSharpMarkup.Wpf;
using static CSharpMarkup.Wpf.Helpers;

namespace WpfCsMarkupExamples;

internal static class MarkupExtensions
{
    // TODO: Generate add-event helpers as member methods on markup type itself so type arguments do not have to be specified manually
    public static TextBlock OnDataContextChanged<TContext>(this TextBlock target, Action<TextBlock_UI, TContext> onChanged)
    => target.OnDataContextChanged<TextBlock, TextBlock_UI, TContext>(onChanged);
}