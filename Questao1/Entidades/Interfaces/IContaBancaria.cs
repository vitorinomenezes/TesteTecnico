using Questao1.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1.Entidades.Interfaces
{
    interface IContaBancaria
    {
        bool Adicionar(ContaBancariaModel _model);
        bool Atualizar(ContaBancariaModel _model);
    }
}
