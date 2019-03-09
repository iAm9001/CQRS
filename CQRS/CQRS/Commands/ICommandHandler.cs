namespace CQRS.Commands
{
    using System.Threading.Tasks;

    /// <summary>
    /// The CommandHandler interface is used to implement the Command Handler pattern for commands of type <see cref="TCommand"/>.
    /// </summary>
    /// <typeparam name="TCommand" />
    public interface ICommandHandler<TCommand>
    {
        /// <summary>
        /// The Handle method is responsible for processing commands of type <see cref="TCommand"/>.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        void Handle(TCommand command);
    }

    /// <summary>
    /// The CommandHandler interface is used to implement the Command Handler pattern for commands of type <see cref="TCommand"/>.
    /// returns a result of type <see cref="TResult"/>.
    /// </summary>
    /// <typeparam name="TCommand" />
    /// <typeparam name="TResult" />
    /// </typeparam>
    public interface ICommandHandler<TCommand, TResult>
    {
        /// <summary>
        /// The Handle method is responsible for processing commands of type <see cref="TCommand"/>.  This implementation returns a result
        /// of type <see cref="TResult"/>.
        /// </summary>
        /// <param name="command">
        /// The command.
        /// </param>
        /// <returns>
        /// The <see cref="TResult"/>.
        /// </returns>
        TResult Handle(TCommand command);
    }
}