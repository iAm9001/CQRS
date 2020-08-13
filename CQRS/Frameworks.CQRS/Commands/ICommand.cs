namespace Frameworks.CQRS.Commands
{
    /// <summary>
    ///     The <see cref="ICommand" /> interface describes a command that is to be passed to
    ///     a <see cref="ICommandHandler{TCommand}" /> command handler.
    /// </summary>
    public interface ICommand
    {
    }

    /// <summary>
    ///     The <see cref="ICommand{TResult}" /> interface describes a command that is to be passed to
    ///     a <see cref="ICommandHandler{TCommand, TResult}" /> command handler.
    /// </summary>
    public interface ICommand<TResult>
    {
    }
}