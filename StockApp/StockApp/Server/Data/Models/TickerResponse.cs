namespace StockApp.Server.Data.Models
{
    public class TickerResponse
    {
        public TickerDetails results { get; set; }
        public string description { get; set; }
        public Branding branding { get; set; }
        
    }

    public class Branding
    {
        public string logo_url { get; set; }
        public string icon_url { get; set; }
    }
}
