using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DAL
{
    public interface IUnityOfWork
    {
        public void Complete();

        public IAccountRepository AccountRepository { get;  set; }

        public IClientRepository ClientRepository { get ;  set; }
    }
}
