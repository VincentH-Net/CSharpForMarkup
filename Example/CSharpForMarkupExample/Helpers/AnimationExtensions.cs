using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CSharpForMarkupExample
{
    public static class AnimationExtensions
    {
        public static void StaggerIn(this IEnumerable<View> children, float translation, double delay)
        {
            var i = 0;
            foreach (var view in children)
            {
                view.Opacity = 0;
                view.TranslationY = translation;

                Task.Delay(TimeSpan.FromSeconds(i++ * delay))
                    .ContinueWith(_ =>
                    {
                        view.FadeTo(1);
                        view.TranslateTo(0, 0, easing: Easing.CubicOut);
                    });
            }
        }
    }
}
