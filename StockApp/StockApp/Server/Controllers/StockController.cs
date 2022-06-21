using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockApp.Server.Data.Services;
using StockApp.Shared.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockApp.Server.Controllers
{
    [Authorize]
    [Route("api")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IClientService _dbService;

        public StockController(IClientService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<IEnumerable<RowData>> GetTickers()
        {
            // return await _dbService.GetTickers();
            return new List<RowData>
           {
               new RowData
               {
                   URL = "https://www.wyborkierowcow.pl/wp-content/uploads/2022/02/Tesla-Logo.jpg",
                   Name = "TESLA",
                   ShortName = "TSLA"
               }
           };

        }
    }
}
