using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Xamarin.Android.Net;

namespace Roshod
{
    [Activity(Label = "Roshod", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.NoTitleBar")]
    public class MainActivity : Activity 
    {
        private WebView localWebView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            localWebView = FindViewById<WebView>(Resource.Id.LocalWebView);
            localWebView.SetWebViewClient(new WebViewClient()); // stops request going to Web Browser
            localWebView.SetWebChromeClient(new WebChromeClient()); // stops request going to Web Browser
            localWebView.Settings.JavaScriptEnabled = true;
            localWebView.LoadUrl("http://roshod.com");
        }

        public override void OnBackPressed()
        {
            if (localWebView.CanGoBack())
            {
                localWebView.GoBack();
            }
            else
            {
                base.OnBackPressed();
            }
            //base.OnBackPressed();
        }
    }
}

