using System;
using System.Collections.Generic;
using System.Data.Entity;
using AccountManager.Migrations;
using AccountManager.Domain;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DAL.EntityFramework
{
    public class AccountManagerDbContext : DbContext
    {

        public AccountManagerDbContext() : base("AccountManager")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AccountManagerDbContext, Configuration>());
        }

        public IDbSet<Client> Clients { get; set; }

        public IDbSet<Account> Accounts { get; set; }

        public IDbSet<AccountMovement> AccountMovements { get; set; }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());

            base.OnModelCreating(pModelBuilder);
        }

    }
}
