using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StockApp.Server.Data.Models;
using StockApp.Server.Data.Services;
using StockApp.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace StockApp.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IClientService _dbService;

        public WeatherForecastController(IClientService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<IEnumerable<RowData>> GetTickers()
        {
         return await _dbService.GetTickers();
        }

        [HttpGet]
        [Route("info/{sName}")]
        public async Task<TickerDet1> GetTickerInfo(string sName)
        {
           // return new TickerDet { name = sName, address="Sobieskiego", city="Warsaw", description="PPPPPPPP", locale="PL", logo_url="222/2222/2", market="PL" };
            return await _dbService.GetTickerInfo(sName);
        }

        [HttpGet]
        [Route("chart/{sName}")]
        public async Task<List<ChartData>> GetChartData(string sName)
        {
            // return new TickerDet { name = sName, address="Sobieskiego", city="Warsaw", description="PPPPPPPP", locale="PL", logo_url="222/2222/2", market="PL" };
            return await _dbService.GetChartData(sName);
        }

        [HttpPost]
        [Route("MyList")]
        public async Task<bool> PostToMyList(TickerDet1 ticker)
        {
            ticker.ID = User.Identity.GetUserId();
            if (await _dbService.CheckMyListElement(ticker)) return false;
            if (await _dbService.PostMyListElement(ticker)) return true;
            else return false;
        }

        [HttpGet]
        [Route("MyList")]
        public async Task<List<TickerDet1>> GetMyList()
        {
            //return new List<TickerDet>();
            return await _dbService.GetMyList(User.Identity.GetUserId());
        }

        [HttpDelete]
        [Route("MyList/{sName}")]
        public async Task<IActionResult> DelMyListElet(string sName)
        {
            await _dbService.DeltMyListElement(sName);
            return Ok();
        }

        [HttpPost]
        [Route("WatchedList")]
        public async Task<bool> PostWatchedList(TickerDet2 ticker)
        {
            ticker.ID = User.Identity.GetUserId();
            if (await _dbService.PostMyWatchElement(ticker)) return true;
            else return false;
        }
    }
}
