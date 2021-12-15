using System;

using R5T.D0085;
using R5T.T0063;
using R5T.T0079;

using Instances = R5T.T0079.X001.Instances;


namespace System
{
    public static class IServiceCollectionBuilderExtensions
    {
        public static IServiceCollectionBuilder UseServicesConfigurer<TServicesConfigurer>(this IServiceCollectionBuilder serviceCollectionBuilder,
            IServiceAction<TServicesConfigurer> servicesConfigurerAction)
            where TServicesConfigurer : class, IServicesConfigurer
        {
            serviceCollectionBuilder.ConfigureServices(services =>
                SyncOverAsyncHelper.ExecuteSynchronously(async () =>
                {
                    using var serviceProvider = Instances.ServiceOperator.GetServiceInstance(
                        servicesConfigurerAction,
                        out var servicesConfigurer);

                    await servicesConfigurer.ConfigureServices(services);
                }));

            return serviceCollectionBuilder;
        }
    }
}