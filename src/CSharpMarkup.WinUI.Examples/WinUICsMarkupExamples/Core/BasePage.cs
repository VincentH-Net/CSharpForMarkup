using Microsoft.UI.Xaml.Controls;

namespace WinUICsMarkupExamples.Core;

#if HAS_UNO
[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1010:Generic interface should also be implemented", Justification = "Fix for inappropriate public IEnumerable in UNO Page")]
#endif
public partial class BasePage : Page
{
	public BasePage() => NavigationCacheMode = UI.Navigation.NavigationCacheMode.Required;
}
