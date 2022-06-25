using StockApp.Server.Data.Models;
using StockApp.Shared.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockApp.Server.Data.Services
{
    public interface IClientService
    {
        public Task<IEnumerable<RowData>> GetTickers();
        public Task<TickerDet1> GetTickerInfo(string sName);
        public Task<List<ChartData>> GetChartData(string sName);
        public Task<bool> PostMyListElement(TickerDet1 ticker);
        public Task<bool> CheckMyListElement(TickerDet1 ticker);
        public Task<List<TickerDet1>> GetMyList(string ID);
        public Task<bool> DeltMyListElement(string sname);
        public Task<bool> PostMyWatchElement(TickerDet2 ticker);
    }
}
