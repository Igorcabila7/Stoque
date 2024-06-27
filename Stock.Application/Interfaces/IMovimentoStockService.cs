using Stock.Application.DTOs;
using Stock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Interfaces
{
    public interface IMovimentoStockService
    {
        Task<movimentostock> Incluir(MovimentoStockDTO Movimento);
        Task<Usuario> SelecionarAsync(int id);
        Task<IEnumerable<Usuario>> SelecionarTodosAsync();
    }
}
