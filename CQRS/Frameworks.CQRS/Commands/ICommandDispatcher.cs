namespace Frameworks.CQRS.Commands
{
    /// <summary>
    /// The ICommandDispatcher interface is responsible for locating and calling the Handle method of a the appropriate <see cref="ICommandHandler{ICommand}"/>, based
    /// on the type of the specified <see cref="ICommand"/>.
    /// </summary>
    /// <typeparam name="ICommand" />
    public interface ICommandDispatcher
    {
        /// <summary>
        /// The Handle method should invoke the Handle method of the appropriate <see cref="ICommandHandler{ICommand}"/> method.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        void Handle(ICommand command);

        /// <summary>
        /// The handle.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        /// <typeparam name="ICommand">
        /// </typeparam>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        /// The <see cref="TResult"/>.
        /// </returns>
        TResult Handle<TResult>(ICommand command);
    }
}