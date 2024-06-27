using Stock.Application.DTOs;
using Stock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<produto> Incluir(ProdutoDTO produtoDTO);
        Task<produto> Alterar(ProdutoDTO produtoDTO);
        Task<produto> Excluir(int id);
        Task<produto> SelecionarAsync(int id);
        Task<IEnumerable<produto>> SelecionarTodosAsync();
    }
}
