using Newtonsoft.Json;
using System;

namespace DATA.Repositories.Funds
{
    public class FundResponseContract
    {
        [JsonProperty("capitalInvestido")]
        public decimal InvestedCapital { get; set; }

        [JsonProperty("ValorAtual")]
        public decimal CurrentValue { get; set; }

        [JsonProperty("dataResgate")]
        public DateTime RedemptionDate { get; set; }

        [JsonProperty("dataCompra")]
        public DateTime PurchaseDate { get; set; }

        [JsonProperty("iof")]
        public decimal IOF { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("totalTaxas")]
        public decimal TotalTax { get; set; }

        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }
    }
}
