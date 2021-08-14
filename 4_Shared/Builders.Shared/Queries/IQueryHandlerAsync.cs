using System.Threading.Tasks;

namespace Builders.Shared.Queries
{
    public interface IQueryHandlerAsync<T> where T : IQuerie
    {
        Task<IQueryResult> Handle(T querie);
    }
}
