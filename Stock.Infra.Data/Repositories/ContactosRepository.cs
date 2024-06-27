using Microsoft.EntityFrameworkCore;
using Stock.Domain.Entities;
using Stock.Domain.Interfaces;
using Stock.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infra.Data.Repositories
{
    public class ContactosRepository : IContactoRepository
    {
        private readonly ApplicationDbContext _context;
        public ContactosRepository(ApplicationDbContext context)
        {

            _context = context;
        }

        public async Task<Contactos> Alterar(Contactos contactos)
        {
            var contacto =  _context.Contactos.Update(contactos);
            await _context.SaveChangesAsync();
            return contactos ;
        }

        public async Task<Contactos> Excluir(int id)
        {
            var contactos = await _context.Contactos.FindAsync(id);
            if (contactos != null)
            {
                _context.Contactos.Remove(contactos);
                _context.SaveChanges();
            }
            return contactos;
        }

        public async Task<Contactos> Incluir(Contactos contactos)
        {
            var contacto = await _context.Contactos.AddAsync(contactos);
            await _context.SaveChangesAsync();
            return contactos;
        }

        public async Task<Contactos> SelecionarAsync(int id)
        {
            var contactos = await _context.Contactos.FindAsync(id);
            return contactos;
        }

        public async Task<IEnumerable<Contactos>> SelecionarTodosAsync()
        {
            var contactos = await _context.Contactos.ToListAsync();
            return contactos;
        }
    }

       

       
    }

