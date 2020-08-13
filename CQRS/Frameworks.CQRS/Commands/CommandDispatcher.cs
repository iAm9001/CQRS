namespace Frameworks.CQRS.Commands
{
    /// <summary>
    /// The <see cref="CommandDispatcher"/> class is responsible for interpreting
    ///  the type of <see cref="ICommand"/> or <see cref="ICommand"/>
    /// </summary>
    public class CommandDispatcher : ICommandDispatcher
    {
        /// <inheritdoc />
        public void Handle<TCommand>(TCommand command) where TCommand : ICommand
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public TResult Handle<TCommand, TResult>(TCommand command) where TCommand : ICommand<TResult>
        {
            throw new System.NotImplementedException();
        }
    }
}