using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank.Models
{
    public class CreditProposal
    {
        public int Id { get; set; }
        //USER public int MyProperty { get; set; }
        public Decimal Cash { get; set; }
        public int NumberOfMonths { get; set; }
        public String ProposalStatus { get; set; }

    }
}