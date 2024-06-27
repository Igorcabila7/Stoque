using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Domain.Validation
{
    public class DomainExceptionValidation:Exception
    {
        public DomainExceptionValidation(string error) :base(error){ }
        public static void when(bool  haserror, string error) 
        {
            if (haserror) { 
             throw new DomainExceptionValidation(error);
            }
        }
    }
}
