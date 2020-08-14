using API.Models;
using AutoMapper;
using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mappers
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<CustomerInvestments, CustomerInvestmentsModel>();
            CreateMap<CustomerInvestmentsModel, CustomerInvestments>();
            CreateMap<Investment, InvestmentModel>();
            CreateMap<InvestmentModel, Investment>();
        }
    }
}
