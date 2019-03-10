namespace Frameworks.CQRS.Queries
{
    /// <summary>
    /// The QueryProcessor interface is responsible for processing queries based on the type of query.  It should pick the appropriate
    /// class of IQueryHandler to actually process the request.
    /// </summary>
    public interface IQueryProcessor
    {
        /// <summary>
        /// The Process method is responsible for executing the appropriate IQueryHandler's Handle method.
        /// </summary>
        /// <param name="query">
        /// The query.
        /// </param>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        /// The <see cref="TResult"/>.
        /// </returns>
        TResult Process<TResult>(IQuery<TResult> query);
    }
}