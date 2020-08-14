using CORE.Enums;
using Newtonsoft.Json;
using System;

namespace API.Models
{
    public class InvestmentModel
    {
        [JsonProperty("Ir")]
        public decimal IR { get; set; }

        [JsonProperty("valorResgate")]
        public decimal RedemptionValue { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("valorInvestido")]
        public decimal InvestedValue { get; set; }

        [JsonProperty("valorTotal")]
        public decimal Amount { get; set; }

        [JsonProperty("vencimento")]
        public DateTime MaturityDate { get; set; }
    }
}
