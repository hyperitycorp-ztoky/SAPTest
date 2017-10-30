using System;
using SAPTest.Helpers;
using Xamarin.Forms;

namespace SAPTest
{
    public partial class OpentokPage : ContentPage
    {
        private IOpentokStreamingService _opentokService;

        public OpentokPage()
        {
            InitializeComponent();

            _opentokService = DependencyService.Get<IOpentokStreamingService>();
            StartSession();

        }

        public void StartSession()
        {
            //    //OpentokSettings.Current.RoomName = "asdf";

            //var sessionId = await OpentokSessionHelper.Request(OpentokSessionHelper.SessionRequestURI, OpentokSettings.Current.RoomName);
            //var token = await OpentokSessionHelper.Request(OpentokSessionHelper.TokenRequestURI, sessionId);

            var sessionId = OpentokTestConstants.SessionId;
            var token = OpentokTestConstants.Token;

            BusyIndicatorView.IsVisible = BusyViewLayer.IsVisible = false;
#if __IOS__
            var wrapper = (Xamarin.Forms.Platform.iOS.NativeViewWrapper)LocalContainer.Content;
            var localView = (UIKit.UIView)wrapper.NativeView;
            _opentokService.SetStreamContainer(localView, true);

            wrapper = (Xamarin.Forms.Platform.iOS.NativeViewWrapper)RemoteContainer.Content;
            var remoteView = (UIKit.UIView)wrapper.NativeView;
            _opentokService.SetStreamContainer(remoteView, false);
#elif __ANDROID__
            var wrapper = (Xamarin.Forms.Platform.Android.NativeViewWrapper)LocalContainer.Content;
            var localView = (Android.Widget.FrameLayout)wrapper.NativeView;
            _opentokService.SetStreamContainer(localView, true);

            wrapper = (Xamarin.Forms.Platform.Android.NativeViewWrapper)RemoteContainer.Content;
            var remoteView = (Android.Widget.FrameLayout)wrapper.NativeView;
            _opentokService.SetStreamContainer(remoteView, false);


#endif

            _opentokService.InitNewSession(OpentokTestConstants.OpentokAPI, sessionId, token);
            //    //UIApplication.SharedApplication.IdleTimerDisabled = true;
        }
    }
}
