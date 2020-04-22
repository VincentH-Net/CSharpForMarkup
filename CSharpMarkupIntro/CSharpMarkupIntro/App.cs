using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.DebugRainbows;
using Xamarin.Forms.Markup;

namespace CSharpMarkupIntro
{
    public class App : Application
    {
        public App()
        {
            EnableDebugRainbows();
            MainPage = new SearchPage();
        }

        [Conditional("DEBUG")]
        void EnableDebugRainbows()
        {
            Resources.Add(
                new Style<BaseContentPage>(
                    (DebugRainbow.ShowColorsProperty, true)
                ) .ApplyToDerivedTypes (true)
            );
        }
    }
}