using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Argumentos.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CommandLineArgumentsProvider"/> implementation of <see cref="ICommandLineArgumentsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultCommandLineArgumentsProvider(this IServiceCollection services)
        {
            services.AddSingleton<ICommandLineArgumentsProvider, CommandLineArgumentsProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CommandLineArgumentsProvider"/> implementation of <see cref="ICommandLineArgumentsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultCommandLineArgumentsProvider<TCommandLineArgumentsProvider>(this IServiceCollection services)
            where TCommandLineArgumentsProvider: ICommandLineArgumentsProvider
        {
            services.AddDefaultCommandLineArgumentsProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CommandLineArgumentsProvider"/> implementation of <see cref="ICommandLineArgumentsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ICommandLineArgumentsProvider> AddDefaultCommandLineArgumentsProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ICommandLineArgumentsProvider>(() => services.AddDefaultCommandLineArgumentsProvider());
            return serviceAction;
        }
    }
}
