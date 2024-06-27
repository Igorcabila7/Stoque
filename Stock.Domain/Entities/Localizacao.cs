using Stock.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Entities
{
    public class Localizacao
    {
        public int id { get; private set; }
        public string userpais { get; private set; }
        public string userprovincia { get; private set; }
        public string usercomuna { get; private set; }
        public string userbairro { get; private set; }
        public string usernumerocasa { get; private set; }
        public int usuarioid { get; private set; }
        public Usuario usuario { get; set; }
        public Localizacao localizacao { get; set; }

        /*


        public Localizacao(string userpais,
           string userprovincia, string usercomuna,
           string userbairro, string usernumerocasa, int usuarioid)
        {

            validateDomain(userpais, userprovincia, usercomuna,
                userbairro, usernumerocasa, usuarioid);

        }


        public Localizacao(int id, string userpais,
           string userprovincia, string usercomuna,
           string userbairro, string usernumerocasa, int usuarioid)
        {
            DomainExceptionValidation.when(id < 0, "O id deve ser positivo.");
            this.id = id;
            validateDomain(userpais, userprovincia, usercomuna,
                userbairro, usernumerocasa, usuarioid);

        }

        public void update(string userpais,
           string userprovincia, string usercomuna,
           string userbairro, string usernumerocasa, int usuarioid)
        {
            validateDomain(userpais, userprovincia, usercomuna,
                userbairro, usernumerocasa, usuarioid);
        }
        




        public void validateDomain(string userpais,
           string userprovincia, string usercomuna,
           string userbairro, string usernumerocasa, int usuarioid)
        {
            DomainExceptionValidation.when(userpais.Length > 200, "O  pais só pode ter até 200 caracteres.");
            DomainExceptionValidation.when(userprovincia.Length > 200, "A provincia só pode ter até 200 caracteres.");
            DomainExceptionValidation.when(usercomuna.Length > 100, "A comuna só pode ter até 100 caracteres.");
            DomainExceptionValidation.when(userbairro.Length > 100, "O bairro só pode ter até 100 caracteres.");



            this.userpais = userpais;
            this.userprovincia = userprovincia;
            this.usercomuna = usercomuna;
            this.userbairro = userbairro;
            this.usernumerocasa = usernumerocasa;
            this.usuarioid = usuarioid;
        } */
    }
}






