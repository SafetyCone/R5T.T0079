using System;
using System.Collections.Generic;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0079
{
    public class ServiceProviderBuilder : IServiceProviderBuilder
    {
        private List<Action<IServiceCollection>> ConfigureActions { get; } = new List<Action<IServiceCollection>>();


        public ServiceProvider Build()
        {
            var services = new ServiceCollection();

            foreach (var configureAction in this.ConfigureActions)
            {
                configureAction(services);
            }

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }

        public IServiceProviderBuilder ConfigureServices(Action<IServiceCollection> configureServicesAction)
        {
            this.ConfigureActions.Add(configureServicesAction);

            return this;
        }
    }
}
