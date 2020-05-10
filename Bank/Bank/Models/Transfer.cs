using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank.Models
{
    public class Transfer
    {
        public int Id { get; set; }
        public int TransferTypeId { get; set; }
        public String AddressesNumber { get; set; }
        public String ReceiversName { get; set; }
        public String ReciversNumber { get; set; }
        public String Title { get; set; }
        public Decimal Cash { get; set; }
        public DateTime Date { get; set; }

        public virtual TransferType TransferType { get; set; }
    }
}