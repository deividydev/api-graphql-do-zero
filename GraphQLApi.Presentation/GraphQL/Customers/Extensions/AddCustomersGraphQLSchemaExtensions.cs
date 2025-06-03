using GraphQL;
using GraphQL.Types;
using GraphQLApi.Presentation.GraphQL.Customers.Mutations;
using GraphQLApi.Presentation.GraphQL.Customers.Queries;
using GraphQLApi.Presentation.GraphQL.Customers.Types;
using GraphQLApi.Presentation.GraphQL.CustomersSchemas;

namespace GraphQLApi.Presentation.GraphQL.Customers.Extensions
{
    public static class AddCustomersGraphQLSchemaExtensions
    {
        public static IServiceCollection AddCustomersGraphQLSchema(this IServiceCollection services)
        {
            services.AddSingleton<ISchema, CustomersSchema>();

            services.AddSingleton<CustomersQuery>();
            services.AddSingleton<CustomersMutation>();
            services.AddSingleton<CustomerType>();
            services.AddSingleton<CreateCustomersInputType>();

            services.AddGraphQL(o => o.AddSchema<CustomersSchema>()
                                      .AddSystemTextJson()
                                      .AddDataLoader());

            return services;
        }
    }
}
