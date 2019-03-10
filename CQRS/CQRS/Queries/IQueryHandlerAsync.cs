namespace CQRS.Queries
{
    using System.Threading.Tasks;

    /// <summary>
    /// The QueryHandlerAsync interface defines a Query Handler that is responsible for processing queries of type <see cref="TQuery"/>, which also
    /// return a query result of type <see cref="TResult"/>.
    /// </summary>
    /// <typeparam name="TQuery">
    /// </typeparam>
    /// <typeparam name="TResult">
    /// </typeparam>
    public interface IQueryHandlerAsync<TQuery, TResult>
        where TQuery : IQuery<TResult>
    {
        /// <summary>
        /// The HandleAsync method is responsible for executing a query of type <see cref="TQuery"/> that returns a result of type <see cref="Task{TResult}"/>.
        /// </summary>
        /// <param name="query">
        /// The query.
        /// </param>
        /// <returns>
        /// The <see cref="TResult"/>.
        /// </returns>
        Task<TResult> HandleAsync(TQuery query);
    }
}