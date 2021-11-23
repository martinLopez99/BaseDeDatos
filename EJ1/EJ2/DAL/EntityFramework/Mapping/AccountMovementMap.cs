using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.ModelConfiguration;
using AccountManager.Domain;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DAL.EntityFramework.Mapping
{
    class AccountMovementMap : EntityTypeConfiguration<AccountMovement>
    {

        public AccountMovementMap()
        {
            this.HasKey(pAccountMovement => pAccountMovement.Id);

            this.Property(pAccountMovement => pAccountMovement.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(pAccountMovement => pAccountMovement.Date)
                .IsRequired();

            this.Property(pAccountMovement => pAccountMovement.Description)
                .HasMaxLength(100)
                .IsRequired();

            this.Property(pAccountMovement => pAccountMovement.Amount)
                .IsRequired();
        }

    }
}
