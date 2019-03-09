namespace CQRS.Commands
{
    /// <summary>
    /// The ICommandDispatcher interface is responsible for locating and calling the Handle method of a the appropriate <see cref="ICommandHandler{TCommand}"/>, based
    /// on the type of the specified <see cref="TCommand"/>.
    /// </summary>
    /// <typeparam name="TCommand" />
    public interface ICommandDispatcher<TCommand>
    {
        /// <summary>
        /// The Handle method should invoke the Handle method of the appropriate <see cref="ICommandHandler{TCommand}"/> method.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        void Handle(TCommand command);
    }

    /// <summary>
    /// The ICommandDispatcher interface is responsible for locating and calling the Handle method of a the appropriate <see cref="ICommandHandler{TCommand, TResult}"/>, based
    /// on the type of the specified <see cref="TCommand"/>.  
    /// </summary>
    /// <typeparam name="TCommand" />
    /// <typeparam name="TResult" />
    public interface ICommandDispatcher<TCommand, TResult>
    {
        /// <summary>
        /// The Handle method should invoke the Handle method of the appropriate <see cref="ICommandHandler{TCommand}"/> method.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        /// <returns>
        /// Returns a result of type <see cref="TResult"/>.
        /// </returns>
        TResult Handle(TCommand command);
    }
}