using Microsoft.Extensions.Caching.StackExchangeRedis;
using SqlSugar;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddStackExchangeRedisCache(option =>
            {
                option.Configuration = "localhost:56379";
                option.InstanceName = "SampleInstance";
            });

            ConnectionConfig config = new ConnectionConfig()
            {
                ConnectionString =
                    "Data Source=8.130.178.66:1521/orcl;User ID=mesdb;Password=mesdb123;Persist Security Info=True;Connection Timeout=60;",
                DbType = DbType.Oracle,
                ConfigId = "oracle",
                IsAutoCloseConnection = true
            };

            builder.Services.AddSingleton<ConnectionConfig>(config);
            builder.Services.AddSingleton<ISqlSugarClient, SqlSugarClient>();
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
