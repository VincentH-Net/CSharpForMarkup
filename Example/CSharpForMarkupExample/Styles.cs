using System;
using Xamarin.Forms;

namespace CSharpForMarkupExample
{
    public static class Styles
    {
        // Implicit styles
        static Style label, button;

        public static ResourceDictionary Create()
        {
            var resources = new ResourceDictionary();

            resources.Add(label = new Style(typeof(Label)) { Setters = {
                new Setter { Property = Label.FontSizeProperty, Value = (int)FontSizes._13 },
                new Setter { Property = Label.TextColorProperty, Value = Colors.BgBlue1.ToColor() },
            }
            });

            resources.Add(button = new Style(typeof(Button)) { Setters = {
                new Setter { Property = Button.FontSizeProperty, Value = (int)FontSizes._13 },
                new Setter { Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                new Setter { Property = Button.VerticalOptionsProperty, Value = LayoutOptions.Center },
            }});

            return resources;
        }

        // Explicit styles
        static Style buttonFilled;

        public static Style ButtonFilled => buttonFilled ?? (buttonFilled = new Style(typeof(Button)) { BasedOn = button, Setters = {
            new Setter { Property = Button.TextColorProperty, Value = Colors.White.ToColor() },
            new Setter { Property = Button.BackgroundColorProperty, Value = Colors.ColorValueAccent.ToColor() }
        }});
    }
}
