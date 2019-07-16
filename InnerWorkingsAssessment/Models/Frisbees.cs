using InnerWorkingsAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerWorkingsAssessment.Controllers
{
    public class Frisbees: PrintItem
    {
        public Frisbees(double Cost, bool IsExempt) : base("Frisbees", Cost, IsExempt) { }

        //Other Frisbee specific members and methods
    }
}
