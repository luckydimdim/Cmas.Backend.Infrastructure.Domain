using Cmas.Backend.Infrastructure.Domain.Criteria;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cmas.Backend.Infrastructure.Domain.Queries
{
    /// <summary>
    ///     Интерфейс для построителя запросов
    /// </summary>
    public interface IQueryBuilder
    {

        /// <summary>
        ///     Начать строить запрос для результата
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        IQueryFor<TResult> For<TResult>();
    }
}
