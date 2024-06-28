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
        Task<MovimentoStockDTO> Incluir(MovimentoStockDTO Movimento);
        Task<MovimentoStockDTO> SelecionarAsync(int id);
        Task<IEnumerable<MovimentoStockDTO>> SelecionarTodosAsync();
    }
}
