
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Storage;
using SqlSugar;

namespace XbclMes
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();


#endif

            
            var file = Path.Combine(FileSystem.Current.CacheDirectory, "main.db");

            if (!File.Exists(file))
            {
                using Stream inputStream = FileSystem.Current.OpenAppPackageFileAsync("main.db").Result;
                using FileStream outputStream = File.Create(file);
                inputStream.CopyToAsync(outputStream).Wait();
            }

            var config = new ConnectionConfig()
            {
                DbType = DbType.Sqlite,
                ConnectionString = $"DataSource={file}",
                IsAutoCloseConnection = true,
            };

            builder.Services.AddSingleton(config);

            builder.Services.AddScoped<ISqlSugarClient, SqlSugarClient>();


            return builder.Build();
        }
    }
}
