
namespace PDJaya.WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json.Linq;

    public partial class Market
    {
        public long Id { get; set; }
        public string MarketNo { get; set; }
        public string MarketName { get; set; }
        public string Address { get; set; }
        public string Remark { get; set; }
        public string Phone { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
