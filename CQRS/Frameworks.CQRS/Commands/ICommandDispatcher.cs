namespace Frameworks.CQRS.Commands
{
    /// <summary>
    /// The TCommandDispatcher interface is responsible for locating and calling the Handle method of a the appropriate <see cref="TCommandHandler{TCommand}"/>, based
    /// on the type of the specified <see cref="TCommand"/>.
    /// </summary>
    /// <typeparam name="TCommand" />
    public interface ICommandDispatcher
    {
        /// <summary>
        /// The Handle method should invoke the Handle method of the appropriate <see cref="TCommandHandler{TCommand}"/> method.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        void Handle<TCommand>(TCommand command) where TCommand : ICommand;

        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        /// <typeparam name="TCommand">
        /// </typeparam>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        /// The <see cref="TResult"/>.
        /// </returns>
        TResult Handle<TCommand, TResult>(TCommand command) where TCommand : ICommand<TResult>;
    }
}