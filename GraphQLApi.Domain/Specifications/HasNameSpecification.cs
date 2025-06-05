using System.Linq.Expressions;
using GraphQLApi.Domain.Entities;
using GraphQLApi.Domain.SpecificationsBase;

namespace GraphQLApi.Domain.Specifications
{
    public class HasNameSpecification : Specification<Customers>
    {
        public override Expression<Func<Customers, bool>> Criteria =>
            customer => !string.IsNullOrEmpty(customer.Name);
    }
}