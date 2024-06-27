using AutoMapper;
using Stock.Application.DTOs;
using Stock.Domain.Entities;
using Stock.Domain.Interfaces;
using Stock.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Services
{
    public class LocalizacaoService : ILOcalizacaoRepository
    {
        private readonly ILOcalizacaoRepository _repository;
        private readonly IMapper _mapper;

        public LocalizacaoService(ILOcalizacaoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async  Task<LocalizacaoDTO> Alterar(LocalizacaoDTO localizacao)
        {
            var endereco = _mapper.Map<Localizacao>(localizacao);
            var Localizacaoalterado = await _repository.Alterar(endereco);
            return _mapper.Map<LocalizacaoDTO>(Localizacaoalterado);
        }

        public async Task<LocalizacaoDTO> Excluir(int id)
        {
            var enderecoexcluido = await _repository.Excluir(id);
            return _mapper.Map<LocalizacaoDTO>(enderecoexcluido);
        }

        public async Task<LocalizacaoDTO> Incluir(LocalizacaoDTO localizacao)
        {
            var endereco = _mapper.Map<Localizacao>(localizacao);
            var enderecoincluir = await _repository.Incluir(endereco);
            return _mapper.Map<LocalizacaoDTO>(enderecoincluir);
        }

        public async Task<LocalizacaoDTO> SelecionarAsync(int id)
        {
            var endereco = await _repository.SelecionarAsync(id);
            return _mapper.Map<LocalizacaoDTO>(endereco);
        }

        public async Task<IEnumerable<LocalizacaoDTO>> SelecionarTodosAsync()
        {
            var endereco = await _repository.SelecionarTodosAsync();
            return _mapper.Map<IEnumerable<LocalizacaoDTO>>(endereco);
        }

        Task<Localizacao> ILOcalizacaoRepository.Alterar(Localizacao localizacao)
        {
            throw new NotImplementedException();
        }

        Task<Localizacao> ILOcalizacaoRepository.Excluir(int id)
        {
            throw new NotImplementedException();
        }

        Task<Localizacao> ILOcalizacaoRepository.Incluir(Localizacao localizacao)
        {
            throw new NotImplementedException();
        }

        Task<Localizacao> ILOcalizacaoRepository.SelecionarAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Localizacao>> ILOcalizacaoRepository.SelecionarTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
