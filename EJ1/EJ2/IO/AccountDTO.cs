using System;

namespace AccountManager.IO
{
    public class AccountDTO
    {

        public int Id { get; set; }

        public String Name { get; set; }

        public double OverDraftLimit { get; set; }

        public double Balance { get; set; }

    }
}