using Castle.Core.Resource;
using Questao5.Domain.Entities;

namespace Questao5.Infrastructure
{
    public interface ICountsRepository
    {
        Task<ContaCorrenteModel> GetById(int id);
        Task<IEnumerable<ContaCorrenteModel>> GetAll();
    }
}
