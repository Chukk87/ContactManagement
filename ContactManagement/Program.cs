using ContactManagerLibrary.Services;
using ContactManagerLibrary.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ContactManagement
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure service collection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build service provider
            ServiceProvider = serviceCollection.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetService<Main>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Register services
            services.AddSingleton<IClassBuilderService, ClassBuilderService>();
            services.AddSingleton<IDataCollector, DataCollector>();
            services.AddSingleton<ISqlService, SqlService>();

            // Register forms to inject dependencies into them
            services.AddTransient<Main>();
        }
    }
}