using System.Collections;
using System.Threading.Tasks;

namespace StockApp.Server.Data.Services
{
    public interface IClientService
    {
        public Task<IEnumerable> GetTickers();
    }
}
