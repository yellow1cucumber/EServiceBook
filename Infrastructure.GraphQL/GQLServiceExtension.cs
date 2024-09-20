using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.GraphQL
{
    public static class GQLServiceExtension
    {
        public static IServiceCollection AddGQLService(this IServiceCollection services)
        {
            services.AddGraphQLServer()
                    .AddProjections()
                    .AddFiltering()
                    .AddSorting();


            return services;
        }
    }
}
