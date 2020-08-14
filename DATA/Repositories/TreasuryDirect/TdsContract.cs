using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Repositories.TreasuryDirect
{
    public class TdsContract
    {
        [JsonProperty("tds")]
        public IEnumerable<TreasuryDirectResponseContract> TDS { get; set; }
    }
}
