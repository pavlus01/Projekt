using StockApp.Server.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockApp.Server.Data.Models
{
    public class TickerDet1
    {
        public string name { get; set; }
        public string sname { get; set; }
        public string market { get; set; }
        public string locale { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string description { get; set; }
        public string logo_url { get; set; }
        public string ID { get; set; }

        [ForeignKey("ID")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }

}
