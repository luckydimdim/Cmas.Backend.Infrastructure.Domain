namespace Cmas.Backend.Infrastructure.Domain.Criteria
{
    /// <summary>
    ///     Критерий для поиска по идентификатору
    /// </summary>
    public class FindById : ICriterion
    {
        public FindById(string id)
        {
            Id = id;
        }

        /// <summary>
        ///     Идентификатор доменной сущности
        /// </summary>
        public string Id { get; private set; }
    }
}