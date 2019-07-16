using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InnerWorkingsAssessment.Models
{
    public class YoYos: PrintItem
    {
        public YoYos(double Cost, bool IsExempt) : base("Yo-Yo's", Cost, IsExempt) { }

        //Other YoYo specific members and methods
    }
}
