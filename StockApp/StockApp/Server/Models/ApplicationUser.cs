using Microsoft.AspNetCore.Identity;
using StockApp.Server.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockApp.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<TickerDet1> MyList { get; set; }

        public ICollection<TickerDet2> WatchedList { get; set; }
    }
}
