using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CustomerInvestmentsModel
    {

        [JsonProperty("valorTotal")]
        public decimal Amount { get; set; }

        [JsonProperty("investimentos")]
        public List<InvestmentModel> Investments { get; set; }
    }
}
