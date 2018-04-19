using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using QuickCross;
using UIKit;

namespace CSharpForMarkupExample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            TaskHelper.InitializeFromUIThread();
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
