using System.Threading.Tasks;

namespace Frameworks.CQRS.Commands
{
    /// <summary>
    /// The <see cref="CommandDispatcherAsync"/> class is responsible for interpreting
    ///  the type of <see cref="ICommand"/> or <see cref="ICommand"/>
    /// </summary>
    public class CommandDispatcherAsync : ICommandDispatcherAsync
    {
        /// <inheritdoc />
        public Task HandleAsync<TCommandAsync>(TCommandAsync command) where TCommandAsync : ICommandAsync
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<TResult> HandleAsync<TCommandAsync, TResult>(TCommandAsync command)
            where TCommandAsync : ICommandAsync<TResult>
        {
            throw new System.NotImplementedException();
        }
    }
}