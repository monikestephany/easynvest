using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Interfaces.Services
{
    public interface IInvestmentService
    {
        Task<CustomerInvestments> GetInvestmentsPerCustomer();
    }
}
