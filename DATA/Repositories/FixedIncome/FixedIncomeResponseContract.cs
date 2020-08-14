using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Repositories.FixedIncome
{
    public class FixedIncomeResponseContract
    {
        [JsonProperty("capitalInvestido")]
        public decimal InvestedCapital { get; set; }
       
        [JsonProperty("capitalAtual")]
        public decimal CurrentCapital { get; set; }
        
        [JsonProperty("quantidade")]
        public decimal Quantity { get; set; }

        [JsonProperty("vencimento")]
        public DateTime MaturityDate { get; set; }

        [JsonProperty("iof")]
        public decimal IOF { get; set; }

        [JsonProperty("outrasTaxas")]
        public decimal OtherTaxes { get; set; }

        [JsonProperty("taxas")]
        public decimal Taxes { get; set; }

        [JsonProperty("indice")]
        public string Index { get; set; }

        [JsonProperty("tipo")]
        public string Type { get; set; }

        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("guarantidoFGC")]
        public bool FGCGuaranteed { get; set; }

        [JsonProperty("dataOperacao")]
        public DateTime OperationDate { get; set; }

        [JsonProperty("precoUnitario")]
        public decimal UnitPrice { get; set; }

        [JsonProperty("primario")]
        public bool Primary { get; set; }
    }
}
