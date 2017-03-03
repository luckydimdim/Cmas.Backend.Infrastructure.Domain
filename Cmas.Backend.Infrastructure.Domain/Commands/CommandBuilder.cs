using System;
using System.Threading.Tasks;

namespace Cmas.Backend.Infrastructure.Domain.Commands
{
    /// <summary>
    ///     Стандартная реализация интерефейса <see cref="ICommandBuilder" />
    /// </summary>
    public class CommandBuilder : ICommandBuilder
    {
        private readonly Func<Type, object> _dataServiceFactory;

        /// <summary>
        ///     Конструктор.
        /// </summary>
        /// <param name="commandFactory"></param>
        public CommandBuilder(Func<Type, object> dataServiceFactory)
        {
            _dataServiceFactory = dataServiceFactory;
        }

        public async Task<TCommandContext> Execute<TCommandContext>(TCommandContext commandContext)
            where TCommandContext : ICommandContext
        {
            var instance = _dataServiceFactory(typeof(ICommand<TCommandContext>));
            return await (instance as ICommand<TCommandContext>).Execute(commandContext);
        }
    }
}
