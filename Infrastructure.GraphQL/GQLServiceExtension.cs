﻿using System.Reflection;
using DAL;
using HotChocolate.Execution.Configuration;
using Infrastructure.GraphQL.Queries;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure.GraphQL
{
    public static class GQLServiceExtension
    {
        public static IServiceCollection AddGQLService(this IServiceCollection services)
        {
            services.AddGraphQLServer()
                    .RegisterDbContext<Context>()
                    .AddProjections()
                    .AddFiltering()
                    .AddSorting()
                    .AddQueries();

            return services;
        }

        private static IRequestExecutorBuilder AddQueries(this IRequestExecutorBuilder builder)
        {
            builder.AddQueryType(q => q.Name("Query"));
            foreach (Type query in GetQueryTypes(Assembly.GetExecutingAssembly()))
            {
                builder.AddType(query);
            }
            return builder;
        }

        private static IEnumerable<Type> GetQueryTypes(Assembly assembly)
        {
            foreach (var type in assembly.GetTypes())
            {
                if (type.GetCustomAttributes(typeof(GQLQuery), true).Length > 0)
                {
                    yield return type;
                }
            }
        }
    }
}
