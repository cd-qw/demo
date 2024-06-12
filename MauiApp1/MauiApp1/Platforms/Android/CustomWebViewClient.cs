using Android.Net.Http;
using Android.Webkit;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbclMes.Platforms.Android
{
    public class CustomWebViewClient:WebViewClient
    {
        public override void OnReceivedSslError(global::Android.Webkit.WebView? view, SslErrorHandler? handler, SslError? error)
        {
            handler.Proceed();
        }

        public override bool ShouldOverrideUrlLoading(global::Android.Webkit.WebView? view, string? url)
        {
            view.LoadUrl(url);
            return true;
        }
    }
}
