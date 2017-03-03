using Cmas.Backend.Infrastructure.Domain.Criteria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cmas.Backend.Infrastructure.Domain.Queries
{
    /// <summary>
    ///     Фабрика объектов запросов
    /// </summary>
    public interface IQueryFactory
    {
        /// <summary>
        ///     Создать запрос, возвращающий необходимые результаты с определенными критериями
        /// </summary>
        /// <typeparam name="TCriterion"> </typeparam>
        /// <typeparam name="TResult"> </typeparam>
        /// <returns> </returns>
        IQuery<TCriterion, TResult> Create<TCriterion, TResult>()
            where TCriterion : ICriterion;
    }
}
