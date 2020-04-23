using Xamarin.Forms.DebugRainbows;
using Xamarin.Forms;

namespace CSharpMarkupIntro
{
    public static class MarkupExtensions
    {
        public static TBindable Rainbow<TBindable>(this TBindable bindable) where TBindable : BindableObject { DebugRainbow.SetShowColors(bindable, true); return bindable; }
    }
}
