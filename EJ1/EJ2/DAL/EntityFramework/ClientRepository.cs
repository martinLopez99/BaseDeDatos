using System;
using System.Collections.Generic;
using AccountManager.Domain;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DAL.EntityFramework
{
    public class ClientRepository : Repository<Client, AccountManagerDbContext>, IClientRepository
    {

        public ClientRepository(AccountManagerDbContext pDbContext) : base(pDbContext)
        {

        }


    }
}
