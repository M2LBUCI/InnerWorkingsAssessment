using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerWorkingsAssessment.Models
{
    public abstract class PrintItem
    {
        public string Description { get; set; }
        public double Cost { get; set; }
        public double SalesTax { get { return 1.07; } }
        public bool IsExempt { get; set; }

        public double Total {
            get{
                return Cost * (IsExempt ? 1 : SalesTax);
            }
        }
        
        public PrintItem(string description, double cost, bool isExempt)
        {
            Description = description;
            Cost = cost;
            IsExempt = isExempt;
        }
    }
}
