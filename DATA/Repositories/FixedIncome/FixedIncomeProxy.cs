using DATA.Base;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DATA.Repositories.FixedIncome
{
    public class FixedIncomeProxy : HttpClientBase
    { 
        public FixedIncomeProxy(IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory, configuration, "Renda Fixa")
        {
        }

        public async Task<IEnumerable<FixedIncomeResponseContract>> GetAllAsync()
        {
            var getResponse = await GetListAsync<LcisContract>();
            return getResponse.LCIS;
        }
    }
}
