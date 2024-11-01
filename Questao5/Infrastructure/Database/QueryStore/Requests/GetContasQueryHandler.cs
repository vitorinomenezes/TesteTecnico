using Dapper;
using FluentAssertions;
using MediatR;
using Microsoft.Data.Sqlite;
using NSubstitute;
using Questao5.Domain.Entities;
using Questao5.Infrastructure.Sqlite;
using System;
using System.Data.SqlClient;

namespace Questao5.Infrastructure.Database.QueryStore.Requests
{
    public class GetContasQueryHandler : IRequestHandler<GetContasPorIdQuery, ContaCorrenteModel>
    {
        private readonly DatabaseConfig _context;     

        public GetContasQueryHandler(DatabaseConfig context)
        {
            _context = context;
        }

        public async Task<ContaCorrenteModel> Handle(GetContasPorIdQuery request, CancellationToken cancellationToken)
        {
            using (var connection = new SqlConnection(_context.Name))
            {
                connection.Open();
                return (ContaCorrenteModel)await connection.QueryAsync<ContaCorrenteModel>(
                      @"SELECT o.[Id] as ordernumber,
                  o.[OrderDate] as [date],os.[Name] as [status],
                  SUM(oi.units*oi.unitprice) as total
                  FROM [ordering].[Orders] o
                  LEFT JOIN[ordering].[orderitems] oi ON  o.Id = oi.orderid
                  LEFT JOIN[ordering].[orderstatus] os on o.OrderStatusId = os.Id
                  GROUP BY o.[Id], o.[OrderDate], os.[Name]
                  ORDER BY o.[Id]");
            }
        }
    }
}
