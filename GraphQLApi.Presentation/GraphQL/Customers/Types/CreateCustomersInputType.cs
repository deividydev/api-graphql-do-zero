using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLApi.Contracts.Customers.Inputs;

namespace GraphQLApi.Presentation.GraphQL.Customers.Types
{
    public class CreateCustomersInputType : InputObjectGraphType<CreateCustomersInput>
    {
        public CreateCustomersInputType()
        {
            Name = "CreateCustomersInput";
            Field(x => x.Name);
            Field(x => x.DateBirth);
            Field(x => x.IsActive);
        }
    }
}