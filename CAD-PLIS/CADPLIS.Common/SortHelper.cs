using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Common
{
    public static class SortHelper
    {
        public static IEnumerable<T> OrderByDynamic<T>(this IEnumerable<T> source, string propertyName, bool Ascending)
        {
            //var propertyInfo = typeof(T).GetProperty(propertyName);
            //if (Ascending)
            //    return source.OrderBy(x => propertyInfo.GetValue(x, null));
            //else
            //    return source.OrderByDescending(x => propertyInfo.GetValue(x, null));

            var queryData = source.AsQueryable();
            string command = Ascending ? "OrderBy" : "OrderByDescending";
            var type = typeof(T);
            var property = type.GetProperty(propertyName);
            var parameter = Expression.Parameter(type, "p");
            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType },
                                          queryData.Expression, Expression.Quote(orderByExpression));
            return queryData.Provider.CreateQuery<T>(resultExpression);
        }
    }
}
