using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Repositories.Funds
{
    public class FundsContract
    {
        [JsonProperty("fundos")]
        public IEnumerable<FundResponseContract> FundResponseContract { get; set; }
    }
}
