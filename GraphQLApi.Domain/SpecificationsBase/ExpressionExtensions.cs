using System.Linq.Expressions;

namespace GraphQLApi.Domain.SpecificationsBase
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> AndAlso<T>(
                this Expression<Func<T, bool>> left,
                Expression<Func<T, bool>> right)
        {
            var param = Expression.Parameter(typeof(T));

            var body = Expression.AndAlso(
                Expression.Invoke(left, param),
                Expression.Invoke(right, param)
            );

            return Expression.Lambda<Func<T, bool>>(body, param);
        }

        public static Expression<Func<T, bool>> OrElse<T>(
            this Expression<Func<T, bool>> left,
            Expression<Func<T, bool>> right)
        {
            var param = Expression.Parameter(typeof(T));

            var body = Expression.OrElse(
                Expression.Invoke(left, param),
                Expression.Invoke(right, param)
            );

            return Expression.Lambda<Func<T, bool>>(body, param);
        }

        public static ISpecification<T> And<T>(this ISpecification<T> left, ISpecification<T> right)
        => new AndSpecification<T>(left, right);

        public static Specification<T> Or<T>(this Specification<T> left, Specification<T> right)
        => new OrSpecification<T>(left, right);
    }
}