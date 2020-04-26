using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Markup.LeftToRight;
using static Xamarin.Forms.Markup.GridRowsColumns;
using static CSharpMarkupIntro.SearchViewModel;
using static CSharpMarkupIntro.Styles;

namespace CSharpMarkupIntro
{
    public partial class SearchPage
    {
        void Build() => Content = 
            new StackLayout { Children = {
                Header,
                SearchResults,
                Footer
            }} .Rainbow ();

        StackLayout Header => new StackLayout { };

        CollectionView SearchResults => new CollectionView { };

        Label Footer => new Label { Text = "Footer" };
    }
}