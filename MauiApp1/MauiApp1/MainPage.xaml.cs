

using Microsoft.Maui.Controls.PlatformConfiguration;
using SqlSugar;
using System.Windows.Input;
using XbclMes.Entity;

namespace XbclMes
{
    public partial class MainPage : ContentPage
    {
        string url = "";


        ISqlSugarClient _db;

        public MainPage()
        {
            InitializeComponent();
            Reload = new Command(() => reload(this, new EventArgs()));
            Set = new Command(() => set(this, new EventArgs()));

            this.Loaded += MainPage_Loaded;
        }

        public ICommand Reload { set; get; }

        public ICommand Set { set; get; }

        private void MainPage_Loaded(object? sender, EventArgs e)
        {

            this._db = Handler.MauiContext.Services.GetService<ISqlSugarClient>();
            var entity = _db.Queryable<AppConfig>().First();

            if (entity != null)
            {
                this.url = entity.Url;
                this.webView.Source = entity.Url;
            }

#if ANDROID
    
    XbclMes.Platforms.Android.SslHandler.SetSsl(this.webView);

#endif
        }

        public void reload(object sender,EventArgs e)
        {
            this.webView.Reload();
        }

        public async void set(object sender, EventArgs e)
        {
            var entity = await _db.Queryable<AppConfig>().FirstAsync();
            string result = await DisplayPromptAsync("设置", "Url","确定","取消",initialValue:entity?.Url);

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
