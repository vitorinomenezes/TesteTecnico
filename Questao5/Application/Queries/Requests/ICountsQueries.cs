using Questao5.Domain.Entities;

namespace Questao5.Application.Queries.Requests
{
    public interface ICountsQueries
    {
        Task<IEnumerable<ContaCorrenteModel>> GetAll();
    }
}
