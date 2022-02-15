using System.Windows.Controls;
namespace WpfCsMarkupExamples;

internal class BasePage : Page
{
    public new object Content { get => base.Content; set { base.Content = value is CSharpMarkup.Wpf.DependencyObject d ? d.UI : value; } }
}
