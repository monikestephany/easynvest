using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DATA.Base
{
    public class HttpClientBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly string _section;

        public HttpClientBase(IHttpClientFactory httpClientFactory, IConfiguration configuration, string section)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _section = section;
        }
        public bool GetBranchesError { get; private set; }
        public async Task<T> GetListAsync<T>()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration.GetSection(_section).Value);
            if (response.IsSuccessStatusCode)
            {
                var responseStreams = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseStreams);
            }
            else
            {
                GetBranchesError = true;
                return default;
            }
        }
    }
}
