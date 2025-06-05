using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GraphQLApi.Domain.SpecificationsBase
{
    public class AndSpecification<T>(ISpecification<T> left, ISpecification<T> right) : Specification<T>
    {
        private readonly ISpecification<T> _left = left;
        private readonly ISpecification<T> _right = right;

        public override Expression<Func<T, bool>> Criteria =>
            _left.Criteria.AndAlso(_right.Criteria);
    }
}