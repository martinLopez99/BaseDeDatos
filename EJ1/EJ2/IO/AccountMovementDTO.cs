using System;

namespace AccountManager.IO
{
    public class AccountMovementDTO
    {

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public String Description { get; set; }

        public double Amount { get; set; }

    }
}