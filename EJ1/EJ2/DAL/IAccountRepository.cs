using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DAL
{
    public interface IAccountRepository: IRepository<>
    {
        public double GetAccountBalance(Account pAccount);

        public IEnumerable<Account> GetOverdrawnAccounts();

        public IEnumerable<AccountMovement> GetLastMovements(Account pAccount, int pCount = 7);
    }
}
