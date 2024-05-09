using Android.Net.Http;
using Android.Webkit;
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

    }
}
