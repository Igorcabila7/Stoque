using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Account
{
    public interface IAuthenticate
    {
        Task<bool> AuthenticateAsync( string useremail, string usersenha);
        Task<bool> userExists( string useremail);
        public string GenerateToken(int id, string email);
    }
}
