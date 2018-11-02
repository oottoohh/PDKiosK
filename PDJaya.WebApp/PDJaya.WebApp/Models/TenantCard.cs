
namespace PDJaya.WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;

    public enum CardStatus { Active, NotActive, BlackListed }
    public class TenantCard
    {
        public long Id { get; set; }
        public string CardID { get; set; }
        public string StoreNo { get; set; }
        public string CardNo { get; set; }
        public string CardType { get; set; }
        public CardStatus Status { get; set; }
    }
}
