using System;
using System.Collections;
using TvUI = WinUI.TableView;

namespace CSharpMarkup.WinUI.TableView
{
    public static partial class TableViewExtensions2
    {
        /// <summary>Bind (or set enum value of) <see cref="TvUI.TableView.ItemsSource"/></summary>
        /// <remarks>Use this method to avoid ambiguity of the .ItemsSource() extension method</remarks>
        public static DependencyProperty<TTarget, IList?> TvItemsSource<TTarget>(this TTarget target) where TTarget : TableView
        => DependencyProperty<TTarget, IList?>.Get(target, TvUI.TableView.ItemsSourceProperty);
    }
}
