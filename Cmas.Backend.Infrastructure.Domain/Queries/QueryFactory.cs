using System;
using Cmas.Backend.Infrastructure.Domain.Criteria;

namespace Cmas.Backend.Infrastructure.Domain.Queries
{
    public class QueryFactory : IQueryFactory
    {
        private readonly Func<Type, object> _dataServiceFactory;

        public QueryFactory(Func<Type, object> dataServiceFactory)
        {
            _dataServiceFactory = dataServiceFactory;
        }

        public IQuery<TCriterion, TResult> Create<TCriterion, TResult>() where TCriterion : ICriterion
        {
            return _dataServiceFactory(typeof(IQuery<TCriterion, TResult>)) as IQuery<TCriterion, TResult>;
        }
    }
}
