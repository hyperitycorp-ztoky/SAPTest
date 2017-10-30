using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Push;
using UIKit;

namespace SAPTest.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            MobileCenter.Start("16284a11-5a51-441b-985b-94536ac3c309", typeof(Analytics), typeof(Crashes), typeof(Push));

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
