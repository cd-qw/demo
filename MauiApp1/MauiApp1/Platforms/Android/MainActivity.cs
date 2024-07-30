﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Webkit;
using XbclMes.Platforms.Android;
using Microsoft.Maui.Platform;
using AndroidX.Core.Content;
using Android;
using AndroidX.Core.App;

namespace XbclMes
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat)
            {
                Android.Webkit.WebView.SetWebContentsDebuggingEnabled(true);
            }

            

            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            {
                ActivityCompat.RequestPermissions(this, new[] { Manifest.Permission.Camera }, 50);
            }
        }
    }
}
