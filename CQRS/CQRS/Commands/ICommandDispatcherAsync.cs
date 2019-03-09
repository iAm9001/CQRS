namespace CQRS.Commands
{
    using System.Threading.Tasks;

    /// <summary>
    /// The ICommandDispatcherAsync interface is responsible for locating and calling the Handle method of a the appropriate <see cref="ICommandHandlerAsync{TCommand, TResult}"/>, based
    /// on the type of the specified <see cref="TCommand"/> and <see cref="TResult"/>.  
    /// </summary>
    /// <typeparam name="TCommand" />
    /// <typeparam name="TResult" />
    public interface ICommandDispatcherAsync<TCommand, TResult>
    {
        /// <summary>
        /// The HandleAsync method should invoke the HandleAsync method of the appropriate <see cref="ICommandHandlerAsync{TCommand, TResult}"/> method.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        /// <returns>
        /// Returns a result of type <see cref="Task{TResult}"/>.
        /// </returns>
        Task<TResult> HandleAsync(TCommand command);
    }
}