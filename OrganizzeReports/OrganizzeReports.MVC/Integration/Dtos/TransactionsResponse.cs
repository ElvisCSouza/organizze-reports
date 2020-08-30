using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizzeReports.MVC.Integration.Dtos
{
    public class Transaction
    {
        public int id { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public bool paid { get; set; }
        public int amount_cents { get; set; }
        public int total_installments { get; set; }
        public int installment { get; set; }
        public bool recurring { get; set; }
        public int account_id { get; set; }
        public int category_id { get; set; }
        public string notes { get; set; }
        public int attachments_count { get; set; }
        public int? credit_card_id { get; set; }
        public int? credit_card_invoice_id { get; set; }
        public int? paid_credit_card_id { get; set; }
        public int? paid_credit_card_invoice_id { get; set; }
        public int? oposite_transaction_id { get; set; }
        public int? oposite_account_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public Tag[] tags { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
    }

}
