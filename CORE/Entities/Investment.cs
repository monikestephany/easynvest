using CORE.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CORE.Entities
{
    public class Investment
    {
        private decimal _ir;
        private decimal _redemptionValue;
        public string Name { get; set; }
        public decimal InvestedValue { get; set; }
        public decimal Amount { get; set; }
        public DateTime MaturityDate { get; set; }
        public InvestmentsType Type { get; set; }

        public decimal RedemptionValue
        {
            get => _redemptionValue;
            set
            {
                var date = TimeSpan.FromTicks(MaturityDate.Ticks).Days / TimeSpan.FromTicks(DateTime.Now.Ticks).Days * 100 - 100;
                if (date >= 50)
                { 
                }

            }
        }
        public decimal IR
        {
            get => _ir;
            set
            {
                switch (Type)
                {
                    case InvestmentsType.TreasuryDirect:
                        _ir = value + ((10/100) * value);
                        break;
                    case InvestmentsType.LCI:
                        _ir = value + ((5 / 100) * value);
                        break;
                    case InvestmentsType.Funds:
                        _ir = value + ((15 / 100) * value);
                        break;
                    default:
                        break;
                }
               
            }
        }
    }
}
