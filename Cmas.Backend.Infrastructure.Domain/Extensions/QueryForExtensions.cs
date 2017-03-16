using Cmas.Backend.Infrastructure.Domain.Criteria;
using Cmas.Backend.Infrastructure.Domain.Queries;

namespace Cmas.Backend.Infrastructure.Domain.Extensions
{
    /// <summary>
    /// </summary>
    public static class QueryForExtensions
    {
        /// <summary>
        ///     Добавить критерий для поиска доменной сущности по идентификатору
        /// </summary>
        /// <param name="queryFor"></param>
        /// <param name="id">Идентификатор доменной сущности</param>
        /// <returns>Возвращает найденную доменную сущность, либо null</returns>
        public static TResult ById<TResult>(this IQueryFor<TResult> queryFor, string id)
        {
            return queryFor.With(new FindById(id));
        }

        /// <summary>
        ///     Добавить критерий для поиска всех объектов данного типа
        /// </summary>
        /// <returns>Возвращает найденную доменную сущность, либо null</returns>
        public static TResult All<TResult>(this IQueryFor<TResult> queryFor)
        {
            return queryFor.With(new AllEntities());
        }
    }
}
