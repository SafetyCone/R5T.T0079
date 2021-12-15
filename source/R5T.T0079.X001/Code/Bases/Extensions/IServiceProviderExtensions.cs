using System;

using R5T.T0079;

using IServiceProviderExtensionMethodBase = R5T.T0061.IServiceProvider;


namespace System
{
    public static class IServiceProviderExtensions
    {
        public static IServiceProviderBuilder NewBuilder(this IServiceProviderExtensionMethodBase _)
        {
            var output = new ServiceProviderBuilder();
            return output;
        }
    }
}