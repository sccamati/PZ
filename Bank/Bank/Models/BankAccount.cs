using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public String Number { get; set; }
        public Decimal Balance { get; set; }
    }
}