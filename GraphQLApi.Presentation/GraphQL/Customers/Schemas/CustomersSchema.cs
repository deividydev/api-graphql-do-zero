using GraphQL.Types;
using GraphQLApi.Presentation.GraphQL.Customers.Mutations;
using GraphQLApi.Presentation.GraphQL.Customers.Queries;

namespace GraphQLApi.Presentation.GraphQL.CustomersSchemas
{
    public class CustomersSchema : Schema
    {
        public CustomersSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<CustomersQuery>();
            Mutation = provider.GetRequiredService<CustomersMutation>();
        }
    }
}