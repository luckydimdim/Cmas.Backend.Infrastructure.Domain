﻿using Cmas.Backend.Infrastructure.Domain.Criteria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cmas.Backend.Infrastructure.Domain.Queries
{
    /// <summary>
    ///     Стандартная реализация <see cref="IQueryFor{T}" />
    /// </summary>
    /// <typeparam name="TResult">Результат возвращаемый запросом</typeparam>
    public class QueryFor<TResult> : IQueryFor<TResult>
    {
        private readonly IQueryFactory _factory;

        /// <summary>
        ///     ctor
        /// </summary>
        /// <param name="factory"></param>
        public QueryFor(IQueryFactory factory)
        {
            _factory = factory;
        }

        public TResult With<TCriterion>(TCriterion criterion)
            where TCriterion : ICriterion
        {
            return _factory.Create<TCriterion, TResult>().Ask(criterion);
        }
    }
}
