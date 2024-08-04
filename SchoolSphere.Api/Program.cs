// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolSphere.Api.Brokers.DateTimes;
using SchoolSphere.Api.Brokers.Loggings;
using SchoolSphere.Api.Brokers.Storages;

namespace SchoolSphere.Api
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<StorageBroker>();
            RegisterBrokers(builder);

            var app = builder.Build();

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

        private static void RegisterBrokers(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IStorageBroker, StorageBroker>();
            builder.Services.AddTransient<ILoggingBroker, LoggingBroker>();
            builder.Services.AddTransient<IDateTimeBroker, DateTimeBroker>();
        }
    }
}