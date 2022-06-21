using System.Collections;

namespace StockApp.Server.Data.Models
{
    public class SomeSortOfTicerData
    {
        public bool adjusted { get; set; }
        public int queryCount { get; set; }
        public IEnumerable results { get; set; }
        public string status { get; set; }
        public string request_id { get; set; }
        public int count { get; set; }
    }
}
