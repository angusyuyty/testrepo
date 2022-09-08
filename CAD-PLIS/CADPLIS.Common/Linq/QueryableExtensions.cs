using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> PageBy<T>(this IQueryable<T> query, int skipCount, int maxResultCount)
        {
            return query.Skip(skipCount).Take(maxResultCount);
        }

        public static TQueryable PageBy<T, TQueryable>(this TQueryable query, int skipCount, int maxResultCount) where TQueryable : IQueryable<T>
        {
            return (TQueryable)query.Skip(skipCount).Take(maxResultCount);
        }

        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate)
        {
            if (!condition)
            {
                return query;
            }

            return query.Where(predicate);
        }

        public static TQueryable WhereIf<T, TQueryable>(this TQueryable query, bool condition, Expression<Func<T, bool>> predicate) where TQueryable : IQueryable<T>
        {
            if (!condition)
            {
                return query;
            }

            return (TQueryable)query.Where(predicate);
        }

        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, int, bool>> predicate)
        {
            if (!condition)
            {
                return query;
            }

            return query.Where(predicate);
        }

        public static TQueryable WhereIf<T, TQueryable>(this TQueryable query, bool condition, Expression<Func<T, int, bool>> predicate) where TQueryable : IQueryable<T>
        {
            if (!condition)
            {
                return query;
            }

            return (TQueryable)query.Where(predicate);
        }
    }
}
