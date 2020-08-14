using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Repositories.TreasuryDirect
{
    public class TreasuryDirectResponseContract
    {
        [JsonProperty("valorInvestido")]
        public decimal InvestedValue { get; set; }
      
        [JsonProperty("valorTotal")]
        public decimal Amount { get; set; }
      
        [JsonProperty("vencimento")]
        public DateTime MaturityDate { get; set; }
      
        [JsonProperty("dataDeCompra")]
        public DateTime PurchaseDate { get; set; }
        
        [JsonProperty("iof")]
        public decimal IOF { get; set; }

        [JsonProperty("indice")]
        public string Index { get; set; }

        [JsonProperty("tipo")]
        public string Type { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }
    }
}
