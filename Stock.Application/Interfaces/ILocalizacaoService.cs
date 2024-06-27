using Stock.Application.DTOs;
using Stock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Interfaces
{
    public interface ILocalizacaoService
    {
        Task<Localizacao> Incluir(LocalizacaoDTO localizacaoDTO);
        Task<Localizacao> Alterar(LocalizacaoDTO localizacaoDTO);
        Task<Localizacao> Excluir(int id);
        Task<Localizacao> SelecionarAsync(int id);
        Task<IEnumerable<Localizacao>> SelecionarTodosAsync();
    }
}
