using AutoMapper;
using Stock.Application.DTOs;
using Stock.Application.Interfaces;
using Stock.Domain.Entities;
using Stock.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Services
{
    public class MovimentoStockService : IMovimentoStockService
    {
        private readonly IMovimentostockRepository _repository;
        private readonly IMapper _mapper;

        public MovimentoStockService(IMovimentostockRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<MovimentoStockDTO> Incluir(MovimentoStockDTO Movimento)
        {
            var movimento = _mapper.Map<movimentostock>(Movimento);
            var movimentoincluir = await _repository.Incluir(movimento);
            return _mapper.Map<MovimentoStockDTO>(movimentoincluir);
        }

        public async  Task<MovimentoStockDTO> SelecionarAsync(int id)
        {
            var movimento = await _repository.SelecionarAsync(id);
            return _mapper.Map<MovimentoStockDTO>(movimento);
        }

        public async Task<IEnumerable<MovimentoStockDTO>> SelecionarTodosAsync()
        {
            var movimento = await _repository.SelecionarTodosAsync();
            return _mapper.Map<IEnumerable<MovimentoStockDTO>>(movimento);
        }
    }
}
