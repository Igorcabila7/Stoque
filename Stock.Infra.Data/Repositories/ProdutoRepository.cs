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
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;
        public ProdutoRepository(ApplicationDbContext context)
        {

            _context = context;
        }

        public async Task<produto> Alterar(produto Produto)
        {
            _context.produto.Update(Produto);
            await _context.SaveChangesAsync();
            return Produto;
        }

        public async Task<produto> Excluir(int id)
        {
            var produto = await _context.produto.FindAsync(id);
            if (produto != null)
            {
                _context.produto.Remove(produto);
                _context.SaveChanges();
            }
            return produto;
        }

        public async Task<produto> Incluir(produto Produto)
        {
            var produtos = await _context.produto.AddAsync(Produto);
            await _context.SaveChangesAsync();
            return Produto;
        }

        public async Task<produto> SelecionarAsync(int id)
        {
            var produtos = await _context.produto.FindAsync(id);
            return produtos;
        }

        public async Task<IEnumerable<produto>> SelecionrTodosAsync(int id)
        {
            var Usuarios = await _context.produto.ToListAsync();
            return Usuarios;
        }

        public async Task<IEnumerable<produto>> SelecionarTodosAsync()
        {
            var Usuarios = await _context.produto.ToListAsync();
            return Usuarios;
        }
    }
}
