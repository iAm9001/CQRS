namespace Frameworks.CQRS.Commands
{
    /// <summary>
    ///     The <see cref="ICommandAsync" /> interface describes a command that is to be passed to
    ///     a <see cref="ICommandHandlerAsync{TCommand}" /> command handler.
    /// </summary>
    public interface ICommandAsync
    {
    }


    /// <summary>
    ///     The <see cref="ICommandAsync{TResult}" /> interface describes a command that is to be passed to
    ///     a <see cref="ICommandHandlerAsync{TCommand, TResult}" /> command handler.
    /// </summary>
    public interface ICommandAsync<TResult>
    {
    }
}