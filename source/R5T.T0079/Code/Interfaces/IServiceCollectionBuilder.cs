using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0072;


namespace R5T.T0079
{
    public interface IServiceCollectionBuilder : IHasConfigureServices<IServiceCollectionBuilder>
    {
        ServiceCollection Build();
    }
}
