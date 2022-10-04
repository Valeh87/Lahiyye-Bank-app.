using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiyye_bank_app_.Models
{
    public class Employee:BaseEntity
    {
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Profession { get; set; }
        public Branch branch { get; set; }
    }
}
