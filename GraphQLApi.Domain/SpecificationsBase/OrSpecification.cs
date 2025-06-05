using System.Linq.Expressions;

namespace GraphQLApi.Domain.SpecificationsBase
{
    public class OrSpecification<T>(ISpecification<T> left, ISpecification<T> right) : Specification<T>
    {
        private readonly ISpecification<T> _left = left;
        private readonly ISpecification<T> _right = right;

        public override Expression<Func<T, bool>> Criteria =>
            _left.Criteria.OrElse(_right.Criteria);
    }
}