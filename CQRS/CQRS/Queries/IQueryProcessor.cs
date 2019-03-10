namespace CQRS.Queries
{
    /// <summary>
    /// The QueryProcessor interface is responsible for processing queries based on the type of query.  It should pick the appropriate
    /// class of IQueryHandler to actually process the request.
    /// </summary>
    public interface IQueryProcessor
    {
        TResult Process<TResult>(IQuery<TResult> query);
    }
}