using AutoMapper;
using Stock.Application.DTOs;
using Stock.Domain.Entities;
using Stock.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Services
{
    public class ContactosService : IContactoRepository
    {


        private readonly IContactoRepository _repository;
        private readonly IMapper _mapper;

        public ContactosService(IContactoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ContactosDTO> Alterar(ContactosDTO contactoDTO)
        {
            var contacto = _mapper.Map<Contactos>(contactoDTO);
            var contactoalterado = await _repository.Alterar(contacto);
            return _mapper.Map<ContactosDTO>(contactoalterado);
        }

        public Task<Contactos> Alterar(Contactos contactos)
        {
            return _repository.Alterar(contactos);
        }

        public async Task<ContactosDTO> Excluir(int id)
        {
            var contactoexcluido = await _repository.Excluir(id);
            return _mapper.Map<ContactosDTO>(contactoexcluido);
        }

        public async Task<ContactosDTO> Incluir(ContactosDTO contactoDTO)
        {
            var contacto = _mapper.Map<Contactos>(contactoDTO);
            var contactoincluir = await _repository.Incluir(contacto);
            return _mapper.Map<ContactosDTO>(contactoincluir);
        }

        public Task<Contactos> Incluir(Contactos contactos)
        {
            return _repository.Incluir(contactos);
        }

        public async Task<ContactosDTO> SelecionarAsync(int id)
        {
            var contactos = await _repository.SelecionarAsync(id);
            return _mapper.Map<ContactosDTO>(contactos);
        }

        public async Task<IEnumerable<ContactosDTO>> SelecionarTodosAsync()
        {
            var contactos = await _repository.SelecionarTodosAsync();
            return _mapper.Map<IEnumerable<ContactosDTO>>(contactos);
        }

        Task<Contactos> IContactoRepository.Excluir(int id)
        {
            throw new NotImplementedException();
        }

        Task<Contactos> IContactoRepository.SelecionarAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Contactos>> IContactoRepository.SelecionarTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
