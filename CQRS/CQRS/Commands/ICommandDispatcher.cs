namespace CQRS.Commands
{
    /// <summary>
    /// The ICommandDispatcher interface is responsible for locating and calling the Handle method of a the appropriate <see cref="ICommandHandler{TCommand}"/>, based
    /// on the type of the specified <see cref="TCommand"/>.
    /// </summary>
    /// <typeparam name="TCommand" />
    public interface ICommandDispatcher
    {
        /// <summary>
        /// The Handle method should invoke the Handle method of the appropriate <see cref="ICommandHandler{TCommand}"/> method.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        void Handle<TCommand>(TCommand command);

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
        TResult Handle<TCommand, TResult>(TCommand command);
    }
}