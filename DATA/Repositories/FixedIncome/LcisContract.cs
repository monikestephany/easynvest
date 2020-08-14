using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Repositories.FixedIncome
{
    public class LcisContract
    {
        [JsonProperty("lcis")]
        public IEnumerable<FixedIncomeResponseContract> LCIS { get; set; }
    }
}
