using Microsoft.AspNetCore.Http.HttpResults;
using Stock.Application.DTOs;
using Stock.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        {
            CreateMap<Usuario,UsuarioDTO>().ReverseMap();
             CreateMap<produto,ProdutoDTO>().ReverseMap();
            CreateMap<movimentostock, MovimentoStockDTO>().ReverseMap();
            CreateMap<Localizacao,LocalizacaoDTO>().ReverseMap();
            CreateMap<Contactos, ContactosDTO>().ReverseMap();

        }
    }
}
