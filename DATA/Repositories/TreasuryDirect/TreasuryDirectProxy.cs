using DATA.Base;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DATA.Repositories.TreasuryDirect
{
    public class TreasuryDirectProxy : HttpClientBase
    {
       
        public TreasuryDirectProxy(IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory, configuration, "Tesouro Direto")
        {
        }
        public async Task<IEnumerable<TreasuryDirectResponseContract>> GetAllAsync()
        {
            var getResponse = await GetListAsync<TdsContract>();
            return getResponse.TDS;
        }
    }
}
