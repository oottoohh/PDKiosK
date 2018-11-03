using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDJaya.WebApp.Models
{
    public partial class Tenant
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Updated { get; set; }
        public long Id { get; set; }
        public string StoreNo { get; set; }
        public string Owner { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
        public string MarketNo { get; set; }
    }
}
