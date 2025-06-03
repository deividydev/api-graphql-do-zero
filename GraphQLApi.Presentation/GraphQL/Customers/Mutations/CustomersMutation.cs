using GraphQL;
using GraphQL.Types;
using GraphQLApi.Application.CustomersServices;
using GraphQLApi.Contracts.Customers.Inputs;
using GraphQLApi.Presentation.GraphQL.Customers.Types;

namespace GraphQLApi.Presentation.GraphQL.Customers.Mutations
{
    public class CustomersMutation : ObjectGraphType
    {
        public CustomersMutation(ICustomersServices customersService)
        {
            Field<CustomerType>("createCustomer")
            .Argument<NonNullGraphType<CreateCustomersInputType>>("customer")
            .ResolveAsync(async context =>
            {
                var input = context.GetArgument<CreateCustomersInput>("customer");
                return await customersService.CreateAsync(input);
            });
        }
    }
}