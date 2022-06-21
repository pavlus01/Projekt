using StockApp.Server.Data.Models;
using StockApp.Shared.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StockApp.Server.Data.Services
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext _dbContext;

        public ClientService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable> GetTickers()
        {
            var httpClient = new HttpClient();
            SomeSortOfTicerData content = null;
            List<RowData> lista = new List<RowData>();

            

                content = await httpClient.GetFromJsonAsync<SomeSortOfTicerData>("https://api.polygon.io/v2/aggs/grouped/locale/us/market/stocks/2022-06-17?adjusted=true&include_otc=false&apiKey=ZqJe9jQrip7ulI2Pa6fkICLddpneFoqK");

                foreach(SomeSortOfTickers ticker in content.results)
                {
                  //  var httpClient2 = new HttpClient();
                  //  TickerResponse response = await httpClient2.GetFromJsonAsync<TickerResponse>("https://api.polygon.io/v3/reference/tickers/" + ticker.T + "?date=2022-06-17&apiKey=ZqJe9jQrip7ulI2Pa6fkICLddpneFoqK");
                    lista.Add(new RowData
                    {
                        URL = "https://www.wyborkierowcow.pl/wp-content/uploads/2022/02/Tesla-Logo.jpg",
                        ShortName = ticker.T,
                        Name = ticker.T

                    });
                }

            return lista;

        }
    }
}
