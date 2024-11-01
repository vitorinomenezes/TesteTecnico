using MediatR;
using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.QueryStore.Requests
{
    public class GetTodasContasQuery : IRequest<IEnumerable<ContaCorrenteModel>>
    {
    }
}
