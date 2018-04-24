using System;
using Xamarin.Forms;

namespace CSharpForMarkupExample
{
    public static class Styles
    {
        public static ResourceDictionary Create()
        {
            var resources = new ResourceDictionary ();

            resources.Add(new Style (typeof(Label)) { Setters = {
                new Setter { Property = Label.TextColorProperty, Value = ThemeColors.BgBlue1.ToColor() },
            }});
            
            resources.Add(new Style (typeof(Button)) { Setters = {
                new Setter { Property = Button.FontSizeProperty, Value = (int)ThemeFontSizes.Size13 },
                new Setter { Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                new Setter { Property = Button.VerticalOptionsProperty, Value = LayoutOptions.Center },
            }});
            
            return resources;
        }
    }
}
