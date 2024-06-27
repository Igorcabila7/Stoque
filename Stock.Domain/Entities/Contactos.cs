using Stock.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Entities
{
    public class Contactos
    {
        public int id { get; private set; }
        public string usercodigopais { get; private set; }
        public string usertelefone1 { get; private set; }
        public string usertelefone2 { get; private set; }
        public string usertelefonefixo { get; private set; }
        public int usuarioid { get; private set; }    
        public Usuario usuarios { get;  set; }   
        public Contactos contactos { get; set; }

        /*public Contactos(string usercodigopais,
               string usertelefone1, string usertelefone2,
                string usertelefonefixo, int usuarioid)
        {
            validateDomain(usercodigopais,  usertelefone1, usertelefone2,
                usertelefonefixo, usuarioid);

        }




        public Contactos( int id, string usercodigopais,
               string usertelefone1, string usertelefone2,
                string usertelefonefixo, int usuarioid)
        {
            DomainExceptionValidation.when(id < 0, "O id deve ser positivo.");
            this.id = id;

            validateDomain(usercodigopais,
             usertelefone1, usertelefone2,
             usertelefonefixo,usuarioid);

        }
        public void update(int id, string usercodigopais,
               string usertelefone1, string usertelefone2,
                string usertelefonefixo, int usuarioid)
        {

        }

        public void validateDomain(
             string usercodigopais,
               string usertelefone1, string usertelefone2,
                string usertelefonefixo, int usuarioid)
        {

            DomainExceptionValidation.when(usercodigopais.Length > 10, "O codigo de terminal telefonico só pode ter até 10 caracteres.");
            DomainExceptionValidation.when(usertelefone1.Length > 20, "O numero de telefone  só pode ter até 20 caracteres.");
            DomainExceptionValidation.when(usertelefone2.Length > 20, "O numero de telefone  só pode ter até 20 caracteres.");
            DomainExceptionValidation.when(usertelefonefixo.Length > 20, "O numero de telefone  só pode ter até 20 caracteres.");





            this.usercodigopais = usercodigopais;
            this.usertelefone1 = usertelefone1;
            this.usertelefone2= usertelefone2;
            this.usertelefonefixo = usertelefonefixo;
            this.usuarioid = usuarioid;
            
        }
        */
        

    }
}
