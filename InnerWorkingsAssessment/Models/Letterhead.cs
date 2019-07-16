using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerWorkingsAssessment.Models
{
    public class Letterhead:PrintItem
    {
        public Letterhead(double Cost, bool IsExempt) : base("Letterhead", Cost, IsExempt) { }

        //Other Envelope specific members and methods
    }
}
