using System;

using R5T.T0079;

using IServiceCollection = R5T.T0061.IServiceCollection;


namespace System
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollectionBuilder NewBuilder(this IServiceCollection _)
        {
            var output = new ServiceCollectionBuilder();
            return output;
        }
    }
}