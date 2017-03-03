using System.Threading.Tasks;

namespace Cmas.Backend.Infrastructure.Domain.Commands
{
    /// <summary>
    ///     Интерфейс для команды.
    /// </summary>
    /// <typeparam name="TCommandContext">Контекст команды</typeparam>
    public interface ICommand<TCommandContext>
        where TCommandContext : ICommandContext
    {
        /// <summary>
        ///     Выполняет действия команды.
        /// </summary>
        /// <param name="commandContext">Контекст команды</param>
        Task<TCommandContext> Execute( TCommandContext commandContext);
    }
}
