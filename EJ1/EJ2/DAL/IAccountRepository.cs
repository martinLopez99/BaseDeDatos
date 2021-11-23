using System;
using System.Collections.Generic;
using AccountManager.Domain;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DAL
{
    public interface IAccountRepository : IRepository<Account>
    {

        IEnumerable<Account> GetOverdrawnAccounts();

    }
}
