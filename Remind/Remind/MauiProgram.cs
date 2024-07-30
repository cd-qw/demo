

using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using Remind.Data;
using SqlSugar;



namespace Remind
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                }).ConfigureLifecycleEvents(app =>
                {
#if ANDROID
                    app.AddAndroid(android => {

                        android.OnResume(d => {
                            EventBus.OnResume?.Invoke(d, null);
                        }); 
                    });

#endif
                });


            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddBootstrapBlazor();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif


            var file = Path.Combine(FileSystem.Current.CacheDirectory, "main.db");

            var config = new ConnectionConfig()
            {
                DbType = DbType.Sqlite,
                ConnectionString = $"DataSource={file}",
                IsAutoCloseConnection = true,
            };

            builder.Services.AddSingleton(config);

            builder.Services.AddScoped<ISqlSugarClient, SqlSugarClient>();

            if (!File.Exists(file))
            {
                using Stream inputStream = FileSystem.Current.OpenAppPackageFileAsync("main.db").Result;
                using FileStream outputStream = File.Create(file);
                inputStream.CopyToAsync(outputStream).Wait();
                outputStream.Flush();
                outputStream.Close();

                SqlSugarClient db = new SqlSugarClient(config);
                db.CodeFirst.InitTables(typeof(RemindRecord));
            }

            return builder.Build();
        }
    }
}
