using Stock.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Entities
{
    public class movimentostock
    {
        /*public movimentostock(int id, string movimento, DateTime dateTime, int produtoid)
        {
            Id = id;
            this.movimento = movimento;
            this.dateTime = dateTime;
            this.produtoid = produtoid;
        }
        */
        public int Id { get; set; }
        public string movimento { get; private set; }
        public DateTime dateTime {  get; private set; }
        public int produtoid { get; set; }
        public produto produto { get; set; }
        

        /*
        public void  Validatedomain (int id, string movimento, DateTime dateTime,int produtoid)
        {

            DomainExceptionValidation.when(movimento.Length > 100, "O  a descricao do movimento realizado no estoque só pode ter até 100 caracteres.Usa os seguintes termos:'Tirar','Colocar','Adicionar','Remover','Debitar','Creditar':");
            Id = id;
            this.movimento = movimento;
            this.dateTime = dateTime;
            this.produtoid = produtoid;
        }*/
    }
}
