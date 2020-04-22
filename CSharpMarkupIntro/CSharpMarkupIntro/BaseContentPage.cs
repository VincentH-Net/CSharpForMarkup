using Xamarin.Forms.DebugRainbows;
using System.Reflection;
using Xamarin.Forms;

namespace CSharpMarkupIntro
{
    public class BaseContentPage : ContentPage
    {
        #region Workaround for DebugRainbows issue: rainbows disappear after updating page content 

        public new View Content {
            get => base.Content;
            set 
            { 
                base.Content = value; 
                UpdateRainbows(); 
            }
        }

        void UpdateRainbows() => 
            typeof(DebugRainbow)
            .GetMethod("Page_Appearing", BindingFlags.NonPublic | BindingFlags.Static)
            .Invoke(null, new object[] { this, System.EventArgs.Empty });

        #endregion Workaround for DebugRainbows issue: rainbows disappear after updating page content 
    }
}
