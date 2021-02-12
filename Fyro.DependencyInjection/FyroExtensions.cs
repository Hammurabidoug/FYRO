using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class FyroExtensions
    {
        public static FyroBuilder AddFyro(this IServiceCollection services)
        {
            return new FyroBuilder(services);
        }
    }
}
