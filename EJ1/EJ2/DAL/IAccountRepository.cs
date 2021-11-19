using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DAL
{
    public interface IAccountRepository
    {
        public double GetAccountBalance(AccountManager.Domain.Account pAccount);

        public IEnumerable<AccountManager.Domain.Account> GetOverdrawnAccounts();

        public IEnumerable<AccountManager.Domain.AccountMovement> GetLastMovements(AccountManager.Domain.Account pAccount, int pCount = 7);
    }
}
