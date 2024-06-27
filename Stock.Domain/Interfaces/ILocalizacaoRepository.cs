using Stock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Interfaces
{
    public interface ILOcalizacaoRepository
    {
        Task<Localizacao> Incluir(Localizacao localizacao);
        Task<Localizacao> Alterar(Localizacao localizacao);
        Task<Localizacao> Excluir(int id);
        Task<Localizacao> SelecionarAsync(int id);
        Task<IEnumerable<Localizacao>> SelecionarTodosAsync();
    }
}
