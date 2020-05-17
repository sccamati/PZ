using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank.Models
{
    public class CreditProposal
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public Decimal Cash { get; set; }
        public int NumberOfMonths { get; set; }
        public CreditProposalStatus ProposalStatus { get; set; }
        public virtual Profile Profile { get; set; }
    }

    public enum CreditProposalStatus
    {
        Waiting,
        Approved,
        Rejected
    }
}