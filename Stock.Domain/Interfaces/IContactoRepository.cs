using Stock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Interfaces
{
    public interface IContactoRepository
    {
        Task<Contactos> Incluir(Contactos contactos);
        Task<Contactos> Alterar(Contactos contactos);
        Task<Contactos> Excluir(int id);
        Task<Contactos> SelecionarAsync(int id);
        Task<IEnumerable<Contactos>> SelecionarTodosAsync();
    }
}
