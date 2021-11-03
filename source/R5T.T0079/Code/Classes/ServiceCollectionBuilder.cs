using System;
using System.Collections.Generic;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0079
{
    public class ServiceCollectionBuilder : IServiceCollectionBuilder
    {
        private List<Action<IServiceCollection>> ConfigureActions { get; } = new List<Action<IServiceCollection>>();


        public ServiceCollection Build()
        {
            var services = new ServiceCollection();

            foreach (var configureAction in this.ConfigureActions)
            {
                configureAction(services);
            }

            return services;
        }

        public IServiceCollectionBuilder ConfigureServices(Action<IServiceCollection> configureServicesAction)
        {
            this.ConfigureActions.Add(configureServicesAction);

            return this;
        }
    }
}
