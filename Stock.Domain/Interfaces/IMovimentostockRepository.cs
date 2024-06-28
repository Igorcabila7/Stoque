using Stock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Interfaces
{
    public interface IMovimentostockRepository
    {
        Task<movimentostock> Incluir(movimentostock Movimento);
        Task<movimentostock> SelecionarAsync(int id);
        Task<IEnumerable<movimentostock>> SelecionarTodosAsync();
    }
}
