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
    public class MovimentoStockRepository : IMovimentostockRepository
    {

        private readonly ApplicationDbContext _context;
        public MovimentoStockRepository(ApplicationDbContext context)
        {

            _context = context;
        }
        public async Task<movimentostock> Incluir(movimentostock Movimento)
        {
            var MOVIMENTO = await _context.movimentostocks.AddAsync(Movimento);
            await _context.SaveChangesAsync();
            return Movimento;
        }

        public async Task<movimentostock> SelecionarAsync(int id)
        {
            var movimento = await _context.movimentostocks.FindAsync(id);
            return movimento;
        }

        public async Task<IEnumerable<movimentostock>> SelecionarTodosAsync()
        {
            var movimento = await _context.movimentostocks.ToListAsync();
            return movimento;
        }

       
    }
}
