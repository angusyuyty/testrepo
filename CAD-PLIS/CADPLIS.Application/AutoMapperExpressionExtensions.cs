using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application
{
    public static class AutoMapperExpressionExtensions
    {
        //public static IMappingExpression<TDestination, TMember> Ignore<TDestination, TMember, TResult>
        //    (this IMappingExpression<TDestination, TMember> mappingExpression, Expression<Func<TMember, TResult>> destinationMember)
        //{
        //    return mappingExpression.ForMember(destinationMember, delegate (IMemberConfigurationExpression<TDestination, TMember, TResult> opts)
        //    {
        //        opts.Ignore();
        //    });
        //}


        public static IMappingExpression<TSource, TDestination> Ignore<TSource, TDestination>(
    this IMappingExpression<TSource, TDestination> map,
    Expression<Func<TDestination, object>> selector)
        {
            map.ForMember(selector, config => config.Ignore());
            return map;
        }
    }
}
