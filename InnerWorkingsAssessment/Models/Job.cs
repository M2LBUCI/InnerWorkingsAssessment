using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerWorkingsAssessment.Models
{
    public class Job
    {
        public List<PrintItem> PrintItems { get; set; }
        public bool IsExtraMargin { get; set; }

        private double BaseMargin = .11;

        private double ExtraMargin = .05;

        public double Total {
            get {

                double runningTotal = 0.00;

                foreach(PrintItem pi in PrintItems)
                {
                    runningTotal = runningTotal + pi.Total;
                }

                //apply margin
                runningTotal = runningTotal * (1 + BaseMargin + (IsExtraMargin ? ExtraMargin : 0));
                
                //check if cents are even and return running total
                return (runningTotal % 2 == 0 ? runningTotal : runningTotal + .01);
            }
        }

        public Job(List<PrintItem> printItems, bool isExtraMargin = false)
        {
            PrintItems = printItems;
            IsExtraMargin = isExtraMargin;
        }
    }
}
