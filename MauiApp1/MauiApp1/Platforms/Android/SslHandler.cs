

using Microsoft.Maui.Controls.Platform;
using Awx = Android.Webkit;

namespace XbclMes.Platforms.Android
{
    public static class SslHandler
    {
        public static void SetSsl(Microsoft.Maui.Controls.WebView webView)
        {
            var web = webView.Handler.PlatformView as Awx.WebView;

            web.Settings.JavaScriptEnabled = true;

            web.Settings.AllowContentAccess = true;

            web.Settings.DomStorageEnabled = true;

            web.Settings.CacheMode = Awx.CacheModes.NoCache;
            web.Settings.DefaultTextEncodingName = "UTF-8";

            web.Settings.AllowFileAccessFromFileURLs = true;
            web.Settings.JavaScriptCanOpenWindowsAutomatically = true;
            web.Settings.UseWideViewPort = true;

            //硬件加速
            web.SetLayerType(global::Android.Views.LayerType.Hardware, null);

            //web.SetInitialScale(44);

            //web.SetInitialScale();

            var client = new CustomWebViewClient();

            web.SetWebChromeClient(new CustomWebClient());
            web.SetWebViewClient(client);

            
        }
    }
}
