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
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<produto> Alterar(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<produto>(produtoDTO);
            var produtoalterado = await _repository.Alterar(produto);
            return produtoalterado;
        }

        public async Task<produto> Excluir(int id)
        {
            var produtoexcluido = await _repository.Excluir(id);
            return produtoexcluido;
        }

        public async Task<produto> Incluir(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<produto>(produtoDTO);
            var produtoincluir = await _repository.Incluir(produto);
            return produtoincluir;
        }

        public async Task<produto> SelecionarAsync(int id)
        {
            var produto = await _repository.SelecionarAsync(id);
            return produto;
        }

        public async Task<IEnumerable<produto>> SelecionarTodosAsync()
        {
            var produto = await _repository.SelecionarTodosAsync();
            return produto as IEnumerable<produto>;
        }

        
    }
}
