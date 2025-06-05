using System.Linq.Expressions;

namespace GraphQLApi.Domain.SpecificationsBase
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
    }
}