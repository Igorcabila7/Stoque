using System.Collections.Generic;
using Stock.Domain.Validation;

namespace Stock.Domain.Entities
{
    public class Usuario
    {
        /*public Usuario(string userfotografiaPath,
                       string usernomecompleto,
                       string useremail,
                       int useridade,
                       string usersector,
                       string usernacionalidade,
                       string password)
        {
            ValidateDomain(userfotografiaPath, usernomecompleto, useremail,
                           useridade, usersector, usernacionalidade, password);
        }

        public Usuario(int id,
                       string userfotografiaPath,
                       string usernomecompleto,
                       string useremail,
                       int useridade,
                       string usersector,
                       string usernacionalidade,
                       string password)
        {
            DomainExceptionValidation.When(id < 0, "O id deve ser positivo.");
            Id = id;
            ValidateDomain(userfotografiaPath, usernomecompleto, useremail,
                           useridade, usersector, usernacionalidade, password);
        }

        public void Update(string userfotografiaPath,
                           string usernomecompleto,
                           string useremail,
                           int useridade,
                           string usersector,
                           string usernacionalidade,
                           string password)
        {
            ValidateDomain(userfotografiaPath, usernomecompleto, useremail,
                           useridade, usersector, usernacionalidade, password);
        }
        */
        public int Id { get; private set; }
        public string UserFotografiaPath { get; private set; }
        public string UserNomeCompleto { get; private set; }
        public string UserEmail { get; private set; }
        public int UserIdade { get; private set; }
        public string UserSector { get; private set; }
        public string UserNacionalidade { get; private set; }
        public string Password { get; private set; }
        public ICollection<Contactos> Contactos { get; set; }
        public ICollection<Localizacao> Localizacao { get; set; }

        /*private void ValidateDomain(string userfotografiaPath,
                                    string usernomecompleto,
                                    string useremail,
                                    int useridade,
                                    string usersector,
                                    string usernacionalidade,
                                    string password)
        {
            DomainExceptionValidation.When(usernomecompleto.Length > 200, "O nome só pode ter até 200 caracteres.");
            DomainExceptionValidation.When(useremail.Length > 200, "O email só pode ter até 200 caracteres.");
            DomainExceptionValidation.When(usersector.Length > 100, "O sector só pode ter até 100 caracteres.");
            DomainExceptionValidation.When(usernacionalidade.Length > 100, "A nacionalidade só pode ter até 100 caracteres.");
            DomainExceptionValidation.When(password.Length > 100, "A password só pode ter até 100 caracteres.");

            UserFotografiaPath = userfotografiaPath;
            UserNomeCompleto = usernomecompleto;
            UserEmail = useremail;
            UserIdade = useridade;
            UserSector = usersector;
            UserNacionalidade = usernacionalidade;
            Password = password;
        }*/
    }
}
