using System.Linq.Expressions;

namespace GraphQLApi.Domain.SpecificationsBase
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public abstract Expression<Func<T, bool>> Criteria { get; }
    }
}