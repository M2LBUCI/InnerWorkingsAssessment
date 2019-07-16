using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerWorkingsAssessment.Models
{
    public class Envelopes: PrintItem
    {
        public Envelopes(double Cost, bool IsExempt) : base("Envelopes", Cost, IsExempt) { }
        
        //Other Envelopes specific members and methods
    }
}
