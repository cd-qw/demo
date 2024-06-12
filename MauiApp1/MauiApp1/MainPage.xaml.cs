

using Microsoft.Maui.Controls.PlatformConfiguration;
using Newtonsoft.Json.Linq;
using SqlSugar;
using System.Windows.Input;
using XbclMes.Entity;

namespace XbclMes
{
    public partial class MainPage : ContentPage
    {
        string url = "";

        System.Timers.Timer timer;

        ISqlSugarClient _db;

        public MainPage()
        {
            InitializeComponent();
            Reload = new Command(() => reload(this, new EventArgs()));
            Set = new Command(() => set(this, new EventArgs()));

            timer = new System.Timers.Timer();
            timer.Interval = 5000;
            timer.Stop();
            timer.Elapsed += Timer_Elapsed;

            this.webView.Loaded += WebView_Loaded;

            this.Loaded += MainPage_Loaded;
        }

        private void WebView_Loaded(object? sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
        }


        private async void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                await MainThread.InvokeOnMainThreadAsync(() =>
                {
                    SaveCache();
                });
            }
            catch (Exception)
            {

            }

        }

        private async void SaveCache()
        {
            try
            {
                string tempUrl = await this.webView.EvaluateJavaScriptAsync("window.location.href");

                var entity = await _db.Queryable<AppConfig>().FirstAsync();

                entity.TempUrl = tempUrl;

                await _db.Updateable(entity).ExecuteCommandAsync();

            }
            catch (Exception)
            {

            }

        }

        public ICommand Reload { set; get; }

        public ICommand Set { set; get; }

        private void MainPage_Loaded(object? sender, EventArgs e)
        {
#if ANDROID
    
    XbclMes.Platforms.Android.SslHandler.SetSsl(this.webView);

#endif
            this._db = Handler.MauiContext.Services.GetService<ISqlSugarClient>();
            var entity = _db.Queryable<AppConfig>().First();

            if (entity != null)
            {
                if (string.IsNullOrEmpty(entity.TempUrl))
                {
                    this.url = entity.Url;
                }
                else
                {
                    this.url = entity.TempUrl;
                }

                //this.webView.Source = this.url;

                this.webView.Source = "https://192.168.14.251/CamstarWeb/#/";
            }



        }

        public async void reload(object sender, EventArgs e)
        {
            var height = DeviceDisplay.Current.MainDisplayInfo.Height;
            var width = DeviceDisplay.MainDisplayInfo.Width;
            this.webView.Reload();
        }

        public async void set(object sender, EventArgs e)
        {
            var entity = await _db.Queryable<AppConfig>().FirstAsync();
            string result = await DisplayPromptAsync("设置", "Url", "确定", "取消", initialValue: entity?.Url);

            if (string.IsNullOrEmpty(result))
            {
                return;
            }

            if (entity != null)
            {
                entity.Url = result;
                await _db.Updateable(entity).ExecuteCommandAsync();
            }
            else
            {
                AppConfig newEntity = new AppConfig { Url = result };

                await _db.Storageable(newEntity).ExecuteCommandAsync();
            }

            this.webView.Source = new UrlWebViewSource() { Url = result };
            this.url = result;
        }
    }
}
