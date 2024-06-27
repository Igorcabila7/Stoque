using Stock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<produto> Incluir(produto Produto);
        Task<produto> Alterar(produto Produto);
        Task<produto> Excluir(int id);
        Task<produto> SelecionarAsync(int id);
        Task<IEnumerable<produto>> SelecionarTodosAsync();
    }
}
