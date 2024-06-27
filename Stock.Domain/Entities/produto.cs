using Microsoft.AspNetCore.Http;
using Stock.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Entities
{
    public class produto
    {
/*
        public produto(IFormFile produtofotografia,
           string produtonome, string categoria,
            string tipo, float preco, float quantidade, float total)
        {
            validateDomain(produtofotografia, produtonome,categoria,
                tipo, preco, quantidade,total);

        }




        public produto(int id, IFormFile produtoFotografia,
            string produtonome, string categoria,
            string tipo, float preco,float quantidade, float total)
        {
            DomainExceptionValidation.when(id < 0, "O id deve ser positivo.");
            this.id = id;

            validateDomain( produtoFotografia,
             produtonome,  categoria,
             tipo,  preco,  quantidade, total);

        }
        public void update(int id, IFormFile produtoFotografia,
            string produtonome, string categoria,
            string tipo, float preco, float quantidade, float total)
        {
            
        }

        public void validateDomain( IFormFile produtoFotografia, 
            string produtonome, 
            string categoria, 
            string tipo, float preco,
            float quantidade, float total)
        {

            DomainExceptionValidation.when(produtonome.Length > 100, "O nome do produto só pode ter até 100 caracteres.");
            DomainExceptionValidation.when(categoria.Length > 100, "A categoria do produto só pode ter até 200 caracteres.");
            DomainExceptionValidation.when(tipo.Length > 100, "O tipo do produto só pode ter até 100 caracteres.");
            


            
            this.produtoFotografia = produtoFotografia;
            this.produtonome = produtonome;
            this.categoria = categoria;
            this.tipo = tipo;
            this.preco = preco;
            this.quantidade = quantidade;
            Total = total;
        }*/

        public int id { get; set; }
        public string produtoFotografia { get; private set; } 
        public string produtonome { get; private set; }
        public string categoria  { get; private set; }  
        public string tipo { get; set; }
        public float preco { get; private set; } 
        public float quantidade { get; private set; } 
        public float Total { get; private set; }
        public movimentostock Movimentostock { get; set; }
    }
}
