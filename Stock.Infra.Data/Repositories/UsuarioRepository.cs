using Microsoft.AspNetCore.Http.HttpResults;
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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;
        public UsuarioRepository(ApplicationDbContext context) { 
        
         _context = context;
        }
        public async Task<Usuario> Alterar(Usuario usuario)
        {
            _context.Usuario.Update(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> Excluir(int id)
        {
           var usuario =await _context.Usuario.FindAsync(id);
           if(usuario != null) 
            {
                _context.Usuario.Remove(usuario);
                _context.SaveChanges();
            }
            return usuario;
        }

        public async Task<Usuario> Incluir(Usuario usuario)
        {
            var Usuario = await _context.Usuario.AddAsync(usuario);
            await _context.SaveChangesAsync();
            return usuario;
            
        }

        public async Task<Usuario> SelecionarAsync(int id)
        {
            var Usuario = await _context.Usuario.FindAsync(id);
            return Usuario;
        }

        public async Task<IEnumerable<Usuario>> SelecionarTodosAsync()
        {
            var Usuarios = await _context.Usuario.ToListAsync();
            return Usuarios;
        }

        
    }
}
