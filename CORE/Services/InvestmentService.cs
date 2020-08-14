using CORE.Entities;
using CORE.Enums;
using CORE.Interfaces.Services;
using DATA.Repositories.FixedIncome;
using DATA.Repositories.Funds;
using DATA.Repositories.TreasuryDirect;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CORE.Services
{
    public class InvestmentService : IInvestmentService
    {
        private readonly FixedIncomeProxy _fixedIncomeProxy;
        private readonly FundsProxy _fundsProxy;
        private readonly TreasuryDirectProxy _treasuryDirectProxy;

        public InvestmentService(FixedIncomeProxy fixedIncomeProxy, FundsProxy fundsProxy, TreasuryDirectProxy treasuryDirectProxy)
        {
            _fixedIncomeProxy = fixedIncomeProxy;
            _fundsProxy = fundsProxy;
            _treasuryDirectProxy = treasuryDirectProxy;
        }

        public async Task<CustomerInvestments> GetInvestmentsPerCustomer()
        {
            var customerInvestments = new CustomerInvestments
            {
                Investments = new List<Investment>()
            };
            customerInvestments.Investments.AddRange(await GetLCIInvestments());
            customerInvestments.Investments.AddRange(await GetFundsInvestments());
            customerInvestments.Investments.AddRange(await GetTreasuryDirectInvestments());
            return customerInvestments;
        }

        private async Task<IEnumerable<Investment>> GetLCIInvestments()
        {
            var investments = new List<Investment>();
            var fixedIncomes = await _fixedIncomeProxy.GetAllAsync();
            foreach (var fixedIncome in fixedIncomes)
            {
                var investment = new Investment
                {
                    Name = fixedIncome.Name,
                    InvestedValue = fixedIncome.InvestedCapital,
                    Amount = fixedIncome.CurrentCapital,
                    MaturityDate = fixedIncome.MaturityDate,
                    IR = fixedIncome.CurrentCapital - fixedIncome.InvestedCapital,
                    Type = InvestmentsType.LCI
                };
                investments.Add(investment);
            }
            return investments;
        }
        private async Task<IEnumerable<Investment>> GetFundsInvestments()
        {
            var investments = new List<Investment>();
            var funds = await _fundsProxy.GetAllAsync();
            foreach (var fund in funds)
            {
                var investment = new Investment
                {
                    Name = fund.Name,
                    InvestedValue = fund.InvestedCapital,
                    Amount = fund.CurrentValue,
                    MaturityDate = fund.PurchaseDate,
                    IR = fund.CurrentValue - fund.InvestedCapital,
                    Type = InvestmentsType.Funds
                };
                investments.Add(investment);
            }
            return investments;
        }
        private async Task<IEnumerable<Investment>> GetTreasuryDirectInvestments()
        {
            var investments = new List<Investment>();
            var treasuryDirects = await _treasuryDirectProxy.GetAllAsync();
            foreach (var treasuryDirect in treasuryDirects)
            {
                var investment = new Investment
                {
                    Name = treasuryDirect.Name,
                    InvestedValue = treasuryDirect.InvestedValue,
                    Amount = treasuryDirect.Amount,
                    MaturityDate = treasuryDirect.MaturityDate,
                    IR = treasuryDirect.Amount - treasuryDirect.InvestedValue,
                    Type = InvestmentsType.TreasuryDirect
                };
                investments.Add(investment);
            }
            return investments;
        }
    }
}
