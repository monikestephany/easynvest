using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CORE.Entities
{
    public class CustomerInvestments
    {
        private decimal _amount;
        public List<Investment> Investments { get; set; }
        public decimal Amount
        {
            get => _amount;
            set
            {
                _amount = Investments.Sum(p => p.Amount);
            }
        }
    
    }
}
