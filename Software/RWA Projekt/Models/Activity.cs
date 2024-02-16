using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Projekt.Models
{
    public class Activity : ExpenseType
    {
        public int Tag { get; set; }
        public string TypeName { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public override string ToString()
        {
                return Tag + " - " + TypeName;
        }
    }
}
