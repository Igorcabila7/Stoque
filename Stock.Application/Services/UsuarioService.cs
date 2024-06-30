using AutoMapper;
using Stock.Application.DTOs;
using Stock.Application.Interfaces;
using Stock.Domain.Entities;
using Stock.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UsuarioDTO> Alterar(UsuarioDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            var usuarioAlterado = await _repository.Alterar(usuario);
            return _mapper.Map<UsuarioDTO>(usuarioAlterado);
        }

        public async Task<UsuarioDTO> Excluir(int id)
        {
            var usuarioexcluido = await _repository.Excluir(id);
            return _mapper.Map<UsuarioDTO>(usuarioexcluido);
        }

        public async Task<UsuarioDTO> Incluir(UsuarioDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);
            var usuarioincluir = await _repository.Incluir(usuario);
            return _mapper.Map<UsuarioDTO>(usuarioincluir);
        }

        public async Task<bool> logarUsuario(loginDTO credencias)
        {
            bool verificarCredencias = await _repository.logarUsuario(credencias);
            return verificarCredencias;
        }

        public async Task<UsuarioDTO> SelecionarAsync(int id)
        {
            var usuario = await _repository.SelecionarAsync(id);
            return _mapper.Map<UsuarioDTO>(usuario);
        }


        public async Task<IEnumerable<UsuarioDTO>> SelecionarTodosAsync()
        {
            var usuario = await _repository.SelecionarTodosAsync();
            return _mapper.Map<IEnumerable<UsuarioDTO>>(usuario);
        }

    }

}
    

