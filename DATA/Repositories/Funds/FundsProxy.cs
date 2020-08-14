using AutoMapper;
using DATA.Base;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DATA.Repositories.Funds
{
    public class FundsProxy : HttpClientBase
    {
        
        public FundsProxy(IHttpClientFactory httpClientFactory, IConfiguration configuration) : base(httpClientFactory, configuration, "Fundos")
        {
          
        }
        public async Task<IEnumerable<FundResponseContract>> GetAllAsync()
        {
            var getResponse = await GetListAsync<FundsContract>();
            return getResponse.FundResponseContract;
        }
    }
}
