using System.Threading.Tasks;

namespace Frameworks.CQRS.Commands
{
    /// <summary>
    /// The <see cref="ICommandDispatcherAsync"/> interface is responsible for locating and calling the HandleAsync
    /// method of the appropriate <see cref="ICommandHandlerAsync{ICommandAsync}"/>, based
    /// on the type of the specified <see cref="ICommandAsync"/>.
    /// </summary>
    /// <typeparam name="ICommand" />
    public interface ICommandDispatcherAsync
    {
        /// <summary>
        /// The HandleAsync method should invoke the Handle method of the appropriate
        /// <see cref="ICommandHandler{TCommand}"/> method.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        Task HandleAsync<TCommandAsync>(TCommandAsync command) where TCommandAsync : ICommandAsync;

        /// <summary>
        /// The HandleAsync method should invoke the Handle method of the appropriate
        /// <see cref="ICommandHandler{TCommand}"/> method.
        /// <param name="command">
        /// The command.
        /// </param>
        /// <typeparam name="ICommandAsync">
        /// </typeparam>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        /// The <see cref="TResult"/>.
        /// </returns>
        /// </summary>
        Task<TResult> HandleAsync<TCommandAsync, TResult>(TCommandAsync command)
            where TCommandAsync : ICommandAsync<TResult>;
    }
}