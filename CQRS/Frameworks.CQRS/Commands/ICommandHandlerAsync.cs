namespace Frameworks.CQRS.Commands
{
    using System.Threading.Tasks;

    /// <summary>
    /// The CommandHandlerAsync interface is used to implement the Command Handler pattern for commands of type <see cref="TCommand"/> asynchronously.
    /// </summary>
    /// <typeparam name="TCommand"/>
    /// <typeparamref name="TResult"/>
    /// </typeparam>
    public interface ICommandHandlerAsync<TCommand, TResult>
    {
        /// <summary>
        /// The HandleAsync method is responsible for processing commands of type <see cref="TCommand"/>.  This method returns a result of type <see cref="TResult"/>.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        /// <returns>
        /// Returns a <see cref="Task"/> of type <see cref="TResult"/>.
        /// </returns>
        Task<TResult> HandleAsync(TCommand command);
    }
}