using Stock.Application.DTOs;
using Stock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Interfaces
{
    public interface IContactosService
    {
        Task<Contactos> Incluir(ContactosDTO contactosDTO);
        Task<Contactos> Alterar(ContactosDTO contactosDTO);
        Task<Contactos> Excluir(int id);
        Task<Contactos> SelecionarAsync(int id);
        Task<IEnumerable<ContactosDTO>> SelecionarTodosAsync();
    }
}
