using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2.Domain
{
    class Client
    {

        List<Account> Accounts = new List<Account>();

        Document ClientDocument = new Document();

        public int IdCliente {  get;   set; }

        public string FirstName { get ;   set; }

        public string LastName { get ;   set; }
    }
}  
