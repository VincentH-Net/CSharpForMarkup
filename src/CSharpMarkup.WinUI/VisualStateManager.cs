#if !HAS_UNO
using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using Xaml = Microsoft.UI.Xaml;

namespace CSharpMarkup.WinUI
{
    public static partial class VisualStateManagerExtensions
    {
        internal const string UnsupportedErrorMessage = "Using VisualStateManager from C# is not supported by Windows App SDK; use a XAML app resource instead. See https://github.com/VincentH-Net/CSharpForMarkup/issues/22#issuecomment-1706468475";

        [UnsupportedOSPlatform("Windows", UnsupportedErrorMessage)]
        public static TTarget VisualStateManager_VisualStateGroups<TTarget>(this TTarget target, IList<Xaml.VisualStateGroup> value) where TTarget : FrameworkElement
        => throw new NotImplementedException();

        [UnsupportedOSPlatform("Windows", UnsupportedErrorMessage)]
        public static DependencyProperty<TTarget, IList<Xaml.VisualStateGroup>> VisualStateManager_VisualStateGroups<TTarget>(this TTarget target) where TTarget : FrameworkElement
        => throw new NotImplementedException();

        [UnsupportedOSPlatform("Windows", UnsupportedErrorMessage)]
        public static TTarget VisualStateManager<TTarget>(this TTarget target

            , IList<Xaml.VisualStateGroup> VisualStateGroups = default

            , Xaml.VisualStateManager CustomVisualStateManager = default

        ) where TTarget : FrameworkElement
        => throw new NotImplementedException();
    }
}
#endif