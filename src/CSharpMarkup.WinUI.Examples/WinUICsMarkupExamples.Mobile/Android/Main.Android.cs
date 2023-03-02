using System;
using Android.Runtime;
using Com.Nostra13.Universalimageloader.Core;
using Microsoft.UI.Xaml.Media;

namespace WinUICsMarkupExamples.Droid;

[global::Android.App.Application(
    Label = "@string/ApplicationName",
    Icon = "@mipmap/icon",
    LargeHeap = true,
    HardwareAccelerated = true,
    Theme = "@style/AppTheme"
)]
public class Application : Microsoft.UI.Xaml.NativeApplication
{
    public Application(IntPtr javaReference, JniHandleOwnership transfer)
        : base(() => new AppHead(), javaReference, transfer) => ConfigureUniversalImageLoader();

    static void ConfigureUniversalImageLoader()
    {
        // Create global configuration and initialize ImageLoader with this config
        var config = new ImageLoaderConfiguration
            .Builder(Context)
            .Build();

        ImageLoader.Instance.Init(config);

        ImageSource.DefaultImageLoader = ImageLoader.Instance.LoadImageAsync;
    }
}
