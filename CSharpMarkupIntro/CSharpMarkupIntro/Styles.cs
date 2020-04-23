using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace CSharpMarkupIntro
{
    public static class Styles
    {

        public static class Implicit
        {
            static ResourceDictionary dictionary;
            static Style<Label> labels;
            static Style<Entry> entries;

            public static ResourceDictionary Dictionary => dictionary ??= new ResourceDictionary { Labels, Entries };

            public static Style<Label> Labels => labels ??= new Style<Label>(
                (Label.TextColorProperty, Color.White)
            );

            public static Style<Entry> Entries => entries ??= new Style<Entry>(
                (Entry.TextColorProperty, Color.White)
            );
        }
    }
}
