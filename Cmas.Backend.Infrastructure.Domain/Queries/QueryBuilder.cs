using System;
using System.Collections.Generic;
using System.Text;
using Cmas.Backend.Infrastructure.Domain.Criteria;

namespace Cmas.Backend.Infrastructure.Domain.Queries
{
    public class QueryBuilder : IQueryBuilder
    {
        private readonly Func<Type, object> _dataServiceFactory;

        public QueryBuilder(Func<Type, object> dataServiceFactory)
        {
            _dataServiceFactory = dataServiceFactory;
        }

        public IQueryFor<TResult> For<TResult>()
        {
            return _dataServiceFactory(typeof(IQueryFor<TResult>)) as IQueryFor<TResult>;
        }
    }
}
