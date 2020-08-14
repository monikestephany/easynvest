
using API.Models;
using AutoMapper;
using CORE.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("easynvest/investments")]
    [ApiController]
    public class InvestmentsController : ControllerBase
    {
        private const string ControllerName = "Investimentos";
        private readonly IMapper _mapper;
        private readonly IInvestmentService _investmentService;

        public InvestmentsController(IMapper mapper, IInvestmentService investmentService)
        {
            _mapper = mapper;
            _investmentService = investmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetInvestmentsPerClient()
        {
            var remittancePaged = await _investmentService.GetInvestmentsPerCustomer();
            return Ok(_mapper.Map<CustomerInvestmentsModel>(remittancePaged));
        }
    }
}