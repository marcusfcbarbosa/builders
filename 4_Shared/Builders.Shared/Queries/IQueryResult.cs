namespace Builders.Shared.Queries
{
    public interface IQueryResult
    {
        bool Success { get; set; }
        string Message { get; set; }
        object Data { get; set; }
    }
}
