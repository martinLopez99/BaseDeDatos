using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2.Domain
{
    public class Account
    {
        List<AccountMovement> Movements  = new List<AccountMovement>();

        public string Name { get; set; }    

        public int Id { get; set; } 

        public double OverdraftLimit { get; set; }  
    }
}
