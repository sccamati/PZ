using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank.Models
{
    public class Credit
    {
        public int Id { get; set; }
        //User public int MyProperty { get; set; }
        public Decimal Cash { get; set; }
        public int NumberOfMonthsLeft { get; set; }
        public int NumberOfMonths { get; set; }
        public DateTime EndDate { get; set; }

    }
}