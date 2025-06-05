using System.Linq.Expressions;
using GraphQLApi.Domain.Entities;
using GraphQLApi.Domain.SpecificationsBase;

namespace GraphQLApi.Domain.Specifications
{
    public class ActiveCustomerSpecification : Specification<Customers>
    {
        public override Expression<Func<Customers, bool>> Criteria =>
            customer => customer.IsActive;
    }
}