using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace PDJaya.WebApp.Models
{
    public partial class Bills
    {
        public long Id { get; set; }
        public string BillID { get; set; }
        public string MarketNo { get; set; }
        public string StoreNo { get; set; }
        public string TransactionCode { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
