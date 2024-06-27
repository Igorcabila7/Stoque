using Microsoft.EntityFrameworkCore;
using Stock.Domain.Entities;
using Stock.Domain.Interfaces;
using Stock.Infra.Data.Context;
using Stock.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infra.Data.Repositories
{
    public class LocalizacaoRepository : ILOcalizacaoRepository
    {
        private readonly ApplicationDbContext _context;
        public LocalizacaoRepository(ApplicationDbContext context)
        {

            _context = context;
        }

        public async Task<Localizacao> Alterar(Localizacao localizacao)
        {
             _context.Localizacao.Update(localizacao);
            await _context.SaveChangesAsync();
            return localizacao;
        }

        public async Task<Localizacao> Excluir(int id)
        {
            var localizacao = await _context.Localizacao.FindAsync(id);
            
            return localizacao;
        }

        public async Task<Localizacao> Incluir(Localizacao localizacao)
        {
              _context.Localizacao.AddAsync(localizacao);
            await _context.SaveChangesAsync();
            return localizacao;
        }

        public async Task<Localizacao> SelecionarAsync(int id)
        {
            var localizacao = await _context.Localizacao.FindAsync(id);
            return localizacao;
        }

        public async Task<IEnumerable<Localizacao>> SelecionarTodosAsync()
        {
            var localizacao = await _context.Localizacao.ToListAsync();
            return localizacao;
        }

        public Task<IEnumerable<Localizacao>> SelecionrAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
