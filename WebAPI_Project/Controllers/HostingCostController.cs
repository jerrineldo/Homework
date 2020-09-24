using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class HostingCostController : ApiController
    {
        public IEnumerable<string> Get(int id)
        {
            double NoofFortNights = id/14;
            double FortNightCost = (NoofFortNights + 1) * 5.50;
            double HST = (FortNightCost * 13) / 100;
            double TotalCost = FortNightCost + HST;
            String value1 = NoofFortNights + " fortnights at $5.50/FN = $" + FortNightCost.ToString("#0.00") + " CAD";
            String value2 = "HST 13 % = $" + Math.Round(HST, 2) + " CAD";
            String value3 = "Total = $" + Math.Round(TotalCost,2) + " CAD";
            return new string[] { value1,value2,value3 };
        }
    }
}
