using Dapper;
using Microsoft.Data.Sqlite;
using Questao5.Domain.Entities;
using Questao5.Infrastructure.Sqlite;

namespace Questao5.Infrastructure.Database.QueryStore.Requests
{
    public class GetTodasContassQueryHandler 
    {
        private readonly DatabaseConfig _context;
        public GetTodasContassQueryHandler(DatabaseConfig context)
        {
            _context = context;
        }

    
        public async Task<IEnumerable<ContaCorrenteModel>> Handle()
        {
            using (var connection = new SqliteConnection(_context.Name))
            {
                connection.Open();
                IEnumerable<ContaCorrenteModel> _dados = connection.Query<ContaCorrenteModel>("SELECT IdContaCorrente,Numero, Nome, Ativo FROM contacorrente");
                return _dados;
            }
        }
    }
}
