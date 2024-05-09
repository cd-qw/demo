

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

            

            var client = new CustomWebViewClient();

            

            web.SetWebChromeClient(new CustomWebClient());
            web.SetWebViewClient(client);

        }
    }
}
