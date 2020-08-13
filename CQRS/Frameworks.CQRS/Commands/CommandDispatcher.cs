namespace Frameworks.CQRS.Commands
{
    /// <summary>
    /// The <see cref="CommandDispatcher"/> class is responsible for interpreting
    ///  the type of <see cref="ICommand"/> or <see cref="ICommand"/>
    /// </summary>
    public class CommandDispatcher : ICommandDispatcher
    {
        /// <inheritdoc />
        public void Handle(ICommand command)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public TResult Handle<TResult>(ICommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}