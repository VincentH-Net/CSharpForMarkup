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
                Header .Rainbow (),
                SearchResults,
                Footer
            }};

        StackLayout Header => new StackLayout { Children = {
            new Button { Text = "\u1438" } .Style (HeaderButton)
                        .Width (50)
                        .Bind (nameof(vm.BackCommand)),

            new Entry { Placeholder = "Search" }
                       .FillExpandHorizontal ()
                       .Bind (nameof(vm.SearchText))
        }} .Horizontal ();

        CollectionView SearchResults => new CollectionView { };

        Label Footer => new Label { Text = "Footer" };
    }
}